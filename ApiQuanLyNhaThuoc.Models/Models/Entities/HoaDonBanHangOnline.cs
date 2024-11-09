using ApiQuanLyNhaThuoc.Models.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ApiQuanLyNhaThuoc.Models.Abstract;

namespace ApiQuanLyNhaThuoc.Models.Models.Entities
{
    public class HoaDonBanHangOnline : CommonAbtract
    {
        [Key]
        public string? Id { get; set; }

        [ForeignKey("KhachHang")]
        public string? KhachHangId { get; set; }
        [JsonIgnore]
        public KhachHang? KhachHang { get; private set; }

        [ForeignKey("NhanVien")]
        [ValidateNever]
        public string? NhanVienId { get; set; }
        [JsonIgnore]
        public NhanVien? NhanVien { get; private set; }

        [ForeignKey("KhuyenMai")]
        [ValidateNever]
        public string? KhuyenMaiId { get; set; }
        [JsonIgnore]
        public KhuyenMai? KhuyenMai { get; private set; }

        public string HinhThucMuaHang { get; set; }
        public string HinhThucThanhToan { get; set; }
        public string? TrangThaiDonHang { get; set; }
        public string? TrangThaiThanhToan { get; set; }
        [Required]
        public decimal TongTien { get; set; }

        [Required]
        public double Thue { get; set; }


        public decimal? PhiVanChuyen { get; set; }


        [Required]
        public decimal ThanhTien { get; set; }

        public bool? DungTichDiem { get; set; }

        public decimal? SoDiemTichLuyDung { get; set; }

        public string? GhiChu { get; set; }

        public ICollection<ChiTietHoaDonBanHangOnline> ChiTietHoaDonBanHangs { get; set; }

        [ForeignKey("GiaoHang")]
        [ValidateNever]
        public string? GiaoHangId { get; set; }
        public GiaoHang? GiaoHang { get; set; }

        public List<TrangThaiHoaDonOnline> Timeline { get; set; }


        public void AddTimelineStatus(string status)
        {
            Timeline.Add(new TrangThaiHoaDonOnline
            {
                Status = status,
                ThoiGian = DateTime.Now,
                HoaDonBanHangOnlineId = this.Id 
            });
        }
    }
}
