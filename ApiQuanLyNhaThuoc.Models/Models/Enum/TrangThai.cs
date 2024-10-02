using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.Enum
{
    public class TrangThai
    {
        // Dùng cho hóa đơn đặt hàng
        public const string ChuaNhap = "Chưa nhập";
        public const string NhapMotPhan = "Nhập một phần";
        public const string HoanThanh = "Hoàn thành";
        public const string KetThuc = "Kết thúc";
        // Dùng cho thanh toán
        public const string DaThanhToan = "Đã thanh toán";
        public const string ChuaThanhToan = "Chưa thanh toán";
        //
        public const string GiaoDich = "Đang giao dịch";
        public const string NgungGiaoDich = "Ngừng giao dịch";
        // Dùng cho hóa đơn bán hàng (
        public const string f = "Đã xuất";
    }
}
