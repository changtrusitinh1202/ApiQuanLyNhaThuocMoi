using ApiQuanLyNhaThuoc.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.DTOs
{
    public class SanPhamDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string MaThuoc { get; set; }
        [Required]
        public string TenSanPham { get; set; }
        [Required]
        public string MaVach { get; set; }
        [Required]
        public string SoDangKy { get; set; }
        [Required]
        public string DonViTinhNhoNhat { get; set; }
        [Required]
        public string LoaiThuoc { get; set; }
        public string? Mota { get; set; }
        [Required]
        public string HoatChatChinh { get; set; }
        [Required]
        public string HangSanXuat { get; set; }
        [Required]
        public string NuocSanXuat { get; set; }
        [Required]
        public string QuyCachDongGoi { get; set; }
        [Required]
        public string DuongDung { get; set; }
        public string AnhSanPham { get; set; }
        [Required]
        public int TrangThaiBan { get; set; }

        [Required]
        [ForeignKey("DanhMuc")]
        public Guid DanhMucId { get; set; }
        public DanhMuc? DanhMuc { get; private set; }
    }
}
