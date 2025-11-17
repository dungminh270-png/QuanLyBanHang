using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    public static class UserSession
    {
        public static string MaKH { get; set; }
        public static string HoTenKH { get; set; }
        public static bool DaDangNhap { get; set; }
        public static void Clear()
        {
            MaKH = "0";
            HoTenKH = "";
            DaDangNhap = false;
        }
    }
}
