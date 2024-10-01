using ApiQuanLyNhaThuoc.Models.Abstract;
using ApiQuanLyNhaThuoc.Models.Entities;
using Microsoft.AspNetCore.Mvc;
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
    public class HoaDonDatHang : CommonAbtract
    {
        public HoaDonDatHang() 
        {
            this.ChiTietHoaDonDatHangs = new HashSet<ChiTietHoaDonDatHang>();
            this.HoaDonNhapHangs = new HashSet<HoaDonNhapHang>();
        }
        [Key]
        public string Id { get; set; }
        [Required]
        public DateTime NgayTao { get; set; }
        public string? TrangThaiNhap { get; set; }

        [Required]
        [ForeignKey("NhaCungCap")]
        public string NhaCungCapId { get; set; }
   
        public NhaCungCap? NhaCungCap { get; private set; }

        [Required]
        [ForeignKey("NhanVien")]
        public string NhanVienId { get; set; }
      
        public NhanVien? NhanVien { get; private set; }

        [Required]
        public decimal TongTien { get; set; }

        [Required]
        public double Thue { get; set; }

        [Required]
        public decimal ThanhTien { get; set; }

        public ICollection<ChiTietHoaDonDatHang>? ChiTietHoaDonDatHangs { get; set; }

        [JsonIgnore]
        public ICollection<HoaDonNhapHang>? HoaDonNhapHangs { get; set; }


      
    }
}
