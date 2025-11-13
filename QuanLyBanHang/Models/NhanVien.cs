using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string Ho { get; set; }
        public string ten { get; set; }
        public bool Nu { get; set; }
        public DateTime NgayNV { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Hinh { get; set; }
        public string MaDN { get; set; }
        public string MatKhau { get; set; }
    }
}
