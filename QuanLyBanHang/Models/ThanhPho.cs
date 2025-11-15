using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QuanLyBanHang.Models
{
    public class ThanhPho
    {
        [Key] public int MaThanhPho { get; set; }
        public string TenThanhPho { get; set; }
    }
}
