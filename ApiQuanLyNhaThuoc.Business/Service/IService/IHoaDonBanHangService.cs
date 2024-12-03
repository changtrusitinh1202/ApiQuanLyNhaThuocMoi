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
        void AddHoaDonBanHangOnline(string token, HoaDonBanHang hoaDonBanHang, GiaoHangDTO giaoHangDTO);
        HoaDonBanHang GetHoaDonBanHangById(string id);

        HoaDonBanHang GetHoaDonBanHangOfflineById(string hoaDonId);


        List<HoaDonBanHang> GetHoaDonBanHangTaiQuay();
        List<HoaDonBanHang> GetHoaDonBanHangs();
        List<HoaDonBanHang> GetHoaDonBanHangOnlineChoXacNhan();
        List<HoaDonBanHang> GetHoaDonBanHangOnlineXacNhanDon();
        List<HoaDonBanHang> GetHoaDonBanHangOnlineChuanBiHang();
        List<HoaDonBanHang> GetHoaDonBanHangOnlineVanChuyen();
        List<HoaDonBanHang> GetHoaDonBanHangOnlineDaGiao();
        List<HoaDonBanHang> GetHoaDonBanHangOnlineHuyDon();

        void XacNhanDonHang(string hoaDonId);
        void XacNhanChuanBiHang(string hoaDonId);
        void XacNhanVanChuyen(string hoaDonId);
        void XacNhanDaGiaoHang(string hoaDonId);
        void XacNhanHuyDonHang(string hoaDonId);

        List<HoaDonBanHang> GetHoaDonBanHangOnlineOfKhachHang(string token);

        HoaDonBanHang GetHoaDonBanHangOnlineById(string hoaDonId);
        void SendMailConfirm(HoaDonBanHang hoaDonBanHang);
    }
}
