using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.DTOs;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service
{
    public class KhachHangService : IKhachHangService
    {
        ApplicationDbContext db;
        public JwtTokenProvider _jwtTokenProvider;
        public IHoaDonBanHangService hoaDonBanHangService;
        public KhachHangService(ApplicationDbContext db, JwtTokenProvider jwtTokenProvider, IHoaDonBanHangService hoaDonBanHangService)
        {
            this.db = db;
            _jwtTokenProvider = jwtTokenProvider;
            this.hoaDonBanHangService = hoaDonBanHangService;
        }

        public void AddKhachHang(KhachHang khachHang)
        {
            db.KhachHang.Add(khachHang);
            db.SaveChanges();
        }

        public KhachHangDTO GetKhachHangByToken(string token)
        {
            JwtTokenClaims jwtTokenClaims = _jwtTokenProvider.GetTokenClaims(token);
            if (jwtTokenClaims != null)
            {
   
                var khachHang = db.KhachHang
                    .Include(x => x.AppUser)
                    .FirstOrDefault(x => x.AppUser.UserName == jwtTokenClaims.UserName);

     
                if (khachHang == null)
                {
                    return null;
                }

                return new KhachHangDTO
                {
                    Id = khachHang.AppUser.Id,
                    Username = khachHang.AppUser.UserName,
                    EmailAddress = khachHang.AppUser.Email,
                    HoTen = khachHang.AppUser.Ten,
                    DiaChi = khachHang.AppUser.DiaChi,
                    ThanhPho = khachHang.AppUser.ThanhPho,
                    GioiTinh = khachHang.AppUser.GioiTinh,
                    NgaySinh = khachHang.AppUser.NgaySinh,
                    SoDienThoai = khachHang.AppUser.PhoneNumber,
                    Quyen = khachHang.AppUser.Quyen,
                    TichDiem = khachHang.TichDiem,
                    RankKhachHang = khachHang.RankKhachHang
                };
            }

            return null;
        }

        public List<KhachHangDTO> GetKhachHangs()
        {
            List<KhachHangDTO> khachHangDTOs = db.KhachHang
                .Include(x => x.AppUser)
                .Select(x => new KhachHangDTO
                {
                    Id = x.AppUser.Id,
                    Username = x.AppUser.UserName,
                    EmailAddress = x.AppUser.Email,
                    HoTen = x.AppUser.Ten,
                    DiaChi = x.AppUser.DiaChi,
                    ThanhPho = x.AppUser.ThanhPho,
                    GioiTinh = x.AppUser.GioiTinh,
                    NgaySinh = x.AppUser.NgaySinh,
                    SoDienThoai = x.AppUser.PhoneNumber,
                    Quyen = x.AppUser.Quyen,
                    TichDiem = x.TichDiem,
                    RankKhachHang = x.RankKhachHang
                }).Where(x => x.Quyen == "CUSTOMER")
                .ToList();  
            return khachHangDTOs;
        }

        public KhachHang GetKhachHangByID(string id)
        {
            KhachHang? khachHang = db.KhachHang.FirstOrDefault(x => x.Id == id);
            return khachHang;
        }

        public void CapNhatTichDiemSuDung(string id, double tichDiemSuDung)
        {
            
        }

        public List<HoaDonBanHang> GetHoaDonBanHangByKhachHangId(string khachHangId)
        {
            List<HoaDonBanHang> hoaDonBanHangs = db.HoaDonBanHang
                .Include(ct => ct.ChiTietHoaDonBanHangs)
                .Where(x => x.KhachHang.Id == khachHangId)
                .ToList();
            return hoaDonBanHangs;
        }
    }
}
