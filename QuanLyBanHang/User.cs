using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QuanLyBanHang
{
    internal class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]

        public string UserName { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty ;

        [Required]
        public string Fullname { get;set; } = string.Empty ;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get ; set; }  =   string .Empty ; 
    }
}
