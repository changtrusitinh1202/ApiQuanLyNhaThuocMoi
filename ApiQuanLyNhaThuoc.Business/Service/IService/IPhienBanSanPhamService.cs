using ApiQuanLyNhaThuoc.Models.Models.DTOs;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service.IService
{
    public interface IPhienBanSanPhamService
    {
        void AddPhienBanSanPham(PhienBanSanPham phienBanSanPham, string sanPhamId);
        PhienBanSanPham GetPhienBanSanPhamById(string sanPhamId, string phienBanSanPhamId);
        PhienBanSanPham GetPhienBanSanPhamByPhienBanId(string phienBanSanPhamId);
        List<PhienBanSanPham> GetPhienBanSanPhams();
        List<PhienBanSanPhamDTO> GetPhienBanSanPhamsDTO();
        List<PhienBanSanPham> GetPhienBanSanPhamsByName(string name);
        void CapNhatTrangThaiBan(string phienBanSanPhamId, string sanPhamId, int trangThai);
    }
}
