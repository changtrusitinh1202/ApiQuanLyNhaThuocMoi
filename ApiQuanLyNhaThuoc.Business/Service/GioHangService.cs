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
    public class GioHangService : IGioHangService
    {
        ApplicationDbContext db;
        public IKhachHangService khachHangService;
        public IPhienBanSanPhamService phienBanSanPhamService;
        public GioHangService(ApplicationDbContext db, IKhachHangService khachHangService, IPhienBanSanPhamService phienBanSanPhamService)
        {
            this.db = db;
            this.khachHangService = khachHangService;
            this.phienBanSanPhamService = phienBanSanPhamService;
        }

        public void ThemSanPhamVaoGioHang(string token, string phienBanSanPhamId, double soLuong)
        {
            KhachHangDTO khachHangDTO = khachHangService.GetKhachHangByToken(token);
            if (khachHangDTO == null)
            {
                return;
            }


            PhienBanSanPham phienBanSanPham = db.PhienBanSanPham.FirstOrDefault(x => x.Id == phienBanSanPhamId);
            if (phienBanSanPham == null)
            {
                return;
            }


            GioHang? gioHang = db.GioHang
                .FirstOrDefault(x => x.KhachHangId == khachHangDTO.Id && x.PhienBanSanPhamId == phienBanSanPhamId);
            //Thêm sản phẩm đã có trong giỏ hàng
            if (gioHang != null)
            {
                gioHang.SoLuong += 1;
            }
            else
            {
                gioHang = new GioHang
                {
                    KhachHangId = khachHangDTO.Id,
                    PhienBanSanPhamId = phienBanSanPham.Id,
                    SoLuong = soLuong,
                    Gia = phienBanSanPham.GiaBanQuyDoi
                };
                db.GioHang.Add(gioHang);
            }

            db.SaveChanges();

        }

        public void TangSoLuongSanPham(string token, string phienBanSanPhamId)
        {
            KhachHangDTO khachHangDTO = khachHangService.GetKhachHangByToken(token);
            if (khachHangDTO == null)
            {
                return;
            }
            GioHang? gioHang = db.GioHang
                .FirstOrDefault(x => x.KhachHangId == khachHangDTO.Id && x.PhienBanSanPhamId == phienBanSanPhamId);
            if (gioHang != null)
            {
                gioHang.SoLuong += 1;
            }
            // db.GioHang.Update(gioHang);
            db.SaveChanges();
        }

        public void GiamSoLuongSanPham(string token, string phienBanSanPhamId)
        {
            KhachHangDTO khachHangDTO = khachHangService.GetKhachHangByToken(token);
            if (khachHangDTO == null)
            {
                return;
            }
            GioHang? gioHang = db.GioHang
                .FirstOrDefault(x => x.KhachHangId == khachHangDTO.Id && x.PhienBanSanPhamId == phienBanSanPhamId);
            if (gioHang != null)
            {
                if (gioHang.SoLuong > 1)
                {
                    gioHang.SoLuong -= 1;
                }
                else
                {
                    db.GioHang.Remove(gioHang);
                }
            }
            db.SaveChanges();
        }

        public void XoaSanPhamKhoiGioHang(string token, string phienBanSanPhamId)
        {
            KhachHangDTO khachHangDTO = khachHangService.GetKhachHangByToken(token);
            if (khachHangDTO == null)
            {
                return;
            }
            GioHang? gioHang = db.GioHang
                .FirstOrDefault(x => x.KhachHangId == khachHangDTO.Id && x.PhienBanSanPhamId == phienBanSanPhamId);
            if (gioHang != null)
            {
                db.GioHang.Remove(gioHang);
            }
            db.SaveChanges();
        }

        public List<GioHangDTO> GetGioHang(string token)
        {
            KhachHangDTO khachHangDTO = khachHangService.GetKhachHangByToken(token);
            if (khachHangDTO == null)
            {
                return null;
            }

     
            List<GioHangDTO> gioHangs = db.GioHang
                .Include(x => x.PhienBanSanPham)
                .Where(x => x.KhachHangId == khachHangDTO.Id) 
                .Select(x => new GioHangDTO
                {
                    KhachHangId = x.KhachHangId,
                    PhienBanSanPhamId = x.PhienBanSanPhamId,
                    SoLuong = x.SoLuong,
                    Gia = x.Gia,
                    TenSanPham = x.PhienBanSanPham.TenQuyDoi, 
                    HinhAnh = x.PhienBanSanPham.SanPham.AnhSanPham 
                })
                .ToList();

            return gioHangs;
        }
    }
}
