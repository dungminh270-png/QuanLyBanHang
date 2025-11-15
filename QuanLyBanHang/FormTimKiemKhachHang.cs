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

        QLBanHangDataContext db = new QLBanHangDataContext();
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

            /* cboThanhPho.DisplayMember = "TenThanhPho";
            cboThanhPho.ValueMember = "MaThanhPho";
            cboThanhPho.DataSource = DataProvider.TruyVanLayDuLieu
                ("SELECT * FROM ThanhPho");

            // ép chọn thành phố đầu tiên
            cboThanhPho.SelectedIndex = 0;
            layKhachHangTheoThanhPho();
            */

            cboThanhPho.DataSource = db.ThanhPhos.ToList();
            cboThanhPho.DisplayMember = "TenThanhPho";
            cboThanhPho.ValueMember = "MathanhPho";

            cboThanhPho.SelectedIndex = 0;

            layKhachHangTheoThanhPho();
        }

        private void layKhachHangTheoThanhPho()
        {
            if (cboThanhPho.SelectedValue == null)
                return;

            int maTP = (int)cboThanhPho.SelectedValue;

            var ds = db.KhachHangs
                .Where (kh => kh.MaThanhPho == maTP)
                .Select (kh => new
                {
                    kh.MaKH,
                    kh.TenCty,
                    kh.DiaChi,
                    kh.DienThoai,
                    kh.MaThanhPho
                }).ToList();

            dgvKhachHang.DataSource = ds;
            txtSoLuongKhachHang.Text = ds.Count.ToString();
           /* var sql = $"SELECT * FROM KhachHang WHERE MaThanhPho = '{cboThanhPho.SelectedValue.ToString()}'";
            var dataKhachHang = DataProvider.TruyVanLayDuLieu(sql);
            dgvKhachHang.DataSource = dataKhachHang;
            txtSoLuongKhachHang.Text = dataKhachHang.Rows.Count.ToString();
           */
        }
    }
}
