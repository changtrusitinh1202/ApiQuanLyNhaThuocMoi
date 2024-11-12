using ApiQuanLyNhaThuoc.Models.Models.DTOs;
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
        void AddHoaDonBanHangTrucTiep(HoaDonBanHang hoaDonBanHang, string nhanVienId);
        void AddHoaDonBanHangOnline(string token, HoaDonBanHangOnline hoaDonBanHang, GiaoHangDTO giaoHangDTO);
        HoaDonBanHang GetHoaDonBanHangById(string id);

        List<HoaDonBanHangOnline> GetHoaDonBanHangs();
        List<HoaDonBanHangOnline> GetHoaDonBanHangOnlineChoXacNhan();
        List<HoaDonBanHangOnline> GetHoaDonBanHangOnlineXacNhanDon();
        List<HoaDonBanHangOnline> GetHoaDonBanHangOnlineChuanBiHang();
        List<HoaDonBanHangOnline> GetHoaDonBanHangOnlineVanChuyen();
        List<HoaDonBanHangOnline> GetHoaDonBanHangOnlineDaGiao();
        List<HoaDonBanHangOnline> GetHoaDonBanHangOnlineHuyDon();

        void XacNhanDonHang(string hoaDonId);
        void XacNhanChuanBiHang(string hoaDonId);
        void XacNhanVanChuyen(string hoaDonId);
        void XacNhanDaGiaoHang(string hoaDonId);
        void XacNhanHuyDonHang(string hoaDonId);

        List<HoaDonBanHangOnline> GetHoaDonBanHangOnlineOfKhachHang(string token);


        void SendMailConfirm(HoaDonBanHang hoaDonBanHang);
    }
}
