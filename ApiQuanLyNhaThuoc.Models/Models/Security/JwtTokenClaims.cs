using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.Security
{
    public class JwtTokenClaims
    {
        [Required]
        public string UserName { get; set; }
    }
}
