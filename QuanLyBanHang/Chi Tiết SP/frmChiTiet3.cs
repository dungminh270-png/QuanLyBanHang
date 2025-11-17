using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Chi_Tiết_SP
{
    public partial class frmChiTiet3 : Form
    {
        public frmChiTiet3()
        {
            InitializeComponent();
        }

        private void btnXacNhanMua3_Click(object sender, EventArgs e)
        {
            int maSanPham = 3;
            string tenSanPham = "But viết xanh bầu trời";
            decimal donGia = 20000;
            var soLuong = (int)SoLuong.Value;

            string maKhachHang = UserSession.MaKH;
            string tenKhachHang = UserSession.HoTenKH;

            MessageBox.Show("Đã thêm vào giỏ hàng. Hãy vào giỏ hàng và xác nhận nhé !!!");

            using (var db = new QLBanHangContext())
            {
                //Kiểm tra xem sản phẩm này đã có trong giỏ hàng của khách chưa
                var itemDaCo = db.GioHangs.FirstOrDefault(
                    g => g.MaSP == maSanPham && g.MaSP == maSanPham
                );

                if (itemDaCo != null)
                {
                    itemDaCo.SoLuong += soLuong;
                }
                else
                {
                    var itemMoi = new GioHang
                    {
                        MaSP = maSanPham,
                        TenSP = tenSanPham,
                        DonGia = donGia,
                        SoLuong = soLuong
                    };
                    db.GioHangs.Add(itemMoi);
                }

                db.SaveChanges();
                this.Close();
            }
        }
    }
}
