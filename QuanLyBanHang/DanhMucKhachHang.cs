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
    public partial class DanhMucKhachHang : Form
    {
        public DanhMucKhachHang()
        {
            InitializeComponent();
        }

        private void DanhMucKhachHang_Load(object sender, EventArgs e)
        {
            LoadThanhPho(); // đổ dữ liệu vào combobox thành phố
            LoadKhachHang(); // đổ dữ liệu vào dgvKhachHang

        }

        string ChuoiKetNoi = @"Server=localhost\SQLEXPRESS;Database=QLBanHang;Trusted_Connection=True;";
        private void LoadKhachHang()
        {
            var connection = new SqlConnection(ChuoiKetNoi);
            var DataAdapter = new SqlDataAdapter("SELECT * FROM KhachHang ORDER BY TenCty", connection);
            var dtKhachHang = new DataTable();
            DataAdapter.Fill(dtKhachHang);
            dgvKhachHang.DataSource = dtKhachHang;
        }

        private void LoadThanhPho()
        {
            var connection = new SqlConnection(ChuoiKetNoi);
            var DataAdapter = new SqlDataAdapter("SELECT * FROM ThanhPho ORDER BY TenThanhPho", connection);
            var dtThanhPho = new DataTable();
            DataAdapter.Fill(dtThanhPho);

            //tìm combo box trong dataGridView
            var cboThanhPho = dgvKhachHang.Columns["MaThanhPho"] as DataGridViewComboBoxColumn;
            cboThanhPho.DataSource = dtThanhPho;
            cboThanhPho.DisplayMember = "TenThanhPho";
            cboThanhPho.ValueMember = "MaThanhPho";
        }
    }
}
