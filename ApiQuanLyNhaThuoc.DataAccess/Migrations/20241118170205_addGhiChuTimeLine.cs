using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addGhiChuTimeLine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "846873d8-5008-41f4-a638-9fe2c19d5f53");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a3270f1f-8335-4a16-9d6d-c5db84e31404");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a9a7a1e5-c544-4e34-afac-c92b9132ef57");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b23af6ee-9aaf-40a2-aa17-94b9f7dc3a83");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c69ae7b0-3241-4afc-8ac2-260ddc96fb8b");

            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "TrangThaiHoaDonOnline",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "TrangThaiHoaDonOnline");

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1307), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1321), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1322), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1324), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1325), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1327), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1495), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1468), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "846873d8-5008-41f4-a638-9fe2c19d5f53", null, "Admin", "ADMIN" },
                    { "a3270f1f-8335-4a16-9d6d-c5db84e31404", null, "Customer", "CUSTOMER" },
                    { "a9a7a1e5-c544-4e34-afac-c92b9132ef57", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "b23af6ee-9aaf-40a2-aa17-94b9f7dc3a83", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "c69ae7b0-3241-4afc-8ac2-260ddc96fb8b", null, "Employee POS", "EMPLOYEE POS" }
                });
        }
    }
}
