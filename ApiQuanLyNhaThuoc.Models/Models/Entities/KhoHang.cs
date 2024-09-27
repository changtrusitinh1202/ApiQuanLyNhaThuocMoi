using ApiQuanLyNhaThuoc.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.Entities
{
    public class KhoHang : CommonAbtract
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string ViTriLuuTru { get; set; }

        [JsonIgnore]
        public ICollection<LoHang>? LoHangs { get; set; }
        [JsonIgnore]
        public ICollection<HoaDonNhapHang>? HoaDonNhapHangs { get; set; }
        [JsonIgnore]
        public ICollection<HangTonKho>? HangTonKhos { get; set; }

       
    }
}
