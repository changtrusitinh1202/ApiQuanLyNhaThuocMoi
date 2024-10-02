using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace ApiQuanLyNhaThuoc.Business.Service
{
    public class HoaDonBanHangService : IHoaDonBanHangService
    {
        ApplicationDbContext db;
        public IPhienBanSanPhamService phienBanSanPhamService;
       
        public HoaDonBanHangService(ApplicationDbContext db, IPhienBanSanPhamService phienBanSanPhamService)
        {
            this.db = db;
            this.phienBanSanPhamService = phienBanSanPhamService;
        }
        public void AddHoaDonBanHangTrucTiep(HoaDonBanHang hoaDonBanHang)
        {
            hoaDonBanHang.Id = GenerateId.TaoMaHoaDonBanHang();
            hoaDonBanHang.CreatedDate = DateTime.Now;
            hoaDonBanHang.ModifiedDate = DateTime.Now;

            foreach (var chiTiet in hoaDonBanHang.ChiTietHoaDonBanHangs)
            {
                chiTiet.Id = GenerateId.TaoMaChiTietHoaDonBanHang();
                chiTiet.HoaDonId = hoaDonBanHang.Id;
                hoaDonBanHang.TongTien = hoaDonBanHang.TongTien + ((decimal)chiTiet.Gia * (decimal)chiTiet.SoLuong);
                hoaDonBanHang.ChiTietHoaDonBanHangs.Add(chiTiet);
            }
            hoaDonBanHang.Thue = 0.1;
            hoaDonBanHang.ThanhTien = hoaDonBanHang.TongTien + (hoaDonBanHang.TongTien * (decimal)hoaDonBanHang.Thue);
            if(hoaDonBanHang.KhachHangId == null) // khách lẻ mua trực tiếp không cho thông tin
            {
                hoaDonBanHang.HinhThucMuaHang = "Tại quầy";
                hoaDonBanHang.TrangThaiThanhToan = "Đã thanh toán";
                hoaDonBanHang.TrangThaiDonHang = "Hoàn thành";
            }
            else 
            {
                hoaDonBanHang.HinhThucMuaHang = "Online";
            }
            db.HoaDonBanHang.Add(hoaDonBanHang);
            db.SaveChanges();
        }

        public void AddHoaDonBanHangOnline(HoaDonBanHang hoaDonBanHang) // khách hàng mua online và có tài khoản
        {
            hoaDonBanHang.Id = GenerateId.TaoMaHoaDonBanHang(); // tự tạo mã hóa đơn
            hoaDonBanHang.CreatedDate = DateTime.Now; // ngày tạo hóa đơn
            hoaDonBanHang.ModifiedDate = DateTime.Now;
            hoaDonBanHang.HinhThucMuaHang = "Online";
            hoaDonBanHang.TrangThaiDonHang = "Đã đặt";
            hoaDonBanHang.KhuyenMaiId = null; // không có mã khuyến mãi

            //hình thức thanh toán bao gồm thanh toán trả trước và thanh toán sau khi nhận hàng
            //hoaDonBanHang.HinhThucThanhToan
            if(hoaDonBanHang.HinhThucThanhToan == "Thanh toán trả trước")
            {
                hoaDonBanHang.HinhThucThanhToan = "Thanh toán trả trước";
                hoaDonBanHang.TrangThaiThanhToan = "Đã thanh toán";
            }
            else // nếu chọn thanh toán sau khi nhận hàng
            {
                hoaDonBanHang.HinhThucThanhToan = "Thanh toán trả sau khi nhận hàng";
                hoaDonBanHang.TrangThaiThanhToan = "Chưa thanh toán";
            }

            List<ChiTietHoaDonBanHang> chiTiets = new List<ChiTietHoaDonBanHang>();

            foreach (var chiTiet in hoaDonBanHang.ChiTietHoaDonBanHangs)
            {
                PhienBanSanPham phienBanSanPham = phienBanSanPhamService.GetPhienBanSanPhamByPhienBanId(chiTiet.PhienBanSanPhamId);
                chiTiet.Id = GenerateId.TaoMaChiTietHoaDonBanHang();
                chiTiet.HoaDonId = hoaDonBanHang.Id;
                chiTiet.Gia = (double)phienBanSanPham.GiaBanQuyDoi;
                hoaDonBanHang.TongTien = hoaDonBanHang.TongTien + ((decimal)chiTiet.Gia * (decimal)chiTiet.SoLuong);
                chiTiets.Add(chiTiet);
            }
            hoaDonBanHang.ChiTietHoaDonBanHangs = chiTiets;
            hoaDonBanHang.Thue = 0.1;
            hoaDonBanHang.ThanhTien = hoaDonBanHang.TongTien + (hoaDonBanHang.TongTien * (decimal)hoaDonBanHang.Thue);
           
            db.HoaDonBanHang.Add(hoaDonBanHang);
            db.SaveChanges();
        }

        public HoaDonBanHang GetHoaDonBanHangById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
