using ApiQuanLyNhaThuoc.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service.IService
{
    public interface IHoaDonBanHangService
    {
        void AddHoaDonBanHangTrucTiep(HoaDonBanHang hoaDonBanHang);
        void AddHoaDonBanHangOnline(HoaDonBanHang hoaDonBanHang);
        HoaDonBanHang GetHoaDonBanHangById(string id);
  
        void SendMailConfirm(HoaDonBanHang hoaDonBanHang);
    }
}
