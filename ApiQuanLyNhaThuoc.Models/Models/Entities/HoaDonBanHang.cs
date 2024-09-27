using ApiQuanLyNhaThuoc.Models.Abstract;
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
    public class HoaDonBanHang : CommonAbtract
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [ForeignKey("KhachHang")]
        public string KhachHangId { get; set; }
        [JsonIgnore]
        public KhachHang? KhachHang { get; private set; }
        [Required]
        [ForeignKey("NhanVien")]
        public string NhanVienId { get; set; }
        [JsonIgnore]
        public NhanVien? NhanVien { get; private set; }
        [Required]
        [ForeignKey("KhuyenMai")]
        public string KhuyenMaiId { get; set; }
        [JsonIgnore]
        public KhuyenMai? KhuyenMai { get; private set; }
        public string? TrangThaiThanhToan { get; set; }
        [Required]
        public decimal TongTien { get; set; }

        [Required]
        public double Thue { get; set; }

        [Required]
        public decimal ThanhTien { get; set; }

       
    }
}
