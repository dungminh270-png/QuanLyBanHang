using QuanLyBanHang.Models;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }

        public bool DaDangNhap { get; set; } = false;
        public string HoTenNhanVien { get; set; }


        public void PhanQuyen()
        {
            MnuDangXuat.Enabled = DaDangNhap;
            MnuDangNhap.Enabled = !DaDangNhap;
           
            lblHoTenNhanVien.Text = DaDangNhap ? $"Xin chào: " + $"{HoTenNhanVien}" : "Chưa đăng nhập";
            // xét quyền theo vai trò
            //MnuCauHinhHeThong.Enabled = DaDangNhap && Quyen == VaiTro.QuanTri;
            //MnuQLNhanVien.Enabled = DaDangNhap && Quyen == VaiTro.QuanTri;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblDongHo != null)
            {
                lblDongHo.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy ");
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Login();
            f.MdiParent = this;
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaDangNhap = false;
            HoTenNhanVien = "";
            PhanQuyen();

            foreach(Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            MessageBox.Show("Đã đăng xuất!!");
        }

        private void kháchHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var f = new frmQuanLiKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new FormTimKiemKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void hóaĐơnToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var f = new frmTimKiemHoaDon();
            f.MdiParent = this;
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new DanhMucKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new DanhMucNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmDanhMucSanPham();
            f.MdiParent = this;
            f.Show();
        }

        private void thànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmDanhMucThanhPho();
            f.MdiParent = this;
            f.Show();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var hdsd = new frmHuongDanSuDung();
           hdsd.MdiParent = this;
           hdsd.Show();
        }

        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var f = new frmQuanLiKhoHang();
            //f.MdiParent = this;
            //f.Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new frmLichSuMuaHang();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }

        private void lblHoTenNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void muaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmLichSuMuaHang();
            f.MdiParent = this;
            f.Show();
        }

        private void MnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}