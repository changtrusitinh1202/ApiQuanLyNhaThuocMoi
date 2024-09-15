using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ModifySomeField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("585e1032-5a9e-4e1f-a64e-df0e7809cd6f"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("9bc2e6c2-bdde-424a-bee8-d602c3f4f8a0"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("c7aaec50-473c-43aa-b41a-65fe2a9bd944"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("cf9e9154-c5b2-4fa5-9abc-20957f368e6f"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("d5934ba7-6337-4bfb-bf42-f6034ea58e1a"));

            migrationBuilder.DeleteData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: new Guid("d9cad089-989d-422a-b8a9-3d3605b794d2"));

            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "ChiTietHoaDonNhapHang",
                newName: "SoLuongNhap");

            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "ChiTietHoaDonDatHang",
                newName: "SoLuongDat");

            migrationBuilder.AddColumn<Guid>(
                name: "LoHangId",
                table: "ChiTietHoaDonNhapHang",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonNhapHang_LoHangId",
                table: "ChiTietHoaDonNhapHang",
                column: "LoHangId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDonNhapHang_LoHang_LoHangId",
                table: "ChiTietHoaDonNhapHang",
                column: "LoHangId",
                principalTable: "LoHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDonNhapHang_LoHang_LoHangId",
                table: "ChiTietHoaDonNhapHang");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHoaDonNhapHang_LoHangId",
                table: "ChiTietHoaDonNhapHang");

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

            migrationBuilder.DropColumn(
                name: "LoHangId",
                table: "ChiTietHoaDonNhapHang");

            migrationBuilder.RenameColumn(
                name: "SoLuongNhap",
                table: "ChiTietHoaDonNhapHang",
                newName: "SoLuong");

            migrationBuilder.RenameColumn(
                name: "SoLuongDat",
                table: "ChiTietHoaDonDatHang",
                newName: "SoLuong");

            migrationBuilder.InsertData(
                table: "DanhMuc",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "MoTa", "ModifiedBy", "ModifiedDate", "TenDanhMuc" },
                values: new object[,]
                {
                    { new Guid("585e1032-5a9e-4e1f-a64e-df0e7809cd6f"), null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9744), "Thuốc dị ứng", null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9755), "Thuốc" },
                    { new Guid("9bc2e6c2-bdde-424a-bee8-d602c3f4f8a0"), null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9774), "Vitamin & Khoáng chất", null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9774), "Thực phẩm chứng năng" },
                    { new Guid("c7aaec50-473c-43aa-b41a-65fe2a9bd944"), null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9776), "Hỗ trợ làm đẹp", null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9776), "Thực phẩm chứng năng" },
                    { new Guid("cf9e9154-c5b2-4fa5-9abc-20957f368e6f"), null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9771), "Thuốc hô hấp", null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9772), "Thuốc" },
                    { new Guid("d5934ba7-6337-4bfb-bf42-f6034ea58e1a"), null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9778), "Dinh dưỡng", null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9779), "Thực phẩm chứng năng" },
                    { new Guid("d9cad089-989d-422a-b8a9-3d3605b794d2"), null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9758), "Thuốc da liễu", null, new DateTime(2024, 9, 5, 23, 44, 31, 671, DateTimeKind.Local).AddTicks(9759), "Thuốc" }
                });
        }
    }
}
