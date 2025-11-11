using Microsoft.SqlServer.Management.Sdk.Sfc;
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
    public partial class frmQuanLiKhachHang : Form
    {
        public frmQuanLiKhachHang()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLiKhachHang_Load(object sender, EventArgs e)
        {
            LoadThanhPho();
            LoadKhachHang();
        }

        private void LoadKhachHang()
        {
            var sql= "SELECT * FROM KhachHang ORDER BY TenCty";
            dgvKhachHang.DataSource= DataProvider.TruyVanLayDuLieu(sql);


        }

        private void LoadThanhPho()
        {
            var sql = "SELECT * FROM ThanhPho ORDER BY TenThanhPho";
            var dtThanhPho = DataProvider.TruyVanLayDuLieu(sql);

            //đổ dữ liệu vào combo box thành phố (cboThanhPho)
            cboThanhPho.DataSource = dtThanhPho;
            cboThanhPho.DisplayMember = "TenThanhPho";
            cboThanhPho.ValueMember = "MaThanhPho";

            //đổ dữ liệu vào combo box thành phố trong DataGridView
            var dgvCboThanhPho= dgvKhachHang.Columns["MaThanhPho"] as DataGridViewComboBoxColumn;
            dgvCboThanhPho.DataSource = dtThanhPho;
            dgvCboThanhPho.DisplayMember = "TenThanhPho";
            dgvCboThanhPho.ValueMember = "MaThanhPho";


        }
    }
}
