using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.Entities
{
    public class ChiTietGiamGia
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [ForeignKey("KhuyenMai")]
        public string KhuyenMaiId { get; set; }
        public KhuyenMai? KhuyenMai { get; private set; }
        [Required]
        [ForeignKey("PhienBanSanPham")]
        public string PhienBanSanPhamId { get; set; }
        public PhienBanSanPham? PhienBanSanPham { get; private set; }
        public double GiamGia { get; set; }

    

    }
}
