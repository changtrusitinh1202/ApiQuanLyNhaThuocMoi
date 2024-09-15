using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service.IService
{
    public interface ISanPhamService
    {
        List<SanPham> GetAllSanPham();
        void AddSanPham(SanPham sanPham);
        void UpdateSanPham(SanPham sanPham);
        SanPham GetSanPhamById(Guid id);
        List<SanPham> GetSanPhamByName(string name);
    }
}
