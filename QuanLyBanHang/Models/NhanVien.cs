using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QuanLyBanHang.Models
{
    public class NhanVien
    {
        [Key] public int? MaNV { get; set; }
        public string HoTen { get; set; }
        public bool? GTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string HinhAnh { get; set; }
        public string MaDN { get; set; }
        public string MatKhau { get; set; }
    }
}
