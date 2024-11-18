using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddDanhSachDiaChi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6655fced-af2b-436f-8169-bb025f0fb1aa");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6891208a-1809-4a8f-9acc-d33525fb0c2c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9afa3bee-fdc2-453f-86d6-190bfee2708a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "cda556c7-6871-4b4b-b3a0-10b3aa6d206b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d58c2b40-0b4c-40b8-a562-40a5942e96a5");

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9006), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9017), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9019), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9021), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9022), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9024), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9231), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9197), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6f04fbb6-7709-4a2f-915b-0c04c604792f", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "804a50c3-0bcf-448a-95c2-47484c14c227", null, "Admin", "ADMIN" },
                    { "87de432e-3814-4286-b835-050efc02d453", null, "Employee POS", "EMPLOYEE POS" },
                    { "a9148fdd-5c2c-440c-af0b-f5af75ca89ab", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "b0d95720-f011-4057-a123-6133a10fd6fa", null, "Customer", "CUSTOMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6f04fbb6-7709-4a2f-915b-0c04c604792f");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "804a50c3-0bcf-448a-95c2-47484c14c227");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "87de432e-3814-4286-b835-050efc02d453");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a9148fdd-5c2c-440c-af0b-f5af75ca89ab");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b0d95720-f011-4057-a123-6133a10fd6fa");

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4366), new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4379), new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4380), new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4382), new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4383), new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4384), new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4652), new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4618), new DateTime(2024, 11, 8, 11, 35, 5, 51, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6655fced-af2b-436f-8169-bb025f0fb1aa", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "6891208a-1809-4a8f-9acc-d33525fb0c2c", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "9afa3bee-fdc2-453f-86d6-190bfee2708a", null, "Admin", "ADMIN" },
                    { "cda556c7-6871-4b4b-b3a0-10b3aa6d206b", null, "Customer", "CUSTOMER" },
                    { "d58c2b40-0b4c-40b8-a562-40a5942e96a5", null, "Employee POS", "EMPLOYEE POS" }
                });
        }
    }
}
