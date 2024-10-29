using ApiQuanLyNhaThuoc.Models.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service.IService
{
    public interface ITongQuanService
    {
        List<decimal> GetTongTienTongQuanTheoThangTrongNam(int nam);

        Dictionary<int, double> GetTongSoSanPhamDaBanTheoThangTrongNam(int nam);

        List<KetQuaKhachHangTheoThang> GetSoLuongKhachHangTheoThangTrongNam(int nam);

        List<KetQuaTrangThaiHoaDonTheoThang> GetSoLuongTrangThaiHoaDonTheoThangTrongNam(int nam);
    }
}
