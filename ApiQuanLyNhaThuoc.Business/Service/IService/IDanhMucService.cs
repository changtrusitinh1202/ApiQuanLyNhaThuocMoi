

using ApiQuanLyNhaThuoc.Models.Entities;
using Microsoft.Identity.Client;

namespace ApiQuanLyNhaThuoc.Business.Service.IService
{
    public interface IDanhMucService
    {
        List<DanhMuc> GetCategories();
        DanhMuc GetCategoryByDescription(string description);
        List<DanhMuc> GetCategoriesByName(string name);
        void AddCategory(DanhMuc danhMuc);
        void UpdateCategory(DanhMuc danhMuc);
    }
}
