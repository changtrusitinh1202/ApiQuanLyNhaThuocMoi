using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Models.Models.Security
{
    public class JwtTokenProvider
    {
        private readonly TokenValidationParameters _tokenValidationParameters;

        public JwtTokenProvider(TokenValidationParameters tokenValidationParameters)
        {
            _tokenValidationParameters = tokenValidationParameters;
        }
        public JwtTokenClaims GetTokenClaims(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            try
            {
                // Xác thực và giải mã token sử dụng TokenValidationParameters
                var principal = tokenHandler.ValidateToken(token, _tokenValidationParameters, out SecurityToken validatedToken);

                // Lấy claim từ token
                var username = principal.Claims.FirstOrDefault(c => c.Type == ClaimTypes.GivenName)?.Value;

                return new JwtTokenClaims
                {
                    UserName = username
                };
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu token không hợp lệ
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
