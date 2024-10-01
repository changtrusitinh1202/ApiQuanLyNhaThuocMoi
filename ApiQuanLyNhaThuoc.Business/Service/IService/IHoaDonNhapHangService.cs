using ApiQuanLyNhaThuoc.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service.IService
{
    public interface IHoaDonNhapHangService
    {
        void AddHoaDon(HoaDonNhapHang hoaDonNhapHang, string hoaDonDatHangId);
        bool KiemTraSoLuongNhap(HoaDonDatHang hoaDonDatHang);
        List <ChiTietHoaDonNhapHang> DieuChinhChiTietHoaDonNhapHang(HoaDonNhapHang hoaDonNhapHang, string hoaDonDatHangID);
        public void XuLyChiTIetHoaDonNhapHang(List<ChiTietHoaDonNhapHang> chiTietHoaDonNhapHangs, HoaDonNhapHang hoaDonNhapHang, HoaDonDatHang hoaDonDatHang);
    }
}
