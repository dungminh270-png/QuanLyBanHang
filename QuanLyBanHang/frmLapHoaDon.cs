using QuanLyBanHang;
using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmLapHoaDon : Form
    {

        public frmLapHoaDon()
        {
            InitializeComponent();
            dgvHoaDon = new DataGridView();
            this.Controls.Add(dgvHoaDon);
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            using (var db = new QLBanHangContext())
            {
                cboKhachHang.DataSource = db.KhachHangs.ToList();
                cboKhachHang.DisplayMember = "TenCty";
                cboKhachHang.ValueMember = "MaKH";
                cboKhachHang.SelectedIndex = -1;

                // Đổ dữ liệu Sản phẩm vào cột ComboBox trên lưới
                DataGridViewComboBoxColumn colSanPham = new DataGridViewComboBoxColumn();
                colSanPham.Name = "MaSP";
                colSanPham.HeaderText = "Sản phẩm";
                colSanPham.DataSource = db.SanPhams.ToList();
                colSanPham.DisplayMember = "TenSP";
                colSanPham.ValueMember = "MaSP";
                dgvHoaDon.Columns.Add(colSanPham);
            }
        }

        private void AutoFillOrderItem(int rowIndex)
        {
            var cellMaSP = dgvHoaDon.Rows[rowIndex].Cells["MaSP"].Value;
            if (cellMaSP == null) return;

            int maSP = Convert.ToInt32(cellMaSP);

            using (var db = new QLBanHangContext())
            {
                // Truy vấn LINQ lấy sản phẩm
                var sp = db.SanPhams.FirstOrDefault(s => s.MaSP == maSP);

                if (sp != null)
                {
                    // Điền đơn giá (cột index 2)
                    // Lưu ý: Cột DonGia trong DB có thể là nullable, cần xử lý
                    double donGia = sp.DonGia ?? 0;
                    dgvHoaDon.Rows[rowIndex].Cells["DonGia"].Value = donGia;

                    // Lấy số lượng (cột index 1)
                    var cellSoLuong = dgvHoaDon.Rows[rowIndex].Cells["SoLuong"].Value;
                    int soLuong = (cellSoLuong == null) ? 0 : Convert.ToInt32(cellSoLuong);

                    // Tính thành tiền (cột index 3)
                    dgvHoaDon.Rows[rowIndex].Cells["ThanhTien"].Value = soLuong * donGia;
                }
            }
            // Tính tổng tiền cả hóa đơn hiển thị lên Label
            CapNhatTongTien();
        }
    
    private void CapNhatTongTien()
        {
            double tong = 0;
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tong += Convert.ToDouble(row.Cells["ThanhTien"].Value);
                }
            }
            lblTongTien.Text = tong.ToString("N0"); // Định dạng số đẹp (vd: 100,000)
        }

        private void dgvHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 0 || e.ColumnIndex == 1))
            {
                AutoFillOrderItem(e.RowIndex);
            }
        }

        public void BtnLuuHoaDon_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu đầu vào
            if (cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }

            // Kiểm tra lưới có hàng nào không
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
                MessageBox.Show("Vui lòng chọn ít nhất 1 sản phẩm!");
                return;
            }

            // 2. Bắt đầu Lưu bằng LINQ
            using (var db = new QLBanHangContext())
            {
                try
                {
                    // --- B1: Tạo và Lưu Hóa Đơn (Header) ---
                    HoaDon hd = new HoaDon();
                    hd.MaKH = cboKhachHang.SelectedValue.ToString();
                    hd.MaNV = 1; // Thay bằng mã nhân viên đăng nhập thực tế
                    hd.NgayLapHD = DateTime.Now;
                    hd.NgayNhanHang = DateTime.Now.AddDays(3); // Ví dụ ngày nhận

                    db.HoaDons.Add(hd); // Đánh dấu để thêm
                    db.SaveChanges(); // Lệnh này chạy xong, hd.MaHD sẽ tự động có giá trị mới

                    // --- B2: Lưu Chi Tiết Hóa Đơn (Details) ---
                    foreach (DataGridViewRow row in dgvHoaDon.Rows)
                    {
                        if (row.IsNewRow) continue;
                        if (row.Cells["MaSP"].Value == null) continue;

                        int maSP = Convert.ToInt32(row.Cells["MaSP"].Value);
                        int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value ?? 0);

                        if (soLuong > 0)
                        {
                            ChiTietHoaDon ct = new ChiTietHoaDon();
                            ct.MaHD = hd.MaHD; // Lấy mã hóa đơn vừa tạo ở trên
                            ct.MaSP = maSP;
                            ct.SoLuong = soLuong;

                            db.ChiTietHoaDons.Add(ct);
                        }
                    }

                    db.SaveChanges(); // Lưu toàn bộ chi tiết xuống DB

                    // --- B3: Hoàn tất ---
                    MessageBox.Show($"Tạo hóa đơn thành công! Mã HĐ: {hd.MaHD}");
                    lblMaHD.Text = hd.MaHD.ToString();

                    // Có thể reset form ở đây nếu muốn
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message);
                }
            }
        }
    }
}
