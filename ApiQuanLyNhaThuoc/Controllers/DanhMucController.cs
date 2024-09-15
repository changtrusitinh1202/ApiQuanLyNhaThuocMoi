using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiQuanLyNhaThuoc.Controllers
{
    [Route("/api/category")]
    public class DanhMucController : Controller
    {
        public IDanhMucService categoryService;
        ApplicationDbContext db;
        public DanhMucController(IDanhMucService categoryService, ApplicationDbContext db)
        {
            this.categoryService = categoryService;
            this.db = db;
        }

        [HttpGet("GetCategories")]
        public IActionResult GetCategories()
        {
            List<DanhMuc> categories = categoryService.GetCategories();
            return Ok(categories);
        }

        [HttpPost("Add")]
        public IActionResult AddCategory([FromBody] DanhMuc category)
        {

            if (ModelState.IsValid)
            {
                category.Id = Guid.NewGuid();
                categoryService.AddCategory(category);
                return Json(new { success = true, message = "Thêm thành công" });
            }

            return BadRequest(ModelState);
        }

        [HttpPut("Update/{categoryId}")]
        public IActionResult UpdateCategory(Guid categoryId, [FromBody] DanhMuc categoryUpdate)
        {
            if (ModelState.IsValid)
            {
                categoryUpdate.Id = categoryId;
                categoryService.UpdateCategory(categoryUpdate);
                return Json(new { success = true, message = "Sửa thành công" });
            }
            return BadRequest(ModelState);
        }

        [HttpGet("GetCategoryByDescription/{description}")]
        public IActionResult GetCategoryByDescription(string description)
        {
            DanhMuc category = categoryService.GetCategoryByDescription(description);
            if (category == null)
                return NotFound("Không tìm thấy theo mô tả");
            return Ok(category);
        }

        [HttpGet("GetCategoriesByName/{name}")]
        public IActionResult GetCategoriesByName(string name)
        {
            List<DanhMuc> category = categoryService.GetCategoriesByName(name);
            if (category == null)
                return NotFound("Không tìm thấy theo tên");
            return Ok(category);
        }
    }
}
