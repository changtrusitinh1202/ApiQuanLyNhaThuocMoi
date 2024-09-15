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
        void AddPhienBanSanPham(PhienBanSanPham phienBanSanPham, Guid sanPhamId);
        PhienBanSanPham GetPhienBanSanPhamById(Guid sanPhamId, Guid phienBanSanPhamId);
        PhienBanSanPham GetPhienBanSanPhamByPhienBanId(Guid phienBanSanPhamId);
        void CapNhatTrangThaiBan(Guid phienBanSanPhamId, Guid sanPhamId, int trangThai);
    }
}
