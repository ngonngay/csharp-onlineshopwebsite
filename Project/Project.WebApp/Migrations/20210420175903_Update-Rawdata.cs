using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class UpdateRawdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 0, 59, 1, 894, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 0, 59, 1, 896, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 0, 59, 1, 896, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "a389d32c-d5da-4a11-954a-db30ef848320");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "0ec1588a-3545-4cdf-a9b8-c599d84cd81a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "262ae853-87ea-4fd1-ae8f-1d76f54e1e8b", "thangnguyenquyetvlth@gmail.com", "AQAAAAEAACcQAAAAEPzSlE/E77n5R0MrCKwYg9Zc8CiYkZi829vCmATE56RdU4e0A0lwD7vFQbziGvMRhg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 0, 51, 14, 882, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 0, 51, 14, 884, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 0, 51, 14, 884, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "2e1faeca-7ada-4574-a97c-bf5a11bbeb8f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "e002352c-1fb3-413b-9091-43de955b976b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "deafc01a-ddb6-46ad-85f9-01928470219a", "tedu.international@gmail.com", "AQAAAAEAACcQAAAAEADgtDH+KecpB947f8O2DnMaFxymexjeaD/Kxp2/1x4vtjiqVyZMShGQ3g05xLFAOw==" });
        }
    }
}
