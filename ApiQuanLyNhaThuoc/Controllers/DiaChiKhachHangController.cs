using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiQuanLyNhaThuoc.Controllers
{
    [Route("/api/diachikhachhang")]
    public class DiaChiKhachHangController : Controller
    {
        public IDiaChiKhachHangService diaChiKhachHangService;
        public IKhachHangService khachHangService;
        ApplicationDbContext db;
        public DiaChiKhachHangController(IDiaChiKhachHangService diaChiKhachHangService, IKhachHangService khachHangService, ApplicationDbContext db)
        {
            this.diaChiKhachHangService = diaChiKhachHangService;
            this.khachHangService = khachHangService;
            this.db = db;
        }
        
        [HttpPost("ThemDiaChiKhachHang")]
        public IActionResult ThemDiaChiKhachHang(string khachHangId, [FromBody] DiaChiKhachHang diaChiKhachHang)
        {
            if (ModelState.IsValid)
            {
                diaChiKhachHangService.ThemDiaChiKhachHang(khachHangId, diaChiKhachHang);
                return Ok(diaChiKhachHang);
            }
            return BadRequest(ModelState);
        }


        [HttpPut("UpdateDiaChiKhachHang")]
        public IActionResult UpdateDiaChiKhachHang(string khachHangId, int diaChiKhachHangId, [FromBody] DiaChiKhachHang diaChiKhachHang)
        {
       
            if (ModelState.IsValid)
            {
               
                diaChiKhachHangService.UpdateDiaChiKhachHang(khachHangId, diaChiKhachHangId, diaChiKhachHang);
                return Ok(diaChiKhachHang);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("XoaDiaChiKhachHang")]
        public IActionResult XoaDiaChiKhachHang(string khachHangId, int diaChiKhachHangId)
        {
            if (ModelState.IsValid)
            {
                diaChiKhachHangService.XoaDiaChiKhachHang(khachHangId, diaChiKhachHangId);
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpGet("LayDanhSachDiaChiKhachHang")]
        public IActionResult LayDanhSachDiaChiKhachHang(string khachHangId)
        {
            List<DiaChiKhachHang> diaChiKhachHangs = diaChiKhachHangService.LayDanhSachDiaChiKhachHang(khachHangId);
            return Ok(diaChiKhachHangs);
        }

        [HttpGet("LayDiaChiKhachHang")]
        public IActionResult LayDiaChiKhachHang(string khachHangId, int diaChiKhachHangId)
        {
            DiaChiKhachHang diaChiKhachHang = diaChiKhachHangService.LayDiaChiKhachHang(khachHangId, diaChiKhachHangId);
            return Ok(diaChiKhachHang);
        }

        [HttpPut("SetDefaultDiaChiKhachHang")]
        public IActionResult SetDefaultDiaChiKhachHang(string khachHangId, int diaChiKhachHangId)
        {
            if (ModelState.IsValid)
            {
                diaChiKhachHangService.SetDefaultDiaChiKhachHang(khachHangId, diaChiKhachHangId);
                return Ok("Đặt địa chỉ mặc định thành công");
            }
            return BadRequest(ModelState);
        }
    }
}
