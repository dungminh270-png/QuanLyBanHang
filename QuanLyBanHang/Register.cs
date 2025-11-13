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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string tenKH = txtHoten.Text.Trim();
            string tenDN = txtTenDN.Text.Trim();
            string matkhau = txtMatkhau.Text;
            string xacnhan = txtXacnhanMK.Text;
            int maTP = (int)cbbCity.SelectedValue;

            if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(matkhau) || string.IsNullOrEmpty(xacnhan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            if (matkhau != xacnhan)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu phải trùng khớp!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            using (var db = new QLBanHangDataContext())
            {
                // Kiểm tra tài khoản đã tồn tại
                var CheckDN = db.KhachHangs.FirstOrDefault(x => x.MaDN == tenDN);
                if (CheckDN != null)
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error );   
                    return;
                }
                // Tạo tài khoản mới
                KhachHang kh = new KhachHang()
                {
                    MaKH = "KH" + DateTime.Now.Ticks.ToString().Substring(15),
                    TenCty = tenKH,
                    MaDN = tenDN,
                    MatKhau = matkhau,
                    MaThanhPho = maTP
                    
                };
                db.KhachHangs.InsertOnSubmit(kh);
                db.SubmitChanges();

                MessageBox.Show("Đăng ký thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information );
                this.Close();
            }
        }

        private void cbbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            using (var db = new QLBanHangDataContext())
            {
                cbbCity.DisplayMember = "TenThanhPho";
                cbbCity.ValueMember = "MaThanhPho";
                cbbCity.DataSource = db.ThanhPhos.ToList();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
