using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class RawdataUserv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 16, 52, 43, 921, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 16, 52, 43, 923, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 4, 21, 16, 52, 43, 923, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "9dc22be1-d546-4c8f-b554-8c0861e8dfb8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "0e5e1d7a-6c3d-4dc8-858f-c4de1c192ee2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 44, 34, DateTimeKind.Local).AddTicks(9371), "68310544-f2a4-4d79-a19c-217204ba067b", "AQAAAAEAACcQAAAAEPnxx6dZzpf560y6bqKVtrT/O00qhsorOJlh9+7lQsZwDYVoU9qwczhEkRmwO8Rx3g==", "raw-account7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 43, 994, DateTimeKind.Local).AddTicks(2824), "385d28a5-00be-4d05-8344-8c422c0cc0d6", "AQAAAAEAACcQAAAAEO7O1MQzEepViDom4M92EZdZmOyk6vLdXq4MhJdJu5YRkkpGxps6vzUsh/RD/7UDEA==", "raw-account4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 43, 981, DateTimeKind.Local).AddTicks(865), "0c9fe468-5065-4385-9017-f12d682d133a", "AQAAAAEAACcQAAAAEJ3TvLHx9CjnwLKz8h/1FAod0F69IHc7UKj6OaGMqVNqu5UIAi43AFuSY1mToegGhQ==", "raw-account3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 44, 7, DateTimeKind.Local).AddTicks(4995), "12b9e24d-44d0-46b4-ba8d-88a034ee5d9b", "AQAAAAEAACcQAAAAEL5NaBgD7tyn/YSUyPqun/5Skw8D1TmTfO7SiM484vOlnMJnOmzh3wdowA7qq039Iw==", "raw-account5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 44, 47, DateTimeKind.Local).AddTicks(9798), "2ddf5415-8770-4ad9-bbb3-f9dc926f12cb", "AQAAAAEAACcQAAAAEMgWz24ygUeae2U9B5Xc43RHYm9ZkSWpijZHwHvwP4V5F0CBNr+rTodG+yiaERMGOQ==", "raw-account8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 43, 954, DateTimeKind.Local).AddTicks(8141), "d10c226b-9069-4503-9db5-02b85c6a0e28", "AQAAAAEAACcQAAAAEOP7bfHfX8ITG1tKZx9NHY4IpqDbMg6SnK5k44jxxwFVe0NnoSuM/tlE+hbvXVHtbQ==", "raw-account1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 43, 966, DateTimeKind.Local).AddTicks(7843), "26114fce-2357-4a05-a45c-20fc5fb579be", "AQAAAAEAACcQAAAAENiPClXMtKTVJYR28tXxlqmz0Tp1QNsyvdKeMq/OJhlUlUn9MbXatRewSYBHhmQtGA==", "raw-account2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 44, 20, DateTimeKind.Local).AddTicks(8268), "f76dc31c-0bb5-4909-b001-db6a3d21e0a0", "AQAAAAEAACcQAAAAEEJID3FhuL/TSdfOKdKWsz99Hy6ONHu04CruOGRrmid+Ycg2Is/q+9QY9fN5+hi+Ig==", "raw-account6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 43, 941, DateTimeKind.Local).AddTicks(5729), "11074662-3ab4-4aa8-8c46-a6782d4dc91f", "AQAAAAEAACcQAAAAEKYPQPPwAIspnn5gySLIPtlkXrV9AlUoRAIGPQmMWSKAJH157RRLiR37IANUlI63kQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6c1b96c7-f48b-49ca-ad27-11dbaf1ad62d", "AQAAAAEAACcQAAAAEI2VTGhEGJZfnPeyxiXXnwr2I7sfGWRC3rMM1v0R0mJW4cuUIHHsymeC8YD+ubjrVA==", "Thang-dev" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6319afc9-6419-4973-83ba-3ed575e6bde1", "AQAAAAEAACcQAAAAEFOz0BfqY2WtK5jBZkY0fLd4fy7EJZ3EqmacCjHN/7OKx+MS2zpeLCMSsQn9khMGGQ==", "Thang-dev" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dfd2ad66-e641-40ff-b8bc-9cd3de770de0", "AQAAAAEAACcQAAAAEHgOfGX5ZKNIyImYa6tnXQp2LTi8+r2BrONqR79GZVLB92d6kg7/0X2JK+Ssu7G47g==", "Thang-dev" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4763b6e7-8322-400e-9668-45db5fba3ce7", "AQAAAAEAACcQAAAAEKIGJsEi4K7AfpY5tPTNhVPdW4iSgcgE/HIAb3KXjr6UNC4JMEaK7AqVkuRerE6WAA==", "Thang-dev" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "baf95800-25fe-4b14-bcb5-cf6151037f6f", "AQAAAAEAACcQAAAAEOLgo9VVplHGNMB0zAiGSaLBZXkQkenznxlqmKZRxfLnmTXVfAT2K13XS3po9kMg1w==", "Thang-dev1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cc8a381c-ac88-4da1-8a56-03a67467ff32", "AQAAAAEAACcQAAAAEInBqcVAwqubnt6TipfPU1suE4INj01XPtWiRE3ZQvZ/NXIEvQSH2DZ8DabsBLAdww==", "Thang-dev" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e0f94031-91ee-4002-b30d-1b84d23bceaa", "AQAAAAEAACcQAAAAEOyHuB5Gzw15k7iNungerErIfe3N+72pr6w86YEMzjCpCyLd60hAEfTcXe7blxoUJQ==", "Thang-dev" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9427990f-a922-4c87-bd99-b0613b6ee636", "AQAAAAEAACcQAAAAEIVZIIBa1i9GCrK/M3Oe6M9MS4XCn7argxH36f1b9sRHVYwXcrEY91ys5ovi5T5A3Q==", "Thang-dev" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e261440f-7015-4970-9485-2c259f831158", "AQAAAAEAACcQAAAAEEd3pJtwFE6tv5vrqWLWuc9kdEr1VO6V1WmrOT5wxWtIiYorkVPWyC+y7191kdJ+Lg==" });
        }
    }
}
