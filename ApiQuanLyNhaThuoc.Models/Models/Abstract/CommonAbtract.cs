using System.ComponentModel.DataAnnotations;

namespace ApiQuanLyNhaThuoc.Models.Abstract
{
    public class CommonAbtract
    {
        public string? CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
