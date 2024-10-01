using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(107), new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(126), new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(128), new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(130), new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(131), new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(133), new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(385), new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(356), new DateTime(2024, 10, 1, 17, 36, 54, 925, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "550b108b-9714-4670-8025-85c452ad3c20", null, "Employee", "EMPLOYEE" },
                    { "94ca299a-6391-483b-9682-7acfd38187c2", null, "Admin", "ADMIN" },
                    { "a8cb0275-d654-4f68-adc7-56fdfdc4e470", null, "Customer", "CUSTOMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "550b108b-9714-4670-8025-85c452ad3c20");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "94ca299a-6391-483b-9682-7acfd38187c2");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a8cb0275-d654-4f68-adc7-56fdfdc4e470");

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4292), new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4307), new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4347), new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4349), new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4351), new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4352), new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4550), new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4522), new DateTime(2024, 9, 27, 16, 12, 40, 981, DateTimeKind.Local).AddTicks(4523) });
        }
    }
}
