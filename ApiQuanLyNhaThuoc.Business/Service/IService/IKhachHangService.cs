using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.DTOs;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service.IService
{
    public interface IKhachHangService
    {
        void AddKhachHang(KhachHang khachHang);
        KhachHangDTO GetKhachHangByToken(string token);
        void CapNhatTichDiemSuDung(string id, double tichDiemSuDung);
        KhachHang GetKhachHangByID(string id);
        List<HoaDonBanHang> GetHoaDonBanHangByKhachHangId(string khachHangId);
        List<KhachHangDTO> GetKhachHangs();
    }
}
