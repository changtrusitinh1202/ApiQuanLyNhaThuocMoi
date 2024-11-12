using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.DTOs;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.Enum;
using ApiQuanLyNhaThuoc.Utility;
using Azure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Utility;

namespace ApiQuanLyNhaThuoc.Business.Service
{
    public class HoaDonBanHangService : IHoaDonBanHangService
    {
        ApplicationDbContext db;
        public IPhienBanSanPhamService phienBanSanPhamService;
        private readonly IServiceProvider serviceProvider;
        IWebHostEnvironment hostingEnvironment;
        IEmailSender emailSender;
        public string css = "width = \"25%\" style=\"padding: 10px; word-break: break-word; border-top: 1px solid transparent; border-right: 1px solid transparent; border-bottom: 1px solid transparent; border-left: 1px solid transparent;\"";
        public HoaDonBanHangService(ApplicationDbContext db, 
            IPhienBanSanPhamService phienBanSanPhamService, 
            IServiceProvider serviceProvider,
            IWebHostEnvironment hostingEnvironment, IEmailSender emailSender)
        {
            this.db = db;
            this.phienBanSanPhamService = phienBanSanPhamService;
            this.hostingEnvironment = hostingEnvironment;
            this.serviceProvider = serviceProvider;
            this.emailSender = emailSender;
        }

        private IKhachHangService KhachHangService => serviceProvider.GetService<IKhachHangService>();

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
            if (khachHang == null) // khách lẻ mua trực tiếp không cho thông tin
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

