using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using ApiQuanLyNhaThuoc.Models.Abstract;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace ApiQuanLyNhaThuoc.Models.Entities
{
    public class NhanVien : CommonAbtract
    {
        [Key]
        [ForeignKey("AppUser")]
        public string? Id { get; set; }
        [ValidateNever]
        public AppUser? AppUser { get; set; }
        public string ChucVu { get; set; } 
        public double? HeSoLuong { get; set; } 
        public string? CaLamViec { get; set; }
    }
}
