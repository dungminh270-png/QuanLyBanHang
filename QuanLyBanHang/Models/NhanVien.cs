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
        public string Ho { get; set; }
        public string Ten { get; set; }
        public bool? Nu { get; set; }
        public DateTime? NgayNV { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Hinh { get; set; }
        public string MaDN { get; set; }
        public string MatKhau { get; set; }
    }
}
