using ApiQuanLyNhaThuoc.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service.IService
{
    public interface INhanVienService
    {
        void AddNhanVien(NhanVien nhanVien);
        NhanVien GetNhanVienById(string token);
    }
}
