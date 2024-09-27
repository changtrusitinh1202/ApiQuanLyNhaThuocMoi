using ApiQuanLyNhaThuoc.Models.Models.DTOs;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Business.Service.IService
{
    public interface ILoHangService
    {
        List<LoHangDTO> GetLoHangs();
        void CapNhatLoHang(LoHang loHang, double soLuongQuyDoi);
    }
}
