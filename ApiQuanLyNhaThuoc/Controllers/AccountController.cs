using ApiQuanLyNhaThuoc.Business.Service;
using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.Models.DTOs;
using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.DTOs;
using ApiQuanLyNhaThuoc.Models.Models.Security;
using ApiQuanLyNhaThuoc.Models.Response;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;




namespace ApiQuanLyNhaThuoc.Controllers
{
    [Route("/api/account")]

    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ITokenService _tokenService;
        private readonly SignInManager<AppUser> _signInManager;
        public JwtTokenProvider _jwtTokenProvider;
        public INhanVienService nhanVienService;
        public IKhachHangService khachHangService;
        public AccountController(UserManager<AppUser> userManager, ITokenService tokenService, 
            SignInManager<AppUser> signInManager, 
            JwtTokenProvider jwtTokenProvider, 
            INhanVienService nhanVienService,
            IKhachHangService khachHangService) 
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _signInManager = signInManager;
            _jwtTokenProvider = jwtTokenProvider;
            this.nhanVienService = nhanVienService;
            this.khachHangService = khachHangService;
        }

        [HttpPost("RegisterEmployee")]
        public async Task<IActionResult> RegisterEmployee([FromBody] RegisterDTO registerDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                var appUser = new AppUser
                {
                    UserName = registerDto.Username,
                    Email = registerDto.EmailAddress,
                  //  Quyen = registerDto.Quyen,
                    Ten = registerDto.HoTen,
                    DiaChi = registerDto.DiaChi,
                    ThanhPho = registerDto.ThanhPho,
                    GioiTinh = registerDto.GioiTinh,
                    NgaySinh = registerDto.NgaySinh,
                    PhoneNumber = registerDto.SoDienThoai
                };

                var createUser = await _userManager.CreateAsync(appUser, registerDto.MatKhau);

                if(createUser.Succeeded)
                {
                    var roleResult = await _userManager.AddToRoleAsync(appUser, "EMPLOYEE MANAGER");
                    if (roleResult.Succeeded)
                    {
                         nhanVienService.AddNhanVien(new NhanVien
                        {
                            Id = appUser.Id,
                            ChucVu = "Nhân viên",
                            HeSoLuong = 1,
                            CreatedDate = DateTime.Now,
                            ModifiedDate = DateTime.Now 

                        });
                        return Ok(
                            new UserDTO
                            {
                                UserName = appUser.UserName,
                                Email = appUser.Email,
                               
                            }
                        );
                    }
                    else
                    {
                        return StatusCode(500, roleResult.Errors);
                    }

                }
                else
                {
                    return StatusCode(500, createUser.Errors);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost("RegisterCustomer")]
        public async Task<IActionResult> RegisterCustomer([FromBody] RegisterDTO registerDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                var appUser = new AppUser
                {
                    UserName = registerDto.Username,
                    Email = registerDto.EmailAddress,
                    Quyen = "CUSTOMER",
                    Ten = registerDto.HoTen,
                    DiaChi = registerDto.DiaChi,
                    ThanhPho = registerDto.ThanhPho,
                    GioiTinh = registerDto.GioiTinh,
                    NgaySinh = registerDto.NgaySinh,
                    PhoneNumber = registerDto.SoDienThoai
                };

                var createUser = await _userManager.CreateAsync(appUser, registerDto.MatKhau);

                if (createUser.Succeeded)
                {
                    var roleResult = await _userManager.AddToRoleAsync(appUser, "CUSTOMER");
                    if (roleResult.Succeeded)
                    {
                        khachHangService.AddKhachHang(new KhachHang
                        {
                            Id = appUser.Id,
                            TichDiem = 0,
                            RankKhachHang = "Đồng",
                            CreatedDate = DateTime.Now,
                            ModifiedDate = DateTime.Now

                        });
                       
                        return Ok(
                            new UserDTO
                            {
                                UserName = appUser.UserName,
                                Email = appUser.Email,

                            }
                        );
                    }
                    else
                    {
                        return StatusCode(500, roleResult.Errors);
                    }

                }
                else
                {
                    return StatusCode(500, createUser.Errors);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        [HttpPost("RegisterCustomerBanHang")]
        public async Task<IActionResult> RegisterCustomerBanHang([FromBody] RegisterBanHangDTO registerDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var appUser = new AppUser
                {
                    Ten = registerDto.HoTen,
                    PhoneNumber = registerDto.SoDienThoai,
                    //Quyen = "CUSTOMER",
                    UserName = registerDto.SoDienThoai
                };

                // Lưu trữ PasswordValidator gốc
                var originalPasswordValidators = _userManager.PasswordValidators.ToList();

                // Thay thế PasswordValidator bằng CustomPasswordValidator
                _userManager.PasswordValidators.Clear();
                _userManager.PasswordValidators.Add(new CustomPasswordValidator<AppUser>());

                // Tạo người dùng mà không kiểm tra mật khẩu
                var createUser = await _userManager.CreateAsync(appUser, "");

                // Khôi phục PasswordValidator gốc sau khi tạo người dùng
                _userManager.PasswordValidators.Clear();
                foreach (var validator in originalPasswordValidators)
                {
                    _userManager.PasswordValidators.Add(validator);
                }

                if (createUser.Succeeded)
                {
                    var roleResult = await _userManager.AddToRoleAsync(appUser, "CUSTOMER");
                    if (roleResult.Succeeded)
                    {
                        khachHangService.AddKhachHang(new KhachHang
                        {
                            Id = appUser.Id,
                            TichDiem = 0,
                            RankKhachHang = "Đồng",
                            CreatedDate = DateTime.Now,
                            ModifiedDate = DateTime.Now
                        });

                        return Ok("Thành công");
                    }
                    else
                    {
                        return StatusCode(500, roleResult.Errors);
                    }
                }
                else
                {
                    return StatusCode(500, createUser.Errors);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == loginDTO.UserName.ToLower());
            if (user == null)
                return Unauthorized("Invalid Username!");

            var accessToken = _tokenService.CreateToken(user);
            var refeshToken = _tokenService.GenerateRefeshToken();
            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDTO.Password, false);

            if (!result.Succeeded)
                return Unauthorized("Username not found and/or password incorrect!");

            return Ok(
                new TokenResponse
                {
                    AccessToken = await accessToken,
                    RefreshToken = refeshToken,                
                }
            );
        }

        [HttpPost("refresh")]
        public IActionResult Refresh(TokenResponse tokenResponse)
        {

            var newAccessToken = _tokenService.GenerateAccessTokenFromRefeshToken(tokenResponse.RefreshToken);

            var response = new TokenResponse
            {
                AccessToken = newAccessToken,
                RefreshToken = tokenResponse.RefreshToken // Return the same refresh token
            };

            return Ok(response);
        }

        [HttpGet("GetText")]
        public IActionResult GetText()
        {
            return Ok("hi");
        }

        [HttpGet("GetUser")]
        public JwtTokenClaims GetUser(string token)
        {
            JwtTokenClaims tokenClaims = _jwtTokenProvider.GetTokenClaims(token);
            return tokenClaims;
        }

        [HttpGet("GetUserById")]
        public IActionResult GetUserById(string token)
        {
            NhanVien nhanVien = nhanVienService.GetNhanVienById(token);
            return Ok(nhanVien);
        }

    }
}
