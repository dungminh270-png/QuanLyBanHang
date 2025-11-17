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
        private QLBanHangContext db = DataProvider.Instance.db;
        public FormTimKiemKhachHang()
        {
            InitializeComponent();
        }

        private void cboThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (cboThanhPho.SelectedValue != null)
            {
                string maThanhPho = cboThanhPho.SelectedValue.ToString();

                var thongtinKH = from kh in db.KhachHangs
                                 where kh.MaThanhPho.ToString() == maThanhPho
                                 select new
                                 {
                                     kh.MaKH,
                                     kh.TenKH,
                                     kh.DiaChi,
                                     kh.DienThoai
                                 };
                var soluong = thongtinKH.Count();
                txtSoLuongKhachHang.Text = soluong.ToString();
                dgvKhachHang.DataSource = thongtinKH.ToList();
            }

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            layKhachHangTheoThanhPho();
            var thongtinKH = from kh in db.KhachHangs
                             where kh.MaThanhPho.ToString() == cboThanhPho.SelectedValue.ToString()
                             select new
                             {
                                 kh.MaKH,
                                 kh.TenKH,
                                 kh.DiaChi,
                                 kh.DienThoai
                             };
            var soluong = thongtinKH.Count();
            txtSoLuongKhachHang.Text = soluong.ToString();
            dgvKhachHang.DataSource = thongtinKH.ToList();
        }

        private void layKhachHangTheoThanhPho()
        {
            var laytheoThanhPho = from tp in db.ThanhPhos
                                  select new
                                  {
                                      tp.MaThanhPho,
                                      tp.TenThanhPho
                                  };
            cboThanhPho.DataSource = laytheoThanhPho.ToList();
            cboThanhPho.DisplayMember = "TenThanhPho";
            cboThanhPho.ValueMember = "MaThanhPho";
        }
    }
}
