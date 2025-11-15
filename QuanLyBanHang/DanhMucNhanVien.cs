using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        }

        private void LoadNV()
        {
            dgvNhanVien.DataSource = DataProvider.Instance.GetAllNhanVien();
        }


    }
}
