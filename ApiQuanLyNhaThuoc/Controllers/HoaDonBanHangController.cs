using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult AddHoaDonBanHangOnline([FromBody] HoaDonBanHang hoaDonBanHang)
        {
            if (ModelState.IsValid)
            {
                hoaDonBanHangService.AddHoaDonBanHangOnline(hoaDonBanHang);

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

    }

}
