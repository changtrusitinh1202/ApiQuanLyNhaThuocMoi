using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiQuanLyNhaThuoc.Controllers
{
    [Route("/api/phienbansanpham")]
    public class PhienBanSanPhamController : Controller
    {
        public ISanPhamService sanPhamService;
        public IPhienBanSanPhamService phienBanSanPhamService;
        ApplicationDbContext db;
        public PhienBanSanPhamController(ISanPhamService sanPhamService, IPhienBanSanPhamService phienBanSanPhamService, ApplicationDbContext db)
        {
            this.sanPhamService = sanPhamService;
            this.phienBanSanPhamService = phienBanSanPhamService;
            this.db = db;
        }

        [HttpGet("GetPhienBanSanPhamById/{sanPhamId}/{phienBanSanPhamId}")]
        public IActionResult GetPhienBanSanPham(string sanPhamId, string phienBanSanPhamId)
        {
            PhienBanSanPham phienBanSanPham = phienBanSanPhamService.GetPhienBanSanPhamById(sanPhamId, phienBanSanPhamId);
            return Ok(phienBanSanPham);
        }

        [HttpGet("GetPhienBanSanPhamByPhienBanId/{phienBanSanPhamId}")]
        public IActionResult GetPhienBanSanPhamByPhienBanId(string phienBanSanPhamId)
        {
            PhienBanSanPham phienBanSanPham = phienBanSanPhamService.GetPhienBanSanPhamByPhienBanId(phienBanSanPhamId);
            return Ok(phienBanSanPham);
        }

        [HttpPost("AddPhienBan/{sanPhamId}")]
        public IActionResult AddPhienBanSanPham([FromBody] PhienBanSanPham phienBanSanPham, string sanPhamId)
        {
            if (ModelState.IsValid)
            {

                phienBanSanPhamService.AddPhienBanSanPham(phienBanSanPham, sanPhamId);
                return Ok(phienBanSanPham);
            }
            return BadRequest(ModelState);
        }
    }
}
