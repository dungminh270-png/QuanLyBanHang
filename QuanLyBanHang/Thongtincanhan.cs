using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Thongtincanhan : Form
    {
        QLBanHangContext db = new QLBanHangContext();
        private string duongDanAnhMoi = "";
        public Thongtincanhan()
        {
            InitializeComponent();
        }


        private void Thongtincanhan_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentUser.MaKH))
            {
                MessageBox.Show("Vui lòng đăng nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            LoadThongTinKhachHang();
        }
        private void LoadThongTinKhachHang()
        {
            var kh = db.KhachHangs
                     .Where(k => k.MaKH == CurrentUser.MaKH)
                     .Select(k => new
                     {
                         k.MaKH,
                         k.TenCty,
                         k.NgSinh,
                         k.GTinh,
                         k.DiaChi,
                         k.DienThoai,
                         ThanhPho = k.MaThanhPho,
                     }).FirstOrDefault();
            if (kh == null)
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng!");
                return;
            }
            txtMaKh.Text = kh.MaKH;
            txtHten.Text = kh.TenCty ?? ""; // Dùng TenCty làm họ tên
            txtDiachi.Text = kh.DiaChi ?? "";
            txtSDT.Text = kh.DienThoai ?? "";

            txtThanhPho.Text = kh.ThanhPho.ToString();

            if (kh.NgSinh.HasValue)
            {
                dateTime.Value = kh.NgSinh.Value;
                dateTime.Checked = true;
            }
            else
            {
                dateTime.Checked = false;
            }
            if (kh.GTinh.HasValue)
            {
                cbbGtinh.Text = kh.GTinh.Value ? "Nam" : "Nữ";
            }
            else
            {
                cbbGtinh.SelectedIndex = -1;
            }
        }
        private void HienThiAvatar(string duongDan)
        {
            try
            {
                if (!string.IsNullOrEmpty(duongDan))
                {
                    pctCanhan.Image = Image.FromFile(duongDan);
                }
                else
                {
                    pctCanhan.Image = Properties.Resources.AvartarCaNhan; // ảnh mặc định
                }
                pctCanhan.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                pctCanhan.Image = Properties.Resources.AvartarCaNhan;
            }
        }

        private void pctCanhan_Click(object sender, EventArgs e)
        {
            OpenFileDialog opp = new OpenFileDialog();
            opp.Title = "Chọn ảnh đại diện";
            opp.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (opp.ShowDialog() == DialogResult.OK)
            {
                duongDanAnhMoi = opp.FileName;
                pctCanhan.Image = Image.FromFile(duongDanAnhMoi);
                pctCanhan.SizeMode = PictureBoxSizeMode.StretchImage;

                LuuAvatar(duongDanAnhMoi);
                MessageBox.Show("Đổi ảnh đại diện thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LuuAvatar(string duongDan)
        {
            var kh = db.KhachHangs
                    .Where(k => k.MaKH == CurrentUser.MaKH)
                    .FirstOrDefault();
            if (kh != null)
            {
                kh.Avatar = duongDan;
            }
        }
    }
}
