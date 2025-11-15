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
        QLBanHangDataContext db = new QLBanHangDataContext();
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
            var KhachHang = db.KhachHangs
                .OrderBy(kh => kh.TenCty)
                .Select(kh => new
                {
                    kh.MaKH,
                    kh.TenCty,
                    kh.DiaChi,
                    kh.DienThoai,
                    MaThanhPho = kh.MaThanhPho,
                }).ToList();
            dgvKhachHang.DataSource = KhachHang;
        }

        private void LoadThanhPho()
        {
            var ThanhPho = db.ThanhPhos
                .OrderBy(tp => tp.TenThanhPho)
                .Select(tp => new
                {
                    tp.MaThanhPho,
                    tp.TenThanhPho,
                }).ToList();

            //đổ dữ liệu vào combo box thành phố (cboThanhPho)
            cboThanhPho.DataSource = ThanhPho;
            cboThanhPho.DisplayMember = "TenThanhPho";
            cboThanhPho.ValueMember = "MaThanhPho";

            //đổ dữ liệu vào combo box thành phố trong DataGridView
            var dgvCboThanhPho= dgvKhachHang.Columns["MaThanhPho"] as DataGridViewComboBoxColumn;
            if (dgvCboThanhPho != null)
            {
                dgvCboThanhPho.DataSource = ThanhPho;
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
            if (e.RowIndex == 0) { return; }
            var row = dgvKhachHang.Rows[e.RowIndex];
            txtMaKH.Text = row.Cells["MaKH"].Value?.ToString(); ;
            txtCongTy.Text = row.Cells["TenCty"].Value?.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();
            var maThanhPho = row.Cells["MaThanhPho"].Value;
            if (maThanhPho != null)
            {
                cboThanhPho.SelectedValue = maThanhPho;
            }

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
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) ||
                string.IsNullOrWhiteSpace(txtCongTy.Text) ||
                cboThanhPho.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (isEdit)
                {
                    // SỬA
                    var kh = db.KhachHangs.FirstOrDefault(k => k.MaKH == txtMaKH.Text);
                    if (kh != null)
                    {
                        kh.TenCty = txtCongTy.Text.Trim();
                        kh.DiaChi = txtDiaChi.Text.Trim();
                        kh.DienThoai = txtDienThoai.Text.Trim();
                        kh.MaThanhPho = (int)cboThanhPho.SelectedValue;
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // THÊM MỚI
                    var khMoi = new KhachHang
                    {
                        MaKH = txtMaKH.Text.Trim(),
                        TenCty = txtCongTy.Text.Trim(),
                        DiaChi = txtDiaChi.Text.Trim(),
                        DienThoai = txtDienThoai.Text.Trim(),
                        MaThanhPho = (int)cboThanhPho.SelectedValue
                    };

                    db.KhachHangs.InsertOnSubmit(khMoi);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadKhachHang();
                SetEnable(false);
                isEdit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var kh = db.KhachHangs.FirstOrDefault(k => k.MaKH == txtMaKH.Text);
                    if (kh != null)
                    {
                        db.KhachHangs.DeleteOnSubmit(kh);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKhachHang();
                        txtMaKH.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
    }
}
