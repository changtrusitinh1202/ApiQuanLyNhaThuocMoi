using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ModifySomeFieldd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("5e1b940e-4b8d-4d50-9df4-6d1a8dfe7c50"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("96b18ce0-371e-44cf-879f-3388054c8e64"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("c16013b1-7165-42ce-87aa-e822939a9cfc"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("cc85b952-dbc1-42af-8127-faab9c515075"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("dce3d632-425e-4bf7-8924-951fc48e2f8e"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("fcd4e470-feb4-4bf9-bc0a-bc353aa27357"));

            migrationBuilder.AlterColumn<double>(
                name: "SoLuongQuyDoi",
                table: "LoHang",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "SoLuongQuyDoi",
                table: "LoHang",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "DanhMuc",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "MoTa", "ModifiedBy", "ModifiedDate", "TenDanhMuc" },
                values: new object[,]
                {
                    { new Guid("5e1b940e-4b8d-4d50-9df4-6d1a8dfe7c50"), null, new DateTime(2024, 9, 6, 1, 59, 37, 854, DateTimeKind.Local).AddTicks(2736), "Dinh dưỡng", null, new DateTime(2024, 9, 6, 1, 59, 37, 854, DateTimeKind.Local).AddTicks(2736), "Thực phẩm chứng năng" },
                    { new Guid("96b18ce0-371e-44cf-879f-3388054c8e64"), null, new DateTime(2024, 9, 6, 1, 59, 37, 854, DateTimeKind.Local).AddTicks(2689), "Thuốc da liễu", null, new DateTime(2024, 9, 6, 1, 59, 37, 854, DateTimeKind.Local).AddTicks(2690), "Thuốc" },
                    { new Guid("c16013b1-7165-42ce-87aa-e822939a9cfc"), null, new DateTime(2024, 9, 6, 1, 59, 37, 854, DateTimeKind.Local).AddTicks(2678), "Thuốc dị ứng", null, new DateTime(2024, 9, 6, 1, 59, 37, 854, DateTimeKind.Local).AddTicks(2687), "Thuốc" },
                    { new Guid("cc85b952-dbc1-42af-8127-faab9c515075"), null, new DateTime(2024, 9, 6, 1, 59, 37, 854, DateTimeKind.Local).AddTicks(2692), "Thuốc hô hấp", null, new DateTime(2024, 9, 6, 1, 59, 37, 854, DateTimeKind.Local).AddTicks(2693), "Thuốc" },
                    { new Guid("dce3d632-425e-4bf7-8924-951fc48e2f8e"), null, new DateTime(2024, 9, 6, 1, 59, 37, 854, DateTimeKind.Local).AddTicks(2720), "Vitamin & Khoáng chất", null, new DateTime(2024, 9, 6, 1, 59, 37, 854, DateTimeKind.Local).AddTicks(2721), "Thực phẩm chứng năng" },
                    { new Guid("fcd4e470-feb4-4bf9-bc0a-bc353aa27357"), null, new DateTime(2024, 9, 6, 1, 59, 37, 854, DateTimeKind.Local).AddTicks(2734), "Hỗ trợ làm đẹp", null, new DateTime(2024, 9, 6, 1, 59, 37, 854, DateTimeKind.Local).AddTicks(2734), "Thực phẩm chứng năng" }
                });
        }
    }
}
