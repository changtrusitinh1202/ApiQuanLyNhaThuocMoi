using ApiQuanLyNhaThuoc.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.Entities
{
    public class LoHang
    {

        [Key]
        public string Id { get; set; }

        public DateTime NgaySanXuat { get; set; }
        [Required]
        public DateTime NgayHetHan {  get; set; }

        [Required]
        public double SoLuongQuyDoi { get; set; }

        [Required]
        [ForeignKey("PhienBanSanPham")]
        public string PhienBanSanPhamId { get; set; }

        [JsonIgnore]
        public PhienBanSanPham? PhienBanSanPham { get; private set; }


        [Required]
        [ForeignKey("NhaCungCap")]
        public string NhaCungCapId { get; set; }
        [JsonIgnore]
        public NhaCungCap? NhaCungCap { get; private set; }

        [Required]
        [ForeignKey("KhoHang")]
        public string KhoHangId { get; set; }
        [JsonIgnore]
        public KhoHang? KhoHang { get; private set; }

     
    }
}
