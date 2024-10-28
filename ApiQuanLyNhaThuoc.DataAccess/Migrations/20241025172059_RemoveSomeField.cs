using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSomeField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "56e2c206-b807-4167-bedf-5dd529ef13da");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6c01f2b0-ad7a-48c3-aec4-82b897f94bd1");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c06a195c-fbd1-4a31-a654-0442371b350c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d367a25b-0b86-46c9-94d3-672faacd187a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "fd7fdeb0-4c48-4a1e-9e8a-a2699f6046f0");

            migrationBuilder.DropColumn(
                name: "DiaChi",
                table: "HoaDonBanHang");

            migrationBuilder.DropColumn(
                name: "SoDienThoai",
                table: "HoaDonBanHang");

            migrationBuilder.DropColumn(
                name: "Ten",
                table: "HoaDonBanHang");

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(677), new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(690), new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(691), new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(693), new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(695), new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(696), new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(875), new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(849), new DateTime(2024, 10, 26, 0, 20, 56, 894, DateTimeKind.Local).AddTicks(850) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06a36e4c-a318-4200-8120-4769476a48b0", null, "Admin", "ADMIN" },
                    { "1c95b12f-19ff-4989-8b72-f35f1a6fd0c5", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "2f65fd91-f8a3-49e1-823e-58dd6e71971b", null, "Employee POS", "EMPLOYEE POS" },
                    { "34bba5e3-e0eb-4bef-ac31-880ca3a496e8", null, "Customer", "CUSTOMER" },
                    { "6b496c4e-efdc-4977-bf5e-0f33999fe10d", null, "Employee Online", "EMPLOYEE ONLINE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "06a36e4c-a318-4200-8120-4769476a48b0");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1c95b12f-19ff-4989-8b72-f35f1a6fd0c5");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2f65fd91-f8a3-49e1-823e-58dd6e71971b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "34bba5e3-e0eb-4bef-ac31-880ca3a496e8");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6b496c4e-efdc-4977-bf5e-0f33999fe10d");

            migrationBuilder.AddColumn<string>(
                name: "DiaChi",
                table: "HoaDonBanHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SoDienThoai",
                table: "HoaDonBanHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ten",
                table: "HoaDonBanHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4458), new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4470), new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4472), new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4473), new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4475), new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4477), new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4615), new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4589), new DateTime(2024, 10, 25, 22, 41, 27, 643, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "56e2c206-b807-4167-bedf-5dd529ef13da", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "6c01f2b0-ad7a-48c3-aec4-82b897f94bd1", null, "Customer", "CUSTOMER" },
                    { "c06a195c-fbd1-4a31-a654-0442371b350c", null, "Admin", "ADMIN" },
                    { "d367a25b-0b86-46c9-94d3-672faacd187a", null, "Employee POS", "EMPLOYEE POS" },
                    { "fd7fdeb0-4c48-4a1e-9e8a-a2699f6046f0", null, "Employee Manager", "EMPLOYEE MANAGER" }
                });
        }
    }
}
