using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Models.DTOs;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace ApiQuanLyNhaThuoc.Controllers
{
    [Route("/api/hoadonbanhang")]
    public class HoaDonBanHangController : Controller
    {
        public IHoaDonBanHangService hoaDonBanHangService;
        public ITongQuanService tongQuanService;
        ApplicationDbContext db;
        public HoaDonBanHangController(IHoaDonBanHangService hoaDonBanHangService, ITongQuanService tongQuanService, ApplicationDbContext db)
        {
            this.hoaDonBanHangService = hoaDonBanHangService;
            this.tongQuanService = tongQuanService;
            this.db = db;
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
        public IActionResult AddHoaDonBanHangOnline([FromBody] HoaDonBanHangOnline hoaDonBanHang, GiaoHangDTO giaoHang)
        {
            if (ModelState.IsValid)
            {
                hoaDonBanHangService.AddHoaDonBanHangOnline(hoaDonBanHang, giaoHang);

                return Ok(hoaDonBanHang);
            }
            return BadRequest(ModelState);
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

    }

}
