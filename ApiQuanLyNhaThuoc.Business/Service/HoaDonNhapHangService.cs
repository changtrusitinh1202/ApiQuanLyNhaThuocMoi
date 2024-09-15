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


        public void AddHoaDon(HoaDonNhapHang hoaDonNhapHang, Guid hoaDonDatHangId)
        {
            HoaDonDatHang hoaDonDatHangFind = hoaDonDatHangService.GetHoaDonDatHangById(hoaDonDatHangId);
            bool capNhatTrangThai = this.KiemTraSoLuongNhap(hoaDonDatHangFind);

            if (hoaDonDatHangFind == null)
                throw new Exception("Đơn đặt hàng không tồn tại");

            if (hoaDonDatHangFind != null && capNhatTrangThai)
                throw new Exception("Đơn đặt hàng đã được nhập đủ");

            hoaDonNhapHang.Id = Guid.NewGuid();
            hoaDonNhapHang.TrangThaiThanhToan = TrangThai.ChuaThanhToan;
            hoaDonNhapHang.HoaDonDatHangId = hoaDonDatHangFind.Id;
            hoaDonNhapHang.NgayNhapHang = DateTime.Now;
            hoaDonNhapHang.NhaCungCapId = hoaDonDatHangFind.NhaCungCapId;
            hoaDonNhapHang.KhoHangId = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6");

            // loại những phiên bản sản phẩm có số lượng nhập <= 0 (tức không nhập số lượng nhập) và những phiên bản sản phẩm đã đặt đủ số lượng
            hoaDonNhapHang.ChiTietHoaDonNhapHangs = this.DieuChinhChiTietHoaDonNhapHang(hoaDonNhapHang, hoaDonDatHangId);

            if (!hoaDonNhapHang.ChiTietHoaDonNhapHangs.Any())
                throw new Exception("Không có sản phẩm nào trong đơn nhập hàng");

            foreach (var chiTiet in hoaDonNhapHang.ChiTietHoaDonNhapHangs)
            {
                chiTiet.Id = Guid.NewGuid();
                chiTiet.HoaDonNhapHangId = hoaDonNhapHang.Id;

                // nếu số lượng nhập nhiều hơn số lượng đặt còn lại thì sẽ gán số lượng còn lại = số lượng nhập
                ChiTietHoaDonDatHang chiTietHoaDonDatHang = hoaDonDatHangService
                    .GetChiTietHoaDonDatHangFromDonNhapHang(hoaDonDatHangId, chiTiet.PhienBanSanPhamId);
                if (chiTiet.SoLuongNhap > hoaDonDatHangService.GetSoLuongDatChiTietConLai(hoaDonDatHangId, chiTiet.PhienBanSanPhamId))
                {
                    chiTiet.SoLuongNhap = hoaDonDatHangService.GetSoLuongDatChiTietConLai(hoaDonDatHangId, chiTiet.PhienBanSanPhamId);
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

                var existingLoHang = db.LoHang.FirstOrDefault(l => l.MaLoHang == chiTiet.LoHang.MaLoHang );
                if (existingLoHang != null)
                {
                    // Gán lại Id của lô hàng đã tồn tại
                    chiTiet.LoHang.Id = existingLoHang.Id;
                    chiTiet.LoHang.NhaCungCapId = hoaDonDatHangFind.NhaCungCapId;
                    chiTiet.LoHang.KhoHangId = hoaDonNhapHang.KhoHangId;
                    chiTiet.LoHang.PhienBanSanPhamId = chiTiet.PhienBanSanPhamId;
                    chiTiet.LoHangId = existingLoHang.Id;

                    // Cập nhật số lượng quy đổi thay vì thêm mới
                    loHangService.CapNhatLoHang(existingLoHang.MaLoHang, chiTiet.LoHang.SoLuongQuyDoi);

                    // Ngăn việc đính kèm lô hàng vào DbContext nhiều lần
                    db.Entry(existingLoHang).State = EntityState.Modified;  
                }
                else
                {
                    chiTiet.LoHang.Id = Guid.NewGuid();
                    chiTiet.LoHang.NhaCungCapId = hoaDonDatHangFind.NhaCungCapId;
                    chiTiet.LoHang.KhoHangId = hoaDonNhapHang.KhoHangId;
                    chiTiet.LoHang.PhienBanSanPhamId = chiTiet.PhienBanSanPhamId;
                    db.LoHang.Add(chiTiet.LoHang);
                    chiTiet.LoHangId = chiTiet.LoHang.Id;
                }
    
        

                chiTiet.Gia = phienBanSanPham.GiaNhapQuyDoi; // 1000, 300000
                hoaDonNhapHang.TongTien = hoaDonNhapHang.TongTien + ((decimal)chiTiet.SoLuongNhap * chiTiet.Gia);

            }
          
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

        public ICollection<ChiTietHoaDonNhapHang> DieuChinhChiTietHoaDonNhapHang(HoaDonNhapHang hoaDonNhapHang, Guid hoaDonDatHangID)
        {
            // loại bỏ những sản phẩm có số lượng < 0
            ICollection<ChiTietHoaDonNhapHang> chiTiets = hoaDonNhapHang.ChiTietHoaDonNhapHangs
                    .Where(chiTiet => chiTiet.SoLuongNhap > 0)
                    .ToList();

            // loại bỏ những sản phẩm đã đủ số lượng đặt hàng
            foreach(var chiTiet in chiTiets)
            {
                ChiTietHoaDonDatHang chiTietHoaDonDatHang = hoaDonDatHangService
                    .GetChiTietHoaDonDatHangFromDonNhapHang(hoaDonDatHangID, chiTiet.PhienBanSanPhamId);
                if(chiTietHoaDonDatHang.SoLuongDat == chiTiet.SoLuongNhap)
                    chiTiets.Remove(chiTiet);
            }
            return chiTiets;
        }
    }


}

