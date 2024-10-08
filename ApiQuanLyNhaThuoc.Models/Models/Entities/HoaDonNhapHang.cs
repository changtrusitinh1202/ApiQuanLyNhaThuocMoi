﻿using ApiQuanLyNhaThuoc.Models.Abstract;
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
    public class HoaDonNhapHang : CommonAbtract
    {
        [Key]
        public string Id { get; set; }

        public string? TrangThaiThanhToan { get; set; }
        [Required]
        [ForeignKey("HoaDonDatHang")]
        public string HoaDonDatHangId { get; set; }
 
        public HoaDonDatHang? HoaDonDatHang { get; private set; }

        [Required]
        public decimal TongTien { get; set; }

        [Required]
        public double Thue { get; set; }

        [Required]
        public decimal ThanhTien { get; set; }

        [Required]
        [ForeignKey("KhoHang")]
        public string KhoHangId { get; set; }

        [ValidateNever]
        public KhoHang? KhoHang { get; private set; }

  
        [ForeignKey("NhaCungCap")]
        public string NhaCungCapId { get; set; }
  
        public NhaCungCap? NhaCungCap { get; private set; }

        [Required]
        [ForeignKey("NhanVien")]
        public string NhanVienId { get; set; }

        public NhanVien? NhanVien { get; private set; }

        public List<ChiTietHoaDonNhapHang> ChiTietHoaDonNhapHangs { get; set; }

     

    }
}
