using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.DTOs
{
    public class GiaoHangDTO
    {
        [Required]
        public string TenNguoiNhan { get; set; }
        [Required]
        public string SoDienThoaiNguoiNhan { get; set; }
        [Required]
        public string DiaChiNguoiNhan { get; set; }
        [Required]
        public string XaPhuongNguoiNhan { get; set; }
        [Required]
        public string QuanHuyenNguoiNhan { get; set; }
        [Required]
        public string TinhThanhNguoiNhan { get; set; }

        public int? FreeShip { get; set; }

        public int? BaoHiem { get; set; }

    }
}
