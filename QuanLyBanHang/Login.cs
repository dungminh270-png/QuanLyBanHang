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
        private FormMaiN_KH_ _frmMainKH;
        public Login(frmMain fmain)
        {
            InitializeComponent();
            _frmMain = fmain;

        }
        public Login(FormMaiN_KH_ fmainKH)
        {
            InitializeComponent();
            _frmMainKH = fmainKH;
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
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new QLBanHangContext())
            {
                if (radNhanvien.Checked)
                {
                    var nv = db.NhanViens.FirstOrDefault(x => x.MaDN == user && x.MatKhau == pass);
                    if (nv != null)
                    {
                        string hoten = nv.HoTen;
                        MessageBox.Show("Đăng nhập thành công (Nhân Viên)!");

                        //Đang ở frmMain, đăng nhập (lại)
                        if (_frmMain != null)
                        {
                            _frmMain.HoTenNhanVien = hoten;
                            _frmMain.DaDangNhap = true;
                            _frmMain.PhanQuyen();
                            this.Close();
                        }
                        //Đang ở frmMainKH, chuyển sang frmMain
                        else if (_frmMainKH != null)
                        {
                            _frmMainKH.Hide();

                            frmMain mainNV = new frmMain();
                            mainNV.HoTenNhanVien = hoten;
                            mainNV.DaDangNhap = true;

                            mainNV.FormClosed += (s, args) => Application.Exit();
                            mainNV.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radKhachHang.Checked)
                {
                    var kh = db.KhachHangs.FirstOrDefault(x => x.MaDN == user && x.MatKhau == pass);
                    if (kh != null)
                    {
                        string hotenKH = kh.TenKH;
                        MessageBox.Show("Đăng nhập thành công (Khách Hàng)!");

                        if (_frmMain != null)
                        {
                            _frmMain.Hide();
                            FormMaiN_KH_ mainKH = new FormMaiN_KH_();
                            mainKH.DaDangNhapKH = true;
                            mainKH.HoTenKH = hotenKH;
                            mainKH.FormClosed += (s, args) => Application.Exit();

                            UserSession.MaKH = kh.MaKH;
                            UserSession.HoTenKH = hotenKH;
                            UserSession.DaDangNhap = true;
                            mainKH.Show();

                            this.Close();
                        }
                        //Đang ở frmMainKH, đăng nhập (lại)
                        else if (_frmMainKH != null)
                        {
                            _frmMainKH.HoTenKH = hotenKH;
                            _frmMainKH.DaDangNhapKH = true;
                            _frmMainKH.PhanQuyen();

                            UserSession.MaKH = kh.MaKH;
                            UserSession.HoTenKH = hotenKH;
                            UserSession.DaDangNhap = true;

                            CurrentUser.MaKH = kh.MaKH;
                            CurrentUser.TenHienThi = kh.TenKH;

                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            frm.Show();
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