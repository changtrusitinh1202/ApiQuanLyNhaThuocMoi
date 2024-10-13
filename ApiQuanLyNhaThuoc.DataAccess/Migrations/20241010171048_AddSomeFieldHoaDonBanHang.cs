using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSomeFieldHoaDonBanHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "24b8a36a-8554-4bb3-9d20-6f57c4674a0d");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3da3934c-b471-4661-a14a-60780f1065e2");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "62bd645d-e01c-4004-a095-0f14f9d2f5f7");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8fba806a-716a-4c9e-bc13-c06daa7a082a");

            migrationBuilder.AddColumn<bool>(
                name: "DungTichDiem",
                table: "HoaDonBanHang",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "HoaDonBanHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SoDiemTichLuyDung",
                table: "HoaDonBanHang",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3782), new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3793), new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3795), new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3796), new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3797), new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3799), new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3952), new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3908), new DateTime(2024, 10, 11, 0, 10, 46, 248, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1689d334-8081-4112-a9fa-cefc6e1ea933", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "26e94c63-aabc-4d90-a423-36b64ff5cf7c", null, "Admin", "ADMIN" },
                    { "872f3690-695d-4b68-9525-1439820e5f9f", null, "Customer", "CUSTOMER" },
                    { "b261ec13-2b99-4a83-8e2c-ee3f7cbfd989", null, "Employee POS", "EMPLOYEE POS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1689d334-8081-4112-a9fa-cefc6e1ea933");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "26e94c63-aabc-4d90-a423-36b64ff5cf7c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "872f3690-695d-4b68-9525-1439820e5f9f");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b261ec13-2b99-4a83-8e2c-ee3f7cbfd989");

            migrationBuilder.DropColumn(
                name: "DungTichDiem",
                table: "HoaDonBanHang");

            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "HoaDonBanHang");

            migrationBuilder.DropColumn(
                name: "SoDiemTichLuyDung",
                table: "HoaDonBanHang");

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1073), new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1085), new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1087), new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1089), new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1090), new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1092), new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1237), new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1208), new DateTime(2024, 10, 7, 11, 50, 22, 637, DateTimeKind.Local).AddTicks(1209) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24b8a36a-8554-4bb3-9d20-6f57c4674a0d", null, "Customer", "CUSTOMER" },
                    { "3da3934c-b471-4661-a14a-60780f1065e2", null, "Employee POS", "EMPLOYEE POS" },
                    { "62bd645d-e01c-4004-a095-0f14f9d2f5f7", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "8fba806a-716a-4c9e-bc13-c06daa7a082a", null, "Admin", "ADMIN" }
                });
        }
    }
}
