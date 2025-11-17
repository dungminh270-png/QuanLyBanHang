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
    public partial class FrmTimKiemSanPham : Form
    {
        QLBanHangContext db = new QLBanHangContext();
        public FrmTimKiemSanPham()
        {
            InitializeComponent();
        }
        private void LoadDuLieu()
        {
            var data = db.SanPhams
                .Select(sp => new
                {
                    sp.MaSP,
                    sp.TenSP,
                    sp.MaLoai,
                    sp.DonGiaBan,
                    sp.HinhAnh
                })
                .ToList();
            var Ketqua = data.Select(sp => new
            {
                sp.MaSP,
                sp.TenSP,
                sp.MaLoai,
                sp.DonGiaBan,
                Hinh = LayAnhTuDuongDan(sp.HinhAnh) 
            }).ToList();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string TENSP = txtTenSP.Text.Trim();
            string MASP = txtMaSP.Text.Trim();
            string GiaTu = txtGiaTu.Text.Trim();
            string GiaDen = txtGiaDen.Text.Trim();

            var query = db.SanPhams.AsQueryable();

            // tim theo ma sp
            if (int.TryParse(MASP, out int maSP))
            {
                query = query.Where(sp => sp.MaSP == maSP);
            }
            // tim theo ten sp
            if (!string.IsNullOrEmpty(TENSP))
            {
                query = query.Where(sp => sp.TenSP.Contains(TENSP));
            }
            // tim theo gia
            if (double.TryParse(GiaTu, out double giaTu))
            {
                decimal giaTuDecimal = (decimal)giaTu;
                query = query.Where(sp => (sp.DonGiaBan ?? 0m) >= giaTuDecimal);
            }
            if (double.TryParse(GiaDen, out double giaDen))
            {
                decimal giaDenDecimal = (decimal)giaDen;
                query = query.Where(sp => (sp.DonGiaBan ?? 0m) <= giaDenDecimal);
            }

            var data = query.Select(sp => new
            {
                sp.MaSP,
                sp.TenSP,
                DonGia = sp.DonGiaBan ?? 0,
                sp.MaLoai,
                sp.HinhAnh
            }).ToList();
            var Ketqua = data
                .Select(sp => new
                {
                    sp.MaSP,
                    sp.TenSP,
                    sp.DonGia,
                    sp.MaLoai,
                    Hinh = LayAnhTuDuongDan(sp.HinhAnh)
                }).ToList();
            dgvSanPham.DataSource = Ketqua;
            if (!Ketqua.Any())
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);    
            }
        }
        private void CauHinhDataGridView()
        {
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.Columns.Clear();
            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaSP",
                HeaderText = "Mã SP",
                Width = 80
            });

            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenSP",
                HeaderText = "Tên sản phẩm",
                Width = 220
            });
            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DonGia",
                HeaderText = "Đơn giá",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dgvSanPham.Columns.Add(new DataGridViewImageColumn
            {
                DataPropertyName = "Hinh",
                HeaderText = "Hình",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 80
            });
        }
        private Image LayAnhTuDuongDan(string duongDan)
        {
            if (string.IsNullOrEmpty(duongDan)) return null;

            try
            {
                // Xây dựng đường dẫn đầy đủ
                string fullPath = Path.Combine(Application.StartupPath, "Images", duongDan.Trim());
                // CHỈ TRẢ VỀ ẢNH NẾU FILE THỰC SỰ TỒN TẠI
                return File.Exists(fullPath) ? Image.FromFile(fullPath) : Properties.Resources.AvartarCaNhan;
            }
            catch
            {
                return null; // Tránh crash nếu file lỗi
            }
        }
        private void FrmTimKiemSanPham_Load(object sender, EventArgs e)
        {
            CauHinhDataGridView();
            LoadDuLieu();
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSP.Text))
                LoadDuLieu();
            else
                btnTim.PerformClick();
        }
    }
}
