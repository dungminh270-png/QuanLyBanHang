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
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public DateTime? NgaySinh { get; set; }
        public bool? GTinh { get; set; }
        public int MaThanhPho { get; set; }
        public string MaDN { get; set; }
        public string MatKhau { get; set; }
        public string HinhAnh { get; set; }
    }
}
