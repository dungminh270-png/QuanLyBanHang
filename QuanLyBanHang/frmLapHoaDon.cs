using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmLapHoaDon : Form
    {
        public frmLapHoaDon()
        {
            InitializeComponent();
            this.Load += frmLapHoaDon_Load;
        }
        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            var db = new QLBanHangContext();
            //Đổ dữ liệu vào ComboBox Khách Hàng (cboKhachHang)
            cboKhachHang.DataSource = db.KhachHangs
                                        .Select(k => new { k.MaKH, k.TenKH })
                                        .ToList();
            cboKhachHang.DisplayMember = "TenCty";
            cboKhachHang.ValueMember = "MaKH";
            cboKhachHang.SelectedIndex = -1;

            //Đổ dữ liệu Sản Phẩm vào cột ComboBox trên lưới (dgvHoaDon)
            var colSanPham = dgvHoaDon.Columns["MaSP"] as DataGridViewComboBoxColumn;
            if (colSanPham != null)
            {
                colSanPham.DataSource = db.SanPhams
                                          .Select(s => new { s.MaSP, s.TenSP })
                                          .ToList();
                colSanPham.DisplayMember = "TenSP";
                colSanPham.ValueMember = "MaSP";
            }

            // Ensure grid events are wired (designer may already wire some)
            dgvHoaDon.CellValueChanged -= dgvHoaDon_CellValueChanged;
            dgvHoaDon.CellValueChanged += dgvHoaDon_CellValueChanged;
            dgvHoaDon.CurrentCellDirtyStateChanged -= dgvHoaDon_CurrentCellDirtyStateChanged;
            dgvHoaDon.CurrentCellDirtyStateChanged += dgvHoaDon_CurrentCellDirtyStateChanged;
            dgvHoaDon.CellEndEdit -= dgvHoaDon_CellEndEdit;
            dgvHoaDon.CellEndEdit += dgvHoaDon_CellEndEdit;
        }
        private void AutoFillOrderItem(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgvHoaDon.Rows.Count) return;

            // Lấy Mã SP từ ô đang chọn
            var cellMaSP = dgvHoaDon.Rows[rowIndex].Cells["MaSP"].Value;
            if (cellMaSP == null)
            {
                // If product not selected, clear price and thanh tien
                dgvHoaDon.Rows[rowIndex].Cells["DonGia"].Value = 0;
                dgvHoaDon.Rows[rowIndex].Cells["ThanhTien"].Value = 0;
                TinhTongTienHoaDon();
                return;
            }

            int maSP = Convert.ToInt32(cellMaSP);

            using (var db = new QLBanHangContext())
            {
                var sp = db.SanPhams.FirstOrDefault(s => s.MaSP == maSP);

                if (sp != null)
                {
                    decimal donGia = sp.DonGiaBan ?? 0;
                    // set the unit price from DB (or keep editable behavior if desired)
                    dgvHoaDon.Rows[rowIndex].Cells["DonGia"].Value = donGia;

                    var cellSoLuong = dgvHoaDon.Rows[rowIndex].Cells["SoLuong"].Value;
                    int soLuong = 0;
                    if (cellSoLuong != null && int.TryParse(cellSoLuong.ToString(), out int parsed))
                        soLuong = parsed;

                    dgvHoaDon.Rows[rowIndex].Cells["ThanhTien"].Value = soLuong * donGia;
                }
            }
            TinhTongTienHoaDon();
        }

        private void TinhTongTienHoaDon()
        {
            double tong = 0;
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.IsNewRow) continue;
                var cell = row.Cells["ThanhTien"].Value;
                if (cell != null && double.TryParse(cell.ToString(), out double val))
                {
                    tong += val;
                }
            }
            // format with thousands separator
            lblTongTien.Text = tong.ToString("N0") + " VNĐ";
        }

        private void dgvHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colName = dgvHoaDon.Columns[e.ColumnIndex].Name;
            if (colName == "MaSP" || colName == "SoLuong" || colName == "DonGia")
            {
                AutoFillOrderItem(e.RowIndex);
            }
        }

        // Commit edits immediately for combo box / cell edits so CellValueChanged fires right away
        private void dgvHoaDon_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvHoaDon.IsCurrentCellDirty)
            {
                dgvHoaDon.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvHoaDon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            // Ensure recalculation after user finishes editing (redundant safe-guard)
            AutoFillOrderItem(e.RowIndex);
            TinhTongTienHoaDon();
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool coSanPham = false;
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (!row.IsNewRow && row.Cells["MaSP"].Value != null)
                {
                    coSanPham = true;
                    break;
                }
            }

            if (!coSanPham)
            {
                MessageBox.Show("Vui lòng nhập ít nhất 1 sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Lưu xuống CSDL
            using (var db = new QLBanHangContext())
            {
                try
                {
                    HoaDon hd = new HoaDon();
                    hd.MaKH = cboKhachHang.SelectedValue.ToString();
                    hd.MaNV = 1;
                    hd.NgayLapHD = DateTime.Now;
                    hd.NgayNhanHang = DateTime.Now.AddDays(3);

                    db.HoaDons.Add(hd);
                    db.SaveChanges();

                    foreach (DataGridViewRow row in dgvHoaDon.Rows)
                    {
                        if (row.IsNewRow) continue;
                        if (row.Cells["MaSP"].Value == null) continue;

                        int maSP = Convert.ToInt32(row.Cells["MaSP"].Value);
                        int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value ?? 0);

                        if (soLuong > 0)
                        {
                            ChiTietHoaDon ct = new ChiTietHoaDon();
                            ct.MaHD = hd.MaHD;
                            ct.MaSP = maSP;
                            ct.SoLuong = soLuong;

                            db.ChiTietHoaDons.Add(ct);
                        }
                    }

                    db.SaveChanges();

                    lblMaHD.Text = hd.MaHD.ToString();
                    MessageBox.Show($"Tạo hóa đơn thành công! Mã số: {hd.MaHD}", "Chúc mừng");

                    btnLuuHoaDon.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang phát triển");
        }
    }
}