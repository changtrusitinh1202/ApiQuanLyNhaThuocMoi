using ApiQuanLyNhaThuoc.Models.Models.DTOs;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.ViewModel
{
    public class BanHangVM
    {
        [ValidateNever]
        public List<PhienBanSanPhamDTO> PhienBanSanPhams { get; set; }
        public HoaDonBanHang HoaDonBanHang { get; set; }
    }
}
