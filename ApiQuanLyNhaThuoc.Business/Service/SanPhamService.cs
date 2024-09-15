using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service
{
    public class SanPhamService : ISanPhamService
    {
        ApplicationDbContext db;
        public SanPhamService(ApplicationDbContext db)
        {
            this.db = db;
        }
   

        public void AddSanPham(SanPham sanPham)
        {
            sanPham.Id = Guid.NewGuid();
            foreach (var phienBan in sanPham.DanhSachPhienBan) // method này thêm 1 phiên bản mặc định lúc đầu khi thêm thuốc
            {
                phienBan.Id = Guid.NewGuid();
                phienBan.SanPhamId = sanPham.Id; // Gắn ID sản phẩm cho phiên bản sản phẩm
                phienBan.TenQuyDoi = sanPham.TenSanPham + " - Mặc định";
                phienBan.DonViQuyDoi = sanPham.DonViTinhNhoNhat;
                phienBan.MaVach = sanPham.MaVach;
                phienBan.SoLuong = 1;
            }
            db.SanPham.Add(sanPham);
            db.SaveChanges();
        }


        public List<SanPham> GetAllSanPham()
        {
            List<SanPham> sanPhams = db.SanPham
                                        .Include(sp => sp.DanhMuc)
                                        .Include(sp => sp.DanhSachPhienBan)
                                        .ToList();
                                
            return sanPhams;
        }

 
        public SanPham GetSanPhamById(Guid id)
        {
            SanPham? sanPham = db.SanPham
                                    .Include(sp => sp.DanhMuc)
                                    .Include(sp => sp.DanhSachPhienBan)
                                    .FirstOrDefault(sp => sp.Id == id);
            return sanPham;
        }

        public List<SanPham> GetSanPhamByName(string name)
        {
            List<SanPham> sanPhams = db.SanPham
                .Include(sp => sp.DanhSachPhienBan)
                .Where(x => x.TenSanPham.ToLower().Contains(name.ToLower())).ToList();
            return sanPhams;
        }

        public void UpdateSanPham(SanPham sanPham)
        {
            db.SanPham.Update(sanPham);
            db.SaveChanges();
        }
    }
}
