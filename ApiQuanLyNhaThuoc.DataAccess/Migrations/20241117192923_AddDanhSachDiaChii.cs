using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddDanhSachDiaChii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6f04fbb6-7709-4a2f-915b-0c04c604792f");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "804a50c3-0bcf-448a-95c2-47484c14c227");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "87de432e-3814-4286-b835-050efc02d453");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a9148fdd-5c2c-440c-af0b-f5af75ca89ab");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b0d95720-f011-4057-a123-6133a10fd6fa");

            migrationBuilder.CreateTable(
                name: "DiaChiKhachHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhachHangId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoaiNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XaPhuongNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuanHuyenNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TinhThanhNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MacDinh = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaChiKhachHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiaChiKhachHang_KhachHang_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1307), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1321), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1322), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1324), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1325), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1327), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1495), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1468), new DateTime(2024, 11, 18, 2, 29, 23, 235, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "846873d8-5008-41f4-a638-9fe2c19d5f53", null, "Admin", "ADMIN" },
                    { "a3270f1f-8335-4a16-9d6d-c5db84e31404", null, "Customer", "CUSTOMER" },
                    { "a9a7a1e5-c544-4e34-afac-c92b9132ef57", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "b23af6ee-9aaf-40a2-aa17-94b9f7dc3a83", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "c69ae7b0-3241-4afc-8ac2-260ddc96fb8b", null, "Employee POS", "EMPLOYEE POS" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiaChiKhachHang_KhachHangId",
                table: "DiaChiKhachHang",
                column: "KhachHangId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaChiKhachHang");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "846873d8-5008-41f4-a638-9fe2c19d5f53");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a3270f1f-8335-4a16-9d6d-c5db84e31404");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a9a7a1e5-c544-4e34-afac-c92b9132ef57");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b23af6ee-9aaf-40a2-aa17-94b9f7dc3a83");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c69ae7b0-3241-4afc-8ac2-260ddc96fb8b");

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM111",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9006), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM112",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9017), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM113",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9019), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM114",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9021), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM115",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9022), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "DanhMuc",
                keyColumn: "Id",
                keyValue: "DM116",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9024), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "KhoHang",
                keyColumn: "Id",
                keyValue: "KHO001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9231), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "NhaCungCap",
                keyColumn: "Id",
                keyValue: "NCC001",
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9197), new DateTime(2024, 11, 18, 2, 25, 40, 542, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6f04fbb6-7709-4a2f-915b-0c04c604792f", null, "Employee Manager", "EMPLOYEE MANAGER" },
                    { "804a50c3-0bcf-448a-95c2-47484c14c227", null, "Admin", "ADMIN" },
                    { "87de432e-3814-4286-b835-050efc02d453", null, "Employee POS", "EMPLOYEE POS" },
                    { "a9148fdd-5c2c-440c-af0b-f5af75ca89ab", null, "Employee Online", "EMPLOYEE ONLINE" },
                    { "b0d95720-f011-4057-a123-6133a10fd6fa", null, "Customer", "CUSTOMER" }
                });
        }
    }
}
