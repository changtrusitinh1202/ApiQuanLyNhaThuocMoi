using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddDbGIaoHanggg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3fd24af8-f970-4572-829d-ebeebbf414b9");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5ddbb10a-2fe0-4d9e-ad6e-3baee16700f6");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "69a8d0c6-7d1d-4062-a6c7-c4da8de1afac");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "da1690a7-853d-46ab-a8ee-4f24bfdd616a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "fd80b9ec-f7ee-4064-a047-25f1cb15e028");

            migrationBuilder.AlterColumn<string>(
                name: "TinhThanhNguoiGui",
                table: "GiaoHang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TenNguoiGui",
                table: "GiaoHang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SoDienThoaiNguoiGui",
                table: "GiaoHang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "QuanHuyenNguoiGui",
                table: "GiaoHang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DiaChiNguoiGui",
                table: "GiaoHang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1215), new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1232), new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1234), new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1235), new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1237), new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1238), new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1485), new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1453), new DateTime(2024, 11, 5, 11, 6, 45, 34, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d3eca62-7a31-410f-9eeb-d3c5fadace76", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "10cf5690-50dc-479e-84ca-975d035ddf8b", null, "Employee POS", "EMPLOYEE POS" },
                    { "194db871-486a-4f42-b609-b80dfa0c0580", null, "Admin", "ADMIN" },
                    { "43a8a82c-f66f-472d-a0a9-92fdf95a1d5e", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "ccec5099-f3e7-42be-9339-b546c2524a6f", null, "Customer", "CUSTOMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0d3eca62-7a31-410f-9eeb-d3c5fadace76");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "10cf5690-50dc-479e-84ca-975d035ddf8b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "194db871-486a-4f42-b609-b80dfa0c0580");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "43a8a82c-f66f-472d-a0a9-92fdf95a1d5e");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ccec5099-f3e7-42be-9339-b546c2524a6f");

            migrationBuilder.AlterColumn<string>(
                name: "TinhThanhNguoiGui",
                table: "GiaoHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenNguoiGui",
                table: "GiaoHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SoDienThoaiNguoiGui",
                table: "GiaoHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "QuanHuyenNguoiGui",
                table: "GiaoHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DiaChiNguoiGui",
                table: "GiaoHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(559), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(572), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(573), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(575), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(576), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(577), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(854), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3fd24af8-f970-4572-829d-ebeebbf414b9", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "5ddbb10a-2fe0-4d9e-ad6e-3baee16700f6", null, "Admin", "ADMIN" },
                    { "69a8d0c6-7d1d-4062-a6c7-c4da8de1afac", null, "Customer", "CUSTOMER" },
                    { "da1690a7-853d-46ab-a8ee-4f24bfdd616a", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "fd80b9ec-f7ee-4064-a047-25f1cb15e028", null, "Employee POS", "EMPLOYEE POS" }
                });
        }
    }
}
