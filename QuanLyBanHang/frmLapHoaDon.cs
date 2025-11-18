using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmLapHoaDon : Form
    {
        private List<GioHang> _danhSachGioHang;
        public frmLapHoaDon()
        {
            InitializeComponent();
            this.Load += frmLapHoaDon_Load;
        }
        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.AutoGenerateColumns = false;
            // List<GioHang> danhSachGioHang;
            decimal tongTien = 0;

            using (var db = new QLBanHangContext())
            {
                _danhSachGioHang = db.GioHangs.ToList(); 
            }
            dgvHoaDon.DataSource = _danhSachGioHang; 

            tongTien = _danhSachGioHang.Sum(item => item.ThanhTien ?? 0); 

            lblTongTien.Text = tongTien.ToString("N0");

            txtKhachHang.Text = UserSession.HoTenKH;
            lblMaHD.Text = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
        private void AutoFillOrderItem(int rowIndex)
        {
            
        }

        private void TinhTongTienHoaDon()
        {
            
        }

        private void dgvHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dgvHoaDon_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
        }

        private void dgvHoaDon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            AutoFillOrderItem(e.RowIndex);
            TinhTongTienHoaDon();
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang phát triển");
        }

        private void lblMaHD_Click(object sender, EventArgs e)
        {

        }

        private void btnInHoaDon_Click_1(object sender, EventArgs e)
        {
            if (_danhSachGioHang == null || !_danhSachGioHang.Any())
            {
                MessageBox.Show("Không có sản phẩm nào để lập hóa đơn!");
                return;
            }

            string maKhach = UserSession.MaKH;
            string tenKhach = UserSession.HoTenKH;

            try
            {
                using (var db = new QLBanHangContext())
                {
                    var hoaDonMoi = new HoaDon
                    {
                        MaKH = maKhach,
                        NgayLapHD = DateTime.Now,
                        NgayNhanHang = DateTime.Now.AddDays(3), 
                        MaNV = null
                    };

                    db.HoaDons.Add(hoaDonMoi);
                    db.SaveChanges(); 

                    int maHoaDonMoi = hoaDonMoi.MaHD; 

                    var danhSachReport = new List<reportHoaDon>();
                    foreach (var item in _danhSachGioHang)
                    {
                        danhSachReport.Add(new reportHoaDon
                        {
                            MaHD = maHoaDonMoi, 
                            MaSP = item.MaSP,
                            SoLuong = item.SoLuong,
                            DonGia = item.DonGia

                        });
                    }

                    db.reportHoaDons.AddRange(danhSachReport); 
                    db.SaveChanges();

                    reportForm frmBaoCao = new reportForm(_danhSachGioHang, tenKhach, maHoaDonMoi);
                    frmBaoCao.Show();

                    // --- 4. XÓA GIỎ HÀNG TẠM ---
                    db.Database.ExecuteSqlRawAsync("TRUNCATE TABLE GioHang");

                    // --- 5. LÀM SẠCH FORM ---
                    UserSession.Clear();
                    MessageBox.Show($"Bạn đã mua hàng thành công! (HĐ số: {maHoaDonMoi})");
                    txtKhachHang.Text = "";
                    lblMaHD.Text = "";
                    lblTongTien.Text = "0";
                    _danhSachGioHang.Clear();
                    dgvHoaDon.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                if (ex.InnerException != null) errorMessage = ex.InnerException.Message;
                MessageBox.Show("Lỗi khi lưu hóa đơn: \n" + errorMessage, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKhachHang_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}