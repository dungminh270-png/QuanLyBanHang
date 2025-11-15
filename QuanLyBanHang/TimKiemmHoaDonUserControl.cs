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
    public partial class TimKiemmHoaDonUserControl : UserControl
    {
        public TimKiemmHoaDonUserControl()
        {
            InitializeComponent();
            this.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void TimKiemmHoaDonUserControl_Load(object sender, EventArgs e)
        {
            LoadThanhPho();
            LoadNhanVien();
            LoadSanPham();

            if (cboThanhPho.Items.Count > 0)
                cboThanhPho.SelectedIndex = 0;
            //LoadKhachHang();
        }

        private void LoadSanPham()
        {
            //var sql = "SELECT MaSP, TenSP FROM SanPham ";

            //var cboMaSP = dgvChiTietHoaDon.Columns["MaSP"] as DataGridViewComboBoxColumn;

            //if (cboMaSP != null)
            //{
            //    cboMaSP.ValueMember = "MaSP";
            //    cboMaSP.DisplayMember = "TenSP";
            //    cboMaSP.DataSource = DataProvider.TruyVanLayDuLieu(sql);
            //}
        }

        private void LoadNhanVien()
        {
            //var sql = "SELECT MaNV, CONCAT(Ho,' ',Ten) as HoTen FROM NhanVien ";

            //var cboMaNV = dgvHoaDon.Columns["MaNV"] as DataGridViewComboBoxColumn;

            //if (cboMaNV != null)
            //{
            //    cboMaNV.ValueMember = "MaNV";
            //    cboMaNV.DisplayMember = "HoTen";
            //    cboMaNV.DataSource = DataProvider.TruyVanLayDuLieu(sql);
            //}


        }

        private void LoadThanhPho()
        {
            //var sql = "SELECT * FROM ThanhPho ORDER BY TenThanhPho";
            //cboThanhPho.ValueMember = "MaThanhPho";
            //cboThanhPho.DisplayMember = "TenThanhPho";
            //cboThanhPho.DataSource = DataProvider.TruyVanLayDuLieu(sql);
        }

        private void LoadKhachHang()
        {
            //var sql = $"SELECT MaKH, TenCty FROM KhachHang WHERE MaThanhPho='{cboThanhPho.SelectedValue}' ORDER BY tenCty";

            //var dtKhachhang=DataProvider.TruyVanLayDuLieu(sql);

            //cboKhachHang.ValueMember = "MaKH";
            //cboKhachHang.DisplayMember = "TenCty";
            //cboKhachHang.DataSource = dtKhachhang;

            //txbSLKhachHang.Text = dtKhachhang.Rows.Count.ToString();

            ////đổ dữ liệu cho column MaKH trong dgvHoaDon
            //var hdCboMaKH = dgvHoaDon.Columns["MaKH"] as DataGridViewComboBoxColumn;
            //if (hdCboMaKH != null)
            //{
            //    hdCboMaKH.ValueMember = "MaKH";
            //    hdCboMaKH.DisplayMember = "TenCty";
            //    hdCboMaKH.DataSource = dtKhachhang;
            //}

            ////ép chọn khách hàng đầu tiên
            //if (dtKhachhang.Rows.Count > 0)
            //    cboKhachHang.SelectedIndex = 0;
        }

        private void cboThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void LoadHoaDon()
        {
            //var sql = $"SELECT * FROM HoaDon WHERE MaKH='{cboKhachHang.SelectedValue}' ";
            //var dtHoadon = DataProvider.TruyVanLayDuLieu(sql);
            //dgvHoaDon.DataSource = dtHoadon;
            //txbSLHoaDon.Text = dtHoadon.Rows.Count.ToString();
        }

        private void dgvHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
 

        }



        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex > -1)
            //{
            //    var sql = $"SELECT cthd.*,sp.DonGia, SoLuong* DonGia as ThanhTien FROM ChiTietHoaDon cthd JOIN SanPham sp ON cthd.MaSP = sp.MaSP WHERE MaHD='{dgvHoaDon.Rows[e.RowIndex].Cells[0].Value}' ";
            //    var dtChiTietHD = DataProvider.TruyVanLayDuLieu(sql);
            //    dgvChiTietHoaDon.DataSource = dtChiTietHD;
            //    txbSLMatHang.Text = dtChiTietHD.Rows.Count.ToString();
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
