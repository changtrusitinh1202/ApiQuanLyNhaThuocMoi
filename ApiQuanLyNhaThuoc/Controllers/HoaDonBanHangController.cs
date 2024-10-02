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
        ApplicationDbContext db;
        public HoaDonBanHangController(IHoaDonBanHangService hoaDonBanHangService, ApplicationDbContext db)
        {
            this.hoaDonBanHangService = hoaDonBanHangService;
            this.db = db;
        }
   

        [HttpPost("AddHoaDonBanHangTrucTiep")]
        public IActionResult AddHoaDonBanHangTrucTiep([FromBody] HoaDonBanHang hoaDonBanHang)
        {
            if (ModelState.IsValid)
            {
                hoaDonBanHangService.AddHoaDonBanHangTrucTiep(hoaDonBanHang);
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
    }
  
}
