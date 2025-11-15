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
        private void LoadKhachHang()
        {
            var gidData = DataProvider.Instance.GetAllKhachHang()
                           .Select(kh => new
                           {
                               kh.MaKH,
                               kh.TenCty,
                               kh.DiaChi,
                               kh.DienThoai,
                               kh.MaThanhPho
                           })
                           .ToList();
            dgvKhachHang.DataSource = gidData;
        }

        private void LoadThanhPho()
        {
            var thanhphos = DataProvider.Instance.GetAllThanhPho()
                            .OrderBy(tp => tp.TenThanhPho)
                            .ToList();
            MaThanhPho.DataSource = thanhphos;
            MaThanhPho.DisplayMember = "TenThanhPho";
            MaThanhPho.ValueMember = "MaThanhPho";

            var dgvCboThanhPho = dgvKhachHang.Columns["MaThanhPho"] as DataGridViewComboBoxColumn;
            if (dgvCboThanhPho != null)
            {
                dgvCboThanhPho.DataSource = thanhphos;
                dgvCboThanhPho.DisplayMember = "TenThanhPho";
                dgvCboThanhPho.ValueMember = "MaThanhPho";
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
