using ApiQuanLyNhaThuoc.Business.Service;
using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiQuanLyNhaThuoc.Controllers
{
    [Route("/api/hoadondathang")]
    public class HoaDonDatHangController : Controller
    {
        public IHoaDonDatHangService hoaDonDatHangService;
        ApplicationDbContext db;
        public HoaDonDatHangController(IHoaDonDatHangService hoaDonDatHangService, ApplicationDbContext db)
        {
            this.hoaDonDatHangService = hoaDonDatHangService;
            this.db = db;
        }

        [HttpPost("AddHoaDon")]
        public IActionResult AddHoaDon([FromBody] HoaDonDatHang hoaDonDatHang)
        {

            if (ModelState.IsValid)
            {
                hoaDonDatHangService.AddHoaDonDatHang(hoaDonDatHang);
                return Ok(hoaDonDatHang);
            }

            return BadRequest(ModelState);
        }

        [HttpGet("GetHoaDonDatHang/{hoaDonDatHangId}")]
        public IActionResult GetHoaDonDatHang(string hoaDonDatHangId)
        {
            HoaDonDatHang hoaDonDatHang = hoaDonDatHangService.GetHoaDonDatHangById(hoaDonDatHangId);
            return Ok(hoaDonDatHang);
        }

        [HttpGet("GetHoaDonDatHangs")]
        public IActionResult GetHoaDonDatHangs()
        {
            List<HoaDonDatHang> hoaDonDatHangs = hoaDonDatHangService.GetHoaDonDatHangs();
            if(!hoaDonDatHangs.Any())
                return NotFound("Không tìm thấy hóa đơn");
            return Ok(hoaDonDatHangs);
        }

        [HttpGet("GetHoaDonDatHangsChuaNhap")]
        public IActionResult GetHoaDonDatHangsChuaNhap()
        {
            List<HoaDonDatHang> hoaDonDatHangs = hoaDonDatHangService.GetHoaDonDatHangsChuaNhap();
            if (!hoaDonDatHangs.Any())
                return NotFound("Không tìm thấy hóa đơn chưa nhập");
            return Ok(hoaDonDatHangs);
        }

        [HttpGet("GetHoaDonDatHangsNhapMotPhan")]
        public IActionResult GetHoaDonDatHangsNhapMotPhan()
        {
            List<HoaDonDatHang> hoaDonDatHangs = hoaDonDatHangService.GetHoaDonDatHangsNhapMotPhan();
            if (!hoaDonDatHangs.Any())
                return NotFound("Không tìm thấy hóa đơn nhập một phần");
            return Ok(hoaDonDatHangs);
        }

        [HttpGet("GetHoaDonDatHangsHoanThanh")]
        public IActionResult GetHoaDonDatHangsHoanThanh()
        {
            List<HoaDonDatHang> hoaDonDatHangs = hoaDonDatHangService.GetHoaDonDatHangsHoanThanh();
            if (!hoaDonDatHangs.Any())
                return NotFound("Không tìm thấy hóa đơn hoàn thành");
            return Ok(hoaDonDatHangs);
        }

        [HttpGet("GetSoLuongDat/{hoaDonDatId}")]
        public IActionResult GetSoLuongDat(string hoaDonDatId)
        {
            double soLuongDat = hoaDonDatHangService.GetSoLuongDat(hoaDonDatId);
            return Ok(soLuongDat);
        }

        [HttpGet("GetSoLuongDatChiTiet/{hoaDonDatId}/{phienBanSanPhamId}")]
        public IActionResult GetSoLuongDat(string hoaDonDatId, string phienBanSanPhamId)
        {
            double soLuongDat = hoaDonDatHangService.GetSoLuongDatChiTiet(hoaDonDatId, phienBanSanPhamId);
            return Ok(soLuongDat);
        }

        [HttpGet("GetSoLuongDatChiTietConLai/{hoaDonDatId}/{phienBanSanPhamId}")]
        public IActionResult GetSoLuongDatChiTietConLai(string hoaDonDatId, string phienBanSanPhamId)
        {
            double soLuongDat = hoaDonDatHangService.GetSoLuongDatChiTietConLai(hoaDonDatId, phienBanSanPhamId);
            return Ok(soLuongDat);
        }


    }
}
