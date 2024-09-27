using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.DTOs
{
    public class ThuocQuocGia
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Registration_no { get; set; }
        public string? Element { get; set; }
        public string? Content { get; set; }
        public string? Packing { get; set; }
        public string Manufacturer { get; set; }
        public string? Manufacturer_country { get; set; }
        public string? Unit { get; set; }
    }
}
