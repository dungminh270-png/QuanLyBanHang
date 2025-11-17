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
        public bool DaDangNhap { get; set; } = true;
        public string HoTenKH { get; set; }
        private void FormMaiN_KH__Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }

        
        public void PhanQuyen()
        {
            MnuDangXuat.Enabled = !DaDangNhap;
            MnuDangNhap.Enabled = DaDangNhap;

            lblHoTen.Text = DaDangNhap ? $"Xin chào: " + $"{HoTenKH}" : "Chưa đăng nhập";
            // xét quyền theo vai trò
            //MnuCauHinhHeThong.Enabled = DaDangNhap && Quyen == VaiTro.QuanTri;
            //MnuQLNhanVien.Enabled = DaDangNhap && Quyen == VaiTro.QuanTri;
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            if (lblTime != null)
            {
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy ");
            }
        }


        private void ThongTinCaNhan(object sender, EventArgs e)
        {
            var profile = new Thongtincanhan();
            profile.MdiParent = this;
            profile.Show();
        }

        private void DangNhap(object sender, EventArgs e)
        {
            var f = new Login();
            f.MdiParent = this;
            f.Show();
        }

        private void DangXuat(object sender, EventArgs e)
        {
            DaDangNhap = false;
            HoTenKH = "";
            PhanQuyen();

            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            MessageBox.Show("Đã đăng xuất!!");
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            
        }

        private void HeThong_Click(object sender, EventArgs e)
        {

        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmMuaHang();
            f.Show();
        }

        private void LichSu_Click(object sender, EventArgs e)
        {
            var f = new frmHuongDanSuDung();
            f.Show();     
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmLichSuMuaHang();    
            f.Show();  
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
