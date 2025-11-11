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
            //hiển thị hết khách hàng
            var sql= "SELECT * FROM KhachHang ORDER BY TenCty";
            dgvKhachHang.DataSource= DataProvider.TruyVanLayDuLieu(sql);

        }

        private void LoadThanhPho()
        {
            var sql = "SELECT * FROM ThanhPho ORDER BY TenThanhPho";
            var dtThanhPho = DataProvider.TruyVanLayDuLieu(sql);

            //đổ dữ liệu vào combo box thành phố (cboThanhPho)
            cboThanhPho.DataSource = dtThanhPho;
            cboThanhPho.DisplayMember = "TenThanhPho";
            cboThanhPho.ValueMember = "MaThanhPho";

            //đổ dữ liệu vào combo box thành phố trong DataGridView
            var dgvCboThanhPho= dgvKhachHang.Columns["MaThanhPho"] as DataGridViewComboBoxColumn;
            dgvCboThanhPho.DataSource = dtThanhPho;
            dgvCboThanhPho.DisplayMember = "TenThanhPho";
            dgvCboThanhPho.ValueMember = "MaThanhPho";

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
            btnXoa.Enabled = !isEdit;
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            //dgvKhachHang.Enabled = enable;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
            txtCongTy.Text = dgvKhachHang.Rows[e.RowIndex].Cells["TenCty"].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            txtDienThoai.Text = dgvKhachHang.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
            cboThanhPho.SelectedValue = dgvKhachHang.Rows[e.RowIndex].Cells["MaThanhPho"].Value;

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
            //cboThanhPho.SelectedIndex = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetEnable(true);
            isEdit = true;
            txtMaKH.Enabled = false; //không cho sửa mã khách hàng

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isEdit == true) //đang sửa
            {
                var sqlEdit = $"UPDATE KhachHang SET TenCty=N'{txtCongTy.Text}',DiaChi=N'{txtDiaChi.Text}',DienThoai='{txtDienThoai.Text}',MaThanhPho='{cboThanhPho.SelectedValue}' WHERE MaKH='{txtMaKH.Text}'";
                
                DataProvider.TruyVanXuLiDuLieu(sqlEdit);
                isEdit = false;
            }
            else
            {
                var sqlInsert = $"INSERT INTO KhachHang (MaKH, TenCty, DiaChi, DienThoai, MaThanhPho) VALUES ('{txtMaKH.Text}',N'{txtCongTy.Text}',N'{txtDiaChi.Text}','{txtDienThoai.Text}','{cboThanhPho.SelectedValue}')";
                DataProvider.TruyVanXuLiDuLieu(sqlInsert);
            }

            LoadKhachHang();
            SetEnable(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isEdit = false;
            SetEnable(false);
        }

        private void TaiLai_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text==string.Empty){
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var TraLoi = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TraLoi == DialogResult.Yes)
                {
                    var sqlDelete = $"DELETE FROM KhachHang WHERE MaKH='{txtMaKH.Text}'";
                    if (DataProvider.TruyVanXuLiDuLieu(sqlDelete))
                    {
                        MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKhachHang();

                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            


        }
    }
}
