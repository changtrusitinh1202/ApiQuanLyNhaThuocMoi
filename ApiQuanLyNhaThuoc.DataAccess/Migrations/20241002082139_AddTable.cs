using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanhMuc",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenDanhMuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNhaCungCap = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ThanhPho = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    QuocGia = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrangThaiGiaoDich = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThanhPho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Quyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaThuoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaVach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDangKy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonViTinhNhoNhat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiThuoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoatChatChinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HangSanXuat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NuocSanXuat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuyCachDongGoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DuongDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhSanPham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThaiBan = table.Column<bool>(type: "bit", nullable: false),
                    DanhMucId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPham_DanhMuc_DanhMucId",
                        column: x => x.DanhMucId,
                        principalTable: "DanhMuc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhachHang_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeSoLuong = table.Column<double>(type: "float", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhienBanSanPham",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenQuyDoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonViQuyDoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false),
                    MaVach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhoiLuong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaNhapQuyDoi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaBanQuyDoi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThaiBan = table.Column<bool>(type: "bit", nullable: false),
                    SanPhamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhienBanSanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhienBanSanPham_SanPham_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonBanHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KhachHangId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NhanVienId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    KhuyenMaiId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HinhThucMuaHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhThucThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThaiDonHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThaiThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thue = table.Column<double>(type: "float", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonBanHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonBanHang_KhachHang_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHang",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDonBanHang_KhuyenMai_KhuyenMaiId",
                        column: x => x.KhuyenMaiId,
                        principalTable: "KhuyenMai",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDonBanHang_NhanVien_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanVien",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonDatHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThaiNhap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhaCungCapId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NhanVienId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thue = table.Column<double>(type: "float", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonDatHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonDatHang_NhaCungCap_NhaCungCapId",
                        column: x => x.NhaCungCapId,
                        principalTable: "NhaCungCap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonDatHang_NhanVien_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietGiamGia",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KhuyenMaiId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhienBanSanPhamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GiamGia = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietGiamGia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietGiamGia_KhuyenMai_KhuyenMaiId",
                        column: x => x.KhuyenMaiId,
                        principalTable: "KhuyenMai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietGiamGia_PhienBanSanPham_PhienBanSanPhamId",
                        column: x => x.PhienBanSanPhamId,
                        principalTable: "PhienBanSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhoHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ViTriLuuTru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhienBanSanPhamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhoHang_PhienBanSanPham_PhienBanSanPhamId",
                        column: x => x.PhienBanSanPhamId,
                        principalTable: "PhienBanSanPham",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDonBanHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoaDonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhienBanSanPhamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDonBanHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonBanHang_HoaDonBanHang_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "HoaDonBanHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonBanHang_PhienBanSanPham_PhienBanSanPhamId",
                        column: x => x.PhienBanSanPhamId,
                        principalTable: "PhienBanSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDonDatHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoaDonDatHangId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhienBanSanPhamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoLuongDat = table.Column<double>(type: "float", nullable: false),
                    SoLuongDaNhap = table.Column<double>(type: "float", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDonDatHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonDatHang_HoaDonDatHang_HoaDonDatHangId",
                        column: x => x.HoaDonDatHangId,
                        principalTable: "HoaDonDatHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonDatHang_PhienBanSanPham_PhienBanSanPhamId",
                        column: x => x.PhienBanSanPhamId,
                        principalTable: "PhienBanSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonNhapHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrangThaiThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoaDonDatHangId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thue = table.Column<double>(type: "float", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KhoHangId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NhaCungCapId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NhanVienId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonNhapHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonNhapHang_HoaDonDatHang_HoaDonDatHangId",
                        column: x => x.HoaDonDatHangId,
                        principalTable: "HoaDonDatHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonNhapHang_KhoHang_KhoHangId",
                        column: x => x.KhoHangId,
                        principalTable: "KhoHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonNhapHang_NhaCungCap_NhaCungCapId",
                        column: x => x.NhaCungCapId,
                        principalTable: "NhaCungCap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_HoaDonNhapHang_NhanVien_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LoHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgaySanXuat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuongQuyDoi = table.Column<double>(type: "float", nullable: false),
                    PhienBanSanPhamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NhaCungCapId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KhoHangId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoHang_KhoHang_KhoHangId",
                        column: x => x.KhoHangId,
                        principalTable: "KhoHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoHang_NhaCungCap_NhaCungCapId",
                        column: x => x.NhaCungCapId,
                        principalTable: "NhaCungCap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoHang_PhienBanSanPham_PhienBanSanPhamId",
                        column: x => x.PhienBanSanPhamId,
                        principalTable: "PhienBanSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDonNhapHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoLuongNhap = table.Column<double>(type: "float", nullable: false),
                    HoaDonNhapHangId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhienBanSanPhamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoHangId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDonNhapHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonNhapHang_HoaDonNhapHang_HoaDonNhapHangId",
                        column: x => x.HoaDonNhapHangId,
                        principalTable: "HoaDonNhapHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonNhapHang_LoHang_LoHangId",
                        column: x => x.LoHangId,
                        principalTable: "LoHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonNhapHang_PhienBanSanPham_PhienBanSanPhamId",
                        column: x => x.PhienBanSanPhamId,
                        principalTable: "PhienBanSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HangTonKho",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KhoHangId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhienBanSanPhamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoHangId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoLuongTrongKho = table.Column<double>(type: "float", nullable: false),
                    SoLuongCoTheBan = table.Column<double>(type: "float", nullable: false),
                    SoLuongDangVe = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangTonKho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HangTonKho_KhoHang_KhoHangId",
                        column: x => x.KhoHangId,
                        principalTable: "KhoHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HangTonKho_LoHang_LoHangId",
                        column: x => x.LoHangId,
                        principalTable: "LoHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_HangTonKho_PhienBanSanPham_PhienBanSanPhamId",
                        column: x => x.PhienBanSanPhamId,
                        principalTable: "PhienBanSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DanhMuc",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "MoTa", "ModifiedBy", "ModifiedDate", "TenDanhMuc" },
                values: new object[,]
                {
                    { "DM111", null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5400), "Thuốc dị ứng", null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5412), "Thuốc" },
                    { "DM112", null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5414), "Thuốc da liễu", null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5415), "Thuốc" },
                    { "DM113", null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5416), "Thuốc hô hấp", null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5416), "Thuốc" },
                    { "DM114", null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5417), "Vitamin & Khoáng chất", null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5418), "Thực phẩm chứng năng" },
                    { "DM115", null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5419), "Hỗ trợ làm đẹp", null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5419), "Thực phẩm chứng năng" },
                    { "DM116", null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5420), "Dinh dưỡng", null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5421), "Thực phẩm chứng năng" }
                });

            migrationBuilder.InsertData(
                table: "KhoHang",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "PhienBanSanPhamId", "ViTriLuuTru" },
                values: new object[] { "KHO001", null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5591), null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5591), null, "Chi nhánh mặc định" });

            migrationBuilder.InsertData(
                table: "NhaCungCap",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DiaChi", "Email", "ModifiedBy", "ModifiedDate", "QuocGia", "SoDienThoai", "TenNhaCungCap", "ThanhPho", "TrangThaiGiaoDich", "Website" },
                values: new object[] { "NCC001", null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5558), "123 Lê Lợi", "longchaugv@gmail.com", null, new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5560), "Việt Nam", "0123456789", "Nhà thuốc Long Châu", "Hồ Chí Minh", 1, "longchau.com" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ceee5a2-2813-4429-ae0d-ac82db8f7e94", null, "Admin", "ADMIN" },
                    { "1d7c095a-00b4-41ff-a9e3-57daa5f5767a", null, "Employee", "EMPLOYEE" },
                    { "cd81f91b-751c-4e0b-8063-30aa0fe1aae1", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiamGia_KhuyenMaiId",
                table: "ChiTietGiamGia",
                column: "KhuyenMaiId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiamGia_PhienBanSanPhamId",
                table: "ChiTietGiamGia",
                column: "PhienBanSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonBanHang_HoaDonId",
                table: "ChiTietHoaDonBanHang",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonBanHang_PhienBanSanPhamId",
                table: "ChiTietHoaDonBanHang",
                column: "PhienBanSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonDatHang_HoaDonDatHangId",
                table: "ChiTietHoaDonDatHang",
                column: "HoaDonDatHangId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonDatHang_PhienBanSanPhamId",
                table: "ChiTietHoaDonDatHang",
                column: "PhienBanSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonNhapHang_HoaDonNhapHangId",
                table: "ChiTietHoaDonNhapHang",
                column: "HoaDonNhapHangId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonNhapHang_LoHangId",
                table: "ChiTietHoaDonNhapHang",
                column: "LoHangId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonNhapHang_PhienBanSanPhamId",
                table: "ChiTietHoaDonNhapHang",
                column: "PhienBanSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_HangTonKho_KhoHangId",
                table: "HangTonKho",
                column: "KhoHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HangTonKho_LoHangId",
                table: "HangTonKho",
                column: "LoHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HangTonKho_PhienBanSanPhamId",
                table: "HangTonKho",
                column: "PhienBanSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBanHang_KhachHangId",
                table: "HoaDonBanHang",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBanHang_KhuyenMaiId",
                table: "HoaDonBanHang",
                column: "KhuyenMaiId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBanHang_NhanVienId",
                table: "HoaDonBanHang",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonDatHang_NhaCungCapId",
                table: "HoaDonDatHang",
                column: "NhaCungCapId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonDatHang_NhanVienId",
                table: "HoaDonDatHang",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonNhapHang_HoaDonDatHangId",
                table: "HoaDonNhapHang",
                column: "HoaDonDatHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonNhapHang_KhoHangId",
                table: "HoaDonNhapHang",
                column: "KhoHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonNhapHang_NhaCungCapId",
                table: "HoaDonNhapHang",
                column: "NhaCungCapId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonNhapHang_NhanVienId",
                table: "HoaDonNhapHang",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_KhoHang_PhienBanSanPhamId",
                table: "KhoHang",
                column: "PhienBanSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_LoHang_KhoHangId",
                table: "LoHang",
                column: "KhoHangId");

            migrationBuilder.CreateIndex(
                name: "IX_LoHang_NhaCungCapId",
                table: "LoHang",
                column: "NhaCungCapId");

            migrationBuilder.CreateIndex(
                name: "IX_LoHang_PhienBanSanPhamId",
                table: "LoHang",
                column: "PhienBanSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_PhienBanSanPham_SanPhamId",
                table: "PhienBanSanPham",
                column: "SanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_DanhMucId",
                table: "SanPham",
                column: "DanhMucId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietGiamGia");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDonBanHang");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDonDatHang");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDonNhapHang");

            migrationBuilder.DropTable(
                name: "HangTonKho");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "HoaDonBanHang");

            migrationBuilder.DropTable(
                name: "HoaDonNhapHang");

            migrationBuilder.DropTable(
                name: "LoHang");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "HoaDonDatHang");

            migrationBuilder.DropTable(
                name: "KhoHang");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "PhienBanSanPham");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "DanhMuc");
        }
    }
}
