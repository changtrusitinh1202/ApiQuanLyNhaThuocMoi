using ApiQuanLyNhaThuoc.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service.IService
{
    public interface IDiaChiKhachHangService
    {
        public void ThemDiaChiKhachHang(string khachHangId, DiaChiKhachHang diaChiKhachHang);
        public void UpdateDiaChiKhachHang(string khachHangId, int diaChiKhachHangId, DiaChiKhachHang diaChiKhachHang);
        public void XoaDiaChiKhachHang(string khachHangId, int diaChiKhachHangId);

        public DiaChiKhachHang LayDiaChiKhachHang(string khachHangId, int diaChiKhachHangId);
        public List<DiaChiKhachHang> LayDanhSachDiaChiKhachHang(string khachHangId);

        public void SetDefaultDiaChiKhachHang(string khachHangId, int diaChiKhachHangId);

    }
}