        public void AddHoaDonBanHangOnline(string token,  HoaDonBanHangOnline hoaDonBanHang, GiaoHangDTO giaoHangDTO) // khách hàng mua online và có tài khoản
        {
            string content = "";
            int freeShip = 0;
            KhachHangDTO khachHang = KhachHangService.GetKhachHangByToken(token);
            hoaDonBanHang.Id = GenerateId.TaoMaHoaDonBanHang(); // tự tạo mã hóa đơn
            hoaDonBanHang.KhachHangId = khachHang.Id; // lấy id khách hàng từ token
            hoaDonBanHang.CreatedDate = DateTime.Now; // ngày tạo hóa đơn
            hoaDonBanHang.ModifiedDate = DateTime.Now;
            hoaDonBanHang.HinhThucMuaHang = "Online";
            hoaDonBanHang.TrangThaiDonHang = TrangThai.ChoXacNhan;
            hoaDonBanHang.KhuyenMaiId = null; // không có mã khuyến mãi
            hoaDonBanHang.NhanVienId = null; // không có nhân viên
            //hình thức thanh toán bao gồm thanh toán trả trước và thanh toán sau khi nhận hàng
            //hoaDonBanHang.HinhThucThanhToan
            if (hoaDonBanHang.HinhThucThanhToan == "Thanh toán trả trước")
            {
                hoaDonBanHang.HinhThucThanhToan = "Thanh toán trả trước";
                hoaDonBanHang.TrangThaiThanhToan = "Đã thanh toán";
            }
            else // nếu chọn thanh toán sau khi nhận hàng
            {
                hoaDonBanHang.HinhThucThanhToan = "Thanh toán trả sau khi nhận hàng";
                hoaDonBanHang.TrangThaiThanhToan = "Chưa thanh toán";
            }

            List<ChiTietHoaDonBanHangOnline> chiTiets = new List<ChiTietHoaDonBanHangOnline>();
            List<ChiTietHoaDonDTO> chiTietHoaDonDTOs = new List<ChiTietHoaDonDTO>();
            foreach (var chiTiet in hoaDonBanHang.ChiTietHoaDonBanHangs)
            {
                PhienBanSanPham phienBanSanPham = phienBanSanPhamService.GetPhienBanSanPhamByPhienBanId(chiTiet.PhienBanSanPhamId);
                ChiTietHoaDonDTO chiTietHoaDonDTO = new ChiTietHoaDonDTO
                {
                    TenHangHoa = phienBanSanPham.TenQuyDoi,
                    KhoiLuong = ChuyenDoiDonVi.ChuyenDoiDonViKhoiLuong(phienBanSanPham.KhoiLuong) * chiTiet.SoLuong,
                    SoLuong = chiTiet.SoLuong
                };
                chiTietHoaDonDTOs.Add(chiTietHoaDonDTO);
                chiTiet.Id = GenerateId.TaoMaChiTietHoaDonBanHang();
                chiTiet.HoaDonId = hoaDonBanHang.Id;
                chiTiet.Gia = (double)phienBanSanPham.GiaBanQuyDoi;
                hoaDonBanHang.TongTien = hoaDonBanHang.TongTien + ((decimal)chiTiet.Gia * (decimal)chiTiet.SoLuong);
                chiTiets.Add(chiTiet);
            }
            hoaDonBanHang.ChiTietHoaDonBanHangs = chiTiets;
            hoaDonBanHang.Thue = 0.1;

            var hoaDonCoThue = hoaDonBanHang.TongTien + (hoaDonBanHang.TongTien * (decimal)hoaDonBanHang.Thue);

            if(hoaDonBanHang.TongTien <= 10000)
                throw new Exception("Giao hàng online không hỗ trợ giao các hóa đơn nhỏ hơn 10.000 đ");

            CallGHTKApi(hoaDonBanHang, out content, out freeShip, giaoHangDTO, chiTietHoaDonDTOs);

            var jsonResponse = JObject.Parse(content); // trả về dữ liệu json
            var phiVanChuyen = (decimal?)jsonResponse["order"]?["fee"] ?? 0;
            var isFreeShip = freeShip;
            var trackingNumber = (long?)jsonResponse["order"]?["tracking_id"] ?? 0;

            hoaDonBanHang.GiaoHang = new GiaoHang
            {
                Id = (string?)jsonResponse["order"]?["label"],
                MaDonRutGon = (string?)jsonResponse["order"]?["sorting_code"],
                TenNguoiGui = "Chưa có", // tên nhân viên gửi hàng
                SoDienThoaiNguoiGui = "0987666111", // số điện thoại nhân viên gửi hàng mặc định
                DiaChiNguoiGui = "102/19, Lê Lợi", // nơi để shipper lấy hàng
                QuanHuyenNguoiGui = "Quận Gò Vấp",
                TinhThanhNguoiGui = "TP. Hồ Chí Minh",
                TenNguoiNhan = giaoHangDTO.TenNguoiNhan,
                SoDienThoaiNguoiNhan = giaoHangDTO.SoDienThoaiNguoiNhan,
                DiaChiNguoiNhan = giaoHangDTO.DiaChiNguoiNhan,
                XaPhuongNguoiNhan = giaoHangDTO.XaPhuongNguoiNhan,
                QuanHuyenNguoiNhan = giaoHangDTO.QuanHuyenNguoiNhan,
                TinhThanhNguoiNhan = giaoHangDTO.TinhThanhNguoiNhan,
                TrackingNumber = trackingNumber,
                ThoiGianLayHangDuKien = (string?)jsonResponse["order"]?["estimated_pick_time"],
                ThoiGianGiaoHangDuKien = (string?)jsonResponse["order"]?["estimated_deliver_time"]
            };

            if (isFreeShip == 0)
            {
                hoaDonBanHang.PhiVanChuyen = phiVanChuyen;
                hoaDonBanHang.ThanhTien = hoaDonBanHang.TongTien + (hoaDonBanHang.TongTien * (decimal)hoaDonBanHang.Thue) + phiVanChuyen;
            }

            else
                hoaDonBanHang.ThanhTien = hoaDonBanHang.TongTien + (hoaDonBanHang.TongTien * (decimal)hoaDonBanHang.Thue);

            hoaDonBanHang.Timeline = hoaDonBanHang.Timeline
                .Where(t => t.Status != "string")
                .ToList();

            hoaDonBanHang.Timeline.Add(new TrangThaiHoaDonOnline
            {
                HoaDonBanHangOnlineId = hoaDonBanHang.Id,
                Status = "Đã đặt",
                ThoiGian = DateTime.Now
            });
    
            
            db.HoaDonBanHangOnline.Add(hoaDonBanHang);
            db.SaveChanges();




            var khachHangId = hoaDonBanHang.KhachHangId;
            var danhSachSanPhamTrongGio = db.GioHang
                 .Where(g => g.KhachHangId == khachHangId)
                 .AsEnumerable() 
                 .Where(g => hoaDonBanHang.ChiTietHoaDonBanHangs.Any(h => h.PhienBanSanPhamId == g.PhienBanSanPhamId))
                 .ToList();

            db.GioHang.RemoveRange(danhSachSanPhamTrongGio);
            db.SaveChanges();


        }

