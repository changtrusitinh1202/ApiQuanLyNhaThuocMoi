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
        public Guid Id { get; set; }
        [ForeignKey("KhoHang")]
        public Guid KhoHangId { get; set; }
        public KhoHang KhoHang{ get; private set; }
        [ForeignKey("PhienBanSanPham")]
        public Guid PhienBanSanPhamId { get; set; }
        public PhienBanSanPham PhienBanSanPham {  get; private set; }
        
        public double SoLuongTrongKho { get; set; }
        public double SoLuongCoTheBan {  get; set; }
        public double SoLuongDangVe {  get; set; }
    }
}
