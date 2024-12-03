using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeHoaDonBanHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7a4f5560-3d5d-43d1-a9f9-83a16116463c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "85fc3549-92f3-44fd-a3e0-1b284c4a19d7");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ac90ad12-7535-4ac1-8def-97e195a1c958");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b8792241-f983-4ea4-a8d6-f9039b70a88e");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d60e0cc2-1725-471a-9951-381e5c00106b");

            migrationBuilder.AddColumn<string>(
                name: "HoaDonBanHangId",
                table: "TrangThaiHoaDonOnline",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GiaoHangId",
                table: "HoaDonBanHang",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoaiHoaDon",
                table: "HoaDonBanHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PhiVanChuyen",
                table: "HoaDonBanHang",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6465), new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6477), new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6479), new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6480), new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6482), new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6484), new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6669), new DateTime(2024, 11, 30, 3, 0, 23, 262, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2da28aa4-14ec-40e1-ad6d-110c07e6a856", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "89d68bdf-0205-4ed2-9491-7d479989ec65", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "b68159e4-0b3a-4a39-9a1d-6ac4616b0d91", null, "Customer", "CUSTOMER" },
                    { "c1e8cc9b-7193-4a78-9c2d-cfa43694cb1e", null, "Admin", "ADMIN" },
                    { "f34a5c04-bd92-4a85-8f57-9e980108810f", null, "Employee POS", "EMPLOYEE POS" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrangThaiHoaDonOnline_HoaDonBanHangId",
                table: "TrangThaiHoaDonOnline",
                column: "HoaDonBanHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBanHang_GiaoHangId",
                table: "HoaDonBanHang",
                column: "GiaoHangId");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonBanHang_GiaoHang_GiaoHangId",
                table: "HoaDonBanHang",
                column: "GiaoHangId",
                principalTable: "GiaoHang",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrangThaiHoaDonOnline_HoaDonBanHang_HoaDonBanHangId",
                table: "TrangThaiHoaDonOnline",
                column: "HoaDonBanHangId",
                principalTable: "HoaDonBanHang",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonBanHang_GiaoHang_GiaoHangId",
                table: "HoaDonBanHang");

            migrationBuilder.DropForeignKey(
                name: "FK_TrangThaiHoaDonOnline_HoaDonBanHang_HoaDonBanHangId",
                table: "TrangThaiHoaDonOnline");

            migrationBuilder.DropIndex(
                name: "IX_TrangThaiHoaDonOnline_HoaDonBanHangId",
                table: "TrangThaiHoaDonOnline");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonBanHang_GiaoHangId",
                table: "HoaDonBanHang");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2da28aa4-14ec-40e1-ad6d-110c07e6a856");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "89d68bdf-0205-4ed2-9491-7d479989ec65");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b68159e4-0b3a-4a39-9a1d-6ac4616b0d91");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c1e8cc9b-7193-4a78-9c2d-cfa43694cb1e");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f34a5c04-bd92-4a85-8f57-9e980108810f");

            migrationBuilder.DropColumn(
                name: "HoaDonBanHangId",
                table: "TrangThaiHoaDonOnline");

            migrationBuilder.DropColumn(
                name: "GiaoHangId",
                table: "HoaDonBanHang");

            migrationBuilder.DropColumn(
                name: "LoaiHoaDon",
                table: "HoaDonBanHang");

            migrationBuilder.DropColumn(
                name: "PhiVanChuyen",
                table: "HoaDonBanHang");

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3138), new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3153), new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3154), new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3156), new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3157), new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3159), new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3378), new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3345), new DateTime(2024, 11, 19, 0, 2, 3, 435, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7a4f5560-3d5d-43d1-a9f9-83a16116463c", null, "Admin", "ADMIN" },
                    { "85fc3549-92f3-44fd-a3e0-1b284c4a19d7", null, "Customer", "CUSTOMER" },
                    { "ac90ad12-7535-4ac1-8def-97e195a1c958", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "b8792241-f983-4ea4-a8d6-f9039b70a88e", null, "Employee POS", "EMPLOYEE POS" },
                    { "d60e0cc2-1725-471a-9951-381e5c00106b", null, "Employee Manager", "EMPLOYEE MANAGER" }
                });
        }
    }
}
