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
        public Login()
        {
            InitializeComponent();
        }
        private frmMain _frmMain;
        public Login(frmMain fmain)
        {

            _frmMain = fmain;

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

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

            using (var db = new QLBanHangContext())
            {
                if (radNhanvien.Checked)
                {
                    var nv = db.NhanViens.FirstOrDefault(x => x.MaDN == user && x.MatKhau == pass);
                    if (nv != null)
                    {
                        string hoten = nv.Ho + " " + nv.Ten;
                        MessageBox.Show("Đăng nhập thành công (Nhân Viên)!");
                        _frmMain.HoTenNhanVien = hoten;
                        _frmMain.DaDangNhap = true;
                        _frmMain.PhanQuyen();
                        frmMain mainNV = new frmMain();
                        mainNV.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radKhachHang.Checked)
                {
                    var kh = db.KhachHangs.FirstOrDefault(x => x.MaDN == user && x.MatKhau == pass);
                    if (kh != null)
                    {
                        //string hotenKH = kh.Ho
                        MessageBox.Show("Đăng nhập thành công (Khách Hàng)!");
                        // chưa tạo FormMain cho Khach Hang
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void Userlb_Click(object sender, EventArgs e)
        {

        }

        private void Passlb_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            radNhanvien.Text = "Nhân viên";
            radKhachHang.Text = "Khách hàng";
            radNhanvien.Checked = true;
            txtPass.UseSystemPasswordChar = true;


        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (!radKhachHang.Checked)
            {
                MessageBox.Show("Chỉ khách hàng mới được đăng ký!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Register frm = new Register();
            frm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass fgp = new ForgotPass();
            fgp.ShowDialog();
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sign Up button clicked!");
        }
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
        }
    }
}