        private static void CallGHTKApi(HoaDonBanHangOnline hoaDonBanHang, out string content, out int freeShip, GiaoHangDTO giaoHangDTO, List<ChiTietHoaDonDTO> chiTietHoaDonDTOs)
        {
            content = "";
            freeShip = 0;
            var hoaDonGomThue = hoaDonBanHang.TongTien + (hoaDonBanHang.TongTien * (decimal)hoaDonBanHang.Thue);
            if (hoaDonGomThue > 500000) // nếu tổng tiền lớn hơn 500k thì freeship (đã bao gồm thuế)
                giaoHangDTO.FreeShip = 1;
            else
                giaoHangDTO.FreeShip = 0;

            var requestData = new
            {
                products = chiTietHoaDonDTOs.Select(p => new
                {
                    name = p?.TenHangHoa,
                    weight = p?.KhoiLuong,
                    quantity = p?.SoLuong
                }).ToList(),
                order = new
                {
                    id = hoaDonBanHang.Id,
                    pick_name = "Chưa có", //tên nhân viên gửi hàng
                    pick_address = "102/19, Lê Lợi", // nơi để shipper lấy hàng
                    pick_province = "TP. Hồ Chí Minh",
                    pick_district = "Quận Gò Vấp",
                    pick_ward = "Phường 4",
                    pick_tel = "0987666111", //số điện thoại nhân viên gửi hàng mặc định
                    tel = giaoHangDTO.SoDienThoaiNguoiNhan,
                    name = giaoHangDTO.TenNguoiNhan,
                    address = giaoHangDTO.DiaChiNguoiNhan,
                    province = giaoHangDTO.TinhThanhNguoiNhan,
                    district = giaoHangDTO.QuanHuyenNguoiNhan,
                    ward = giaoHangDTO.QuanHuyenNguoiNhan,
                    hamlet = "Khác",
                    is_freeship = giaoHangDTO.FreeShip,
                    pick_money = hoaDonGomThue,
                    value = hoaDonGomThue,
                    pick_option = "cod",
                    deliver_option = "xfast"
                }
            };
            freeShip = giaoHangDTO.FreeShip ?? 0;


            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Token", "3f4176ed163e26e0c511c1dc5df9bdc273ff64cf");
                httpClient.DefaultRequestHeaders.Add("X-Client-Source", "S308157");

                var jsonContent = JsonConvert.SerializeObject(requestData);
                var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");


                var orderResponse = httpClient.PostAsync("https://services.giaohangtietkiem.vn/services/shipment/order", contentString).Result;
                long trackingNumber = 0;



                var responseString = orderResponse.Content.ReadAsStringAsync().Result;
                var jsonResponse = JObject.Parse(responseString);
                content = responseString;
                trackingNumber = (long?)jsonResponse["order"]?["tracking_id"] ?? 0;


                //var request = new HttpRequestMessage(HttpMethod.Get,
                //   $"https://services.giaohangtietkiem.vn/services/label/{trackingNumber}?original=true&paper_size=A5");


                //request.Headers.Add("Token", "3f4176ed163e26e0c511c1dc5df9bdc273ff64cf");
                //request.Headers.Add("X-Client-Source", "S308157");


                var response1 = httpClient.PostAsync($"https://services.giaohangtietkiem.vn/services/shipment/cancel/{trackingNumber}", contentString).Result;

            }
        }


