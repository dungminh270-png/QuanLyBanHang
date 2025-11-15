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
    public partial class frmHuongDanSuDung : Form
    {
        public frmHuongDanSuDung()
        {
            InitializeComponent();
        }

        

        private void SetActiveButton(Button activeBtn)
        {
            foreach (Control ctrl in sideBarPanel.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = SystemColors.Control; // màu mặc định
                }
            }
            activeBtn.BackColor = Color.LightBlue; // nút đang chọn
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            tctlMain.SelectedTab = tpDonHang;
            SetActiveButton(btnDonHang);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            tctlMain.SelectedTab = tpSanPham;
            SetActiveButton(btnSanPham);

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            tctlMain.SelectedTab = tpKhachHang;
            SetActiveButton(btnKhachHang);

        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            tctlMain.SelectedTab = tpBanHang;
            SetActiveButton(btnBanHang);

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            tctlMain.SelectedTab = tpBaoCao;
            SetActiveButton(btnBaoCao);

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            tctlMain.SelectedTab = tpHoaDon;
            SetActiveButton(btnHoaDon);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //import ProductionQuantityLimitsIcon from '@mui/icons-material/ProductionQuantityLimits';
        }
    }
}
