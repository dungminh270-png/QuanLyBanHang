using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmQuanLiTonKho : Form
    {
        QLBanHangContext db = new QLBanHangContext();
        SanPham spDangchon = null;
        public frmQuanLiTonKho()
        {
            InitializeComponent();
        }
        public void LoadSanPham()
        {
            dgvSanPham.AutoGenerateColumns = false;

            var list = (from sp in db.SanPhams
                       select new
                       {
                           sp.MaSP,
                           sp.TenSP,
                           sp.SoLuongTon,
                           sp.DonGiaBan 
                       })
                       .ToList();
            
            dgvSanPham.DataSource = list;

        }
        private void frmQuanLiTonKho_Load(object sender, EventArgs e)
        {
            CauHinhDataGridView();
            LoadSanPham();
            pctAnh.Image = Properties.Resources.vietmacdinh;
            pctAnh.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if ( dgvSanPham.CurrentRow  == null ) { return; }

            try
            {
                // Lấy mã sản phẩm từ dòng đang chọn
                int maSP = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["MaSP"].Value);
                spDangchon = db.SanPhams.FirstOrDefault(s => s.MaSP == maSP);

                if (spDangchon == null) return;

                // Đổ dữ liệu vào các ô
                txtTenSP.Text = spDangchon.TenSP ?? "";
                txtSLT.Text = spDangchon.SoLuongTon.ToString();
                txtGia.Text = spDangchon.DonGiaBan.HasValue
              ? spDangchon.DonGiaBan.Value.ToString("N0")
              : "0";

                pctAnh.Image = Properties.Resources.vietmacdinh; 

                if (!string.IsNullOrWhiteSpace(spDangchon.HinhAnh))
                {
                    string tenAnh = spDangchon.HinhAnh.Trim();
                    var anh = Properties.Resources.ResourceManager.GetObject(tenAnh) as Bitmap;
                    if (anh != null)
                    {
                        pctAnh.Image = anh;
                        return;
                    }
                    // Nếu không tìm thấy → vẫn để ảnh mặc định
                }
           
                
                pctAnh.Image = Properties.Resources.vietmacdinh;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn sản phẩm: " + ex.Message);
            }
        }
        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSanPham.Columns[e.ColumnIndex].Name == "DonGiaBan" && e.Value != null)
            {
                e.Value = string.Format("{0:#,##0} ₫", e.Value);
                e.FormattingApplied = true;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham sp = new SanPham()
                {
                    TenSP = txtTenSP.Text,
                    SoLuongTon = int.Parse(txtSLT.Text),
                    DonGiaBan = float.Parse(txtGia.Text),

                    HinhAnh = ""
                };
                db.SanPhams.Add(sp);
                db.SaveChanges();
                LoadSanPham();
                MessageBox.Show("Thêm sản phẩm thành công!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi thêm sản phẩm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (spDangchon == null) { return; }
            try
            {
                spDangchon.TenSP = txtTenSP.Text;
                spDangchon.SoLuongTon = int.Parse(txtSLT.Text);
                spDangchon.DonGiaBan = decimal.Parse(txtGia.Text);
                if (!string.IsNullOrEmpty(pctAnh.ImageLocation))
                {
                    spDangchon.HinhAnh = pctAnh.ImageLocation;
                }

                    db.SaveChanges();
                    LoadSanPham();
                    MessageBox.Show("Cập nhật sản phẩm thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật sản phẩm: " + ex.Message);
                }
            }
            catch
            {

            }
        }
        private void CauHinhDataGridView()
        {
            dgvSanPham.AutoGenerateColumns = false;  // tắt tự động tạo cột
            dgvSanPham.Columns.Clear();              // xóa hết cột cũ (nếu có)

            // Cột Mã SP
            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaSP",
                HeaderText = "Mã SP",
                Width = 80
            });

            // Cột Tên sản phẩm
            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenSP",
                HeaderText = "Tên sản phẩm",
                Width = 195
            });

            // Cột Số lượng tồn
            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SoLuongTon",
                HeaderText = "Số lượng tồn",
                Width = 100
            });

            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DonGiaBan",                   
                DataPropertyName = "DonGiaBan",
                HeaderText = "Đơn giá bán",
                Width = 105
            });
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (spDangchon != null) { return; }
            try
            {
                db.SanPhams.Remove(spDangchon);
                db.SaveChanges();
                LoadSanPham();
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại! +", ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                db.SaveChanges();
                LoadSanPham();
                MessageBox.Show("Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại!", ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTenSP.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadSanPham(); 
                return;
            }
            var ketQua = db.SanPhams
                .Where(sp => sp.TenSP.ToLower().Contains(tuKhoa.ToLower()))
                .Select(sp => new
                {
                    sp.MaSP,
                    sp.TenSP,
                    sp.SoLuongTon,
                    sp.DonGiaBan
                }).ToList();
            dgvSanPham.DataSource = ketQua;
            if (ketQua.Count == 0)
                MessageBox.Show("Không tìm thấy sản phẩm nào phù hợp!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Tìm thấy {ketQua.Count} sản phẩm!", "Thành công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
