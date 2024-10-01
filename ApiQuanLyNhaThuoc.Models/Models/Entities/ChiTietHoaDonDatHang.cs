using ApiQuanLyNhaThuoc.Models.Entities;
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
    public class ChiTietHoaDonDatHang
    {
        [Key]
        public string? Id { get; set; }

        [Required]
        [ForeignKey("HoaDonDatHang")]
        public string HoaDonDatHangId { get; set; }
        [JsonIgnore]
        public HoaDonDatHang? HoaDonDatHang { get; private set; }

        [Required]
        [ForeignKey("PhienBanSanPham")]
        public string PhienBanSanPhamId { get; set; }
        public PhienBanSanPham? PhienBanSanPham { get; private set; }

        [Required]
        public double SoLuongDat {  get; set; }
        [Required]
        public double SoLuongDaNhap { get; set; }
        [Required]
        public decimal Gia { get; set; }

     
    }
}
