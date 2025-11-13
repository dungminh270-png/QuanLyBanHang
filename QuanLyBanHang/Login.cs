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
    public partial class Login : Form
    {

        private FormMain forMain;
        public Login( FormMain fmain)
        {
            forMain = fmain;
            InitializeComponent();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;

            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem MaDN có tồn tại không
            string sqlCheckUser = "SELECT MatKhau FROM NhanVien WHERE MaDN = @user";
            SqlParameter[] p1 = { new SqlParameter("@user", user) };
            var dtUser = DataProvider.TruyVanLayDuLieu(sqlCheckUser, p1);

            if (dtUser == null || dtUser.Rows.Count == 0)
            {
                // Không tìm thấy user => sai tài khoản
                MessageBox.Show("Sai tài khoản. Vui lòng nhập lại !!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy mật khẩu từ CSDL (ở đây giả sử lưu plain text)
            var dbPassObj = dtUser.Rows[0]["MatKhau"];
            string dbPass = dbPassObj == DBNull.Value ? "" : dbPassObj.ToString();

            // So sánh mật khẩu
            if (dbPass != pass)
            {
                MessageBox.Show("Sai mật khẩu. Vui lòng nhập lại !!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu tới đây => đúng tài khoản và mật khẩu
            MessageBox.Show("Đăng nhập thành công", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void Userlb_Click(object sender, EventArgs e)
        {

        }

        private void Passlb_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
