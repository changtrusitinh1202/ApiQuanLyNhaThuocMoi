using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.Entities
{
    public class ChiTietHoaDonBanHangOnline
    {
        [Key]
        public string? Id { get; set; }
        [ForeignKey("HoaDonBanHangOnline")]
        public string HoaDonId { get; set; }
        [JsonIgnore]
        public HoaDonBanHangOnline? HoaDon { get; private set; }
        [ForeignKey("PhienBanSanPham")]
        public string PhienBanSanPhamId { get; set; }
        [JsonIgnore]
        public PhienBanSanPham? PhienBanSanPham { get; private set; }
        public double SoLuong { get; set; }
        public double Gia { get; set; }
    }
}
