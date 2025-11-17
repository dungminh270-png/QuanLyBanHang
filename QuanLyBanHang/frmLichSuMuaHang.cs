using Microsoft.EntityFrameworkCore.Internal;
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
                cboKhachHang.DisplayMember = "TenKH";
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
                               .Where(hd => hd.MaKH != null && hd.MaKH == maKH)
                               .Select(hd => new
                               {
                                   hd.MaHD,
                                   NgayLapHD = hd.NgayLapHD.HasValue ? hd.NgayLapHD.Value.ToString("dd/MM/yyyy") : "",
                                   NgayNhanHang = hd.NgayNhanHang.HasValue ? hd.NgayNhanHang.Value.ToString("dd/MM/yyyy") : "Chưa nhận",


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

                var listChiTiet = db.ChiTietHoaDons
                                   .Where(ct => ct.MaHD == maHD)
                                   .Join(db.SanPhams,
                                       ct => ct.MaSP,
                                       sp => sp.MaSP,
                                       (ct, sp) => new
                                       {
                                           ct.MaSP,
                                           TenSP = sp.TenSP,
                                           DonGia = sp.DonGiaBan ?? 0,
                                           ct.SoLuong,
                                           ThanhTien = (sp.DonGiaBan ?? 0) * ct.SoLuong
                                       }).ToList();
                dgvChiTietHoaDon.DataSource = listChiTiet;





                decimal total = listChiTiet.Sum(x => x.ThanhTien);

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