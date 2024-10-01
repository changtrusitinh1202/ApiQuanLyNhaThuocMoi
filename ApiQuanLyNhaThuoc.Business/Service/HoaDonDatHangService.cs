using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.Enum;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;


namespace ApiQuanLyNhaThuoc.Business.Service
{
    public class HoaDonDatHangService : IHoaDonDatHangService
    {
        ApplicationDbContext db;
        public IPhienBanSanPhamService phienBanSanPhamService;
        public HoaDonDatHangService(ApplicationDbContext db, IPhienBanSanPhamService phienBanSanPhamService)
        {
            this.db = db;
            this.phienBanSanPhamService = phienBanSanPhamService;
        }
        public void AddHoaDonDatHang(HoaDonDatHang hoaDonDatHang)
        {
            hoaDonDatHang.Id = GenerateId.TaoMaHoaDonDatHang();
            hoaDonDatHang.TrangThaiNhap = TrangThai.ChuaNhap;
            hoaDonDatHang.NgayTao = DateTime.Now;
            hoaDonDatHang.CreatedDate = DateTime.Now;
            hoaDonDatHang.ModifiedDate = DateTime.Now;
  
            foreach(var chiTiet in hoaDonDatHang.ChiTietHoaDonDatHangs)
            {
                chiTiet.Id = GenerateId.TaoMaChiTietHoaDonDatHang();
                chiTiet.HoaDonDatHangId = hoaDonDatHang.Id;  
                chiTiet.SoLuongDaNhap = 0;
                hoaDonDatHang.TongTien = hoaDonDatHang.TongTien + (chiTiet.Gia * (decimal)chiTiet.SoLuongDat);
                hoaDonDatHang.ChiTietHoaDonDatHangs.Add(chiTiet);
            }
            hoaDonDatHang.Thue = 0.1;
            hoaDonDatHang.ThanhTien = hoaDonDatHang.TongTien + (hoaDonDatHang.TongTien * (decimal)hoaDonDatHang.Thue);
            
            db.HoaDonDatHang.Add(hoaDonDatHang);
            db.SaveChanges();
        }

        public HoaDonDatHang GetHoaDonDatHangById(string guid)
        {
            HoaDonDatHang? hoaDonDatHang = db.HoaDonDatHang
                .Include(ct => ct.ChiTietHoaDonDatHangs)
                    .ThenInclude(pbsp => pbsp.PhienBanSanPham)
                .Include(ncc => ncc.NhaCungCap)
                .Include(nv => nv.NhanVien)
                .FirstOrDefault(x => x.Id == guid);
            return hoaDonDatHang;
        }

        public List<HoaDonDatHang> GetHoaDonDatHangs()
        {
            List<HoaDonDatHang> hoaDonDatHangs = db.HoaDonDatHang
                .Include(ct => ct.ChiTietHoaDonDatHangs)
                .Include(ncc => ncc.NhaCungCap)
                .Include(nv => nv.NhanVien)
                .ToList();
            return hoaDonDatHangs;
        }

        public List<HoaDonDatHang> GetHoaDonDatHangsChuaNhap()
        {
            List<HoaDonDatHang> hoaDonDatHangs = db.HoaDonDatHang
                .Include(ct => ct.ChiTietHoaDonDatHangs)
                .Include(ncc => ncc.NhaCungCap)
                .Include(nv => nv.NhanVien)
                .Where(x => x.TrangThaiNhap == TrangThai.ChuaNhap).ToList();
            return hoaDonDatHangs;
        }

        public List<HoaDonDatHang> GetHoaDonDatHangsHoanThanh()
        {
            List<HoaDonDatHang> hoaDonDatHangs = db.HoaDonDatHang
                .Include(ct => ct.ChiTietHoaDonDatHangs)
                .Include(ncc => ncc.NhaCungCap)
                .Include(nv => nv.NhanVien)
                .Where(x => x.TrangThaiNhap == TrangThai.HoanThanh).ToList();
            return hoaDonDatHangs;
        }

        public List<HoaDonDatHang> GetHoaDonDatHangsNhapMotPhan()
        {
            List<HoaDonDatHang> hoaDonDatHangs = db.HoaDonDatHang
                .Include(ct => ct.ChiTietHoaDonDatHangs)
                .Include(ncc => ncc.NhaCungCap)
                .Include(nv => nv.NhanVien)
                .Where(x => x.TrangThaiNhap == TrangThai.NhapMotPhan).ToList();
            return hoaDonDatHangs;
        }

