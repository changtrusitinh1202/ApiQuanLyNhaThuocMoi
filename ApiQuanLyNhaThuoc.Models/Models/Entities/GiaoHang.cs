using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.Entities
{
    public class GiaoHang
    {
        [Key]
        public string? Id { get; set; }

        public string? MaDonRutGon { get; set; }
  
        public string? TenNguoiGui { get; set; }

        public string? SoDienThoaiNguoiGui { get; set; }

        public string? DiaChiNguoiGui { get; set; }

        public string? QuanHuyenNguoiGui { get; set; }

        public string? TinhThanhNguoiGui { get; set; }
        [Required]
        public string TenNguoiNhan { get; set; }
        [Required]
        public string SoDienThoaiNguoiNhan { get; set; }
        [Required]
        public string DiaChiNguoiNhan { get; set; }
        [Required]
        public string XaPhuongNguoiNhan { get; set; }
        [Required]
        public string QuanHuyenNguoiNhan { get; set; }
        [Required]
        public string TinhThanhNguoiNhan { get; set; }
        
        public long? TrackingNumber { get; set; }
        

        public string? ThoiGianLayHangDuKien { get; set; }
        public string? ThoiGianGiaoHangDuKien { get; set; }


    }
}
