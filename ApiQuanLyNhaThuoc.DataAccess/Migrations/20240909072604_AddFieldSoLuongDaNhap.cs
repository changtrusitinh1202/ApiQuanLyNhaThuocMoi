using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldSoLuongDaNhap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("0e5882fa-0a61-4c81-8e7b-ce9e945a58bb"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("4c16a760-1944-4467-84bd-a91559f70640"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("82489dbb-d14d-413f-9eee-4f06eeec8f79"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("8e40ecec-5965-4cc1-afab-a5e64128c6bc"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("dffcb110-463d-40ac-b786-cd1ba91901ad"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("e37c8fce-dc22-4f57-9b25-f4d1ec7c6d33"));

            migrationBuilder.AddColumn<double>(
                name: "SoLuongDaNhap",
                table: "ChiTietHoaDonDatHang",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "DanhMuc",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "MoTa", "ModifiedBy", "ModifiedDate", "TenDanhMuc" },
                values: new object[,]
                {
                    { new Guid("1b0a6de4-acab-4be5-b968-2c885c7ebb93"), null, new DateTime(2024, 9, 9, 14, 26, 4, 113, DateTimeKind.Local).AddTicks(6991), "Thuốc hô hấp", null, new DateTime(2024, 9, 9, 14, 26, 4, 113, DateTimeKind.Local).AddTicks(6991), "Thuốc" },
                    { new Guid("5e18001b-7de0-4283-a71a-5b7e25a8e0c3"), null, new DateTime(2024, 9, 9, 14, 26, 4, 113, DateTimeKind.Local).AddTicks(7004), "Hỗ trợ làm đẹp", null, new DateTime(2024, 9, 9, 14, 26, 4, 113, DateTimeKind.Local).AddTicks(7004), "Thực phẩm chứng năng" },
                    { new Guid("671ddf45-9853-4960-99b8-84e7f0f256ec"), null, new DateTime(2024, 9, 9, 14, 26, 4, 113, DateTimeKind.Local).AddTicks(6993), "Vitamin & Khoáng chất", null, new DateTime(2024, 9, 9, 14, 26, 4, 113, DateTimeKind.Local).AddTicks(6993), "Thực phẩm chứng năng" },
                    { new Guid("87b806d0-dde3-47fe-94cc-6b8a803d4466"), null, new DateTime(2024, 9, 9, 14, 26, 4, 113, DateTimeKind.Local).AddTicks(7005), "Dinh dưỡng", null, new DateTime(2024, 9, 9, 14, 26, 4, 113, DateTimeKind.Local).AddTicks(7006), "Thực phẩm chứng năng" },
                    { new Guid("f43021a5-7703-40d4-8d83-a9b7c5bee327"), null, new DateTime(2024, 9, 9, 14, 26, 4, 113, DateTimeKind.Local).AddTicks(6989), "Thuốc da liễu", null, new DateTime(2024, 9, 9, 14, 26, 4, 113, DateTimeKind.Local).AddTicks(6989), "Thuốc" },
                    { new Guid("fd89d4e7-30fc-48a3-afb2-9fdc347c7aa5"), null, new DateTime(2024, 9, 9, 14, 26, 4, 113, DateTimeKind.Local).AddTicks(6979), "Thuốc dị ứng", null, new DateTime(2024, 9, 9, 14, 26, 4, 113, DateTimeKind.Local).AddTicks(6987), "Thuốc" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("1b0a6de4-acab-4be5-b968-2c885c7ebb93"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("5e18001b-7de0-4283-a71a-5b7e25a8e0c3"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("671ddf45-9853-4960-99b8-84e7f0f256ec"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("87b806d0-dde3-47fe-94cc-6b8a803d4466"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("f43021a5-7703-40d4-8d83-a9b7c5bee327"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("fd89d4e7-30fc-48a3-afb2-9fdc347c7aa5"));

            migrationBuilder.DropColumn(
                name: "SoLuongDaNhap",
                table: "ChiTietHoaDonDatHang");

            migrationBuilder.InsertData(
                table: "DanhMuc",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "MoTa", "ModifiedBy", "ModifiedDate", "TenDanhMuc" },
                values: new object[,]
                {
                    { new Guid("0e5882fa-0a61-4c81-8e7b-ce9e945a58bb"), null, new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(4986), "Thuốc dị ứng", null, new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(4997), "Thuốc" },
                    { new Guid("4c16a760-1944-4467-84bd-a91559f70640"), null, new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5014), "Thuốc hô hấp", null, new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5015), "Thuốc" },
                    { new Guid("82489dbb-d14d-413f-9eee-4f06eeec8f79"), null, new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5016), "Vitamin & Khoáng chất", null, new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5017), "Thực phẩm chứng năng" },
                    { new Guid("8e40ecec-5965-4cc1-afab-a5e64128c6bc"), null, new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5019), "Hỗ trợ làm đẹp", null, new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5019), "Thực phẩm chứng năng" },
                    { new Guid("dffcb110-463d-40ac-b786-cd1ba91901ad"), null, new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5012), "Thuốc da liễu", null, new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5012), "Thuốc" },
                    { new Guid("e37c8fce-dc22-4f57-9b25-f4d1ec7c6d33"), null, new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5021), "Dinh dưỡng", null, new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5021), "Thực phẩm chứng năng" }
                });
        }
    }
}
