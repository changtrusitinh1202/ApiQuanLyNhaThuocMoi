
using ApiQuanLyNhaThuoc.Models.Entities;
using ApiQuanLyNhaThuoc.Models.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;





namespace ApiQuanLyNhaThuoc.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<DanhMuc> DanhMuc { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<PhienBanSanPham> PhienBanSanPham { get; set; }
        public DbSet<NhaCungCap> NhaCungCap { get; set; }
        public DbSet<HoaDonDatHang> HoaDonDatHang { get; set; }
        public DbSet<HoaDonNhapHang> HoaDonNhapHang { get; set; }
        public DbSet<ChiTietHoaDonDatHang> ChiTietHoaDonDatHang { get; set; }
        public DbSet<ChiTietHoaDonNhapHang> ChiTietHoaDonNhapHang { get; set; }
        public DbSet<LoHang> LoHang { get; set; }
        public DbSet<KhoHang> KhoHang { get; set; }
        public DbSet<HangTonKho> HangTonKho { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>(entity =>
            {
                entity.ToTable(name: "Users");
            });

            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Roles");
            });

            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable(name: "UserRoles");
            });

            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable(name: "UserClaims");
            });

            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable(name: "UserLogins");
            });

            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable(name: "RoleClaims");
            });

            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable(name: "UserTokens");
            });
            //    List<IdentityRole> roles = new List<IdentityRole>
            //        {
            //            new IdentityRole
            //            {
            //                Name = "Admin",
            //                NormalizedName = "ADMIN"
            //            },
            //            new IdentityRole
            //            {
            //                Name = "Employee",
            //                NormalizedName = "EMPLOYEE"
            //            },
            //            new IdentityRole
            //            {
            //                Name = "Customer",
            //                NormalizedName = "CUSTOMER"
            //            }
            //        };
            //    builder.Entity<IdentityRole>().HasData(roles);

            builder.Entity<DanhMuc>().HasData(
                new DanhMuc { Id = Guid.NewGuid(), TenDanhMuc = "Thuốc", MoTa = "Thuốc dị ứng", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new DanhMuc { Id = Guid.NewGuid(), TenDanhMuc = "Thuốc", MoTa = "Thuốc da liễu", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new DanhMuc { Id = Guid.NewGuid(), TenDanhMuc = "Thuốc", MoTa = "Thuốc hô hấp", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new DanhMuc { Id = Guid.NewGuid(), TenDanhMuc = "Thực phẩm chứng năng", MoTa = "Vitamin & Khoáng chất", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new DanhMuc { Id = Guid.NewGuid(), TenDanhMuc = "Thực phẩm chứng năng", MoTa = "Hỗ trợ làm đẹp", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new DanhMuc { Id = Guid.NewGuid(), TenDanhMuc = "Thực phẩm chứng năng", MoTa = "Dinh dưỡng", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now }
             );

           

        }




    }
}
