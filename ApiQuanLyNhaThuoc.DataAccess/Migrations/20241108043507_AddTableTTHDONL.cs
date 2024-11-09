using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddTableTTHDONL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "01964eeb-ce79-4c5f-a226-7e6cd4d35ccb");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4036ed4a-bfd4-4441-a3eb-b1b5962e5a1c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a9a8867b-d483-4ba7-afc3-39cf1c853026");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b8d7afb1-a4d8-46df-998b-d84bb6a35397");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d00134ce-00c1-4ba7-b319-fb49e2967294");

            migrationBuilder.CreateTable(
                name: "TrangThaiHoaDonOnline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoaDonBanHangOnlineId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiHoaDonOnline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrangThaiHoaDonOnline_HoaDonBanHangOnline_HoaDonBanHangOnlineId",
                        column: x => x.HoaDonBanHangOnlineId,
                        principalTable: "HoaDonBanHangOnline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TrangThaiHoaDonOnline_HoaDonBanHangOnlineId",
                table: "TrangThaiHoaDonOnline",
                column: "HoaDonBanHangOnlineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrangThaiHoaDonOnline");

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
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2810), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2822), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2824), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2826), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2827), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2856), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(3161), new DateTime(2024, 11, 5, 14, 54, 30, 829, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01964eeb-ce79-4c5f-a226-7e6cd4d35ccb", null, "Admin", "ADMIN" },
                    { "4036ed4a-bfd4-4441-a3eb-b1b5962e5a1c", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "a9a8867b-d483-4ba7-afc3-39cf1c853026", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "b8d7afb1-a4d8-46df-998b-d84bb6a35397", null, "Employee POS", "EMPLOYEE POS" },
                    { "d00134ce-00c1-4ba7-b319-fb49e2967294", null, "Customer", "CUSTOMER" }
                });
        }
    }
}
