using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.Security
{
    public class CustomPasswordValidator<TUser> : IPasswordValidator<TUser> where TUser : class
    {
        public Task<IdentityResult> ValidateAsync(UserManager<TUser> manager, TUser user, string password)
        {
            // Luôn trả về thành công, bỏ qua mọi kiểm tra mật khẩu
            return Task.FromResult(IdentityResult.Success);
        }
    }
}
