using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service
{
    public class NhanVienService : INhanVienService
    {
        ApplicationDbContext db;
        public JwtTokenProvider _jwtTokenProvider;
        public NhanVienService(ApplicationDbContext db, JwtTokenProvider jwtTokenProvider)
        {
            this.db = db;
            _jwtTokenProvider = jwtTokenProvider;
        }
        public void AddNhanVien(NhanVien nhanVien)
        {
         
            nhanVien.CreatedDate = DateTime.Now;
            nhanVien.ModifiedDate = DateTime.Now;
            db.NhanVien.Add(nhanVien);
            db.SaveChanges();
        }

        public NhanVien GetNhanVienById(string token)
        {
            JwtTokenClaims jwtTokenClaims = _jwtTokenProvider.GetTokenClaims(token);
            if (jwtTokenClaims != null)
            {
                NhanVien nhanVien = db.NhanVien
                    .Include(x => x.AppUser)
                    .FirstOrDefault(x => x.AppUser.UserName == jwtTokenClaims.UserName);
                return nhanVien;
            }
            return null;
        }
    }
}
