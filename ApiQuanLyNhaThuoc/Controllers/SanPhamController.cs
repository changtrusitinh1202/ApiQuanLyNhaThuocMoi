using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.DTOs;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiQuanLyNhaThuoc.Controllers
{
    [Route("/api/sanpham")]
    public class SanPhamController : Controller
    {
        public ISanPhamService sanPhamService;
        public IPhienBanSanPhamService phienBanSanPhamService;
        ApplicationDbContext db;
        public SanPhamController(ISanPhamService sanPhamService, IPhienBanSanPhamService phienBanSanPhamService, ApplicationDbContext db)
        {
            this.sanPhamService = sanPhamService;
            this.phienBanSanPhamService = phienBanSanPhamService;
            this.db = db;
        }

        [HttpPost("AddSanPham")]
        public IActionResult AddSanPham([FromBody] SanPhamDTO sanPham)
        {
            if (ModelState.IsValid)
            {

                sanPhamService.AddSanPham(sanPham);
                return Json(new { success = true, message = "Thêm thành công" });
            }
            return BadRequest(ModelState);
        }

        

        [HttpGet("GetSanPhams")]
        public IActionResult GetAllSanPham()
        {
            List<SanPham> sanPhams = sanPhamService.GetAllSanPham();
            return Ok(sanPhams);
        }

        [HttpGet("GetSanPham/{sanPhamId}")]
        public IActionResult GetSanPhamById(string sanPhamId)
        {
            SanPham sanPham = sanPhamService.GetSanPhamById(sanPhamId);
            return Ok(sanPham);
        }

        [HttpGet("GetSanPhamByName")]
        public IActionResult GetSanPhamByName(string name)
        {
            List<SanPham> sanPhams = sanPhamService.GetSanPhamByName(name);
            return Ok(sanPhams);
        }

        [HttpPost("UpdateSanPham/{sanPhamId}")]
        public IActionResult UpdateSanPham(string sanPhamId, [FromBody] SanPham sanPhamUpdate)
        {
            if (ModelState.IsValid) 
            {
                sanPhamUpdate.Id = sanPhamId;
                sanPhamService.UpdateSanPham(sanPhamUpdate);
                return Ok(sanPhamUpdate);
            }
            return BadRequest(ModelState);
        }
    }
}
