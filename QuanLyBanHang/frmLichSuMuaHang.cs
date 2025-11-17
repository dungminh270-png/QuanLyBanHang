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

        private void LoadKhachHang()
        {
            using (var db = new QLBanHangContext())
            {
                var listKH = db.KhachHangs
                               .Select(kh => new { kh.MaKH, kh.TenKH })
                               .ToList();

                cboKhachHang.DataSource = listKH;
                cboKhachHang.DisplayMember = "TenCty";
                cboKhachHang.ValueMember = "MaKH";

                if (listKH.Count > 0)
                    cboKhachHang.SelectedIndex = 0;
            }
        }

        private void LoadHoaDon()
        {
            if (cboKhachHang.SelectedValue == null) return;

            string maKH = cboKhachHang.SelectedValue.ToString();

            using (var db = new QLBanHangContext())
            {
                var listHD = db.HoaDons
                               .Where(hd => hd.MaKH == maKH)
                               .Select(hd => new
                               {
                                   hd.MaHD,
                                   hd.NgayLapHD,
                                   hd.NgayNhanHang,
                                   hd.MaNV
                               })
                               .ToList();

                dgvHoadon.DataSource = listHD;
            }
        }

        private void LoadChiTietHoaDon(string maHDString)
        {

            if (!int.TryParse(maHDString, out int maHD)) return;

            using (var db = new QLBanHangContext())
            {
                // Thực hiện Join bảng ChiTietHoaDon với SanPham để lấy Tên và Giá

                var listChiTiet = (from cthd in db.ChiTietHoaDons
                                   join sp in db.SanPhams on cthd.MaSP equals sp.MaSP
                                   where cthd.MaHD == maHD
                                   select new
                                   {
                                       cthd.MaSP,
                                       sp.TenSP,       
                                       sp.DonGiaBan,   
                                       cthd.SoLuong,
                                       ThanhTien = sp.DonGiaBan * cthd.SoLuong
                                   }).ToList();

                dgvChiTietHoaDon.DataSource = listChiTiet;

                double total = listChiTiet.Sum(x => x.ThanhTien ?? 0);

                lblTongTien.Text = "Tổng tiền hóa đơn: " + total.ToString("N0") + " đ";
            }
        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void dgvHoadon_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHoadon.Rows[e.RowIndex].Cells["MaHD"].Value != null)
            {
                string maHD = dgvHoadon.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();
                LoadChiTietHoaDon(maHD);
            }
        }
        private void splitContainer4_Panel1_Paint(object sender, PaintEventArgs e) { }
        private void splitContainer4_Panel2_Paint(object sender, PaintEventArgs e) { }
        private void lblTongTien_Click(object sender, EventArgs e) { }
    }
}