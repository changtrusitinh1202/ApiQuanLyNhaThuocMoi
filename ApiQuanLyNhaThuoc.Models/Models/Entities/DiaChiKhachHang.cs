using ApiQuanLyNhaThuoc.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiQuanLyNhaThuoc.Models.Entities;
using System.Text.Json.Serialization;

namespace ApiQuanLyNhaThuoc.Models.Models.Entities
{
    public class DiaChiKhachHang : CommonAbtract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int Id { get; set; }
        [ForeignKey("KhachHang")]
        [Required]
        public string? KhachHangId { get; set; }
        [JsonIgnore]
        public KhachHang? KhachHang { get; set; }
        public string TenNguoiNhan { get; set; }
        [Required]
        public string SoDienThoaiNguoiNhan { get; set; }
        [Required]
        public string DiaChiNguoiNhan { get; set; } // Số nhà , tên đường
        [Required]
        public string XaPhuongNguoiNhan { get; set; }
        [Required]
        public string QuanHuyenNguoiNhan { get; set; }
        [Required]
        public string TinhThanhNguoiNhan { get; set; }

        [Required]
        public bool MacDinh { get; set; }


    }
}
