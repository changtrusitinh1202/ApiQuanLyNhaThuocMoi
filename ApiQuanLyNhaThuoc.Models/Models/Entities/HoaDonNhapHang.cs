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
    public class HoaDonNhapHang
    {
        [Key]
        public Guid Id { get; set; }

        public string? TrangThaiThanhToan { get; set; }
        public DateTime NgayNhapHang { get; set; }
        [Required]
        [ForeignKey("HoaDonDatHang")]
        public Guid HoaDonDatHangId { get; set; }
        [JsonIgnore]
        public HoaDonDatHang? HoaDonDatHang { get; private set; }

        [Required]
        public decimal TongTien { get; set; }

        [Required]
        [ForeignKey("KhoHang")]
        public Guid KhoHangId { get; set; }
        [JsonIgnore]
        public KhoHang? KhoHang { get; private set; }

  
        [ForeignKey("NhaCungCap")]
        public Guid NhaCungCapId { get; set; }
        [JsonIgnore]
        public NhaCungCap? NhaCungCap { get; private set; }


        public ICollection<ChiTietHoaDonNhapHang> ChiTietHoaDonNhapHangs { get; set; } = new HashSet<ChiTietHoaDonNhapHang>();

    }
}
