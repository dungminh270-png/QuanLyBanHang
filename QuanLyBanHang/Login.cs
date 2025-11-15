using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !checkPass.Checked;
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

            using (var db = new QLBanHangContext())
            {
                // 1. Tìm nhân viên có MaDN trùng với user nhập vào
                var taiKhoan = db.NhanViens.FirstOrDefault(nv => nv.MaDN == user);

                if (taiKhoan != null)
                {
                    // User có tồn tại -> Kiểm tra mật khẩu
                    string dbPass = taiKhoan.MatKhau ?? "";

                    if (dbPass == pass)
                    {
                        // Đăng nhập thành công
                        MessageBox.Show("Đăng nhập thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FormMain f = new FormMain();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        // Sai mật khẩu
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }

        private void Userlb_Click(object sender, EventArgs e) {
        }
        private void Passlb_Click(object sender, EventArgs e) { 
        }
        private void Login_Load(object sender, EventArgs e) { 
        }
        private void pictureBox1_Click(object sender, EventArgs e) {
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
        }
    }
}