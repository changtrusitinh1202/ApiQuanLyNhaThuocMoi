using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service
{
    public class NhaCungCapService : INhaCungCapService
    {
        ApplicationDbContext db;
        public NhaCungCapService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void AddNhaCungCap(NhaCungCap nhaCungCap)
        {
            db.NhaCungCap.Add(nhaCungCap);
            db.SaveChanges();
        }

        public NhaCungCap GetNhaCungCapById(string id)
        {
            NhaCungCap nhaCungCap = db.NhaCungCap.First(x => x.Id == id);
            return nhaCungCap;
        }

        public NhaCungCap GetNhaCungCapByName(string name)
        {
            NhaCungCap nhaCungCap = db.NhaCungCap.FirstOrDefault(x => x.TenNhaCungCap == name);
            return nhaCungCap;
        }

        public List<NhaCungCap> GetNhaCungCapGiaoDich()
        {
            List<NhaCungCap> nhaCungCaps = db.NhaCungCap.Where(x => x.TrangThaiGiaoDich == 1).ToList();
            return nhaCungCaps;
        }

        public List<NhaCungCap> GetNhaCungCapNgungGiaoDich()
        {
            List<NhaCungCap> nhaCungCaps = db.NhaCungCap.Where(x => x.TrangThaiGiaoDich == 0).ToList();
            return nhaCungCaps;
        }

        public List<NhaCungCap> GetNhaCungCaps()
        {
            List<NhaCungCap> nhaCungCaps = db.NhaCungCap.ToList();
            return nhaCungCaps;
        }

        public void UpdateNhaCungCap(NhaCungCap nhaCungCap)
        {
            db.NhaCungCap.Update(nhaCungCap);
            db.SaveChanges();
        }
    }
}
