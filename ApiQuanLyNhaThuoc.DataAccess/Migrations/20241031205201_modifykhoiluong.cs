using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class modifykhoiluong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(5812), new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(5969), new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(5971), new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(5973), new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(5974), new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(5976), new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(6360), new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(6326), new DateTime(2024, 11, 1, 3, 51, 59, 941, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12678635-519a-4f81-9251-5d6a7ebdfab2", null, "Employee POS", "EMPLOYEE POS" },
                    { "1f2a60b2-b6ba-4357-a393-a7b07e42a0ba", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "72ac5a94-3e60-41d5-8ae8-bb048bc256eb", null, "Admin", "ADMIN" },
                    { "d28d9d6c-8f6f-411f-a547-814fde43f04e", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "d9d5016b-c8d6-42e0-a419-16dc0763ee36", null, "Customer", "CUSTOMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "12678635-519a-4f81-9251-5d6a7ebdfab2");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1f2a60b2-b6ba-4357-a393-a7b07e42a0ba");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "72ac5a94-3e60-41d5-8ae8-bb048bc256eb");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d28d9d6c-8f6f-411f-a547-814fde43f04e");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d9d5016b-c8d6-42e0-a419-16dc0763ee36");

            migrationBuilder.AlterColumn<string>(
                name: "KhoiLuong",
                table: "PhienBanSanPham",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

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
    }
}
