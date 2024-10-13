using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.DTOs
{
    public class KhachHangDTO
    {
        public string Id { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? EmailAddress { get; set; }
        [Required]
        public string HoTen { get; set; }
        public string? DiaChi { get; set; }
        public string? ThanhPho { get; set; }
        public bool? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        [Required]
        public string SoDienThoai { get; set; }
        [Required]
        public string Quyen { get; set; }
        public decimal TichDiem { get; set; }
        public string? RankKhachHang { get; set; }

    }
}
