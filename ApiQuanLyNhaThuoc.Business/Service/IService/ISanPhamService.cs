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
    public interface ISanPhamService
    {
        List<SanPham> GetAllSanPham();
        void AddSanPham(SanPhamDTO sanPhamDTO);
        void UpdateSanPham(SanPham sanPham);
        SanPham GetSanPhamById(string id);
        List<SanPham> GetSanPhamByName(string name);
    }
}
