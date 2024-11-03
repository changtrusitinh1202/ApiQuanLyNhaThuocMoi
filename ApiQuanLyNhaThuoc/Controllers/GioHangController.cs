using ApiQuanLyNhaThuoc.Business.Service;
using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Models.DTOs;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiQuanLyNhaThuoc.Controllers
{
    [Route("/api/giohang")]
    public class GioHangController : Controller
    {
        ApplicationDbContext db;
        public IGioHangService gioHangService;
        public GioHangController(ApplicationDbContext db, IGioHangService gioHangService)
        {
            this.db = db;
            this.gioHangService = gioHangService;
        }


        [HttpPost("ThemSanPhamVaoGioHang")]
        public IActionResult ThemSanPhamVaoGioHang([FromHeader] string token, [FromBody] GioHang gioHang)
        {

            if (string.IsNullOrEmpty(token))
            {
                return BadRequest("Token không hợp lệ.");
            }


            try
            {

                gioHangService.ThemSanPhamVaoGioHang(token, gioHang.PhienBanSanPhamId, gioHang.SoLuong);
                return Ok("Thêm sản phẩm vào giỏ hàng thành công.");
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Đã xảy ra lỗi: " + ex.Message);
            }
        }

        [HttpPost("TangSoLuong")]
        public IActionResult TangSoLuong([FromHeader] string token, [FromBody] string phienBanSanPhamId)
        {
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest("Token không hợp lệ.");
            }

            if (phienBanSanPhamId == null || string.IsNullOrEmpty(phienBanSanPhamId))
            {
                return BadRequest("Sản phẩm không tồn tại.");
            }

            try
            {
                gioHangService.TangSoLuongSanPham(token, phienBanSanPhamId);
                return Ok("Tăng số lượng sản phẩm trong giỏ hàng thành công.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Đã xảy ra lỗi: " + ex.Message);
            }
        }

        [HttpPost("GiamSoLuong")]
        public IActionResult GiamSoLuong([FromHeader] string token, [FromBody] string phienBanSanPhamId)
        {
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest("Token không hợp lệ.");
            }

            if (phienBanSanPhamId == null || string.IsNullOrEmpty(phienBanSanPhamId))
            {
                return BadRequest("Sản phẩm không tồn tại.");
            }

            try
            {
                gioHangService.GiamSoLuongSanPham(token, phienBanSanPhamId);
                return Ok("Giảm số lượng sản phẩm trong giỏ hàng thành công.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Đã xảy ra lỗi: " + ex.Message);
            }
        }

        [HttpDelete("XoaSanPhamKhoiGioHang")]
        public IActionResult XoaSanPhamKhoiGioHang([FromHeader] string token, [FromBody] string phienBanSanPhamId)
        {
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest("Token không hợp lệ.");
            }

            if (phienBanSanPhamId == null || string.IsNullOrEmpty(phienBanSanPhamId))
            {
                return BadRequest("Sản phẩm không tồn tại.");
            }

            try
            {
                gioHangService.XoaSanPhamKhoiGioHang(token, phienBanSanPhamId);
                return Ok("Xóa sản phẩm trong giỏ hàng thành công.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Đã xảy ra lỗi: " + ex.Message);
            }
        }

        [HttpGet("GetGioHangByToken")]
        public IActionResult GetGioHangByToken([FromHeader] string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest("Token không hợp lệ.");
            }
            List<GioHangDTO> gioHangs = gioHangService.GetGioHang(token);
            return Ok(gioHangs);
        }
    }
}
