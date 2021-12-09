using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class testseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 0, 5, 2, 58, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 0, 5, 2, 60, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "Description", "Details", "IsFeatured", "Name", "Price" },
                values: new object[] { 6, new DateTime(2021, 4, 21, 0, 5, 2, 60, DateTimeKind.Local).AddTicks(6906), "Áo sơ mi nữ trắng Việt Tiến", "Áo sơ mi nữ trắng Việt Tiến", null, "Áo sơ mi nữ trắng Việt Tiến", 200000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 20, 16, 20, 25, 246, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 20, 16, 20, 25, 248, DateTimeKind.Local).AddTicks(8124));
        }
    }
}
