using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddTableAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanhMuc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "NhaCungCap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    AnhSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThaiBan = table.Column<int>(type: "int", nullable: false),
                    DanhMucId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "HoaDonDatHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThaiNhap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhaCungCapId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenQuyDoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonViQuyDoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false),
                    MaVach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaNhapQuyDoi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaBanQuyDoi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThaiBan = table.Column<int>(type: "int", nullable: false),
                    SanPhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                name: "ChiTietHoaDonDatHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoaDonDatHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhienBanSanPhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false),
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
                name: "KhoHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ViTriLuuTru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhienBanSanPhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                name: "HangTonKho",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhoHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhienBanSanPhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_HangTonKho_PhienBanSanPham_PhienBanSanPhamId",
                        column: x => x.PhienBanSanPhamId,
                        principalTable: "PhienBanSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonNhapHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThaiThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayNhapHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoaDonDatHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KhoHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NhaCungCapId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LoHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaLoHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySanXuat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuongQuyDoi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhienBanSanPhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NhaCungCapId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhoHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoaDonNhapHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhienBanSanPhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false),
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
                        name: "FK_ChiTietHoaDonNhapHang_PhienBanSanPham_PhienBanSanPhamId",
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
                    { new Guid("585e1032-5a9e-4e1f-a64e-df0e7809cd6f"), null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9744), "Thuốc dị ứng", null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9755), "Thuốc" },
                    { new Guid("9bc2e6c2-bdde-424a-bee8-d602c3f4f8a0"), null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9774), "Vitamin & Khoáng chất", null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9774), "Thực phẩm chứng năng" },
                    { new Guid("c7aaec50-473c-43aa-b41a-65fe2a9bd944"), null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9776), "Hỗ trợ làm đẹp", null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9776), "Thực phẩm chứng năng" },
                    { new Guid("cf9e9154-c5b2-4fa5-9abc-20957f368e6f"), null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9771), "Thuốc hô hấp", null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9772), "Thuốc" },
                    { new Guid("d5934ba7-6337-4bfb-bf42-f6034ea58e1a"), null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9778), "Dinh dưỡng", null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9779), "Thực phẩm chứng năng" },
                    { new Guid("d9cad089-989d-422a-b8a9-3d3605b794d2"), null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9758), "Thuốc da liễu", null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9759), "Thuốc" }
                });

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
                name: "IX_ChiTietHoaDonNhapHang_PhienBanSanPhamId",
                table: "ChiTietHoaDonNhapHang",
                column: "PhienBanSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_HangTonKho_KhoHangId",
                table: "HangTonKho",
                column: "KhoHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HangTonKho_PhienBanSanPhamId",
                table: "HangTonKho",
                column: "PhienBanSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonDatHang_NhaCungCapId",
                table: "HoaDonDatHang",
                column: "NhaCungCapId");

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
                name: "ChiTietHoaDonDatHang");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDonNhapHang");

            migrationBuilder.DropTable(
                name: "HangTonKho");

            migrationBuilder.DropTable(
                name: "LoHang");

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
                name: "HoaDonNhapHang");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "HoaDonDatHang");

            migrationBuilder.DropTable(
                name: "KhoHang");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "PhienBanSanPham");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "DanhMuc");
        }
    }
}
