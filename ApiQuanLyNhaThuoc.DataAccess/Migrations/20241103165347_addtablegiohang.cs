using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addtablegiohang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhachHangId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PhienBanSanPhamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHang_KhachHang_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHang",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GioHang_PhienBanSanPham_PhienBanSanPhamId",
                        column: x => x.PhienBanSanPhamId,
                        principalTable: "PhienBanSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(805), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(817), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(818), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(823), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(1213), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(1104), new DateTime(2024, 11, 3, 23, 53, 45, 854, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "094e7378-a827-49a1-b754-9760082b68b4", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "49d7a0b9-3921-4c8e-aa6e-827c7f425469", null, "Employee POS", "EMPLOYEE POS" },
                    { "a14c3b06-03c6-4908-bdd4-d3516fb84476", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "beb947c0-45c6-41df-9381-ac91b3b05d7f", null, "Admin", "ADMIN" },
                    { "c6b17923-9fc2-49f1-a1f9-74fcea74094a", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_KhachHangId",
                table: "GioHang",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_PhienBanSanPhamId",
                table: "GioHang",
                column: "PhienBanSanPhamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "094e7378-a827-49a1-b754-9760082b68b4");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "49d7a0b9-3921-4c8e-aa6e-827c7f425469");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a14c3b06-03c6-4908-bdd4-d3516fb84476");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "beb947c0-45c6-41df-9381-ac91b3b05d7f");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c6b17923-9fc2-49f1-a1f9-74fcea74094a");

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
    }
}
