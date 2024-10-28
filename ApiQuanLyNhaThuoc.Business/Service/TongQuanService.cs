using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service
{
    public class TongQuanService : ITongQuanService
    {

        ApplicationDbContext db;

        public TongQuanService(ApplicationDbContext db)
        {
            this.db = db;
        }


        public List<decimal> GetTongTienTongQuanTheoThangTrongNam(int nam)
        {
            List<decimal> tongTienTheoThang = new List<decimal>();

       
            for (int thang = 1; thang <= 12; thang++)
            {
             
                var tongTien = db.HoaDonBanHang
                    .Where(h => h.CreatedDate.Year == nam && h.CreatedDate.Month == thang && h.TrangThaiDonHang == "Hoàn thành")
                    .Sum(h => (decimal?)h.TongTien) ?? 0; 

         
                tongTienTheoThang.Add(tongTien);
            }

            return tongTienTheoThang;
        }
    }
}
