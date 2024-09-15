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
    public class HoaDonDatHang
    {
        public HoaDonDatHang() 
        {
            this.ChiTietHoaDonDatHangs = new HashSet<ChiTietHoaDonDatHang>();
            this.HoaDonNhapHangs = new HashSet<HoaDonNhapHang>();
        }
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime NgayTao { get; set; }
        public string? TrangThaiNhap { get; set; }

        [Required]
        [ForeignKey("NhaCungCap")]
        public Guid NhaCungCapId { get; set; }
        [JsonIgnore]
        public NhaCungCap? NhaCungCap { get; private set; }

        [Required]
        public decimal TongTien {  get; set; }

        [MinLength(1, ErrorMessage = "Hóa đơn đặt hàng chưa có sản phẩm nào")]
        public ICollection<ChiTietHoaDonDatHang>? ChiTietHoaDonDatHangs { get; set; }

        [JsonIgnore]
        public ICollection<HoaDonNhapHang>? HoaDonNhapHangs { get; set; }
    }
}
