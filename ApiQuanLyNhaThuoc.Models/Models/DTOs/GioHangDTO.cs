using ApiQuanLyNhaThuoc.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.DTOs
{
    public class GioHangDTO
    {
        public string PhienBanSanPhamId { get; set; }
        public string KhachHangId { get; set; }
        public string TenSanPham { get; set; }
        public string? HinhAnh { get; set; }
        public decimal Gia { get; set; }
        public double SoLuong { get; set; }
        
    }
}
