using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ModiFyandAddTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "094e7378-a827-49a1-b754-9760082b68b4");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "49d7a0b9-3921-4c8e-aa6e-827c7f425469");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a14c3b06-03c6-4908-bdd4-d3516fb84476");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "beb947c0-45c6-41df-9381-ac91b3b05d7f");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c6b17923-9fc2-49f1-a1f9-74fcea74094a");

            migrationBuilder.AlterColumn<string>(
                name: "KhoiLuong",
                table: "PhienBanSanPham",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "GiaoHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaDonRutGon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenNguoiGui = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoaiNguoiGui = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiNguoiGui = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuanHuyenNguoiGui = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TinhThanhNguoiGui = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoaiNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XaPhuongNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuanHuyenNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TinhThanhNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrackingNumber = table.Column<long>(type: "bigint", nullable: true),
                    ThoiGianLayHangDuKien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianGiaoHangDuKien = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonBanHangOnline",
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
                    PhiBaoHiem = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PhiVanChuyen = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DungTichDiem = table.Column<bool>(type: "bit", nullable: true),
                    SoDiemTichLuyDung = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonBanHangOnline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonBanHangOnline_KhachHang_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHang",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDonBanHangOnline_KhuyenMai_KhuyenMaiId",
                        column: x => x.KhuyenMaiId,
                        principalTable: "KhuyenMai",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDonBanHangOnline_NhanVien_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanVien",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDonBanHangOnline",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoaDonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhienBanSanPhamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    HoaDonBanHangOnlineId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDonBanHangOnline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonBanHangOnline_HoaDonBanHangOnline_HoaDonBanHangOnlineId",
                        column: x => x.HoaDonBanHangOnlineId,
                        principalTable: "HoaDonBanHangOnline",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonBanHangOnline_HoaDonBanHang_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "HoaDonBanHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonBanHangOnline_PhienBanSanPham_PhienBanSanPhamId",
                        column: x => x.PhienBanSanPhamId,
                        principalTable: "PhienBanSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8107), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8121), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8123), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8124), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8125), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8127), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8586), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8473), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7ed115bf-e207-49f2-b2eb-2247eacf10f5", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "a7a32cb1-7eb9-4134-8db5-0c1c23356ab4", null, "Admin", "ADMIN" },
                    { "be04c634-b0a6-473f-a390-b7d7ecf16978", null, "Employee POS", "EMPLOYEE POS" },
                    { "e3ab3474-5384-4ede-a848-3739ffc34482", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "f731f905-0571-431f-87df-e03b25c21f0e", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonBanHangOnline_HoaDonBanHangOnlineId",
                table: "ChiTietHoaDonBanHangOnline",
                column: "HoaDonBanHangOnlineId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonBanHangOnline_HoaDonId",
                table: "ChiTietHoaDonBanHangOnline",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonBanHangOnline_PhienBanSanPhamId",
                table: "ChiTietHoaDonBanHangOnline",
                column: "PhienBanSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBanHangOnline_KhachHangId",
                table: "HoaDonBanHangOnline",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBanHangOnline_KhuyenMaiId",
                table: "HoaDonBanHangOnline",
                column: "KhuyenMaiId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBanHangOnline_NhanVienId",
                table: "HoaDonBanHangOnline",
                column: "NhanVienId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDonBanHangOnline");

            migrationBuilder.DropTable(
                name: "GiaoHang");

            migrationBuilder.DropTable(
                name: "HoaDonBanHangOnline");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7ed115bf-e207-49f2-b2eb-2247eacf10f5");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a7a32cb1-7eb9-4134-8db5-0c1c23356ab4");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "be04c634-b0a6-473f-a390-b7d7ecf16978");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e3ab3474-5384-4ede-a848-3739ffc34482");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f731f905-0571-431f-87df-e03b25c21f0e");

            migrationBuilder.AlterColumn<double>(
                name: "KhoiLuong",
                table: "PhienBanSanPham",
                type: "float",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(805), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(817), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(818), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(823), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(1213), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(1104), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "094e7378-a827-49a1-b754-9760082b68b4", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "49d7a0b9-3921-4c8e-aa6e-827c7f425469", null, "Employee POS", "EMPLOYEE POS" },
                    { "a14c3b06-03c6-4908-bdd4-d3516fb84476", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "beb947c0-45c6-41df-9381-ac91b3b05d7f", null, "Admin", "ADMIN" },
                    { "c6b17923-9fc2-49f1-a1f9-74fcea74094a", null, "Customer", "CUSTOMER" }
                });
        }
    }
}
