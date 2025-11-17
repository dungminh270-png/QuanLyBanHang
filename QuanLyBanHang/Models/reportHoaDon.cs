using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Models
{
    [Table("reportHoaDon")]
    public class reportHoaDon
    {
        public int MaHD { get; set; }
        public int MaSP { get; set; }
        public decimal? DonGia { get; set; }
        public int? SoLuong { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? ThanhTien { get; set; }
    }
}
