using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApiQuanLyNhaThuoc.Models.Abstract;
namespace ApiQuanLyNhaThuoc.Models.Entities
{
    public class NhanVien : CommonAbtract
    {
        [Key]
        [ForeignKey("AppUser")]
        public string Id { get; set; }
        public AppUser AppUser { get; set; }
        public string ChucVu { get; set; } 
        public double? HeSoLuong { get; set; } 
    }
}
