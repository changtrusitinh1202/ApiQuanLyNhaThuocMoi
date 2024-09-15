using System.ComponentModel.DataAnnotations;
using ApiQuanLyNhaThuoc.Models.Abstract;
namespace ApiQuanLyNhaThuoc.Models.Entities
{
    public class NhanVien : CommonAbtract
    {
        public DateTime? HireDate { get; set; } 
        public string Position { get; set; } 
        public decimal? Salary { get; set; } 


    }
}
