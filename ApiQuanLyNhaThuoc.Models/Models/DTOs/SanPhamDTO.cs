using ApiQuanLyNhaThuoc.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.DTOs
{
    public class SanPhamDTO
    {
        public string Id { get; set; }
        public string MaThuoc { get; set; }
        public string TenSanPham { get; set; }
        public string MaVach { get; set; }
        public string SoDangKy { get; set; }
        public string DonViTinhNhoNhat { get; set; }
        public string LoaiThuoc { get; set; }
        public string? Mota { get; set; }
        public string HoatChatChinh { get; set; }
        public string HangSanXuat { get; set; }
        public string NuocSanXuat { get; set; }
        public string QuyCachDongGoi { get; set; }
        public string DuongDung { get; set; }
        public string? AnhSanPham { get; set; }
        public bool TrangThaiBan { get; set; }
        public string DanhMucId { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }


        // Danh sách các phiên bản sản phẩm
        public List<PhienBanSanPhamDTO> DanhSachPhienBan { get; set; }

        public static string TaoMaSanPham()
        {
            Random random = new Random();
            return "SP" + System.DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
        }
    }
}
