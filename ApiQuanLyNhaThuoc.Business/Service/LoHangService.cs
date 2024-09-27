using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Models.DTOs;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service
{
    public class LoHangService : ILoHangService
    {
        ApplicationDbContext db;
        public LoHangService(ApplicationDbContext db, IHoaDonDatHangService hoaDonDatHangService, IPhienBanSanPhamService phienBanSanPhamService)
        {
            this.db = db;
        }
        public void CapNhatLoHang(LoHang loHang, double soLuongQuyDoi)
        {

            loHang.SoLuongQuyDoi += soLuongQuyDoi;
            db.Entry(loHang).Property(lh => lh.SoLuongQuyDoi).IsModified = true;
            db.SaveChanges();
        }

        public List<LoHangDTO> GetLoHangs()
        {
            var loHangs = db.LoHang
                   .Include(lh => lh.PhienBanSanPham)
                   .Include(lh => lh.NhaCungCap)
                   .Include(lh => lh.KhoHang)
                   .Select(lh => new LoHangDTO
                   {
                       Id = lh.Id,
                       NgaySanXuat = lh.NgaySanXuat,
                       NgayHetHan = lh.NgayHetHan,
                       SoLuongQuyDoi = lh.SoLuongQuyDoi,
                       TenPhienBanSanPham = lh.PhienBanSanPham.TenQuyDoi,
                       TenNhaCungCap = lh.NhaCungCap.TenNhaCungCap,
                       TenKhoHang = lh.KhoHang.ViTriLuuTru
                   })
                   .ToList();
            return loHangs;
        }
    }
}
