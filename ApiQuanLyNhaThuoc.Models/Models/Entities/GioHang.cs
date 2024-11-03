using ApiQuanLyNhaThuoc.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.Entities
{
    public class GioHang
    {
        public int Id { get; set; }
        [ForeignKey("KhachHang")]
        public string? KhachHangId { get; set; }
        [JsonIgnore]
        public KhachHang? KhachHang { get; private set; }
        [ForeignKey("PhienBanSanPham")]
        public string PhienBanSanPhamId { get; set; }
        [JsonIgnore]
        public PhienBanSanPham? PhienBanSanPham { get; private set; }
        public double SoLuong { get; set; }
        public decimal Gia { get; set; }

    }
}