        public static void HuyDonHang(int trackingNumber)
        {

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Token", "3f4176ed163e26e0c511c1dc5df9bdc273ff64cf");
                httpClient.DefaultRequestHeaders.Add("X-Client-Source", "S308157");

                var jsonContent = JsonConvert.SerializeObject(null);
                var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = httpClient.PostAsync($"https://services.giaohangtietkiem.vn/services/shipment/cancel/{trackingNumber}", contentString).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Đã hủy đơn hàng thành công!");
                }
                else
                {
                    Console.WriteLine("Lỗi khi hủy đơn hàng: " + response.StatusCode);
                }
            }
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

        public void XacNhanDonHang(string hoaDonId)
        {
            var hoaDon = db.HoaDonBanHangOnline.FirstOrDefault(hd => hd.Id == hoaDonId);
            var trangThaiHoaDon = new TrangThaiHoaDonOnline
            {
                HoaDonBanHangOnlineId = hoaDonId,
                Status = TrangThai.DaXacNhan,
                ThoiGian = DateTime.Now
            };

            if (hoaDon != null)
            {
                hoaDon.TrangThaiDonHang = TrangThai.DaXacNhan;
                db.TrangThaiHoaDonOnline.Add(trangThaiHoaDon);
                db.SaveChanges();
            }
        }

        public void XacNhanChuanBiHang(string hoaDonId)
        {
            var hoaDon = db.HoaDonBanHangOnline.FirstOrDefault(hd => hd.Id == hoaDonId);
            var trangThaiHoaDon = new TrangThaiHoaDonOnline
            {
                HoaDonBanHangOnlineId = hoaDonId,
                Status = TrangThai.DangChuanBi,
                ThoiGian = DateTime.Now
            };

            if (hoaDon != null && hoaDon.TrangThaiDonHang == TrangThai.DaXacNhan)
            {
                hoaDon.TrangThaiDonHang = TrangThai.DangChuanBi;
                db.TrangThaiHoaDonOnline.Add(trangThaiHoaDon);
                db.SaveChanges();
            }
        }

        public void XacNhanVanChuyen(string hoaDonId)
        {
            var hoaDon = db.HoaDonBanHangOnline.FirstOrDefault(hd => hd.Id == hoaDonId);
            var trangThaiHoaDon = new TrangThaiHoaDonOnline
            {
                HoaDonBanHangOnlineId = hoaDonId,
                Status = TrangThai.DangVanChuyen,
                ThoiGian = DateTime.Now
            };

            if (hoaDon != null && hoaDon.TrangThaiDonHang == TrangThai.DangChuanBi)
            {
                hoaDon.TrangThaiDonHang = TrangThai.DangVanChuyen;
                db.TrangThaiHoaDonOnline.Add(trangThaiHoaDon);
                db.SaveChanges();
            }
        }

     

        public void XacNhanDaGiaoHang(string hoaDonId)
        {
            var hoaDon = db.HoaDonBanHangOnline.FirstOrDefault(hd => hd.Id == hoaDonId);
            var trangThaiHoaDon = new TrangThaiHoaDonOnline
            {
                HoaDonBanHangOnlineId = hoaDonId,
                Status = TrangThai.DaGiaoHang,
                ThoiGian = DateTime.Now
            };

            if (hoaDon != null && hoaDon.TrangThaiDonHang == TrangThai.DangVanChuyen)
            {
                hoaDon.TrangThaiDonHang = TrangThai.DaGiaoHang;
                db.TrangThaiHoaDonOnline.Add(trangThaiHoaDon);
                db.SaveChanges();
            }
        }

        public void XacNhanHuyDonHang(string hoaDonId)
        {
            var hoaDon = db.HoaDonBanHangOnline.FirstOrDefault(hd => hd.Id == hoaDonId);
            var trangThaiHoaDon = new TrangThaiHoaDonOnline
            {
                HoaDonBanHangOnlineId = hoaDonId,
                Status = TrangThai.DaHuy,
                ThoiGian = DateTime.Now
            };

            if (hoaDon != null)
            {
                if(hoaDon.TrangThaiDonHang == TrangThai.DaGiaoHang || hoaDon.TrangThaiDonHang == TrangThai.DangVanChuyen)
                {
                    throw new Exception("Đơn đã vận chuyển hoặc đã giao không thể hủy");
              
                }
                else if(hoaDon.TrangThaiDonHang == TrangThai.DaHuy)
                    throw new Exception("Đơn hàng này đã được hủy trước đó");
                else
                {
                    hoaDon.TrangThaiDonHang = TrangThai.DaHuy;
                    db.TrangThaiHoaDonOnline.Add(trangThaiHoaDon);
                    db.SaveChanges();
                }
                
              
            }
        }

        public List<HoaDonBanHangOnline> GetHoaDonBanHangs()
        {
            List<HoaDonBanHangOnline> hoaDons = db.HoaDonBanHangOnline.AsNoTracking()             
                .Include(g => g.GiaoHang)
                .ToList();
            return hoaDons;
        }

        public List<HoaDonBanHangOnline> GetHoaDonBanHangOnlineChoXacNhan()
        {
            List<HoaDonBanHangOnline> hoaDons = db.HoaDonBanHangOnline.AsNoTracking()
                .Include(kh => kh.KhachHang)
                .Include(g => g.GiaoHang)
                .Where(hd => hd.TrangThaiDonHang == TrangThai.ChoXacNhan)
                .ToList();
            return hoaDons;
        }

        public List<HoaDonBanHangOnline> GetHoaDonBanHangOnlineXacNhanDon()
        {
            List<HoaDonBanHangOnline> hoaDons = db.HoaDonBanHangOnline.AsNoTracking()
             .Include(kh => kh.KhachHang)
             .Include(g => g.GiaoHang)
             .Where(hd => hd.TrangThaiDonHang == TrangThai.DaXacNhan)
             .ToList();
            return hoaDons;
        }

        public List<HoaDonBanHangOnline> GetHoaDonBanHangOnlineChuanBiHang()
        {
            List<HoaDonBanHangOnline> hoaDons = db.HoaDonBanHangOnline.AsNoTracking()
             .Include(kh => kh.KhachHang)
             .Include(g => g.GiaoHang)
             .Where(hd => hd.TrangThaiDonHang == TrangThai.DangChuanBi)
             .ToList();
            return hoaDons;
        }

        public List<HoaDonBanHangOnline> GetHoaDonBanHangOnlineVanChuyen()
        {
            List<HoaDonBanHangOnline> hoaDons = db.HoaDonBanHangOnline.AsNoTracking()
             .Include(kh => kh.KhachHang)
             .Include(g => g.GiaoHang)
             .Where(hd => hd.TrangThaiDonHang == TrangThai.DangVanChuyen)
             .ToList();
            return hoaDons;
        }

        public List<HoaDonBanHangOnline> GetHoaDonBanHangOnlineDaGiao()
        {
            List<HoaDonBanHangOnline> hoaDons = db.HoaDonBanHangOnline.AsNoTracking()
             .Include(kh => kh.KhachHang)
             .Include(g => g.GiaoHang)
             .Where(hd => hd.TrangThaiDonHang == TrangThai.DaGiaoHang)
             .ToList();
            return hoaDons;
        }

        public List<HoaDonBanHangOnline> GetHoaDonBanHangOnlineHuyDon()
        {
            List<HoaDonBanHangOnline> hoaDons = db.HoaDonBanHangOnline.AsNoTracking()
             .Include(kh => kh.KhachHang)
             .Include(g => g.GiaoHang)
             .Where(hd => hd.TrangThaiDonHang == TrangThai.DaHuy)
             .ToList();
            return hoaDons;
        }

        public List<HoaDonBanHangOnline> GetHoaDonBanHangOnlineOfKhachHang(string token)
        {
            KhachHangDTO khachHangDTO = KhachHangService.GetKhachHangByToken(token);
            if(khachHangDTO == null)
            {
                throw new Exception("Không tìm thấy khách hàng");
            }
            else
            {
                List<HoaDonBanHangOnline> hoaDons = db.HoaDonBanHangOnline.AsNoTracking()
                  .Include(kh => kh.KhachHang)
                  .Include(g => g.GiaoHang)
                  .Where(hd => hd.KhachHangId == khachHangDTO.Id)
                  .ToList();
                return hoaDons;
            }
         
        }
    }
}
