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
        public frmLapHoaDon()
        {
            InitializeComponent();
            this.Load += frmLapHoaDon_Load;
        }
        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.AutoGenerateColumns = false;
            List<GioHang> danhSachGioHang;
            decimal tongTien = 0;

            using (var db = new QLBanHangContext())
            {
                danhSachGioHang = db.GioHangs.ToList();
            }
            dgvHoaDon.DataSource = danhSachGioHang;

            tongTien = danhSachGioHang.Sum(item => item.ThanhTien ?? 0);

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
            // Ensure recalculation after user finishes editing (redundant safe-guard)
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
            using (var db = new QLBanHangContext())
            {
                db.Database.ExecuteSqlRaw("TRUNCATE TABLE GioHang");
            }
            UserSession.Clear();
            MessageBox.Show("Bạn đã mua hàng thành công!!");
            txtKhachHang.Text = "";
            lblMaHD.Text = "";
            lblTongTien.Text = "0";
        }

        private void txtKhachHang_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}