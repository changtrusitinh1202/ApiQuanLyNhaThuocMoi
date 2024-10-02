using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.Entities
{
    public class ChiTietHoaDonBanHang
    {
        [Key]
        public string? Id { get; set; }
        [ForeignKey("HoaDonBanHang")]
        public string HoaDonId { get; set; }
        [JsonIgnore]
        public HoaDonBanHang? HoaDon { get; private set; }
        [ForeignKey("PhienBanSanPham")]
        public string PhienBanSanPhamId { get; set; }
        [JsonIgnore]
        public PhienBanSanPham? PhienBanSanPham { get; private set; }
        public double SoLuong { get; set; }
        public double Gia { get; set; }
    

      
    }
}
