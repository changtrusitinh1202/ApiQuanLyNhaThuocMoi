using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ModiFyandAddTableEE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDonBanHangOnline_HoaDonBanHangOnline_HoaDonBanHangOnlineId",
                table: "ChiTietHoaDonBanHangOnline");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDonBanHangOnline_HoaDonBanHang_HoaDonId",
                table: "ChiTietHoaDonBanHangOnline");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHoaDonBanHangOnline_HoaDonBanHangOnlineId",
                table: "ChiTietHoaDonBanHangOnline");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7ed115bf-e207-49f2-b2eb-2247eacf10f5");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a7a32cb1-7eb9-4134-8db5-0c1c23356ab4");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "be04c634-b0a6-473f-a390-b7d7ecf16978");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e3ab3474-5384-4ede-a848-3739ffc34482");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f731f905-0571-431f-87df-e03b25c21f0e");

            migrationBuilder.DropColumn(
                name: "HoaDonBanHangOnlineId",
                table: "ChiTietHoaDonBanHangOnline");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDonBanHangOnline_HoaDonBanHangOnline_HoaDonId",
                table: "ChiTietHoaDonBanHangOnline",
                column: "HoaDonId",
                principalTable: "HoaDonBanHangOnline",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDonBanHangOnline_HoaDonBanHangOnline_HoaDonId",
                table: "ChiTietHoaDonBanHangOnline");

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
                name: "HoaDonBanHangOnlineId",
                table: "ChiTietHoaDonBanHangOnline",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8107), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8121), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8123), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8124), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8125), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8127), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8586), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8473), new DateTime(2024, 11, 5, 1, 1, 17, 635, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7ed115bf-e207-49f2-b2eb-2247eacf10f5", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "a7a32cb1-7eb9-4134-8db5-0c1c23356ab4", null, "Admin", "ADMIN" },
                    { "be04c634-b0a6-473f-a390-b7d7ecf16978", null, "Employee POS", "EMPLOYEE POS" },
                    { "e3ab3474-5384-4ede-a848-3739ffc34482", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "f731f905-0571-431f-87df-e03b25c21f0e", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonBanHangOnline_HoaDonBanHangOnlineId",
                table: "ChiTietHoaDonBanHangOnline",
                column: "HoaDonBanHangOnlineId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDonBanHangOnline_HoaDonBanHangOnline_HoaDonBanHangOnlineId",
                table: "ChiTietHoaDonBanHangOnline",
                column: "HoaDonBanHangOnlineId",
                principalTable: "HoaDonBanHangOnline",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDonBanHangOnline_HoaDonBanHang_HoaDonId",
                table: "ChiTietHoaDonBanHangOnline",
                column: "HoaDonId",
                principalTable: "HoaDonBanHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
