using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Text.Json.Serialization;
using ApiQuanLyNhaThuoc.Models.Abstract;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace ApiQuanLyNhaThuoc.Models.Entities
{
    public class SanPham : CommonAbtract
    {
        public SanPham() 
        {
            this.DanhSachPhienBan = new HashSet<PhienBanSanPham>();
        }
        [Key]
        public string Id { get; set; } // mã thuốc duy nhất
        [Required]
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
        public string HoatChatChinh {  get; set; }
        [Required]
        public string HangSanXuat { get; set; }
        [Required]
        public string NuocSanXuat { get; set; }
        [Required]
        public string QuyCachDongGoi { get; set; }
        [Required]
        public string DuongDung {  get; set; }
        public string? AnhSanPham { get; set;}
        [Required]
        public bool TrangThaiBan { get; set; }

        [ForeignKey("DanhMuc")]
        public string DanhMucId { get; set; }
        [JsonIgnore]
        public DanhMuc? DanhMuc { get; private set; } //private tránh khi db.SaveChanges() sẽ tự động thêm mới
       

        public ICollection<PhienBanSanPham> DanhSachPhienBan { get; set; }

      
    }
}
