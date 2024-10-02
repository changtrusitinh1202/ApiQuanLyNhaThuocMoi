using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace ApiQuanLyNhaThuoc.Business.Service
{
    public class HoaDonNhapHangService : IHoaDonNhapHangService
    {
        ApplicationDbContext db;
        public IHoaDonDatHangService hoaDonDatHangService;
        public IPhienBanSanPhamService phienBanSanPhamService;
        public ILoHangService loHangService;
        public HoaDonNhapHangService(ApplicationDbContext db, IHoaDonDatHangService hoaDonDatHangService, IPhienBanSanPhamService phienBanSanPhamService, ILoHangService loHangService)
        {
            this.db = db;
            this.hoaDonDatHangService = hoaDonDatHangService;
            this.phienBanSanPhamService = phienBanSanPhamService;
            this.loHangService = loHangService;
        }


        public void AddHoaDon(HoaDonNhapHang hoaDonNhapHang, string hoaDonDatHangId)
        {
            HoaDonDatHang hoaDonDatHangFind = hoaDonDatHangService.GetHoaDonDatHangById(hoaDonDatHangId);
            bool capNhatTrangThai = this.KiemTraSoLuongNhap(hoaDonDatHangFind);

            if (hoaDonDatHangFind == null)
                throw new Exception("Đơn đặt hàng không tồn tại");

            if (hoaDonDatHangFind != null && capNhatTrangThai)
                throw new Exception("Đơn đặt hàng đã được nhập đủ");

            hoaDonNhapHang.Id = GenerateId.TaoMaHoaDonNhapHang();
            hoaDonNhapHang.TrangThaiThanhToan = TrangThai.ChuaThanhToan;
            hoaDonNhapHang.HoaDonDatHangId = hoaDonDatHangFind.Id;
            hoaDonNhapHang.CreatedDate = DateTime.Now;
            hoaDonNhapHang.NhaCungCapId = hoaDonDatHangFind.NhaCungCapId;
            hoaDonNhapHang.KhoHangId = "KHO001";

          
            // loại những phiên bản sản phẩm có số lượng nhập <= 0 (tức không nhập số lượng nhập) và những phiên bản sản phẩm đã đặt đủ số lượng
            hoaDonNhapHang.ChiTietHoaDonNhapHangs = DieuChinhChiTietHoaDonNhapHang(hoaDonNhapHang, hoaDonDatHangId);


            XuLyChiTIetHoaDonNhapHang(hoaDonNhapHang.ChiTietHoaDonNhapHangs, hoaDonNhapHang, hoaDonDatHangFind);



            db.HoaDonNhapHang.Add(hoaDonNhapHang);
            db.SaveChanges();

            // cập nhật trạng thái của hóa đơn đặt hàng
            bool capNhatTrangThaiKhiDatXong = this.KiemTraSoLuongNhap(hoaDonDatHangFind);
            if (capNhatTrangThaiKhiDatXong)
            {
                hoaDonDatHangService.CapNhatTrangThaiDonDatHang(hoaDonDatHangFind.Id, TrangThai.HoanThanh);
            }
            else
            {
                hoaDonDatHangService.CapNhatTrangThaiDonDatHang(hoaDonDatHangFind.Id, TrangThai.NhapMotPhan);
            }
        }

        public bool KiemTraSoLuongNhap(HoaDonDatHang hoaDonDatHang)
        {
            bool kiemTra = false;
            foreach (var chiTiet in hoaDonDatHang.ChiTietHoaDonDatHangs)
            {
                if (chiTiet.SoLuongDat == chiTiet.SoLuongDaNhap)
                    kiemTra = true;
                else
                    kiemTra = false;
            }
            return kiemTra;

        }

        public List<ChiTietHoaDonNhapHang> DieuChinhChiTietHoaDonNhapHang(HoaDonNhapHang hoaDonNhapHang, string hoaDonDatHangID)
        {
            // loại bỏ những sản phẩm có số lượng < 0
            List<ChiTietHoaDonNhapHang> chiTiets = hoaDonNhapHang.ChiTietHoaDonNhapHangs
                    .Where(chiTiet => chiTiet.SoLuongNhap > 0)
                    .ToList();

            // loại bỏ những sản phẩm đã đủ số lượng đặt hàng
            foreach(var chiTiet in chiTiets)
            {
                ChiTietHoaDonDatHang chiTietHoaDonDatHang = hoaDonDatHangService
                    .GetChiTietHoaDonDatHangFromDonNhapHang(hoaDonDatHangID, chiTiet.PhienBanSanPhamId);
                if(chiTietHoaDonDatHang.SoLuongDaNhap == chiTiet.SoLuongNhap)
                    chiTiets.Remove(chiTiet);
            }
            return chiTiets;
        }

        public void XuLyChiTIetHoaDonNhapHang(List<ChiTietHoaDonNhapHang> chiTietHoaDonNhapHangs, HoaDonNhapHang hoaDonNhapHang, HoaDonDatHang hoaDonDatHang)
        {
            foreach (var chiTiet in hoaDonNhapHang.ChiTietHoaDonNhapHangs)
            {
                chiTiet.Id = GenerateId.TaoMaChiTietHoaDonNhapHang();
                chiTiet.HoaDonNhapHangId = hoaDonNhapHang.Id;

                // nếu số lượng nhập nhiều hơn số lượng đặt còn lại thì sẽ gán số lượng còn lại = số lượng nhập
                ChiTietHoaDonDatHang chiTietHoaDonDatHang = hoaDonDatHangService
                    .GetChiTietHoaDonDatHangFromDonNhapHang(hoaDonDatHang.Id, chiTiet.PhienBanSanPhamId);
                if (chiTiet.SoLuongNhap > hoaDonDatHangService.GetSoLuongDatChiTietConLai(hoaDonDatHang.Id, chiTiet.PhienBanSanPhamId))
                {
                    chiTiet.SoLuongNhap = hoaDonDatHangService.GetSoLuongDatChiTietConLai(hoaDonDatHang.Id, chiTiet.PhienBanSanPhamId);
                    hoaDonDatHangService.CapNhatSoLuongNhapDonDatHang(chiTietHoaDonDatHang.Id, chiTiet.SoLuongNhap);

                }
                else
                    hoaDonDatHangService.CapNhatSoLuongNhapDonDatHang(chiTietHoaDonDatHang.Id, chiTiet.SoLuongNhap);

                PhienBanSanPham? phienBanSanPham = phienBanSanPhamService.GetPhienBanSanPhamByPhienBanId(chiTiet.PhienBanSanPhamId);
                // quy đổi số lượng sản phẩm về đơn vị nhỏ nhất (phiên bản mặc định)
                if (phienBanSanPham.TenQuyDoi.Contains("Mặc định"))
                {
                    chiTiet.LoHang.SoLuongQuyDoi = chiTiet.SoLuongNhap;
                }
                else
                {
                    chiTiet.LoHang.SoLuongQuyDoi = chiTiet.SoLuongNhap * phienBanSanPham.SoLuong;
                }

                var existingLoHang = db.LoHang.FirstOrDefault(l => l.Id == chiTiet.LoHang.Id);
                if (existingLoHang != null)
                {
                    // Gán lại Id của lô hàng đã tồn tại
                    chiTiet.LoHang.Id = existingLoHang.Id;
                    chiTiet.LoHang = existingLoHang;

                    // Cập nhật số lượng quy đổi thay vì thêm mới
                    loHangService.CapNhatLoHang(existingLoHang, chiTiet.LoHang.SoLuongQuyDoi);

                }
                else
                {
                    chiTiet.LoHang.Id = GenerateId.TaoMaLoHang();
                    chiTiet.LoHang.NhaCungCapId = hoaDonDatHang.NhaCungCapId;
                    chiTiet.LoHang.KhoHangId = hoaDonNhapHang.KhoHangId;
                    chiTiet.LoHang.PhienBanSanPhamId = chiTiet.PhienBanSanPhamId;
                    db.LoHang.Add(chiTiet.LoHang);
                    chiTiet.LoHangId = chiTiet.LoHang.Id;
                    
                }

                chiTiet.Gia = phienBanSanPham.GiaNhapQuyDoi; // 1000, 300000
                hoaDonNhapHang.Thue = 0.1;
                hoaDonNhapHang.TongTien = hoaDonNhapHang.TongTien + ((decimal)chiTiet.SoLuongNhap * chiTiet.Gia);
                hoaDonNhapHang.ThanhTien = hoaDonNhapHang.TongTien + (hoaDonNhapHang.TongTien * (decimal)hoaDonNhapHang.Thue);
            }

        }
    }


}

