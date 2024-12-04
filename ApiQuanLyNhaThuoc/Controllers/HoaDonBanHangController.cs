﻿using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Models.DTOs;
using ApiQuanLyNhaThuoc.Models.Models.Entities;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace ApiQuanLyNhaThuoc.Controllers
{
    [Route("/api/hoadonbanhang")]
    public class HoaDonBanHangController : Controller
    {
        public IHoaDonBanHangService hoaDonBanHangService;
        public ITongQuanService tongQuanService;
       // private readonly IHubContext<ThongBaoHub> _hubContext;
        ApplicationDbContext db;
        public HoaDonBanHangController(IHoaDonBanHangService hoaDonBanHangService,
           // IHubContext<ThongBaoHub> hubContext,
            ITongQuanService tongQuanService, 
            ApplicationDbContext db)
        {
            this.hoaDonBanHangService = hoaDonBanHangService;
            this.tongQuanService = tongQuanService;
            this.db = db;
           // _hubContext = hubContext;
        }


        [HttpPost("AddHoaDonBanHangTrucTiep")]
        public IActionResult AddHoaDonBanHangTrucTiep([FromBody] HoaDonBanHang hoaDonBanHang , string nhanVienId)
        {
            if (ModelState.IsValid)
            {
                hoaDonBanHangService.AddHoaDonBanHangTrucTiep(hoaDonBanHang, nhanVienId);
                return Ok(hoaDonBanHang);
            }
            return BadRequest(ModelState);
        }

        [HttpPost("AddHoaDonBanHangOnline")]
        public async Task<IActionResult> AddHoaDonBanHangOnline([FromBody] HoaDonBanHang hoaDonBanHang, string token,GiaoHangDTO giaoHang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                hoaDonBanHangService.AddHoaDonBanHangOnline(token ,hoaDonBanHang, giaoHang);
                string message = "Bạn có hóa đơn bán hàng mới";
                //await _hubContext.Clients.All.SendAsync("ReceiveMessage", "Hyuy", message);
                return Ok(hoaDonBanHang);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Trả về thông báo lỗi trong Exception
            }
         
        }



        [HttpGet("GetTongQuan")]
        public IActionResult GetTongQuan(int nam)
        {
            var tongQuan = tongQuanService.GetTongTienTongQuanTheoThangTrongNam(nam);
            return Ok(tongQuan);
        }

        [HttpPost("XacNhanDonHang")]
        public IActionResult XacNhanDonHang(string hoaDonId)
        {
            if(ModelState.IsValid) 
            {
                hoaDonBanHangService.XacNhanDonHang(hoaDonId);
                return Ok("Xác nhận đơn hàng thành công");
            }
            return BadRequest(ModelState);
        }


        [HttpPost("XacNhanChuanBiHang")]
        public IActionResult XacNhanChuanBiHang(string hoaDonId)
        {
            if (ModelState.IsValid)
            {
                hoaDonBanHangService.XacNhanChuanBiHang(hoaDonId);
                return Ok("Đang chuẩn bị hàng");

            }

            return BadRequest(ModelState);
        }

        [HttpPost("XacNhanVanChuyen")]
        public IActionResult XacNhanVanChuyen(string hoaDonId)
        {
            if (ModelState.IsValid)
            {
                hoaDonBanHangService.XacNhanVanChuyen(hoaDonId);
                return Ok("Đang vận chuyển");
            }
            return BadRequest(ModelState);

        }


        [HttpPost("XacNhanDaGiaoHang")]
        public IActionResult XacNhanDaGiaoHang(string hoaDonId)
        {
            if (ModelState.IsValid)
            {
                hoaDonBanHangService.XacNhanDaGiaoHang(hoaDonId);
                return Ok("Đã giao hàng");
            }
            return BadRequest(ModelState);
        }


        [HttpPost("XacNhanHuyDonHang")]
        public IActionResult XacNhanHuyDonHang(string hoaDonId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                hoaDonBanHangService.XacNhanHuyDonHang(hoaDonId);
                return Ok("Đã hủy đơn hàng");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Trả về thông báo lỗi trong Exception
            }
         
        }

        [HttpGet("GetHoaDonBanHangOnline")]
        public IActionResult GetHoaDonBanHangOnline()
        {
            var hoaDonBanHangs = hoaDonBanHangService.GetHoaDonBanHangs();
            return Ok(hoaDonBanHangs);
        }

        [HttpGet("GetHoaDonBanHangOnlineChoXacNhan")]
        public IActionResult GetHoaDonBanHangOnlineChoXacNhan()
        {
            var hoaDonBanHangs = hoaDonBanHangService.GetHoaDonBanHangOnlineChoXacNhan();
            return Ok(hoaDonBanHangs);
        }

        [HttpGet("GetHoaDonBanHangOnlineXacNhanDon")]
        public IActionResult GetHoaDonBanHangOnlineXacNhanDon()
        {
            var hoaDonBanHangs = hoaDonBanHangService.GetHoaDonBanHangOnlineXacNhanDon();
            return Ok(hoaDonBanHangs);
        }

        [HttpGet("GetHoaDonBanHangOnlineChuanBiHang")]
        public IActionResult GetHoaDonBanHangOnlineChuanBiHang()
        {
            var hoaDonBanHangs = hoaDonBanHangService.GetHoaDonBanHangOnlineChuanBiHang();
            return Ok(hoaDonBanHangs);
        }

        [HttpGet("GetHoaDonBanHangOnlineVanChuyen")]
        public IActionResult GetHoaDonBanHangOnlineVanChuyen()
        {
            var hoaDonBanHangs = hoaDonBanHangService.GetHoaDonBanHangOnlineVanChuyen();
            return Ok(hoaDonBanHangs);
        }

        [HttpGet("GetHoaDonBanHangOnlineDaGiao")]
        public IActionResult GetHoaDonBanHangOnlineDaGiao()
        {
            var hoaDonBanHangs = hoaDonBanHangService.GetHoaDonBanHangOnlineDaGiao();
            return Ok(hoaDonBanHangs);
        }

        [HttpGet("GetHoaDonBanHangOnlineByTokenKhachHang")]
        public IActionResult GetHoaDonBanHangOnlineByTokenKhachHang(string token)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                List<HoaDonBanHang> hoaDons =  hoaDonBanHangService.GetAllHoaDonBanHangOfKhachHang(token);
                return Ok(hoaDons);
            }
            catch (Exception ex)
            {
                return BadRequest("Bạn chưa có đơn hàng nào"); 
            }

        }

        //[HttpGet("GetAllHoaDonBanHangByTokenKhachHang")]
        //public IActionResult GetAllHoaDonBanHangByTokenKhachHang(string token)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    try
        //    {
        //        List<HoaDonBanHang> hoaDons = hoaDonBanHangService.GetAllHoaDonBanHangOfKhachHang(token);
        //        return Ok(hoaDons);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest("Bạn chưa có đơn hàng nào");
        //    }

        //}

        [HttpGet("GetHoaDonBanHangOnlineByID")]
        public IActionResult GetHoaDonBanHangOnlineByID(string hoaDonId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                HoaDonBanHang hoaDon = hoaDonBanHangService.GetHoaDonBanHangOnlineById(hoaDonId);
                return Ok(hoaDon);
            }
            catch (Exception ex)
            {
                return BadRequest("Không tìm thấy đơn hàng"); 
            }

        }
    }

}
