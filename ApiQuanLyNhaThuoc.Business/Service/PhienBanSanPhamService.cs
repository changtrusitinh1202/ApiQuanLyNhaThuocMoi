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
using Utility;

namespace ApiQuanLyNhaThuoc.Business.Service
{
    public class PhienBanSanPhamService : IPhienBanSanPhamService
    {
        ApplicationDbContext db;
        ISanPhamService sanPhamService;
        public PhienBanSanPhamService(ApplicationDbContext db, ISanPhamService sanPhamService)
        {
            this.db = db;
            this.sanPhamService = sanPhamService;
        }


        public void AddPhienBanSanPham(PhienBanSanPham phienBanSanPham, string sanPhamId)
        {
            SanPham sanPhamTim = sanPhamService.GetSanPhamById(sanPhamId);
            PhienBanSanPham? phienBanSanPhamMacDinh = sanPhamTim.DanhSachPhienBan
                .FirstOrDefault(x => x.TenQuyDoi.Contains("Mặc định")); // lấy giá nhập và bán của đơn vị nhỏ nhất (mặc định) 
            phienBanSanPham.Id = GenerateId.TaoMaPhienBanSanPham();
            phienBanSanPham.SanPhamId = sanPhamId;
            phienBanSanPham.DonViQuyDoi = phienBanSanPham.TenQuyDoi;
            phienBanSanPham.TenQuyDoi = sanPhamTim.TenSanPham + " - " + phienBanSanPham.TenQuyDoi;
            phienBanSanPham.GiaBanQuyDoi = phienBanSanPhamMacDinh.GiaBanQuyDoi * (decimal)phienBanSanPham.SoLuong;
            phienBanSanPham.GiaNhapQuyDoi = phienBanSanPhamMacDinh.GiaNhapQuyDoi * (decimal)phienBanSanPham.SoLuong;    
            db.PhienBanSanPham.Add(phienBanSanPham);
            db.SaveChanges();
        }

        public PhienBanSanPham GetPhienBanSanPhamById(string sanPhamId, string phienBanSanPhamId)
        {
            SanPham sanPhamTim = sanPhamService.GetSanPhamById(sanPhamId);
            if (sanPhamTim != null)
            {
                PhienBanSanPham? phienBanSanPhamTim = sanPhamTim.DanhSachPhienBan.FirstOrDefault(x => x.Id == phienBanSanPhamId);
                return phienBanSanPhamTim;
            }
            return null;
        }

        public void CapNhatTrangThaiBan(string phienBanSanPhamId, string sanPhamId, int trangThai)
        {

        }

        public PhienBanSanPham GetPhienBanSanPhamByPhienBanId(string phienBanSanPhamId)
        {
            PhienBanSanPham? phienBanSanPhamTim = db.PhienBanSanPham.FirstOrDefault(x => x.Id == phienBanSanPhamId);
            return phienBanSanPhamTim;
        }

        public List<PhienBanSanPham> GetPhienBanSanPhams()
        {
            List<PhienBanSanPham> phienBanSanPhams = db.PhienBanSanPham.ToList();
            return phienBanSanPhams;
        }

        public List<PhienBanSanPham> GetPhienBanSanPhamsByName(string name)
        {
            List<PhienBanSanPham> phienBanSanPhams = db.PhienBanSanPham
                .Where(p => p.TenQuyDoi.ToLower().Contains(name.ToLower())).ToList();
            return phienBanSanPhams;
        }
    }
}
