using QuanLyBanHang.Chi_Tiết_SP;
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
    public partial class FrmMuaHang : Form
    {
        public FrmMuaHang()
        {
            InitializeComponent();
        }

        private void sảnPhẩmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tìmKiếmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hotToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMuaHang_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        // MUA HÀNG 1
        private void button1_Click(object sender, EventArgs e)
        {
            var f = new frmChiTiet1();
            f.Show();

        }
        // MUA HÀNG 2   
        private void button2_Click(object sender, EventArgs e)
        {
            var f = new frmChiTiet2();  
            f.Show();   
        }
        // MUA HÀNG 3   
        private void button3_Click(object sender, EventArgs e)
        {
            var f = new frmChiTiet3();  
            f.Show();
        }
        // MUA HÀNG 4   
        private void button4_Click(object sender, EventArgs e)
        {
            var f = new frmChiTiet4();
            f.Show();   
        }
        // MUA HÀNG 5   
        private void button5_Click(object sender, EventArgs e)
        {
            var f = new frmChiTiet5();  
            f.Show();   
        }
        // MUA HÀNG 6   
        private void button6_Click(object sender, EventArgs e)
        {
            var f = new frmChiTiet6();  
            f.Show();   
        }
    }
}
