using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class GenerateId
    {
        public static string TaoMaSanPham()
        {
            Random random = new Random();
            return "SP" + System.DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
        }

        public static string TaoMaPhienBanSanPham()
        {
            Random random = new Random();
            return "PBSP" + System.DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
        }

        public static string TaoMaNhaCungCap()
        {
            Random random = new Random();
            return "NCC" + System.DateTime.Now.ToString("ddMMyyyyHHmmss");
        }

        public static string TaoMaLoHang()
        {
            Random random = new Random();
            return "LH" + System.DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
        }

        public static string TaoMaKhuyenMai()
        {
            Random random = new Random();
            return "KM" + System.DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
        }

        public static string TaoMaKhoHang()
        {
            Random random = new Random();
            return "KHO" + System.DateTime.Now.ToString("ddMMyyyyHHmmss");
        }

        public static string TaoMaHoaDonNhapHang()
        {
            Random random = new Random();
            return "HDNH" + System.DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
        }

        public static string TaoMaHoaDonDatHang()
        {
            Random random = new Random();
            return "HDDH" + System.DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
        }

        public static string TaoMaHoaDonBanHang()
        {
            Random random = new Random();
            return "HDBH" + System.DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
        }

        public static string TaoMaHangTonKho()
        {
            Random random = new Random();
            return "HTK" + System.DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
        }

        public static string TaoMaDanhMuc()
        {
            Random random = new Random();
            return "DM" + System.DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
        }

        public static string TaoMaChiTietHoaDonNhapHang()
        {
            Random random = new Random();
            return "CTHDNH" + System.DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
        }

        public static string TaoMaChiTietHoaDonDatHang()
        {
            Random random = new Random();
            return "CTHDDH" + System.DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
        }

        public static string TaoMaChiTietHoaDonBanHang()
        {
            Random random = new Random();
            return "CTHDBH" + System.DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
        }

        public static string TaoMaChiTietGiamGia()
        {
            Random random = new Random();
            return "CTGG" + System.DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
        }
    }
}
