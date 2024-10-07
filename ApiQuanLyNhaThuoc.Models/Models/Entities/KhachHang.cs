using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApiQuanLyNhaThuoc.Models.Abstract;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace ApiQuanLyNhaThuoc.Models.Entities
{
    public class KhachHang : CommonAbtract
    {
        [Key]
        [ForeignKey("AppUser")]
        public string? Id { get; set; }
        [ValidateNever]
        public AppUser? AppUser { get;  set; }
        public decimal TichDiem { get; set; }

        public string? RankKhachHang { get; set; }
    }
}
