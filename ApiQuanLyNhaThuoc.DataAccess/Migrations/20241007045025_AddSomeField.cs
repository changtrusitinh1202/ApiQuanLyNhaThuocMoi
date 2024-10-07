using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSomeField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0ceee5a2-2813-4429-ae0d-ac82db8f7e94");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1d7c095a-00b4-41ff-a9e3-57daa5f5767a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "cd81f91b-751c-4e0b-8063-30aa0fe1aae1");

            migrationBuilder.AddColumn<string>(
                name: "CaLamViec",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RankKhachHang",
                table: "KhachHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TichDiem",
                table: "KhachHang",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CaLamViec",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "RankKhachHang",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "TichDiem",
                table: "KhachHang");

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5400), new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5414), new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5416), new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5417), new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5419), new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5420), new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5421) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5591), new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5558), new DateTime(2024, 10, 2, 15, 21, 38, 187, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ceee5a2-2813-4429-ae0d-ac82db8f7e94", null, "Admin", "ADMIN" },
                    { "1d7c095a-00b4-41ff-a9e3-57daa5f5767a", null, "Employee", "EMPLOYEE" },
                    { "cd81f91b-751c-4e0b-8063-30aa0fe1aae1", null, "Customer", "CUSTOMER" }
                });
        }
    }
}
