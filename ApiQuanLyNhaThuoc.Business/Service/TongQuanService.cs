using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.Enum;
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
                .Where(hdb => hdb.CreatedDate.Year == nam)
                .GroupBy(hdb => new { hdb.CreatedDate.Year, hdb.CreatedDate.Month })
                .Select(g => new KetQuaKhachHangTheoThang
                {
                    Nam = g.Key.Year,
                    Thang = g.Key.Month,
                    SoLuongKhachHang = g.Count()
                })
                .OrderBy(kq => kq.Nam)
                .ThenBy(kq => kq.Thang)
                .ToList();

            return result;
        }

        public List<KetQuaTrangThaiHoaDonTheoThang> GetSoLuongTrangThaiHoaDonTheoThangTrongNam(int nam)
        {
            var result = db.HoaDonBanHang
              .Where(h => h.TrangThaiDonHang == TrangThai.HoanThanh ||
                          h.TrangThaiDonHang == TrangThai.DaDat ||
                          h.TrangThaiDonHang == TrangThai.DangVanChuyen)
              .GroupBy(h => new { Year = h.CreatedDate.Year, Month = h.CreatedDate.Month })
              .Select(g => new KetQuaTrangThaiHoaDonTheoThang
              {
                  Nam = g.Key.Year,
                  Thang = g.Key.Month,
                  SoLuongHoanThanh = g.Count(h => h.TrangThaiDonHang == TrangThai.HoanThanh),
                  SoLuongDangXuLy = g.Count(h => h.TrangThaiDonHang == TrangThai.DaDat),
                  SoLuongDangVanChuyen = g.Count(h => h.TrangThaiDonHang == TrangThai.DangVanChuyen)
              })
              .OrderBy(o => o.Nam)
              .ThenBy(o => o.Thang)
              .ToList();

            return result;
        }

        public Dictionary<int, double> GetTongSoSanPhamDaBanTheoThangTrongNam(int nam)
        {
            var result = db.HoaDonBanHang
              .Where(hdb => hdb.TrangThaiDonHang == TrangThai.HoanThanh && hdb.CreatedDate.Year == nam)
              .Join(db.ChiTietHoaDonBanHang,
                    hdb => hdb.Id,
                    cthd => cthd.HoaDonId,
                    (hdb, cthd) => new { hdb.CreatedDate, cthd.SoLuong })
              .GroupBy(x => x.CreatedDate.Month)
              .Select(g => new
              {
                  Thang = g.Key,
                  TongSoLuongSanPham = g.Sum(x => x.SoLuong)
              })
              .OrderBy(x => x.Thang)
              .ToDictionary(x => x.Thang, x => x.TongSoLuongSanPham);

            return result;
        }

        public Dictionary<int, double> GetTongDoanhThuTheoGioHomNay()
        {
            var today = DateTime.UtcNow.AddHours(7).Date;


            var result = new Dictionary<int, double>();


            for (int i = 0; i < 24; i++)
            {
                result[i] = 0;
            }

            var doanhThuTheoGio = db.HoaDonBanHang
                .Where(hdb => hdb.ModifiedDate.Date == today)
                .GroupBy(hdb => hdb.ModifiedDate.Hour)
                .Select(g => new
                {
                    Gio = g.Key,
                    TongDoanhThu = g.Sum(hdb => hdb.ThanhTien)
                })
                .ToList();


            foreach (var item in doanhThuTheoGio)
            {
                result[item.Gio] = (double)item.TongDoanhThu;
            }

            return result;
        }

        public List<decimal> GetTongTienTongQuanTheoThangTrongNam(int nam)
        {
            List<decimal> tongTienTheoThang = new List<decimal>();
            for (int thang = 1; thang <= 12; thang++)
            {

                var tongTien = db.HoaDonBanHang
                    .Where(h => h.CreatedDate.Year == nam
                        && h.CreatedDate.Month == thang
                        && (h.TrangThaiThanhToan == TrangThai.DaThanhToan || h.TrangThaiDonHang == TrangThai.HoanThanh)
                        )
                    .Sum(h => (decimal?)h.TongTien) ?? 0;

                tongTienTheoThang.Add(tongTien);
            }

            return tongTienTheoThang;
        }

        public decimal GetTongTienTongQuanTrongHomNay()
        {
            var ngayHomNay = DateTime.UtcNow.AddHours(7).Date;


            var tongTienHomNay = db.HoaDonBanHang
                .Where(hdb => hdb.CreatedDate >= ngayHomNay && hdb.CreatedDate < ngayHomNay.AddDays(1))
                .Sum(hdb => hdb.ThanhTien);

            return tongTienHomNay;
        }

        public int GetSoLuongKhachHangHomNay()
        {
            var today = DateTime.UtcNow.AddHours(7).Date;

            int soLuongKhachHang = db.HoaDonBanHang
               .Where(hdb => hdb.CreatedDate.Date == today)
               .Count();

            return soLuongKhachHang;
        }

        public int GetTongSoSanPhamNgayHomNay()
        {
            var today = DateTime.UtcNow.AddHours(7).Date;

            var tongSoLuongSanPham = db.HoaDonBanHang
           .Join(db.ChiTietHoaDonBanHang,
                 hdb => hdb.Id,
                 cthd => cthd.HoaDonId,
                 (hdb, cthd) => new { hdb, cthd })
           .Where(h => h.hdb.CreatedDate.Date == today)
           .Sum(h => (int?)h.cthd.SoLuong) ?? 0; // Trả về 0 nếu không có sản phẩm nào bán

            return tongSoLuongSanPham;
        }

        public KetQuaTrangThaiHoaDon GetKetQuaTrangThaiHoaDonNgayHomNay()
        {

            var today = DateTime.UtcNow.AddHours(7).Date;

            var result = db.HoaDonBanHang
                .Where(h => (h.TrangThaiDonHang == TrangThai.HoanThanh ||
                             h.TrangThaiDonHang == TrangThai.DaDat ||
                             h.TrangThaiDonHang == TrangThai.DangVanChuyen) &&
                             h.ModifiedDate.Date == today) 
                .GroupBy(h => 1) 
                .Select(g => new KetQuaTrangThaiHoaDon
                {
                    SoLuongHoanThanh = g.Count(h => h.TrangThaiDonHang == TrangThai.HoanThanh),
                    SoLuongDangXuLy = g.Count(h => h.TrangThaiDonHang == TrangThai.DaDat),
                    SoLuongDangVanChuyen = g.Count(h => h.TrangThaiDonHang == TrangThai.DangVanChuyen)
                })
                .FirstOrDefault() ?? new KetQuaTrangThaiHoaDon(); 

            return result;


        }

        public async Task<List<KetQuaHoaDonMoiNgay>> GetTongTienTheoNgayTrongTuanNay()
        {
            var today = DateTime.Today;
            var startOfWeek = today.AddDays(-(int)today.DayOfWeek + 1);
            if (today.DayOfWeek == DayOfWeek.Sunday)
            {
                startOfWeek = startOfWeek.AddDays(-7);
            }

            var endOfWeek = startOfWeek.AddDays(6);

        
            var result = await db.HoaDonBanHang
                .Where(hdb => hdb.CreatedDate >= startOfWeek && hdb.CreatedDate <= endOfWeek)
                .GroupBy(hdb => hdb.CreatedDate.Date) 
                .Select(g => new KetQuaHoaDonMoiNgay
                {
                    Ngay = g.Key,
                    TongTien = g.Sum(hdb => hdb.ThanhTien)
                })
                .OrderBy(r => r.Ngay)
                .ToListAsync();

            var daysOfWeek = Enumerable.Range(0, 7)
                .Select(i => startOfWeek.AddDays(i))
                .ToList();

            // Ghép ngày không có doanh thu vào danh sách kết quả
            var finalResult = daysOfWeek.Select(day => new KetQuaHoaDonMoiNgay
            {
                Ngay = day,
                TongTien = result.FirstOrDefault(r => r.Ngay == day)?.TongTien ?? 0
            }).ToList();

            return finalResult;
        }

        public async Task<int> GetSoLuongKhachHangTrongTuanNay()
        {
            var startOfWeek = DateTime.Now.AddDays(1 - (int)DateTime.Now.DayOfWeek).Date; 
            var endOfWeek = startOfWeek.AddDays(7); 

         
            var totalCustomers = await db.HoaDonBanHang
                .Where(h => h.CreatedDate >= startOfWeek && h.CreatedDate < endOfWeek)
                .CountAsync(); 

            return totalCustomers;
        }

        public async Task<double> GetSoLuongSanPhamTrongTuanNay()
        {
            var startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + 1); 
            var endOfWeek = startOfWeek.AddDays(7);

            var soLuong = await db.ChiTietHoaDonBanHang
                .Join(
                    db.HoaDonBanHang,
                    cthd => cthd.HoaDonId,
                    hdb => hdb.Id,
                    (cthd, hdb) => new { cthd.SoLuong, hdb.CreatedDate }
                )
                .Where(x => x.CreatedDate >= startOfWeek && x.CreatedDate < endOfWeek)
                .SumAsync(x => x.SoLuong);

            return soLuong;
        }

        public async Task<KetQuaTrangThaiHoaDon> GetKetQuaTrangThaiHoaDonTrongTuanNay()
        {
            var startOfWeek = DateTime.UtcNow.AddHours(7).Date.AddDays(-(int)DateTime.UtcNow.AddHours(7).DayOfWeek + 1);
            var endOfWeek = startOfWeek.AddDays(6); // Ngày cuối tuần

            var result = await db.HoaDonBanHang
                .Where(h => (h.TrangThaiDonHang == TrangThai.HoanThanh ||
                             h.TrangThaiDonHang == TrangThai.DaDat ||
                             h.TrangThaiDonHang == TrangThai.DangVanChuyen) &&
                             h.ModifiedDate >= startOfWeek && h.ModifiedDate <= endOfWeek)
                .GroupBy(h => 1)
                .Select(g => new KetQuaTrangThaiHoaDon
                {
                    SoLuongHoanThanh = g.Count(h => h.TrangThaiDonHang == TrangThai.HoanThanh),
                    SoLuongDangXuLy = g.Count(h => h.TrangThaiDonHang == TrangThai.DaDat),
                    SoLuongDangVanChuyen = g.Count(h => h.TrangThaiDonHang == TrangThai.DangVanChuyen)
                })
                .FirstOrDefaultAsync() ?? new KetQuaTrangThaiHoaDon();

            return result;
        }

      

        public async Task<int> GetSoLuongKhachHangTrongThangNay()
        {
            var currentMonth = DateTime.UtcNow.AddHours(7).Month; 
            var currentYear = DateTime.UtcNow.AddHours(7).Year;

            var tongSoKhachHang = await db.HoaDonBanHang
                .Where(h => h.CreatedDate.Month == currentMonth && h.CreatedDate.Year == currentYear)
                .CountAsync();

            return tongSoKhachHang;
        }

        public async Task<double> GetSoLuongSanPhamTrongThangNay()
        {
            var currentMonth = DateTime.UtcNow.AddHours(7).Month; 
            var currentYear = DateTime.UtcNow.AddHours(7).Year;

            var tongSoSanPham = await db.ChiTietHoaDonBanHang
                .Where(ct => ct.HoaDonId != null &&
                             db.HoaDonBanHang
                                .Where(h => h.Id == ct.HoaDonId &&
                                            h.CreatedDate.Month == currentMonth &&
                                            h.CreatedDate.Year == currentYear)
                                .Any())
                .SumAsync(ct => ct.SoLuong);

            return tongSoSanPham;
        }

        public async Task<KetQuaTrangThaiHoaDon> GetKetQuaTrangThaiHoaDonTrongThangNay()
        {
            var now = DateTime.UtcNow.AddHours(7);
            var startOfMonth = new DateTime(now.Year, now.Month, 1); // Ngày đầu tháng
            var endOfMonth = startOfMonth.AddMonths(1).AddDays(-1); // Ngày cuối tháng

            var result = await db.HoaDonBanHang
                .Where(h => (h.TrangThaiDonHang == TrangThai.HoanThanh ||
                             h.TrangThaiDonHang == TrangThai.DaDat ||
                             h.TrangThaiDonHang == TrangThai.DangVanChuyen) &&
                             h.ModifiedDate >= startOfMonth && h.ModifiedDate <= endOfMonth)
                .GroupBy(h => 1)
                .Select(g => new KetQuaTrangThaiHoaDon
                {
                    SoLuongHoanThanh = g.Count(h => h.TrangThaiDonHang == TrangThai.HoanThanh),
                    SoLuongDangXuLy = g.Count(h => h.TrangThaiDonHang == TrangThai.DaDat),
                    SoLuongDangVanChuyen = g.Count(h => h.TrangThaiDonHang == TrangThai.DangVanChuyen)
                })
                .FirstOrDefaultAsync() ?? new KetQuaTrangThaiHoaDon();

            return result;
        }

        public async Task<List<KetQuaHoaDonMoiNgay>> GetTongTienTheoNgayTrongThangNay()
        {
            var currentMonth = DateTime.UtcNow.AddHours(7).Month; 
            var currentYear = DateTime.UtcNow.AddHours(7).Year;

            var result = await db.HoaDonBanHang
                .Where(h => h.CreatedDate.Month == currentMonth && h.CreatedDate.Year == currentYear)
                .GroupBy(h => h.CreatedDate.Date)
                .Select(g => new KetQuaHoaDonMoiNgay
                {
                    Ngay = g.Key,
                    TongTien = g.Sum(h => h.ThanhTien)
                })
                .OrderBy(r => r.Ngay) 
                .ToListAsync();

            return result;
        }
    }

}
