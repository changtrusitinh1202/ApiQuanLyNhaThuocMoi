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
        public Guid Id { get; set; }

        [Required]
        public string MaLoHang { get; set; }

        public DateTime NgaySanXuat { get; set; }
        [Required]
        public DateTime NgayHetHan {  get; set; }

        [Required]
        public double SoLuongQuyDoi { get; set; }

        [Required]
        [ForeignKey("PhienBanSanPham")]
        public Guid PhienBanSanPhamId { get; set; }
        [JsonIgnore]
        public PhienBanSanPham? PhienBanSanPham { get; private set; }


        [Required]
        [ForeignKey("NhaCungCap")]
        public Guid NhaCungCapId { get; set; }
        [JsonIgnore]
        public NhaCungCap? NhaCungCap { get; private set; }

        [Required]
        [ForeignKey("KhoHang")]
        public Guid KhoHangId { get; set; }
        [JsonIgnore]
        public KhoHang? KhoHang { get; private set; }
    }
}
