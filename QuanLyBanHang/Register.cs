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

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtconfirm.UseSystemPasswordChar = true;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text.Trim();
            string email = txtEmail.Text.Trim();
            string username = txtUser.Text.Trim();
            string password = txtPass.Text;
            string confirm = txtconfirm.Text;

            if (string.IsNullOrWhiteSpace(fullname))
            {
                MessageBox.Show("Vui lòng nhập Họ và tên!", "Thiếu thông tin",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtFullname.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập Email!", "Thiếu thông tin!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtconfirm.Focus();
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtconfirm.Focus();
                txtconfirm.SelectAll();
                return;
            }
            if (password.Length < 7)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 7 ký tự!", "Yếu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }

        }
    }
}
