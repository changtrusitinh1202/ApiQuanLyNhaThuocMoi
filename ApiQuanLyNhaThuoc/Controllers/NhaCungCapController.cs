using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiQuanLyNhaThuoc.Controllers
{
    [Route("/api/nhacungcap")]
    public class NhaCungCapController : Controller
    {
        public INhaCungCapService nhaCungCapService;
        ApplicationDbContext db;
        public NhaCungCapController(INhaCungCapService nhaCungCapService, ApplicationDbContext db)
        {
            this.nhaCungCapService = nhaCungCapService;
            this.db = db;
        }

        [HttpGet("GetNhaCungCaps")]
        public IActionResult GetNhaCungCaps()
        {
            List<NhaCungCap> nhaCungCaps = nhaCungCapService.GetNhaCungCaps();
            return Ok(nhaCungCaps);
        }

        [HttpGet("GetNhaCungCapByName")]
        public IActionResult GetNhaCungCapByName(string name)
        {
            NhaCungCap nhaCungCaps = nhaCungCapService.GetNhaCungCapByName(name);
            if (nhaCungCaps != null)
            {
                return Ok(nhaCungCaps);
            }
            return NotFound("Không tìm thấy");
        }

        [HttpGet("GetNhaCungCapGiaoDich")]
        public IActionResult GetNhaCungCapGiaoDich()
        {
            List<NhaCungCap> nhaCungCaps = nhaCungCapService.GetNhaCungCapGiaoDich();
            if (nhaCungCaps.Count > 0)
            {
                return Ok(nhaCungCaps);
            }
            return NotFound("Không có nhà cung cấp nào");
        }

        [HttpGet("GetNhaCungCapNgungGiaoDich")]
        public IActionResult GetNhaCungCapNgungGiaoDich()
        {
            List<NhaCungCap> nhaCungCaps = nhaCungCapService.GetNhaCungCapNgungGiaoDich();
            if (nhaCungCaps.Count > 0) 
            {
                return Ok(nhaCungCaps);
            }
            return NotFound("Không có nhà cung cấp nào");
            
        }

        [HttpPost("Add")]
        public IActionResult AddCategory([FromBody] NhaCungCap nhaCungCap)
        {

            if (ModelState.IsValid)
            {
                nhaCungCap.Id = Guid.NewGuid();
                nhaCungCapService.AddNhaCungCap(nhaCungCap);
                return Json(new { success = true, message = "Thêm thành công" });
            }

            return BadRequest(ModelState);
        }

        [HttpPut("Update/{nhacungcapId}")]
        public IActionResult UpdateCategory(Guid nhacungcapId, [FromBody] NhaCungCap nhaCungCapUpdate)
        {
         
            if (ModelState.IsValid)
            {
                nhaCungCapUpdate.Id = nhacungcapId;
                nhaCungCapService.UpdateNhaCungCap(nhaCungCapUpdate);
                return Json(new { success = true, message = "Sửa thành công" });
            }
            return BadRequest(ModelState);
        }

    }
}
