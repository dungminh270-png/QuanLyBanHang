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
    public partial class FrmDanhMucSanPham : Form
    {
        public FrmDanhMucSanPham()
        {
            InitializeComponent();
        }

        private void FrmDanhMucSanPham_Load(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM SanPham ";
            dgvSanPham.DataSource = DataProvider.TruyVanLayDuLieu(sql);
        }
    }
}
