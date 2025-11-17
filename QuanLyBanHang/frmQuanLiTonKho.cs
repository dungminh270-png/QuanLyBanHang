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

namespace QuanLyBanHang
{
    public partial class frmQuanLiTonKho : Form
    {
        QLBanHangContext db = new QLBanHangContext();
        SanPham spDangchon = null;
        public frmQuanLiTonKho()
        {
            InitializeComponent();
        }
        public void LoadSanPham()
        {
            var list = from sp in db.SanPhams
                       select new
                       {
                           sp.MaSP,
                           sp.TenSP,
                           sp.SoLuongTon,
                           sp.DonGiaBan,
                           sp.HinhAnh
                       };
            dgvSanPham.DataSource = list.ToList();

        }
        private void frmQuanLiTonKho_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }
        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if ( dgvSanPham.CurrentRow  == null ) { return; }

            int maSP = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["MaSP"].Value);
            spDangchon = db.SanPhams.FirstOrDefault(s => s.MaSP == maSP);
            if (spDangchon != null)
            {
                txtTenSP.Text = spDangchon.TenSP;
                txtSLT.Text = spDangchon.SoLuongTon.ToString();
                txtGia.Text = spDangchon.DonGiaBan.ToString();
                if (!string.IsNullOrEmpty(spDangchon.HinhAnh))
                {
                    try
                    {
                        pctAnh.ImageLocation = spDangchon.HinhAnh;
                    }
                    catch
                    {
                        pctAnh.Image = null;
                    }
                }
                else
                {
                    pctAnh.Image = null;
                }
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham sp = new SanPham()
                {
                    TenSP = txtTenSP.Text,
                    SoLuongTon = int.Parse(txtSLT.Text),
                    DonGiaBan = decimal.Parse(txtGia.Text),
                    HinhAnh = ""
                };
                db.SanPhams.Add(sp);
                db.SaveChanges();
                LoadSanPham();
                MessageBox.Show("Thêm sản phẩm thành công!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi thêm sản phẩm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (spDangchon == null) { return}
            ;
            try
            {
                spDangchon.TenSP = txtTenSP.Text,
                spDangchon.SoLuongTon = int.Parse(txtSLT.Text),
                spDangchon.DonGiaBan = decimal.Parse (txtGia.Text),


                db.SaveChanges();
                LoadSanPham();
                MessageBox.Show("Cập nhật sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật sản phẩm: " + ex.Message);
            }

        }

        private void pctAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pctAnh.ImageLocation = ofd.FileName; 
                if (spDangchon != null)
                {
                    spDangchon.HinhAnh = ofd.FileName; 
                }
            }
        }
    }
}
