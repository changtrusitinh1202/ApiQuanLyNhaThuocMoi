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
        void AddHoaDon(HoaDonNhapHang hoaDonNhapHang, Guid hoaDonDatHangId);
        bool KiemTraSoLuongNhap(HoaDonDatHang hoaDonDatHang);
        ICollection <ChiTietHoaDonNhapHang> DieuChinhChiTietHoaDonNhapHang(HoaDonNhapHang hoaDonNhapHang, Guid hoaDonDatHangID);
    }
}
