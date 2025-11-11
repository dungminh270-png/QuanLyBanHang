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
            var f = new Login();
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
    }
}
