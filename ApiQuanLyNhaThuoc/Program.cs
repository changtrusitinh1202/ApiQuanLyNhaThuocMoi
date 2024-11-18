
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ApiQuanLyNhaThuoc.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Business.Service.IService;
using ApiQuanLyNhaThuoc.Business.Service;
using SwaggerThemes;
using AspNetCore.Swagger.Themes;
using Microsoft.AspNetCore.Identity.UI.Services;
using ApiQuanLyNhaThuoc.Utility;
using ApiQuanLyNhaThuoc.Models.Models.Security;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddEndpointsApiExplorer();

//var connectionString = builder.Configuration.GetConnectionString("DatabaseQLNT");
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseQLNT")));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Pharmacy API",
        Version = "v1",
        Description = "API Quản lý nhà thuốc dùng cho cả Web và Mobile (by Gia Huy)",
        Contact = new OpenApiContact()
        {
            Email = "phamhagiahuy1708@gmail.com",
            Name = " Huy Pham"
        },
    });
});



builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseQLNT")));
    

builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 12;
  
}).AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddSingleton(new TokenValidationParameters
{
    ValidateIssuer = true,
    ValidIssuer = builder.Configuration["JWT:Issuer"],
    ValidateAudience = true,
    ValidAudience = builder.Configuration["JWT:Audience"],
    IssuerSigningKey = new SymmetricSecurityKey(
        System.Text.Encoding.UTF8.GetBytes(builder.Configuration["JWT:SigningKey"])
    ),
    ValidateIssuerSigningKey = true,
    ValidateLifetime = true // Đảm bảo token không hết hạn
});

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme =
    options.DefaultChallengeScheme =
    options.DefaultForbidScheme =
    options.DefaultScheme =
    options.DefaultSignInScheme =
    options.DefaultSignOutScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = options.TokenValidationParameters = builder.Services.BuildServiceProvider().GetRequiredService<TokenValidationParameters>();


});



builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IDanhMucService, DanhMucService>();
builder.Services.AddScoped<ISanPhamService, SanPhamService>();
builder.Services.AddScoped<IPhienBanSanPhamService, PhienBanSanPhamService>();
builder.Services.AddScoped<INhaCungCapService, NhaCungCapService>();
builder.Services.AddScoped<IHoaDonDatHangService, HoaDonDatHangService>();
builder.Services.AddScoped<IHoaDonNhapHangService, HoaDonNhapHangService>();
builder.Services.AddScoped<ILoHangService, LoHangService>();
builder.Services.AddScoped<IKhoHangService, KhoHangService>();
builder.Services.AddScoped<IHangTonKhoService, HangTonKhoService>();
builder.Services.AddScoped<IHoaDonBanHangService, HoaDonBanHangService>();
builder.Services.AddScoped<INhanVienService, NhanVienService>();
builder.Services.AddScoped<IKhachHangService, KhachHangService>();
builder.Services.AddScoped<ITongQuanService, TongQuanService>();
builder.Services.AddScoped<IGioHangService, GioHangService>();
builder.Services.AddScoped<IDiaChiKhachHangService, DiaChiKhachHangService>();
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JWT"));
builder.Services.AddSingleton<JwtTokenProvider>();

builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.EnableSensitiveDataLogging();
});
var app = builder.Build();


app.UseStaticFiles();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1 by Gia Huy");
        options.RoutePrefix = string.Empty;
        //options.InjectStylesheet("/css/xmas.css");
        //options.InjectJavascript("/js/custom.js");
        //options.DocumentTitle = "My Swagger";
    });
}

app.UseHttpsRedirection();
app.UseCors("AllowAll");

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
