using ApiQuanLyNhaThuoc.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.ViewModel
{
    public class HoaDonBanHangOnlineVM
    {
        public List<HoaDonBanHang> HoaDonBanHangs { get; set; }
        public List<HoaDonBanHang> HoaDonBanHangChoXacNhan { get; set; }
        public List<HoaDonBanHang> HoaDonBanHangXacNhanDon { get; set; }
        public List<HoaDonBanHang> HoaDonBanHangChuanBiHang { get; set; }
        public List<HoaDonBanHang> HoaDonBanHangVanChuyen { get; set; }
        public List<HoaDonBanHang> HoaDonBanHangDaGiao { get; set; }
        public List<HoaDonBanHang> HoaDonBanHangHuyDon { get; set; }

    }
}
