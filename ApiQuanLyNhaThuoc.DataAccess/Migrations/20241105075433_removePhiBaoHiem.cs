using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class removePhiBaoHiem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "PhiBaoHiem",
                table: "HoaDonBanHangOnline");

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2810), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2822), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2824), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2826), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2827), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2856), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(3161), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01964eeb-ce79-4c5f-a226-7e6cd4d35ccb", null, "Admin", "ADMIN" },
                    { "4036ed4a-bfd4-4441-a3eb-b1b5962e5a1c", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "a9a8867b-d483-4ba7-afc3-39cf1c853026", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "b8d7afb1-a4d8-46df-998b-d84bb6a35397", null, "Employee POS", "EMPLOYEE POS" },
                    { "d00134ce-00c1-4ba7-b319-fb49e2967294", null, "Customer", "CUSTOMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "01964eeb-ce79-4c5f-a226-7e6cd4d35ccb");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4036ed4a-bfd4-4441-a3eb-b1b5962e5a1c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a9a8867b-d483-4ba7-afc3-39cf1c853026");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b8d7afb1-a4d8-46df-998b-d84bb6a35397");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d00134ce-00c1-4ba7-b319-fb49e2967294");

            migrationBuilder.AddColumn<decimal>(
                name: "PhiBaoHiem",
                table: "HoaDonBanHangOnline",
                type: "decimal(18,2)",
                nullable: true);

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
    }
}
