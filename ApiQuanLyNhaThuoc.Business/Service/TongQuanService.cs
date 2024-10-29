using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Models.ViewModel;
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

        public List<KetQuaKhachHangTheoThang> GetSoLuongKhachHangTheoThangTrongNam(int nam)
        {
            var result = db.HoaDonBanHang
                .Where(hdb => hdb.ModifiedDate.Year == nam)
                .GroupBy(hdb => new { hdb.ModifiedDate.Year, hdb.ModifiedDate.Month })
                .Select(g => new KetQuaKhachHangTheoThang
                {
                    Nam = g.Key.Year,
                    Thang = g.Key.Month,
                    SoLuongKhachHang = g.Select(hdb => hdb.KhachHangId ?? hdb.Id).Distinct().Count()
                })
                .OrderBy(kq => kq.Nam)
                .ThenBy(kq => kq.Thang)
                .ToList();

            return result;
        }

        public List<KetQuaTrangThaiHoaDonTheoThang> GetSoLuongTrangThaiHoaDonTheoThangTrongNam(int nam)
        {
            var result = db.HoaDonBanHang
              .Where(h => h.TrangThaiDonHang == "Hoàn thành" ||
                          h.TrangThaiDonHang == "Đang xử lý" ||
                          h.TrangThaiDonHang == "Đang vận chuyển")
              .GroupBy(h => new { Year = h.ModifiedDate.Year, Month = h.ModifiedDate.Month })
              .Select(g => new KetQuaTrangThaiHoaDonTheoThang
              {
                  Nam = g.Key.Year,
                  Thang = g.Key.Month,
                  SoLuongHoanThanh = g.Count(h => h.TrangThaiDonHang == "Hoàn thành"),
                  SoLuongDangXuLy = g.Count(h => h.TrangThaiDonHang == "Đang xử lý"),
                  SoLuongDangVanChuyen = g.Count(h => h.TrangThaiDonHang == "Đang vận chuyển")
              })
              .OrderBy(o => o.Nam)
              .ThenBy(o => o.Thang)
              .ToList();

            return result;
        }

        public Dictionary<int, double> GetTongSoSanPhamDaBanTheoThangTrongNam(int nam)
        {
            var result = db.HoaDonBanHang
              .Where(hdb => hdb.TrangThaiDonHang == "Hoàn thành" && hdb.ModifiedDate.Year == nam)
              .Join(db.ChiTietHoaDonBanHang,
                    hdb => hdb.Id,
                    cthd => cthd.HoaDonId,
                    (hdb, cthd) => new { hdb.ModifiedDate, cthd.SoLuong })
              .GroupBy(x => x.ModifiedDate.Month)
              .Select(g => new
              {
                  Thang = g.Key,
                  TongSoLuongSanPham = g.Sum(x => x.SoLuong)
              })
              .OrderBy(x => x.Thang)
              .ToDictionary(x => x.Thang, x => x.TongSoLuongSanPham);

            return result;
        }

        public List<decimal> GetTongTienTongQuanTheoThangTrongNam(int nam)
        {
            List<decimal> tongTienTheoThang = new List<decimal>();
            for (int thang = 1; thang <= 12; thang++)
            {

                var tongTien = db.HoaDonBanHang
                    .Where(h => h.ModifiedDate.Year == nam && h.ModifiedDate.Month == thang && h.TrangThaiDonHang == "Hoàn thành")
                    .Sum(h => (decimal?)h.TongTien) ?? 0;

                tongTienTheoThang.Add(tongTien);
            }

            return tongTienTheoThang;
        }
    }
}
