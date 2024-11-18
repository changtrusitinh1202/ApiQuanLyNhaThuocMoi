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
    public class TrangThaiHoaDonOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("HoaDonBanHangOnline")]
        [Required]
        public string?  HoaDonBanHangOnlineId { get; set; }
        [JsonIgnore]
        public HoaDonBanHangOnline? HoaDonBanHangOnline { get; set; }
        public string Status { get; set; }
        [Required]
        public DateTime ThoiGian { get; set; }  

        public string? GhiChu { get; set; }

    }
}
