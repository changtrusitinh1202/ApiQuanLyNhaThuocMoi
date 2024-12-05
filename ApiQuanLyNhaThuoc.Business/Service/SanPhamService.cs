using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.DTOs;
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
    public class SanPhamService : ISanPhamService
    {
        ApplicationDbContext db;

        public SanPhamService(ApplicationDbContext db)
        {
            this.db = db;

        }


        public void AddSanPham(SanPhamDTO sanPhamDTO)
        {
            var sanPham = new SanPham();
            sanPham.Id = GenerateId.TaoMaSanPham();


            sanPham.MaThuoc = sanPhamDTO.MaThuoc;
            sanPham.TenSanPham = sanPhamDTO.TenSanPham;
            sanPham.MaVach = sanPhamDTO.MaVach;
            sanPham.SoDangKy = sanPhamDTO.SoDangKy;
            sanPham.DonViTinhNhoNhat = sanPhamDTO.DonViTinhNhoNhat;
            sanPham.QuyCachDongGoi = sanPhamDTO.QuyCachDongGoi;
            sanPham.LoaiThuoc = sanPhamDTO.LoaiThuoc;
            sanPham.HoatChatChinh = sanPhamDTO.HoatChatChinh;
            sanPham.HangSanXuat = sanPhamDTO.HangSanXuat;
            sanPham.TrangThaiBan = sanPhamDTO.TrangThaiBan;
            sanPham.NuocSanXuat = sanPhamDTO.NuocSanXuat;
            sanPham.DuongDung = sanPhamDTO.DuongDung;
            sanPham.DanhMucId = sanPhamDTO.DanhMucId;
            sanPham.DanhSachPhienBan = new List<PhienBanSanPham>();
            sanPham.AnhSanPham = "https://cdn.tgdd.vn/Products/Images/6985/236751/progetic-ginkgo-biloba-750mg-h-90v-thumb01-600x600.jpg";
            sanPham.CreatedBy = "Gia Huy";
            sanPham.CreatedDate = DateTime.Now;
            sanPham.ModifiedDate = DateTime.Now;



            foreach (var pb in sanPhamDTO.DanhSachPhienBan)
            {
                if(pb.TenQuyDoi.Contains("Mặc định"))
                {

                   sanPham.DanhSachPhienBan.Add(new PhienBanSanPham
                   {
                        Id = GenerateId.TaoMaPhienBanSanPham(),

                        TenQuyDoi = sanPham.TenSanPham + " - Mặc định",
                        DonViQuyDoi = pb.DonViQuyDoi,
                        MaSanPham = sanPham.MaThuoc,
                        SoLuong = pb.SoLuong,
                        MaVach = sanPham.MaVach,
                        GiaNhapQuyDoi = pb.GiaNhapQuyDoi,
                        GiaBanQuyDoi = pb.GiaBanQuyDoi,
                        KhoiLuong = pb.KhoiLuong,
                        SanPhamId = sanPham.Id,
                        CreatedBy = "Gia Huy",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now
                   });               
                }
                else
                {
                    sanPham.DanhSachPhienBan.Add(new PhienBanSanPham
                    {
                        Id = GenerateId.TaoMaPhienBanSanPham(),

                        TenQuyDoi = sanPham.TenSanPham + " - " + pb.DonViQuyDoi,
                        DonViQuyDoi = pb.DonViQuyDoi,
                        MaSanPham = sanPham.MaThuoc,
                        SoLuong = pb.SoLuong,
                        MaVach = sanPham.MaVach,
                        GiaNhapQuyDoi = pb.GiaNhapQuyDoi,
                        GiaBanQuyDoi = pb.GiaBanQuyDoi,
                        KhoiLuong = pb.KhoiLuong,
                        SanPhamId = sanPham.Id,
                        CreatedBy = "Gia Huy",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now
                    });
                }

               
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


        public SanPham GetSanPhamById(string id)
        {
            SanPham? sanPham = db.SanPham
                                    .Include(sp => sp.DanhMuc)
                                    .Include(sp => sp.DanhSachPhienBan)
                                    .FirstOrDefault(sp => sp.MaThuoc == id);
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
