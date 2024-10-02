using ApiQuanLyNhaThuoc.Models.Abstract;
using ApiQuanLyNhaThuoc.Models.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
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
    public class PhienBanSanPham : CommonAbtract
    {
        public PhienBanSanPham() 
        {
            this.LoHangs = new HashSet<LoHang>();
            this.ChiTietHoaDonDatHangs = new HashSet<ChiTietHoaDonDatHang>();
            this.ChiTietHoaDonNhapHangs = new HashSet<ChiTietHoaDonNhapHang>();
            this.KhoHangs = new HashSet<KhoHang>();
        }

        
        [Key]
        public string Id { get; set; }
        [Required]
        public string TenQuyDoi { get; set; }
        [Required]
        public string DonViQuyDoi { get; set; }
        [Required]
        public double SoLuong { get; set; }
        [Required]
        public string MaVach { get; set; }
        [Required]
        public string MaSanPham { get; set; }
        public string? KhoiLuong { get; set; }
        [Required]
        public decimal GiaNhapQuyDoi { get; set; }
        [Required]
        public decimal GiaBanQuyDoi { get; set; }
        [Required]
        public bool TrangThaiBan { get; set; }

        [Required]
        [ForeignKey("SanPham")]
        public string SanPhamId { get; set; }
        [JsonIgnore]
        public SanPham? SanPham { get; private set; }



        public ICollection<LoHang> LoHangs { get; set; }
 
        public ICollection<ChiTietHoaDonDatHang> ChiTietHoaDonDatHangs { get; set; }

        public ICollection<ChiTietHoaDonNhapHang> ChiTietHoaDonNhapHangs { get; set; }

        public ICollection<KhoHang> KhoHangs { get; set; }

       
    }   
}
