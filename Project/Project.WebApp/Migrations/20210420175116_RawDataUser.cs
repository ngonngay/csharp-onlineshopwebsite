using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class RawDataUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8D04DCE3-969A-435D-BBA4-DF3F325983DC", "e002352c-1fb3-413b-9091-43de955b976b", "admin", "ADMIN" },
                    { "8D04DCE2-969A-435D-BBA4-DF3F325983DC", "2e1faeca-7ada-4574-a97c-bf5a11bbeb8f", "editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "69BD714F-9576-45BA-B5B7-F00649BE00DE", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "deafc01a-ddb6-46ad-85f9-01928470219a", "thangnguyenquyetvlth@gmail.com", true, null, false, null, "tedu.international@gmail.com", "admin", "AQAAAAEAACcQAAAAEADgtDH+KecpB947f8O2DnMaFxymexjeaD/Kxp2/1x4vtjiqVyZMShGQ3g05xLFAOw==", null, false, "", false, "Thang-dev" });

            migrationBuilder.InsertData(
                table: "RoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[] { -1, "permission", "manage.user", "8D04DCE3-969A-435D-BBA4-DF3F325983DC" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8D04DCE3-969A-435D-BBA4-DF3F325983DC", "69BD714F-9576-45BA-B5B7-F00649BE00DE" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8D04DCE2-969A-435D-BBA4-DF3F325983DC", "69BD714F-9576-45BA-B5B7-F00649BE00DE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8D04DCE2-969A-435D-BBA4-DF3F325983DC", "69BD714F-9576-45BA-B5B7-F00649BE00DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8D04DCE3-969A-435D-BBA4-DF3F325983DC", "69BD714F-9576-45BA-B5B7-F00649BE00DE" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE");

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 0, 5, 2, 60, DateTimeKind.Local).AddTicks(6906));
        }
    }
}
