using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace ApiQuanLyNhaThuoc.Business.Service
{
    public class HoaDonBanHangService : IHoaDonBanHangService
    {
        ApplicationDbContext db;
        public IPhienBanSanPhamService phienBanSanPhamService;
        IWebHostEnvironment hostingEnvironment;
        IEmailSender emailSender;
        public string css = "width = \"25%\" style=\"padding: 10px; word-break: break-word; border-top: 1px solid transparent; border-right: 1px solid transparent; border-bottom: 1px solid transparent; border-left: 1px solid transparent;\"";
        public HoaDonBanHangService(ApplicationDbContext db, IPhienBanSanPhamService phienBanSanPhamService, IWebHostEnvironment hostingEnvironment, IEmailSender emailSender)
        {
            this.db = db;
            this.phienBanSanPhamService = phienBanSanPhamService;
            this.hostingEnvironment = hostingEnvironment;
            this.emailSender = emailSender;
        }
        public void AddHoaDonBanHangTrucTiep(HoaDonBanHang hoaDonBanHang, string nhanVienId)
        {
            hoaDonBanHang.Id = GenerateId.TaoMaHoaDonBanHang();
            hoaDonBanHang.CreatedDate = DateTime.Now;
            hoaDonBanHang.ModifiedDate = DateTime.Now;
            hoaDonBanHang.KhuyenMaiId = null;
            hoaDonBanHang.NhanVienId = nhanVienId;

            List<ChiTietHoaDonBanHang> chiTiets = new List<ChiTietHoaDonBanHang>();


            foreach (var chiTiet in hoaDonBanHang.ChiTietHoaDonBanHangs)
            {
                chiTiet.Id = GenerateId.TaoMaChiTietHoaDonBanHang();
                chiTiet.HoaDonId = hoaDonBanHang.Id;
                hoaDonBanHang.TongTien = hoaDonBanHang.TongTien + ((decimal)chiTiet.Gia * (decimal)chiTiet.SoLuong);
                chiTiets.Add(chiTiet);
            }
            hoaDonBanHang.ChiTietHoaDonBanHangs = chiTiets;
            hoaDonBanHang.Thue = 0.1;
            hoaDonBanHang.ThanhTien = hoaDonBanHang.TongTien + (hoaDonBanHang.TongTien * (decimal)hoaDonBanHang.Thue);
            KhachHang? khachHang = db.KhachHang.FirstOrDefault(kh => kh.Id == hoaDonBanHang.KhachHangId);
            if(khachHang == null) // khách lẻ mua trực tiếp không cho thông tin
            {
                hoaDonBanHang.HinhThucThanhToan = "Tiền mặt";
                hoaDonBanHang.HinhThucMuaHang = "Tại quầy";
                hoaDonBanHang.TrangThaiThanhToan = "Đã thanh toán";
                hoaDonBanHang.TrangThaiDonHang = "Hoàn thành";
            }
            else
            {
                khachHang.TichDiem = khachHang.TichDiem + (hoaDonBanHang.ThanhTien * (decimal)0.01);
                hoaDonBanHang.HinhThucThanhToan = "Tiền mặt";
                hoaDonBanHang.HinhThucMuaHang = "Tại quầy";
                hoaDonBanHang.TrangThaiThanhToan = "Đã thanh toán";
                hoaDonBanHang.TrangThaiDonHang = "Hoàn thành";
            }
      

            db.HoaDonBanHang.Add(hoaDonBanHang);
            db.SaveChanges();
            //SendMailConfirm(hoaDonBanHang);
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

                var khachHangId = hoaDonBanHang.KhachHangId;
                var danhSachSanPhamTrongGio = db.GioHang
                    .Where(g => g.KhachHangId == khachHangId && hoaDonBanHang.ChiTietHoaDonBanHangs.Any(h => h.PhienBanSanPhamId == g.PhienBanSanPhamId))
                    .ToList();

                db.GioHang.RemoveRange(danhSachSanPhamTrongGio);
                db.SaveChanges();
        }

        public HoaDonBanHang GetHoaDonBanHangById(string id)
        {
            HoaDonBanHang? hoaDonBanHang = db.HoaDonBanHang
                         .Include(ct => ct.ChiTietHoaDonBanHangs)
                         .Include(kh => kh.KhachHang)
                         .Include(km => km.KhuyenMai)
                         .FirstOrDefault(hd => hd.Id == id);
            return hoaDonBanHang;

        }

        public void SendMailConfirm(HoaDonBanHang hoaDonBanHangFind)
        {
            hoaDonBanHangFind = this.GetHoaDonBanHangById(hoaDonBanHangFind.Id);
            DateTime orderDate = DateTime.Parse(hoaDonBanHangFind.CreatedDate.ToString(), System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            string formattedDate = orderDate.ToString("dd/MM/yyyy");
            string contentRootPath = hostingEnvironment.ContentRootPath;
            string contentCustomer = Path.Combine(contentRootPath, "Contents", "send2.html");
            contentCustomer = System.IO.File.ReadAllText(contentCustomer);
            decimal thanhTien = hoaDonBanHangFind.ThanhTien;
            BigInteger total = (int)Math.Floor(thanhTien);
            contentCustomer = contentCustomer.Replace("{{Name}}", "Gia Huy");
            contentCustomer = contentCustomer.Replace("{{City}}", "Hồ Chí Minh");
            contentCustomer = contentCustomer.Replace("{{StreetAddress}}", "102/19, Lê Lợi, Gò Vấp");
            contentCustomer = contentCustomer.Replace("{{Email}}", "phamhagiahuy1708@gmail.com");
            contentCustomer = contentCustomer.Replace("{{OrderDate}}", formattedDate);
            contentCustomer = contentCustomer.Replace("{{Total}}", total.ToString("c", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")));
            var sanpham = "";
            foreach (var item in hoaDonBanHangFind.ChiTietHoaDonBanHangs)
            {
                PhienBanSanPham phienBanSanPham = phienBanSanPhamService.GetPhienBanSanPhamByPhienBanId(item.PhienBanSanPhamId);
                double tongCong = item.Gia * item.SoLuong;
                BigInteger totalItem = (int)Math.Floor(tongCong);
                sanpham += "<tr style=\"background-color:#f9f9f9;\">";
                sanpham += "<td " + css + ">" + phienBanSanPham.TenQuyDoi + "</td>";
                sanpham += "<td " + css + ">" + item.SoLuong + "</td>";
                sanpham += "<td " + css + ">" + item.Gia.ToString("c", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + "</td>";
                sanpham += "<td " + css + ">" + totalItem.ToString("c", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + "</td>";
                sanpham += "</tr>";
            }
            contentCustomer = contentCustomer.Replace("{{ProductList}}", sanpham);

            emailSender.SendEmailAsync("phamhagiahuy1708@gmail.com", "Đơn đặt hàng của bạn", contentCustomer);
        }

     
    }
}
