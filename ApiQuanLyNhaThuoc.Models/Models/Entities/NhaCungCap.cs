using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ApiQuanLyNhaThuoc.Models.Abstract;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
namespace ApiQuanLyNhaThuoc.Models.Entities
{
    public class NhaCungCap : CommonAbtract
    {
        [Key]     
        public string Id { get; set; }
        [Required]
        [StringLength(70)]
        public string TenNhaCungCap { get; set; }
        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; }
        [Required]
        [StringLength(20)]
        public string ThanhPho  { get; set; }
        [Required]
        [StringLength(20)]
        public string QuocGia { get; set; }
        [Required]
        [StringLength(15)]
        public string SoDienThoai  { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(30)]
        public string Website { get; set; }
        [Required]
        public int TrangThaiGiaoDich {  get; set; }

        [JsonIgnore]
        public ICollection<LoHang>? LoHangs { get; set; } 
        [JsonIgnore]
        public ICollection<HoaDonNhapHang>? HoaDonNhapHangs { get; set; }

       
    }
}
