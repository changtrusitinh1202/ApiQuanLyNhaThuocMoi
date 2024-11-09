using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddDbGIaoHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "11a713e9-0074-4717-9369-fdc01fc516a5");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "33137de7-db5e-4481-8546-640098040c13");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "68aff29f-b8ce-4b6f-a9a5-5e01e39abee4");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9a8d6a83-516c-49ca-b36c-e1f4502f357d");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "aa7d3f80-3cbc-4852-a406-3bd5620c2f5f");

            migrationBuilder.AddColumn<string>(
                name: "GiaoHangId",
                table: "HoaDonBanHangOnline",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(559), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(572), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(573), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(575), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(576), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(577), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(854), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 11, 5, 10, 20, 53, 238, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3fd24af8-f970-4572-829d-ebeebbf414b9", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "5ddbb10a-2fe0-4d9e-ad6e-3baee16700f6", null, "Admin", "ADMIN" },
                    { "69a8d0c6-7d1d-4062-a6c7-c4da8de1afac", null, "Customer", "CUSTOMER" },
                    { "da1690a7-853d-46ab-a8ee-4f24bfdd616a", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "fd80b9ec-f7ee-4064-a047-25f1cb15e028", null, "Employee POS", "EMPLOYEE POS" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBanHangOnline_GiaoHangId",
                table: "HoaDonBanHangOnline",
                column: "GiaoHangId");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonBanHangOnline_GiaoHang_GiaoHangId",
                table: "HoaDonBanHangOnline",
                column: "GiaoHangId",
                principalTable: "GiaoHang",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonBanHangOnline_GiaoHang_GiaoHangId",
                table: "HoaDonBanHangOnline");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonBanHangOnline_GiaoHangId",
                table: "HoaDonBanHangOnline");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3fd24af8-f970-4572-829d-ebeebbf414b9");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5ddbb10a-2fe0-4d9e-ad6e-3baee16700f6");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "69a8d0c6-7d1d-4062-a6c7-c4da8de1afac");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "da1690a7-853d-46ab-a8ee-4f24bfdd616a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "fd80b9ec-f7ee-4064-a047-25f1cb15e028");

            migrationBuilder.DropColumn(
                name: "GiaoHangId",
                table: "HoaDonBanHangOnline");

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4064), new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4078), new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4079), new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4081), new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4082), new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4084), new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4454), new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4415), new DateTime(2024, 11, 5, 1, 3, 53, 71, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11a713e9-0074-4717-9369-fdc01fc516a5", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "33137de7-db5e-4481-8546-640098040c13", null, "Admin", "ADMIN" },
                    { "68aff29f-b8ce-4b6f-a9a5-5e01e39abee4", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "9a8d6a83-516c-49ca-b36c-e1f4502f357d", null, "Customer", "CUSTOMER" },
                    { "aa7d3f80-3cbc-4852-a406-3bd5620c2f5f", null, "Employee POS", "EMPLOYEE POS" }
                });
        }
    }
}
