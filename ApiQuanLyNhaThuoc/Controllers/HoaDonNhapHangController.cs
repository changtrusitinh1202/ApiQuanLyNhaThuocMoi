using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiQuanLyNhaThuoc.Controllers
{
    [Route("/api/hoadonnhaphang")]
    public class HoaDonNhapHangController : Controller
    {
        public IHoaDonDatHangService hoaDonDatHangService;
        public IHoaDonNhapHangService hoaDonNhapHangService;
        ApplicationDbContext db;
        public HoaDonNhapHangController(IHoaDonDatHangService hoaDonDatHangService, IHoaDonNhapHangService hoaDonNhapHangService, ApplicationDbContext db)
        {
            this.hoaDonDatHangService = hoaDonDatHangService;
            this.hoaDonNhapHangService = hoaDonNhapHangService;
            this.db = db;
        }


        [HttpPost("AddHoaDon/{hoaDonDatHangId}")]
        public IActionResult AddHoaDon([FromBody] HoaDonNhapHang hoaDon, Guid hoaDonDatHangId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    hoaDonNhapHangService.AddHoaDon(hoaDon, hoaDonDatHangId);
                    return Ok(hoaDon);
                }
                return BadRequest(hoaDon);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
         
        }
    }
}
