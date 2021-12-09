using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class RawdataUserv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 16, 45, 7, 767, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 16, 45, 7, 768, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 16, 45, 7, 768, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "c3cfa8ee-a791-4e9b-ba4f-f2490cb040ce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "b06ad265-84c1-40ca-834d-d90de980b4fd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e261440f-7015-4970-9485-2c259f831158", "AQAAAAEAACcQAAAAEEd3pJtwFE6tv5vrqWLWuc9kdEr1VO6V1WmrOT5wxWtIiYorkVPWyC+y7191kdJ+Lg==" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "69BD711F-9576-45BA-B5B7-F00649BE00DE", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cc8a381c-ac88-4da1-8a56-03a67467ff32", "thangnguyenquyetvlth1@gmail.com", true, null, false, null, "thangnguyenquyetvlth1@gmail.com", "raw-account1", "AQAAAAEAACcQAAAAEInBqcVAwqubnt6TipfPU1suE4INj01XPtWiRE3ZQvZ/NXIEvQSH2DZ8DabsBLAdww==", null, false, "", false, "Thang-dev" },
                    { "69BD712F-9576-45BA-B5B7-F00649BE00DE", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e0f94031-91ee-4002-b30d-1b84d23bceaa", "thangnguyenquyetvlth2@gmail.com", true, null, false, null, "thangnguyenquyetvlth2@gmail.com", "raw-account2", "AQAAAAEAACcQAAAAEOyHuB5Gzw15k7iNungerErIfe3N+72pr6w86YEMzjCpCyLd60hAEfTcXe7blxoUJQ==", null, false, "", false, "Thang-dev" },
                    { "61BD714F-9576-45BA-B5B7-F00649BE00DE", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dfd2ad66-e641-40ff-b8bc-9cd3de770de0", "thangnguyenquyetvlth3@gmail.com", true, null, false, null, "thangnguyenquyetvlth3@gmail.com", "raw-account3", "AQAAAAEAACcQAAAAEHgOfGX5ZKNIyImYa6tnXQp2LTi8+r2BrONqR79GZVLB92d6kg7/0X2JK+Ssu7G47g==", null, false, "", false, "Thang-dev" },
                    { "19BD714F-9576-45BA-B5B7-F00649BE00DE", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6319afc9-6419-4973-83ba-3ed575e6bde1", "thangnguyenquyetvlth4@gmail.com", true, null, false, null, "thangnguyenquyetvlth4@gmail.com", "raw-account4", "AQAAAAEAACcQAAAAEFOz0BfqY2WtK5jBZkY0fLd4fy7EJZ3EqmacCjHN/7OKx+MS2zpeLCMSsQn9khMGGQ==", null, false, "", false, "Thang-dev" },
                    { "65BD710F-9576-45BA-B5B7-F00649BE00DE", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4763b6e7-8322-400e-9668-45db5fba3ce7", "thangnguyenquyetvlth5@gmail.com", true, null, false, null, "thangnguyenquyetvlth5@gmail.com", "raw-account5", "AQAAAAEAACcQAAAAEKIGJsEi4K7AfpY5tPTNhVPdW4iSgcgE/HIAb3KXjr6UNC4JMEaK7AqVkuRerE6WAA==", null, false, "", false, "Thang-dev" },
                    { "69BD714F-9576-45BA-B5B6-F00649BE01DE", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9427990f-a922-4c87-bd99-b0613b6ee636", "thangnguyenquyetvlth6@gmail.com", true, null, false, null, "thangnguyenquyetvlth6@gmail.com", "raw-account6", "AQAAAAEAACcQAAAAEIVZIIBa1i9GCrK/M3Oe6M9MS4XCn7argxH36f1b9sRHVYwXcrEY91ys5ovi5T5A3Q==", null, false, "", false, "Thang-dev" },
                    { "09BD714F-9576-45BA-B5B7-F00649BE04DE", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6c1b96c7-f48b-49ca-ad27-11dbaf1ad62d", "thangnguyenquyetvlth7@gmail.com", true, null, false, null, "thangnguyenquyetvlth7@gmail.com", "raw-account7", "AQAAAAEAACcQAAAAEI2VTGhEGJZfnPeyxiXXnwr2I7sfGWRC3rMM1v0R0mJW4cuUIHHsymeC8YD+ubjrVA==", null, false, "", false, "Thang-dev" },
                    { "69BD114F-9576-45BA-B4B7-F00649BE00DE", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "baf95800-25fe-4b14-bcb5-cf6151037f6f", "thangnguyenquyetvlth8@gmail.com", true, null, false, null, "thangnguyenquyetvlth8@gmail.com", "raw-account8", "AQAAAAEAACcQAAAAEOLgo9VVplHGNMB0zAiGSaLBZXkQkenznxlqmKZRxfLnmTXVfAT2K13XS3po9kMg1w==", null, false, "", false, "Thang-dev1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 16, 26, 56, 912, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 16, 26, 56, 913, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 16, 26, 56, 913, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "62dcb162-89ba-4dfa-b1d6-1d5f6c766dad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "3a48b265-fd6a-4c88-9a5c-a72ff7af8b5e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a35c5501-4183-44da-9f17-564334845ca7", "AQAAAAEAACcQAAAAEOWO6WXaayCt3NVgllyAhf11ul5vqwJOBuNEwjMqv4418sX1ydieM0X0b+RgNPN+fQ==" });
        }
    }
}