        public void CapNhatTrangThaiDonDatHang(string hoaDonDatHangId, string trangThai)
        {
            HoaDonDatHang hoaDonDatHangUpdate = this.GetHoaDonDatHangById(hoaDonDatHangId);
            if (hoaDonDatHangUpdate == null)
                return;
            hoaDonDatHangUpdate.TrangThaiNhap = trangThai;
            db.HoaDonDatHang.Attach(hoaDonDatHangUpdate);
            db.Entry(hoaDonDatHangUpdate).Property(x => x.TrangThaiNhap).IsModified = true;
            db.SaveChanges();
        }

        public void CapNhatSoLuongNhapDonDatHang(string chiTietHoaDonDatHangId, double soLuongNhap)
        {
            ChiTietHoaDonDatHang chiTietHoaDonDatHangFind = db.ChiTietHoaDonDatHang.FirstOrDefault(ct => ct.Id == chiTietHoaDonDatHangId);
            if (chiTietHoaDonDatHangFind == null)
                return;
            chiTietHoaDonDatHangFind.SoLuongDaNhap = chiTietHoaDonDatHangFind.SoLuongDaNhap + soLuongNhap;
            db.ChiTietHoaDonDatHang.Attach(chiTietHoaDonDatHangFind);
            db.Entry(chiTietHoaDonDatHangFind).Property(x => x.SoLuongDaNhap).IsModified = true;
            db.SaveChanges();
        }


        public double GetSoLuongDat(string hoaDonDatHangId)
        {
            HoaDonDatHang hoaDonDatHangFind = this.GetHoaDonDatHangById(hoaDonDatHangId);
            double soLuongDat = 0;
            foreach(var chiTiet in hoaDonDatHangFind.ChiTietHoaDonDatHangs)
            {
                soLuongDat = soLuongDat + chiTiet.SoLuongDat;
            }
            return soLuongDat;
        }

        public double GetSoLuongDatChiTiet(string hoaDonDatHangId, string phienBanSanPhamId)
        {
            double soLuongdat = 0;
            HoaDonDatHang hoaDonDatHangFind = this.GetHoaDonDatHangById(hoaDonDatHangId);
            if(hoaDonDatHangFind != null)
            {
                var chiTietHoaDon = hoaDonDatHangFind.ChiTietHoaDonDatHangs.FirstOrDefault(ct => ct.PhienBanSanPhamId == phienBanSanPhamId);
                soLuongdat = chiTietHoaDon.SoLuongDat;
                return soLuongdat;
            }
            return soLuongdat;                     
        }

        public ChiTietHoaDonDatHang GetChiTietHoaDonDatHangFromDonNhapHang(string hoaDonDatHangId, string phienBanSanPhamId)
        {
            HoaDonDatHang hoaDonDatHangFind = this.GetHoaDonDatHangById(hoaDonDatHangId);
            ChiTietHoaDonDatHang chiTietHoaDon = hoaDonDatHangFind.ChiTietHoaDonDatHangs
                                    .FirstOrDefault(ct => ct.PhienBanSanPhamId == phienBanSanPhamId);
            return chiTietHoaDon;
        }

        public double GetSoLuongDatChiTietConLai(string hoaDonDatHangId, string phienBanSanPhamId)
        {
            double soLuongConLai = 0;
            HoaDonDatHang hoaDonDatHangFind = this.GetHoaDonDatHangById(hoaDonDatHangId);
            if (hoaDonDatHangFind != null)
            {
                var chiTietHoaDon = hoaDonDatHangFind.ChiTietHoaDonDatHangs.FirstOrDefault(ct => ct.PhienBanSanPhamId == phienBanSanPhamId);
                soLuongConLai = chiTietHoaDon.SoLuongDat - chiTietHoaDon.SoLuongDaNhap;
                return soLuongConLai;
            }
            return soLuongConLai;
        }

        public double GetSoLuongDaNhapChiTiet(string hoaDonDatHangId, string phienBanSanPhamId)
        {
            double soLuongdat = 0;
            HoaDonDatHang hoaDonDatHangFind = this.GetHoaDonDatHangById(hoaDonDatHangId);
            if (hoaDonDatHangFind != null)
            {
                var chiTietHoaDon = hoaDonDatHangFind.ChiTietHoaDonDatHangs.FirstOrDefault(ct => ct.PhienBanSanPhamId == phienBanSanPhamId);
                soLuongdat = chiTietHoaDon.SoLuongDat;
                return soLuongdat;
            }
            return soLuongdat;
        }
    }
}
