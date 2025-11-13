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
        public string DonViTinh { get; set; }
        public double? DonGia { get; set; }
        public string Hinh { get; set; }
    }
}
