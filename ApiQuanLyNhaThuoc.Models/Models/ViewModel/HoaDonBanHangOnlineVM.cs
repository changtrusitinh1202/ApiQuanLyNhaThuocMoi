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
        public List<HoaDonBanHangOnline> HoaDonBanHangs { get; set; }
        public List<HoaDonBanHangOnline> HoaDonBanHangDaDat { get; set; }
        public List<HoaDonBanHangOnline> HoaDonBanHangXacNhanDon { get; set; }
        public List<HoaDonBanHangOnline> HoaDonBanHangChuanBiHang { get; set; }
        public List<HoaDonBanHangOnline> HoaDonBanHangVanChuyen { get; set; }
        public List<HoaDonBanHangOnline> HoaDonBanHangDaGiao { get; set; }
        public List<HoaDonBanHangOnline> HoaDonBanHangHuyDon { get; set; }

    }
}
