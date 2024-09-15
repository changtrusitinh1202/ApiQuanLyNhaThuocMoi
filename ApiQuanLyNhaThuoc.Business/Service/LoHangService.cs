using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service
{
    public class LoHangService : ILoHangService
    {
        ApplicationDbContext db;
        public LoHangService(ApplicationDbContext db, IHoaDonDatHangService hoaDonDatHangService, IPhienBanSanPhamService phienBanSanPhamService)
        {
            this.db = db;
        }
        public void CapNhatLoHang(string MaLoHang, double soLuongQuyDoi)
        {
            LoHang? loHangFind = db.LoHang.FirstOrDefault(lh => lh.MaLoHang == MaLoHang);
            if (loHangFind == null)
                throw new Exception("Không tìm thấy lô hàng tồn tại");
            else
            {
                loHangFind.SoLuongQuyDoi += soLuongQuyDoi;
                db.Entry(loHangFind).Property(lh => lh.SoLuongQuyDoi).IsModified = true;
                db.SaveChanges();
            }
        }

    }
}
