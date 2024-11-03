using ApiQuanLyNhaThuoc.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.DTOs
{
    public class PhienBanSanPhamDTO
    {
        public string Id { get; set; }
        public string TenQuyDoi { get; set; }
        public string DonViQuyDoi { get; set; }
        public double SoLuong { get; set; }
        public string? MaVach { get; set; }
        public double? KhoiLuong { get; set; }
        public decimal GiaNhapQuyDoi { get; set; }
        public decimal GiaBanQuyDoi { get; set; }
        public bool TrangThaiBan { get; set; }
        public string? SanPhamId { get; set; }
        public SanPham? SanPham { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
