using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QuanLyBanHang.Models
{
    public class SanPham
    {
       [Key] public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int MaLoai { get; set; }
        public float? DonGiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string HinhAnh { get; set; }
    }
}
