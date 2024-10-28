using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddQuyen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "06e20060-4f18-4b24-a3c1-5f240876d506");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1de06f99-b44e-4ebd-9ebb-09e5027cbcc4");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "308efd73-3dc7-40b4-b550-eda76bbe9dba");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9183fae1-2ff1-4bdc-a2d3-e82636166e55");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d21e5a9c-7659-49ef-b836-3e4ed44b44e8");

            migrationBuilder.AddColumn<string>(
                name: "Quyen",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Quyen",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8223), new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8236), new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8237), new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8239), new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8240), new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8242), new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8415), new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8389), new DateTime(2024, 10, 25, 12, 12, 46, 430, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06e20060-4f18-4b24-a3c1-5f240876d506", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "1de06f99-b44e-4ebd-9ebb-09e5027cbcc4", null, "Admin", "ADMIN" },
                    { "308efd73-3dc7-40b4-b550-eda76bbe9dba", null, "Employee POS", "EMPLOYEE POS" },
                    { "9183fae1-2ff1-4bdc-a2d3-e82636166e55", null, "Customer", "CUSTOMER" },
                    { "d21e5a9c-7659-49ef-b836-3e4ed44b44e8", null, "Employee Manager", "EMPLOYEE MANAGER" }
                });
        }
    }
}
