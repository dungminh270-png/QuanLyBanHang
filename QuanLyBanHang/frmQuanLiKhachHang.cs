using Microsoft.SqlServer.Management.Sdk.Sfc;
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
    public partial class frmQuanLiKhachHang : Form
    {
        QLBanHangContext db = new QLBanHangContext();
        bool isEdit = false; //biến cờ để phân biệt thêm hay sửa
        public frmQuanLiKhachHang()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLiKhachHang_Load(object sender, EventArgs e)
        {
            LoadThanhPho();
            LoadKhachHang();
            SetEnable(false);
        }

        private void LoadKhachHang()
        {
            var gidData = DataProvider.Instance.GetAllKhachHang()
                           .Select(kh => new
                           {
                               kh.MaKH,
                               kh.TenKH,
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
            cboThanhPho.DataSource = thanhphos;
            cboThanhPho.DisplayMember = "TenThanhPho";
            cboThanhPho.ValueMember = "MaThanhPho";

            var dgvCboThanhPho = dgvKhachHang.Columns["MaThanhPho"] as DataGridViewComboBoxColumn;
            if(dgvCboThanhPho!=null)
            {
                dgvCboThanhPho.DataSource = thanhphos;
                dgvCboThanhPho.DisplayMember = "TenThanhPho";
                dgvCboThanhPho.ValueMember = "MaThanhPho";
            }
        }
        //Thay đổi trạng thái các nút nhấn
        void SetEnable(bool enable)
        {
            txtMaKH.Enabled = enable;
            txtCongTy.Enabled = enable;
            txtDiaChi.Enabled = enable;
            txtDienThoai.Enabled = enable;
            cboThanhPho.Enabled = enable;

            //set bộ nút ( thêm, sửa trái ngược với textbox ở trên)
            btnThem.Enabled = !enable;
            btnSua.Enabled = !enable;

            //không cho xóa khi đang edit 
            btnXoa.Enabled = !isEdit && !enable;
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            //dgvKhachHang.Enabled = enable;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.RowIndex >= dgvKhachHang.Rows.Count) return;

            var row = dgvKhachHang.Rows[e.RowIndex];
            txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
            txtCongTy.Text = row.Cells["TenCty"].Value.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            txtDienThoai.Text = row.Cells["DienThoai"].Value.ToString();

            var maTP = row.Cells["MaThanhPho"].Value;
            if(maTP != null) cboThanhPho.SelectedValue = maTP;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SetEnable(true);
            isEdit = false; // reset cờ để thêm mới

            //xóa giá trị đang nhập ở trên
            txtMaKH.Clear();
            txtCongTy.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            //cboThanhPho.SelectedIndex = -1;
            txtMaKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SetEnable(true);
            isEdit = true;
            txtMaKH.Enabled = false; //không cho sửa mã khách hàng

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var kh = new Models.KhachHang
            {
                MaKH = txtMaKH.Text,
                TenKH = txtCongTy.Text,
                DiaChi = txtDiaChi.Text,
                DienThoai = txtDienThoai.Text,
                MaThanhPho = Convert.ToInt32(cboThanhPho.SelectedValue)
            };
            bool ok;
            if (isEdit)
            {
                ok = DataProvider.Instance.UpdateKhachHang(kh);
                isEdit = false;
            }
            else
            {
                ok = DataProvider.Instance.AddKhachHang(kh);
            }

            if (ok)
            {
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHang();
                SetEnable(false);
            }
            else
            {
                MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isEdit = false;
            SetEnable(false);
            LoadKhachHang();
        }

        private void TaiLai_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var TraLoi = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (TraLoi != DialogResult.Yes) return;

            if (DataProvider.Instance.DeleteKhachHang(txtMaKH.Text.Trim()))
            {
                MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHang();
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
