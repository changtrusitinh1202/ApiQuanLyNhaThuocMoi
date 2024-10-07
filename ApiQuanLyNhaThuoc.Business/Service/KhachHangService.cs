using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.DTOs;
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
        public KhachHangService(ApplicationDbContext db, JwtTokenProvider jwtTokenProvider)
        {
            this.db = db;
            _jwtTokenProvider = jwtTokenProvider;
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
    }
}
