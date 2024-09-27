using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.Entities
{
    public class HangTonKho
    {
        public string Id { get; set; }
        [ForeignKey("KhoHang")]
        public string KhoHangId { get; set; }
        public KhoHang? KhoHang { get; private set; }
        [ForeignKey("PhienBanSanPham")]
        public string PhienBanSanPhamId { get; set; }
        public PhienBanSanPham? PhienBanSanPham {  get; private set; }
        [ForeignKey("LoHang")]
        public string LoHangId { get; set; }
        public LoHang? LoHang { get; private set; }
        public double SoLuongTrongKho { get; set; }
        public double SoLuongCoTheBan {  get; set; }
        public double SoLuongDangVe {  get; set; }

     
    }
}
