using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiQuanLyNhaThuoc.Controllers
{
    [Route("/api/lohang")]
    public class LoHangController : Controller
    {       
        public ILoHangService loHangService;
        public IHoaDonNhapHangService hoaDonNhapHangService;

        ApplicationDbContext db;
        public LoHangController(ILoHangService loHangService, IHoaDonNhapHangService hoaDonNhapHangService, ApplicationDbContext db)
        {
            this.loHangService = loHangService;
            this.hoaDonNhapHangService = hoaDonNhapHangService;
            this.db = db;
        }

        [HttpGet("GetLoHangs")]
        public IActionResult GetLoHangs()
        {
            var loHangs = loHangService.GetLoHangs();
            if(!loHangs.Any())
                return NotFound("Không tìm thấy lô hàng");  
            return Ok(loHangs); 
        }
    }
}
