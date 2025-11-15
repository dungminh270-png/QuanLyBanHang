using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    public class CurrentUser
    {
        public static string MaKH { get; set; }
        public static string TenHienThi { get; set; }
        public static void Clear() { MaKH = null; TenHienThi = null; }
    }
}
