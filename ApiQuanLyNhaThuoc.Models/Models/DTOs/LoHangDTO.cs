using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.DTOs
{
    public class LoHangDTO
    {
        public string Id { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public DateTime NgayHetHan { get; set; }
        public double SoLuongQuyDoi { get; set; }
        public string TenPhienBanSanPham { get; set; } 
        public string TenNhaCungCap { get; set; } 
        public string TenKhoHang { get; set; } 
    }
}
