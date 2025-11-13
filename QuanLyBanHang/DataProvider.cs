using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public class DataProvider
    {
        private static DataProvider _instance;
        public QLBanHangContext db;

        public static DataProvider Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataProvider();
                return _instance;
            }
        }

        private DataProvider()
        {
            db = new QLBanHangContext();
        }

        public List<KhachHang> GetAllKhachHang()
        {
            return db.KhachHangs.ToList();
        }

    }
}
