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
    public partial class FormTimKiemKhachHang : Form
    {
        public FormTimKiemKhachHang()
        {
            InitializeComponent();
        }

        private void cboThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {
            layKhachHangTheoThanhPho();   

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            cboThanhPho.DisplayMember = "TenThanhPho";
            cboThanhPho.ValueMember = "MaThanhPho";
            cboThanhPho.DataSource = DataProvider.TruyVanLayDuLieu
                ("SELECT * FROM ThanhPho");

            // ép chọn thành phố đầu tiên
            cboThanhPho.SelectedIndex = 0;
            layKhachHangTheoThanhPho();
        }

        private void layKhachHangTheoThanhPho()
        {
            var sql = $"SELECT * FROM KhachHang WHERE MaThanhPho = '{cboThanhPho.SelectedValue.ToString()}'";
            var dataKhachHang = DataProvider.TruyVanLayDuLieu(sql);
            dgvKhachHang.DataSource = dataKhachHang;
            txtSoLuongKhachHang.Text = dataKhachHang.Rows.Count.ToString();
        }
    }
}
