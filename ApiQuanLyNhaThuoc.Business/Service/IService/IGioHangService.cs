using ApiQuanLyNhaThuoc.Models.Models.DTOs;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service.IService
{
    public interface IGioHangService
    {
        public void ThemSanPhamVaoGioHang(string token, string phienBanSanPhamId, double soLuong);
        public void TangSoLuongSanPham(string token, string phienBanSanPhamId);
        public void GiamSoLuongSanPham(string token, string phienBanSanPhamId);
        public void XoaSanPhamKhoiGioHang(string token, string phienBanSanPhamId);
        public List<GioHangDTO> GetGioHang(string token);
    }
}
