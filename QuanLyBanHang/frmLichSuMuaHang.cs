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
    public partial class frmLichSuMuaHang : Form
    {
        public frmLichSuMuaHang()
        {
            InitializeComponent();
        }

        private void frmLichSuMuaHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();

        }

        private void LoadHoaDon()
        {
            string maKH = cboKhachHang.SelectedValue.ToString();

            string sql = $@"SELECT MaHD, NgayLapHD, NgayNhanHang, MaNV FROM HoaDon WHERE MaKH = '{maKH}' ";

            dgvHoadon.DataSource = DataProvider.TruyVanLayDuLieu(sql);
        }

        private void LoadKhachHang()
        {
            string sql = "SELECT MaKH, TenCty FROM KhachHang";
            var dt = DataProvider.TruyVanLayDuLieu(sql);

            cboKhachHang.DataSource = dt;
            cboKhachHang.DisplayMember = "TenCty";
            cboKhachHang.ValueMember = "MaKH";
            cboKhachHang.SelectedIndex = 0;
        }

        //private void btnXem_Click(object sender, EventArgs e)
        //{
        //    LoadHoaDon();
        //}

        //private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
            
        //}

        private void LoadChiTietHoaDon(string maHD)
        {
            string sql = $@"SELECT cthd.MaSP, sp.TenSP, sp.DonGia, cthd.SoLuong, (cthd.SoLuong * sp.DonGia) AS ThanhTien FROM ChiTietHoaDon cthd JOIN SanPham sp ON cthd.MaSP = sp.MaSP WHERE cthd.MaHD = '{maHD}'";

            var dt = DataProvider.TruyVanLayDuLieu(sql);
            dgvChiTietHoaDon.DataSource = dt;

            // Tính tổng tiền
            decimal total = 0;
            foreach (DataRow r in dt.Rows)
            {
                total += Convert.ToDecimal(r["ThanhTien"]);
            }

            lblTongTien.Text = "Tổng tiền hóa đơn: " + total.ToString("N0") + " đ";
        }

        private void splitContainer4_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer4_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void dgvHoadon_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHD = dgvHoadon.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();
                LoadChiTietHoaDon(maHD);
            }
        }
    }
}
