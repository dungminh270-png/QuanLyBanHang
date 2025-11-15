using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QuanLyBanHang.Models
{
    public class KhachHang
    {
        [Key] public string MaKH { get; set; }
        public string TenCty { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public int MaThanhPho { get; set; }
    }
}
