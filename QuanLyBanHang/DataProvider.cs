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
        public List<SanPham> GetAllSanPham()
        {
            return db.SanPhams.ToList();
        }
        public List<NhanVien> GetAllNhanVien()
        {
            return db.NhanViens.ToList();
        }
        public List<HoaDon> GetAllHoaDon()
        {
            return db.HoaDons.ToList();
        }
        public List<ThanhPho> GetAllThanhPho()
        {
            return db.ThanhPhos.ToList();
        }
        public List<ChiTietHoaDon> GetAllChiTietHoaDon()
        {
            return db.ChiTietHoaDons.ToList();
        }
        public bool UpdateKhachHang(KhachHang khachHang)
        {
            var existingKhachHang = db.KhachHangs.Find(khachHang.MaKH);
            if (existingKhachHang != null)
            {
                existingKhachHang.TenKH = khachHang.TenKH;
                existingKhachHang.DiaChi = khachHang.DiaChi;
                existingKhachHang.DienThoai = khachHang.DienThoai;
                existingKhachHang.MaThanhPho = khachHang.MaThanhPho;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool AddKhachHang(KhachHang khachHang)
        {
            var existingKhachHang = db.KhachHangs.Find(khachHang.MaKH);
            if (existingKhachHang == null)
            {
                db.KhachHangs.Add(khachHang);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool DeleteKhachHang(string maKH)
        {
            var kh = db.KhachHangs.Find(maKH) ?? db.KhachHangs.FirstOrDefault(k => k.MaKH == maKH);
            if (kh == null) return false;

            db.KhachHangs.Remove(kh);
            return db.SaveChanges() > 0;
        }

    }
}
