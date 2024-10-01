using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.ViewModel
{
    public class AddHoaDonNhapHangVM
    {
        [ValidateNever]
        public HoaDonDatHang HoaDonDatHang { get; set; }
        public HoaDonNhapHang HoaDonNhapHang { get; set; }
    }
}
