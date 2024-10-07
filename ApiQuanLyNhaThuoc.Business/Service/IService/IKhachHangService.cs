using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service.IService
{
    public interface IKhachHangService
    {
        void AddKhachHang(KhachHang khachHang);
        KhachHangDTO GetKhachHangByToken(string token);
    }
}
