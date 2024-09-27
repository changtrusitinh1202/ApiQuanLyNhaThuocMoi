using ApiQuanLyNhaThuoc.Models.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiQuanLyNhaThuoc.Models.Entities
{
    public class DanhMuc : CommonAbtract
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        public string TenDanhMuc { get; set; }
        [Required(ErrorMessage = "Mô tả không được để trống")]
        public string? MoTa { get; set; }


      
    }
}
