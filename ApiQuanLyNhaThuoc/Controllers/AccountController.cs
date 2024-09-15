using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.Models.DTOs;
using ApiQuanLyNhaThuoc.Models.Entities;
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
        public AccountController(UserManager<AppUser> userManager, ITokenService tokenService, SignInManager<AppUser> signInManager) 
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _signInManager = signInManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO registerDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                var appUser = new AppUser
                {
                    UserName = registerDto.Username,
                    Email = registerDto.EmailAddress
                };

                var createUser = await _userManager.CreateAsync(appUser, registerDto.Password);

                if(createUser.Succeeded)
                {
                    var roleResult = await _userManager.AddToRoleAsync(appUser, "Customer");
                    if (roleResult.Succeeded)
                    {
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

        [HttpPost("login")]
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
                    AccessToken = accessToken,
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

    }
}
