using ApiQuanLyNhaThuoc.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApiQuanLyNhaThuoc.Business.Service.IService
{
    public interface IHoaDonDatHangService
    {
        void AddHoaDonDatHang(HoaDonDatHang hoaDonDatHang);
        HoaDonDatHang GetHoaDonDatHangById(string guid);
        void CapNhatTrangThaiDonDatHang(string hoaDonDatHangId, string trangThai);
        void CapNhatSoLuongNhapDonDatHang(string chiTietHoaDonDatHangId, double soLuongNhap);
        List<HoaDonDatHang> GetHoaDonDatHangs();
        List<HoaDonDatHang> GetHoaDonDatHangsHoanThanh();
        List<HoaDonDatHang> GetHoaDonDatHangsChuaNhap();
        List<HoaDonDatHang> GetHoaDonDatHangsNhapMotPhan();
        double GetSoLuongDat(string hoaDonDatHangId);
        double GetSoLuongDatChiTiet(string hoaDonDatHangId, string phienBanSanPhamId);
        double GetSoLuongDaNhapChiTiet(string hoaDonDatHangId, string phienBanSanPhamId);
        double GetSoLuongDatChiTietConLai(string hoaDonDatHangId, string phienBanSanPhamId);
        ChiTietHoaDonDatHang GetChiTietHoaDonDatHangFromDonNhapHang(string hoaDonDatHangId, string phienBanSanPhamId);

    }
}
