using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Utility
{
    public class ChuyenDoiDonVi
    {
        public static double ChuyenDoiDonViKhoiLuong(string khoiLuong)
        {
            
            if(khoiLuong.Contains("kg"))
                return Regex.Match(khoiLuong, @"\d+").Value == "" ? 0 : double.Parse(Regex.Match(khoiLuong, @"\d+").Value);
            if(khoiLuong.Contains("g"))
                return Regex.Match(khoiLuong, @"\d+").Value == "" ? 0 : double.Parse(Regex.Match(khoiLuong, @"\d+").Value) / 1000;
            return 0;
        }
    }
}
