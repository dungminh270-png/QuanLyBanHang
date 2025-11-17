using Microsoft.Reporting.WinForms;
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
    public partial class reportForm : Form
    {
        private List<GioHang> _dataSource;
        private string _tenKhachHang;
        private int _maHD;
        public reportForm(List<GioHang> dataSource, string tenKhachHang, int maHD)
        {
            InitializeComponent();
            _dataSource = dataSource;
            _tenKhachHang = tenKhachHang;
            _maHD = maHD;
        }

        private void reportForm_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.report.rdlc";

            //Gán DataSource
            ReportDataSource rds = new ReportDataSource("CTHoaDon", _dataSource);
            reportViewer1.LocalReport.DataSources.Add(rds);


            ReportParameter rptTenKH = new ReportParameter("HoTenKhachHang", _tenKhachHang);
            ReportParameter rptMaHD = new ReportParameter("MaHD", _maHD.ToString()); 

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rptTenKH, rptMaHD }); 


            reportViewer1.RefreshReport();
        }
    }
}
