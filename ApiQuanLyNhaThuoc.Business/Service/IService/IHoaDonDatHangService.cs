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
        HoaDonDatHang GetHoaDonDatHangById(Guid guid);
        void CapNhatTrangThaiDonDatHang(Guid hoaDonDatHangId, string trangThai);
        void CapNhatSoLuongNhapDonDatHang(Guid chiTietHoaDonDatHangId, double soLuongNhap);
        List<HoaDonDatHang> GetHoaDonDatHangs();
        List<HoaDonDatHang> GetHoaDonDatHangsHoanThanh();
        List<HoaDonDatHang> GetHoaDonDatHangsChuaNhap();
        List<HoaDonDatHang> GetHoaDonDatHangsNhapMotPhan();
        double GetSoLuongDat(Guid hoaDonDatHangId);
        double GetSoLuongDatChiTiet(Guid hoaDonDatHangId, Guid phienBanSanPhamId);
        double GetSoLuongDaNhapChiTiet(Guid hoaDonDatHangId, Guid phienBanSanPhamId);
        double GetSoLuongDatChiTietConLai(Guid hoaDonDatHangId, Guid phienBanSanPhamId);
        ChiTietHoaDonDatHang GetChiTietHoaDonDatHangFromDonNhapHang(Guid hoaDonDatHangId, Guid phienBanSanPhamId);

    }
}
