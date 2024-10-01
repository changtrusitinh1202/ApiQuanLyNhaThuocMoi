using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.DTOs
{
    public class HoaDonDatHangDTO
    {
        public string Id { get; set; }

        public DateTime NgayTao { get; set; }
        public string? TrangThaiNhap { get; set; }
 
        public string NhaCungCapId { get; set; }

        public NhaCungCap? NhaCungCap { get;  set; }

   
        public string NhanVienId { get; set; }

        public NhanVien? NhanVien { get;  set; }

        public decimal TongTien { get; set; }

 
        public double Thue { get; set; }

  
        public decimal ThanhTien { get; set; }

        public List<ChiTietHoaDonDatHang>? ChiTietHoaDonDatHangs { get; set; } 

   
        public List<HoaDonNhapHang>? HoaDonNhapHangs { get; set; }
    }
}
