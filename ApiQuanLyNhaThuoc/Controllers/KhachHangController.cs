using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;

namespace ApiQuanLyNhaThuoc.Controllers
{
    [Route("/api/khachhang")]
    public class KhachHangController : Controller
    {
        public IKhachHangService khachHangService;
        ApplicationDbContext db;
        public KhachHangController(IKhachHangService khachHangService, ApplicationDbContext db)
        {
            this.khachHangService = khachHangService;
            this.db = db;
        }

        [HttpGet("GetCurrentKhachHang")]
        public IActionResult GetKhachHangByToken(string token)
        {
            var khachHangs = khachHangService.GetKhachHangByToken(token);
            return Ok(khachHangs);
        }

        [HttpGet("GetHoaDonKhacHangByID")]
        public IActionResult GetHoaDonKhacHangByID(string id)
        {
            var hoaDonBanHangs = khachHangService.GetHoaDonBanHangByKhachHangId(id);
            return Ok(hoaDonBanHangs);
        }
    }
}
