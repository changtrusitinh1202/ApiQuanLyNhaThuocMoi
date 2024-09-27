using ApiQuanLyNhaThuoc.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service.IService
{
    public interface INhaCungCapService
    {
        List<NhaCungCap> GetNhaCungCaps();
        NhaCungCap GetNhaCungCapByName(string name);
        NhaCungCap GetNhaCungCapById(string id);
        //List<DanhMuc> GetCategoriesByName(string name);
        void AddNhaCungCap(NhaCungCap nhaCungCap);
        void UpdateNhaCungCap(NhaCungCap nhaCungCap);
        List<NhaCungCap> GetNhaCungCapGiaoDich();
        List<NhaCungCap> GetNhaCungCapNgungGiaoDich();
    }
}
