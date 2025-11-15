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
    public partial class FormMain : Form
    {

     
        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Login(this);
            f.MdiParent = this;
            f.Show();
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            PhanQuyen();    
        }

        public bool DaDangNhap { get; set; } = true;
        public string HoTenNhanVien { get; set; }

        public void PhanQuyen()
        {
            menuStrip1.Enabled = DaDangNhap;
            đăngXuấtToolStripMenuItem.Enabled = DaDangNhap;
            đăngNhậpToolStripMenuItem.Enabled = !DaDangNhap;
            lblHoTenNhanVien.Text= DaDangNhap ? $"Xin Chào: {HoTenNhanVien}" : "Chưa Đăng Nhập";

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy ");
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new DanhMucNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f=new FrmDanhMucSanPham();
            f.MdiParent = this;
            f.Show();
        }

        private void thànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f= new FrmDanhMucThanhPho();
            f.MdiParent = this;
            f.Show();
        }
    }
}
