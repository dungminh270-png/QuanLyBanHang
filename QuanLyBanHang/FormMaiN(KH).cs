using Microsoft.EntityFrameworkCore;
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
    public partial class FormMaiN_KH_ : Form
    {
        public FormMaiN_KH_()
        {
            InitializeComponent();
        }
        public bool DaDangNhapKH { get; set; } = false;
        public string HoTenKH { get; set; }

        private void FormMaiN_KH__Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }
        private bool KiemTraDangNhap()
        {
            if (!DaDangNhapKH || string.IsNullOrEmpty(UserSession.MaKH))
            {
                MessageBox.Show("Vui lòng đăng nhập để sử dụng chức năng này!",
                    "Chưa đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Tự động mở form đăng nhập luôn (rất pro!)
                DangNhap(null, null);
                return false;
            }
            return true;
        }

        public void PhanQuyen()
        {
            MnuDangXuat.Enabled = DaDangNhapKH;
            MnuDangNhap.Enabled = !DaDangNhapKH;

            lblHoTen.Text = DaDangNhapKH ? $"Xin chào: " + $"{HoTenKH}" : "Chưa đăng nhập";
            // xét quyền theo vai trò
            //MnuCauHinhHeThong.Enabled = DaDangNhap && Quyen == VaiTro.QuanTri;
            //MnuQLNhanVien.Enabled = DaDangNhap && Quyen == VaiTro.QuanTri;
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            //lblTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy ");

        }


        private void ThongTinCaNhan(object sender, EventArgs e)
        {
            picFullView.Visible = false;
            if (!DaDangNhapKH || string.IsNullOrEmpty(UserSession.MaKH))
            {
                MessageBox.Show("Vui lòng đăng nhập để xem thông tin cá nhân!",
                    "Chưa đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            var profile = new Thongtincanhan();
            profile.MdiParent = this;
            profile.WindowState = FormWindowState.Maximized;
            profile.Show();

            
            //else
            //{
            //    MessageBox.Show("Vui lòng đăng nhập để xem thông tin cá nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //} 


        }
        private void DangNhap(object sender, EventArgs e)
        {
            picFullView.Visible = false;
            var f = new Login(this);
            f.MdiParent = this;
            f.Show();
        }

        private void DangXuat(object sender, EventArgs e)
        {
            picFullView.Visible = false;
            DaDangNhapKH = false;
            HoTenKH = "";
            PhanQuyen();

            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            using (var db = new QLBanHangContext())
            {
                db.Database.ExecuteSqlRaw("TRUNCATE TABLE GioHang");
            }
            UserSession.Clear();
            MessageBox.Show("Đã đăng xuất!!");

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            using (var db = new QLBanHangContext())
            {
                db.Database.ExecuteSqlRaw("TRUNCATE TABLE GioHang");
            }
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void HeThong_Click(object sender, EventArgs e)
        {

        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picFullView.Visible = false;
            if (!KiemTraDangNhap()) return;
            var f = new FrmMuaHang();
            f.MdiParent = this;
            f.Show();
        }

        private void LichSu_Click(object sender, EventArgs e)
        {
            picFullView.Visible = false;
            var f = new frmHuongDanSuDung();
            f.MdiParent = this;
            f.Show();     
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picFullView.Visible = false;
            if (!KiemTraDangNhap()) return;
            var f = new frmLichSuMuaHang();    
            f.Show();  
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picFullView.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy ");
        }

        private void lblTime_Click_1(object sender, EventArgs e)
        {

        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picFullView.Image = Properties.Resources.hotsale2; 
            picFullView.Visible = true;
            picFullView.BringToFront();
        }

        private void SanPham_Click(object sender, EventArgs e)
        {

        }

        private void picFullView_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!KiemTraDangNhap()) return;
            var f = new frmLapHoaDon();
            f.MdiParent = this;
            f.Show();
        }
    }
}
