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
    public partial class ForgotPass : Form
    {
        QLBanHangContext db = new QLBanHangContext();
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string tenDN = txttenDN.Text.Trim();
            string mkMoi = txtMKmoi.Text;
            string xacnhan = txtXacnhan.Text;
            
            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(mkMoi) || string.IsNullOrEmpty(xacnhan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (mkMoi != xacnhan)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!");
                return;
            }

            // Tim tai khoan theo tenDN

            var user = db.KhachHangs.FirstOrDefault( x => x.MaDN == tenDN);

            if (user != null)
            {
                MessageBox.Show("Tài khoản không tồn tại!");
                return;
            }
            // cap nhat mat khau
            user.MatKhau = mkMoi;
            db.SaveChanges();


            MessageBox.Show("Đổi mật khẩu thành công!");
            this.Close();
        }
    }
}
