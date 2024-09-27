using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApiQuanLyNhaThuoc.Models.Abstract;
namespace ApiQuanLyNhaThuoc.Models.Entities
{
    public class KhachHang : CommonAbtract
    {
        [Key]
        [ForeignKey("AppUser")]
        public string Id { get; set; }
        public AppUser AppUser { get; private set; }

    }
}
