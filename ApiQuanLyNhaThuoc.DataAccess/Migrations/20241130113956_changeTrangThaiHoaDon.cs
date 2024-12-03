using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changeTrangThaiHoaDon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
     

            migrationBuilder.DropForeignKey(
                name: "FK_TrangThaiHoaDonOnline_HoaDonBanHang_HoaDonBanHangId",
                table: "TrangThaiHoaDonOnline");

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

            migrationBuilder.AlterColumn<string>(
                name: "HoaDonBanHangOnlineId",
                table: "TrangThaiHoaDonOnline",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "HoaDonBanHangId",
                table: "TrangThaiHoaDonOnline",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(2778), new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(2792), new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(2794), new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(2795), new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(2797), new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(2798), new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(3072), new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(3036), new DateTime(2024, 11, 30, 18, 39, 53, 841, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "870729ca-54d4-46ab-b800-06253f90a51d", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "8c217271-4033-449c-93da-5f13821d4f6d", null, "Customer", "CUSTOMER" },
                    { "a4f03907-61be-4b22-b47d-b3ea028c9bd9", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "c111b536-11be-48f2-b70e-5a1078077a9c", null, "Employee POS", "EMPLOYEE POS" },
                    { "df93d03c-b89b-438a-93fe-4791c053b0ef", null, "Admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TrangThaiHoaDonOnline_HoaDonBanHangOnline_HoaDonBanHangOnlineId",
                table: "TrangThaiHoaDonOnline",
                column: "HoaDonBanHangOnlineId",
                principalTable: "HoaDonBanHangOnline",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrangThaiHoaDonOnline_HoaDonBanHang_HoaDonBanHangId",
                table: "TrangThaiHoaDonOnline",
                column: "HoaDonBanHangId",
                principalTable: "HoaDonBanHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrangThaiHoaDonOnline_HoaDonBanHangOnline_HoaDonBanHangOnlineId",
                table: "TrangThaiHoaDonOnline");

            migrationBuilder.DropForeignKey(
                name: "FK_TrangThaiHoaDonOnline_HoaDonBanHang_HoaDonBanHangId",
                table: "TrangThaiHoaDonOnline");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "870729ca-54d4-46ab-b800-06253f90a51d");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8c217271-4033-449c-93da-5f13821d4f6d");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a4f03907-61be-4b22-b47d-b3ea028c9bd9");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c111b536-11be-48f2-b70e-5a1078077a9c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "df93d03c-b89b-438a-93fe-4791c053b0ef");

            migrationBuilder.AlterColumn<string>(
                name: "HoaDonBanHangOnlineId",
                table: "TrangThaiHoaDonOnline",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HoaDonBanHangId",
                table: "TrangThaiHoaDonOnline",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

 

            migrationBuilder.AddForeignKey(
                name: "FK_TrangThaiHoaDonOnline_HoaDonBanHang_HoaDonBanHangId",
                table: "TrangThaiHoaDonOnline",
                column: "HoaDonBanHangId",
                principalTable: "HoaDonBanHang",
                principalColumn: "Id");
        }
    }
}
