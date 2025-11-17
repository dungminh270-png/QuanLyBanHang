using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Thongtincanhan : Form
    {
        QLBanHangContext db = new QLBanHangContext();
        
        public Thongtincanhan()
        {
            InitializeComponent();
        }

        

        private void Thongtincanhan_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(UserSession.MaKH))
            {
                MessageBox.Show("Vui lòng đăng nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //this.Close();
                GanThongTinTrong();
                pctCanhan.Enabled = false;
                return;

            }
            pctCanhan.Enabled = true;
            LoadThongTinKhachHang();

        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GanThongTinTrong()
        {
            txtMaKh.Text = "";
            txtHten.Text = "Chưa đăng nhập";
            txtDiachi.Text = "";
            txtSDT.Text = "";
            txtThanhPho.Text = "";
            cbbGtinh.SelectedIndex = -1;
            dateTime.Checked = false;
            pctCanhan.Image = Properties.Resources.AvartarCaNhan;
        }
        private void LoadThongTinKhachHang()
        {
            var kh = db.KhachHangs
                     .Where(k => k.MaKH == UserSession.MaKH)
                     .Select(k => new
                     {
                         k.MaKH,
                         k.TenKH,
                         k.NgaySinh,
                         k.GTinh,
                         k.DiaChi,
                         k.DienThoai,
                         k.HinhAnh,
                         ThanhPho = k.MaThanhPho,
                     }).FirstOrDefault();
            if (kh == null)
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng!");
                return;
            }
            txtMaKh.Text = kh.MaKH;

            txtHten.Text = kh.TenKH ?? ""; 

            txtHten.Text = kh.TenKH ?? "";

            txtDiachi.Text = kh.DiaChi ?? "";
            txtSDT.Text = kh.DienThoai ?? "";

            txtThanhPho.Text = kh.ThanhPho.ToString();

            if (kh.NgaySinh.HasValue)
            {
                dateTime.Value = kh.NgaySinh.Value;
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
            HienThiAvatar(kh.HinhAnh);
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
                pctCanhan.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pctCanhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserSession.MaKH))
            {
                MessageBox.Show("Vui lòng đăng nhập để thay đổi ảnh đại diện!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenFileDialog opp = new OpenFileDialog
            {
                Title = "Chọn ảnh đại diện",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };
            if (opp.ShowDialog() != DialogResult.OK) return;
            try
            {
                string duongDanMoi = opp.FileName;
                string thuMucAnh = Path.Combine(Application.StartupPath, "Avatars");
                Directory.CreateDirectory(thuMucAnh);

                string duoiFile = Path.GetExtension(opp.FileName);
                string tenFileMoi = UserSession.MaKH + duoiFile;
                string duongDanLuu = Path.Combine(thuMucAnh, tenFileMoi);

                File.Copy(opp.FileName, duongDanLuu, true);
                string duongDanLuuVaoDB = Path.Combine("Avatars", tenFileMoi);
                var kh = db.KhachHangs.FirstOrDefault(k => k.MaKH == UserSession.MaKH);
                if (kh != null)
                {
                    kh.HinhAnh = duongDanLuuVaoDB;
                    db.SaveChanges();
                }
                HienThiAvatar(duongDanLuu);
                MessageBox.Show("Đổi ảnh đại diện thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổi ảnh: " + ex.Message, "Lỗi",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
