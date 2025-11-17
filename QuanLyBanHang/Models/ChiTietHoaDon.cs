using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QuanLyBanHang.Models
{
    public class ChiTietHoaDon
    {
        public int MaHD { get; set; }

        public int MaSP { get; set; }

        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int? ThanhTien { get; set; }
    }
}
