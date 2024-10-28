
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Entities
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string Ten { get; set; }
        public string? DiaChi { get; set; }
        public string? ThanhPho { get; set; }
        public bool? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }

        [Required]
        public string Quyen { get; set; }
    }
}
