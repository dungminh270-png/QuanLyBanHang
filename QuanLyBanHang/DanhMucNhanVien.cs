using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class DanhMucNhanVien : Form
    {
        public DanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void DanhMucNhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
            CauHinhDataGridView();
            HienThiAnhTrongGrid();

        }

        private void LoadNV()
        {
            var dsNhanVien = DataProvider.Instance.GetAllNhanVien();
            var data = dsNhanVien.Select(nv => new
            {
                nv.MaNV,
                nv.DiaChi,
                nv.DienThoai,
                nv.MaDN,
                nv.MatKhau,
                nv.HoTen,
                GTinh = nv.GTinh == true ? "Nam" : (nv.GTinh == false ? "Nữ" : "Không xác định"),
                NgaySinh = nv.NgaySinh.HasValue ? nv.NgaySinh.Value.ToString("dd/MM/yyyy") : "",
                nv.Email,
                HinhAnh = nv.HinhAnh 
            }).ToList();
            dgvNhanVien.DataSource = data;
        }
        private void CauHinhDataGridView()
        {
            // Đổi tên cột tiếng Việt đẹp
            dgvNhanVien.Columns["MaNV"].HeaderText = "MÃ NV";
            dgvNhanVien.Columns["DiaChi"].HeaderText = "ĐỊA CHỈ";
            dgvNhanVien.Columns["DienThoai"].HeaderText = "ĐIỆN THOẠI";
            dgvNhanVien.Columns["MaDN"].HeaderText = "MÃ ĐĂNG NHẬP";
            dgvNhanVien.Columns["MatKhau"].HeaderText = "MẬT KHẨU";
            dgvNhanVien.Columns["HoTen"].HeaderText = "HỌ TÊN";
            dgvNhanVien.Columns["GTinh"].HeaderText = "GIỚI TÍNH";
            dgvNhanVien.Columns["NgaySinh"].HeaderText = "NGÀY SINH";
            dgvNhanVien.Columns["Email"].HeaderText = "EMAIL";
            dgvNhanVien.Columns["HinhAnh"].HeaderText = "HÌNH ẢNH";

            dgvNhanVien.Columns["HoTen"].Width = 200;
            dgvNhanVien.Columns["HoTen"].MinimumWidth = 160;
            dgvNhanVien.Columns["HoTen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            // Căn giữa, font đẹp
            dgvNhanVien.Columns["MaNV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvNhanVien.Columns["DienThoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvNhanVien.Columns["DiaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhanVien.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Header đẹp
            dgvNhanVien.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNhanVien.ColumnHeadersHeight = 45;
            dgvNhanVien.EnableHeadersVisualStyles = false;

            // Tự động co giãn cột

            // Thêm cột ảnh (nếu muốn hiện ảnh nhỏ trong grid)
            if (!dgvNhanVien.Columns.Contains("AnhDaiDien"))
            {
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.Name = "AnhDaiDien";
                imgCol.HeaderText = "ẢNH";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvNhanVien.Columns.Add(imgCol);
            }
        }
        private void HienThiAnhTrongGrid()
        {
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (row.IsNewRow) continue;

                string duongDan = row.Cells["HinhAnh"].Value?.ToString();
                if (!string.IsNullOrEmpty(duongDan))
                {
                    string fullPath = Path.Combine(Application.StartupPath, duongDan);
                    if (File.Exists(fullPath))
                    {
                        try
                        {
                            using (var img = Image.FromFile(fullPath))
                            {
                                row.Cells["AnhDaiDien"].Value = new Bitmap(img, new Size(60, 60));
                            }
                            row.Height = 70;
                        }
                        catch { /* Bỏ qua nếu lỗi ảnh */ }
                    }
                }
            }
        }
    }
}
