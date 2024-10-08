﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        [EmailAddress]
        public string? EmailAddress { get; set; }
        [Required]
        public string? MatKhau { get; set; }
        public string? HoTen { get; set; }
        public string? DiaChi { get; set; }
        public string? ThanhPho { get; set; }
        public bool? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? Quyen { get; set; }
        [Required]
        public string SoDienThoai { get; set; }
       
    }
}
