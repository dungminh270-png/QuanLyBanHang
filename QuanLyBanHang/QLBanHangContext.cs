using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    public class QLBanHangContext : DbContext
    {
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }    
        public DbSet<ThanhPho> ThanhPhos { get; set; }

        // Connection to database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ROSANNRYY;Database=QLBanHang;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cấu hình khóa gộp cho ChiTietHoaDon
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasKey(ct => new { ct.MaHD, ct.MaSP });

            // ánh xạ các thực thể với bảng tương ứng
            modelBuilder.Entity<KhachHang>().ToTable("KhachHang");
            modelBuilder.Entity<HoaDon>().ToTable("HoaDon");
            modelBuilder.Entity<NhanVien>().ToTable("NhanVien");
            modelBuilder.Entity<SanPham>().ToTable("SanPham");
            modelBuilder.Entity<ThanhPho>().ToTable("ThanhPho");
        }
    }
}