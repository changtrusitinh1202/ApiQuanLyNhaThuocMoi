using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;


namespace ApiQuanLyNhaThuoc.Business.Service
{
    public class DanhMucService : IDanhMucService
    {
        ApplicationDbContext db;
        public DanhMucService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddCategory(DanhMuc danhMuc)
        {
            db.DanhMuc.Add(danhMuc);
            db.SaveChanges();
        }

        public List<DanhMuc> GetCategories()
        {
            List<DanhMuc> categories = db.DanhMuc.ToList();
            return categories;
        }

        public List<DanhMuc> GetCategoriesByName(string name)
        {
            List<DanhMuc> categoriesByName = db.DanhMuc.Where(x => x.TenDanhMuc == name).ToList();
            return categoriesByName;
        }

        public DanhMuc GetCategoryByDescription(string description)
        {
            DanhMuc category = db.DanhMuc.FirstOrDefault(c => c.MoTa == description);
            return category;
        }

        public void UpdateCategory(DanhMuc category)
        {
            db.DanhMuc.Update(category);
            db.SaveChanges();
        }
    }
}
