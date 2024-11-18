using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service
{
    public class DiaChiKhachHangService : IDiaChiKhachHangService
    {
        ApplicationDbContext db;
        public IKhachHangService khachHangService;
        public DiaChiKhachHangService(ApplicationDbContext db, IKhachHangService khachHangService)
        {
            this.db = db;
            this.khachHangService = khachHangService;
        }
        public void ThemDiaChiKhachHang(string khachHangId, DiaChiKhachHang diaChiKhachHang)
        {
            KhachHang khachHang = khachHangService.GetKhachHangByID(khachHangId);
            diaChiKhachHang.KhachHangId = khachHangId;
            diaChiKhachHang.CreatedDate = DateTime.Now;
            diaChiKhachHang.MacDinh = false;
            db.DiaChiKhachHang.Add(diaChiKhachHang);
            db.SaveChanges();
        }

        public void UpdateDiaChiKhachHang(string khachHangId, int diaChiKhachHangId, DiaChiKhachHang diaChiKhachHang)
        {
            bool khachHangExists = db.KhachHang.Any(kh => kh.Id == khachHangId);
            if (!khachHangExists)
            {
                throw new Exception($"KhachHangId '{khachHangId}' không tồn tại trong bảng KhachHang.");
            }

            // Lấy thực thể cần cập nhật từ cơ sở dữ liệu
            DiaChiKhachHang diaChiKhachHangTim = db.DiaChiKhachHang
                .FirstOrDefault(dc => dc.Id == diaChiKhachHangId && dc.KhachHangId == khachHangId);
            if (diaChiKhachHangTim != null)
            {
                // Cập nhật các thuộc tính cần thay đổi
                diaChiKhachHangTim.TenNguoiNhan = diaChiKhachHang.TenNguoiNhan;
                diaChiKhachHangTim.SoDienThoaiNguoiNhan = diaChiKhachHang.SoDienThoaiNguoiNhan;
                diaChiKhachHangTim.DiaChiNguoiNhan = diaChiKhachHang.DiaChiNguoiNhan;
                diaChiKhachHangTim.XaPhuongNguoiNhan = diaChiKhachHang.XaPhuongNguoiNhan;
                diaChiKhachHangTim.QuanHuyenNguoiNhan = diaChiKhachHang.QuanHuyenNguoiNhan;
                diaChiKhachHangTim.TinhThanhNguoiNhan = diaChiKhachHang.TinhThanhNguoiNhan;
                diaChiKhachHangTim.ModifiedDate = DateTime.Now;

                // Lưu thay đổi
                db.SaveChanges();
            }
            else
            {
                throw new Exception($"Không tìm thấy DiaChiKhachHang với Id '{diaChiKhachHangId}' và KhachHangId '{khachHangId}'.");
            }
        }

        public void XoaDiaChiKhachHang(string khachHangId, int diaChiKhachHangId)
        {
            DiaChiKhachHang? diaChiKhachHang = this.LayDiaChiKhachHang(khachHangId, diaChiKhachHangId);
            if (diaChiKhachHang != null)
            {
                db.DiaChiKhachHang.Remove(diaChiKhachHang);
                db.SaveChanges();
            }
        }

        public List<DiaChiKhachHang> LayDanhSachDiaChiKhachHang(string khachHangId)
        {
            List<DiaChiKhachHang> diaChiKhachHangs = db.DiaChiKhachHang.Where(x => x.KhachHangId == khachHangId).ToList();
            return diaChiKhachHangs;
        }

        public DiaChiKhachHang LayDiaChiKhachHang(string khachHangId, int diaChiKhachHangId)
        {
            DiaChiKhachHang? diaChiKhachHang = db.DiaChiKhachHang.FirstOrDefault(x => x.Id == diaChiKhachHangId && x.KhachHangId == khachHangId);
            return diaChiKhachHang;
        }

        public void SetDefaultDiaChiKhachHang(string khachHangId, int diaChiKhachHangId)
        {
   
            var diaChiKhachHangList = db.DiaChiKhachHang
                .Where(dc => dc.KhachHangId == khachHangId)
                .ToList();

            if (!diaChiKhachHangList.Any())
            {
                throw new Exception($"Khách hàng với ID '{khachHangId}' không có địa chỉ nào trong hệ thống.");
            }


            var diaChiKhachHangMoi = diaChiKhachHangList.FirstOrDefault(dc => dc.Id == diaChiKhachHangId);
            if (diaChiKhachHangMoi == null)
            {
                throw new Exception($"Không tìm thấy địa chỉ với ID '{diaChiKhachHangId}' cho khách hàng '{khachHangId}'.");
            }

    
            foreach (var diaChi in diaChiKhachHangList)
            {
                if (diaChi.MacDinh)
                {
                    diaChi.MacDinh = false;
                }
            }


            diaChiKhachHangMoi.MacDinh = true;

 
            db.SaveChanges();
        }
    }
}
