using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class AddProductStatusfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 1, 18, 27, 50, 243, DateTimeKind.Local).AddTicks(7689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 27, 18, 49, 5, 132, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Products_Name",
                table: "Products",
                column: "Name");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 27, 50, 297, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 27, 50, 297, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 27, 50, 296, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 27, 50, 297, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "e8f82251-9f09-4867-86af-e35e6ffbbec0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "496faea3-5ec4-44c1-b9df-25ec46708b57");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "d0e5d2ba-4526-4db6-8a73-46c4001d88ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "aa128821-097a-4ef4-841f-08937403845d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 658, DateTimeKind.Local).AddTicks(4786), "b988aead-95ea-4909-8705-e50c9166219a", "AQAAAAEAACcQAAAAEDNQev0Jk48Py9MtinG51aDoyartAUuappONQ/N8mxEPgxaES3o9YxUIl8IcSSpNTQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 317, DateTimeKind.Local).AddTicks(2231), "2314d19d-7ea3-42bc-9a90-41eaa77ebc89", "AQAAAAEAACcQAAAAEHQXQ6warT5l78CrZy/IsVtudl5bNPsiV7r3zc7zGDZI8+SdZY4RlK92Z6vVg07/ng==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 332, DateTimeKind.Local).AddTicks(96), "d3145b7f-7eaf-4599-87ba-062889a7cb91", "AQAAAAEAACcQAAAAEAwL2NTwrHwgWZVboRDjaz0jEYb9qELfTIGgLKdbweGbwxd+vxg/ow5HvcTUY/CSiw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 344, DateTimeKind.Local).AddTicks(5686), "df6835ba-52d2-44c9-ac0f-1bb0c16c4f10", "AQAAAAEAACcQAAAAEDq60eL3WIOrANkrHHSpn3Z7JW0YvZs3u08JW+s2BHkesj6Ot6elfD581BMfjqwyWw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 358, DateTimeKind.Local).AddTicks(3246), "05072bc6-0325-4d2e-89d1-6022deb4330c", "AQAAAAEAACcQAAAAELSr/DItizZ13wgmw+2uGBEB9fuWopg973lKEaEhZvCMCuEetujh6+g6VU5cPswopg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 372, DateTimeKind.Local).AddTicks(1263), "6d1a2da9-2798-44bd-923d-c495cef42f26", "AQAAAAEAACcQAAAAENgZzmYgmjPQ7sxVFDm1xcBoZtXMKyVyzuXgHDWLcgmfugQr7QftIeNXtXtnirU+mA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 385, DateTimeKind.Local).AddTicks(2865), "2824da54-4465-43f5-ac6d-bf303dddb66e", "AQAAAAEAACcQAAAAEPQLNuhi3PP9u3Aiwh2US19rl1JINWNwYi18HNpS+Xfv/jYtMfV7RxYgpp7RotjShg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 399, DateTimeKind.Local).AddTicks(7497), "05cf88ea-e748-4b25-8dd1-e4c09a3bd2c5", "AQAAAAEAACcQAAAAELXmH7hQE/5OkkeMPD0aDxJRZxDhL6/0ktnGQ6/4aySITgfe0qpF3Z2wFeRIEOAobQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 412, DateTimeKind.Local).AddTicks(9036), "4a23a331-5e9c-4e9f-9e62-ea634a01113e", "AQAAAAEAACcQAAAAEKyZ7aiX4E6vUTu+hLrK7LJFORTGeY/YS4ZmxgGCM8gd2xuHRIfLo6TsflQnmwJ2YA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 426, DateTimeKind.Local).AddTicks(6525), "79893086-876f-4aff-acb8-26a9744c979d", "AQAAAAEAACcQAAAAECtZwnUqXLmujFJeQO2tbpt0zvlo0x/Vz7679eWNmXKtikFz85CHlp6/yRqqiz/JyQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 440, DateTimeKind.Local).AddTicks(6880), "fb4f6222-5d9a-43ca-ba7f-3ff638997992", "AQAAAAEAACcQAAAAEIBzS+0wXjs6ivGW0yl9jGt1vyuNBbeCm/hNx3b7tIcqZkeycwg3y2ZWUNnL85I2Kg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 452, DateTimeKind.Local).AddTicks(3191), "69baf493-22ca-4e99-a72a-a468108885b3", "AQAAAAEAACcQAAAAEGJfSFlPsmUnfOc+lPZd0h6t+q3HV8tgOr7Qit+zBteChyKk1e8xYX7Y+abwvJyQ8A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 464, DateTimeKind.Local).AddTicks(7550), "ea0278c9-ac23-4d0d-98d9-6aeaf75d0d5f", "AQAAAAEAACcQAAAAENTV9Dla/GbKqC44XbfRSrXGHmhA6wauJd6DCJSUQXr9XNwGSAX8zcaKAnPuWNUTQQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 477, DateTimeKind.Local).AddTicks(930), "3d4843d3-e700-4490-a850-fe1d4c7049b8", "AQAAAAEAACcQAAAAEP+4X5NmQbCknY6qnas1OnJinyMPE0iPdN4b6YiDpGeblMn9TpIpO8g2r6JkcjP3eQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 490, DateTimeKind.Local).AddTicks(2427), "99099aa4-dbf8-46ef-997a-4b40076cb385", "AQAAAAEAACcQAAAAEOnauWFkCZqBTuRakT2aNrBww1OJZui233mX0yCrfXrLTUpiK1IXBF59USp1q5K8gQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 502, DateTimeKind.Local).AddTicks(1342), "03e1bc75-4e24-4227-982f-02f799951972", "AQAAAAEAACcQAAAAEE6NvOvI8TuLFtT5Yen9v4zJHCh2H8KtKMStf7SUB9zG4MOaqUnnlBlLo1aJ5xbqnQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 514, DateTimeKind.Local).AddTicks(6367), "5d94d820-d57f-4e55-bbb7-6df4fd79e323", "AQAAAAEAACcQAAAAEIeBpF85qpaZiqB4ju4fhNOrseaL5MiRoYh/l/+l7T8oeZEggJGF8GmWkrDIXkcAMA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 529, DateTimeKind.Local).AddTicks(6120), "2347f53d-2a87-4ad3-9524-2d8eb4dbb378", "AQAAAAEAACcQAAAAEPWubSulWfBZ/b5g4nontQLOr1rd5X+6YhF0Rsv1Lw6Xe9OfrSmNPt+y9gAJ0FkXRQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 544, DateTimeKind.Local).AddTicks(7554), "c60be9bb-5d69-43ec-86b7-e596de3a1cd4", "AQAAAAEAACcQAAAAEKd1dziyMZW0ip21ilVXKYZg/jV0yqbO2VBTEeL/wE56EWxgLUwphW9S04NovJG5FQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 561, DateTimeKind.Local).AddTicks(5806), "33b505b6-51b5-4217-aeaf-0ea8184669e4", "AQAAAAEAACcQAAAAEDvEmjBymgzEBB0IHbraHP08hIWzvXq1930Y6nBdqWIAxWVlbFbvst6V8+AZTjWE0A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 576, DateTimeKind.Local).AddTicks(4955), "488a4e74-464f-4a89-ba9f-76b9cc4a0cf1", "AQAAAAEAACcQAAAAEP1DX2U6/tqYabsrEWImJfuV6ihebD6um+gIZITdrnCPdv7f+o/IhfrWKGIQfxDEXw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 629, DateTimeKind.Local).AddTicks(2292), "6e6df6e3-dd0d-4ab8-8258-e7dff4335a32", "AQAAAAEAACcQAAAAEDb7hO+MC9J6CTojXlqGguwpVfPmFh11WmYAMqPDljQZHXRRiWNtunlkkKWKTNkFEg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 621, DateTimeKind.Local).AddTicks(2647), "a9431637-5221-4471-8223-d44e114fb604", "AQAAAAEAACcQAAAAEP4/NZ9s7zOoFA1Hb2/3mPKL6MKFkC2P+arnuhwg5QyvKNvckO+eZgzr4H5eigq9zw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 638, DateTimeKind.Local).AddTicks(8641), "c444d467-0d8e-45fe-942d-6cffa82a2e15", "AQAAAAEAACcQAAAAEOSLnyf8XHlUlJtWpf2TbnT0sZDBkVlvx2YHHFuaFeo4UJZWEJn9EyyLv2me2ADcWg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 668, DateTimeKind.Local).AddTicks(349), "12add973-1b11-4dab-b8ee-994569d878da", "AQAAAAEAACcQAAAAEOEQudMoaoD9x/H2PRhYju2WxmtrFw7LwrcUy6Q9ECRsoXLXsv27o1RQ8LcZ3x9cOQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 601, DateTimeKind.Local).AddTicks(8727), "237d984c-f74d-4d78-bf3b-224cf027c12b", "AQAAAAEAACcQAAAAEAJOGcfxvKkoNRxK8ygECEwwAM1UYoQ93TgNFeaWu6MnWpcdSjw/dekDpyY1v25QHQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 610, DateTimeKind.Local).AddTicks(6736), "ffcad5bc-620b-41fb-9c88-700796552a6f", "AQAAAAEAACcQAAAAEI3u+jHVLxJO2lLy5klWiwzh8wy8mVYhqVjhfFG3dlvhtMJZe1PdeJCN3YN3k4HLLQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 649, DateTimeKind.Local).AddTicks(2770), "cbf5fbf2-a72a-4296-9916-6eb3a6681bc9", "AQAAAAEAACcQAAAAECOR/lSug8A/SwO+py/qpRwrIpjBS8uy3AndvNJtHgkSEo6oA4FQaG9qLyp53kjbQw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 27, 50, 590, DateTimeKind.Local).AddTicks(2499), "5295f797-a7ea-4633-bae5-0640c80334e1", "AQAAAAEAACcQAAAAEM8dZNRGe2xWUi9kdB/951sNqwdvLMrO1nGdKNV0AMZiyHezLQ6KG0pjxDB+lEO6Yg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Products_Name",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 18, 49, 5, 132, DateTimeKind.Local).AddTicks(6032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 1, 18, 27, 50, 243, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 18, 49, 5, 181, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 18, 49, 5, 181, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 18, 49, 5, 180, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 18, 49, 5, 181, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "b1434f7d-342f-45e1-a9c4-12cfb727ba3a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "487c075b-8ba5-4f0e-9876-f6e3baae5ea1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "c853d22d-01a4-4b2d-90fc-348dc3e195e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "5102f9cb-0fe4-4f1f-a3cb-4b66f2a69867");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 553, DateTimeKind.Local).AddTicks(5291), "3783ae6e-2e33-4fc1-bc60-4ddbc280802c", "AQAAAAEAACcQAAAAEGBJZXXDX2TwIeNOYGLAoP2lKzka1MzGEB6c0V5Uxxm3WSKUNkYZuhTYqqs9tRsxwQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 203, DateTimeKind.Local).AddTicks(6397), "a08d44c7-4651-4df0-9d5d-0bf20f210e94", "AQAAAAEAACcQAAAAECqnQZTFrsXrn+0kITSUe2NZr4sxaB2hFeZvShoyq1WTfSWS1xPDsM6vXFTEhXzN1w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 219, DateTimeKind.Local).AddTicks(2358), "18374491-95ef-4995-9be7-0b4f94d381fb", "AQAAAAEAACcQAAAAEHtWQu8VCcx1HCep6m5tN8+O5/gNLXBrfX/e5Xzr3cDeF3Bijaczbx9ey2SuWuWKfQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 236, DateTimeKind.Local).AddTicks(515), "a7236018-4fca-4bd0-80ae-e6c5d782eb47", "AQAAAAEAACcQAAAAEL2KloTe2Sbfb8GzqljpHg6GzOhZOeeIfm0T+MnHIGmItT90JF8Svt8QS+Qrea5ELw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 252, DateTimeKind.Local).AddTicks(1300), "17546f29-fac3-4084-914b-4eb052fd91ba", "AQAAAAEAACcQAAAAEPXb2C47Qs+V2J51W/UVxZ17vja05RwyLCY1gm7ywuO8XOLGxSXCbYPqHkV47lZiEw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 268, DateTimeKind.Local).AddTicks(4179), "05ec70de-b317-46aa-87d0-545ea352ca47", "AQAAAAEAACcQAAAAEHeHlcInj0T+ZNcqon1tkK3aaK/AHeNUWY3DA/3wWQyy9uqruP06/zQbdz/HcNlCIw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 281, DateTimeKind.Local).AddTicks(9643), "f81cfe7a-dfbf-405f-8887-490b3afd514d", "AQAAAAEAACcQAAAAEHko6aFKMR60h5J0rqTJS1xH546hUPWYmJj2pKz09jYi0wnS0iuLi4s3LfXtkeqrjw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 295, DateTimeKind.Local).AddTicks(5887), "c5d08247-65e1-4a35-91c7-4736b6f6473d", "AQAAAAEAACcQAAAAEL0trwBr+zKalT1wgjk1qeJr5mlVUI1mnjsGXQ0MMLY78YIM6oJ6eBkpiuqA45nSsQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 311, DateTimeKind.Local).AddTicks(1271), "e294ff53-1a2c-4ce6-826d-daae2b31439a", "AQAAAAEAACcQAAAAEFbG/DbIWCX+NuIyy5NfmJbLoiOlVlSYdpCWYInLE2jXCfxKwKzBZ8AouoKxXeCQwg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 326, DateTimeKind.Local).AddTicks(8380), "c3d10afc-1d4d-4d96-9d51-78e0f0b95b6e", "AQAAAAEAACcQAAAAEGaD0ubA0Vc7mvDaNeewkDdon5YooyWQkEhrXqEiW3pB8dhpNilrsMtn3Gk8+AeLSg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 339, DateTimeKind.Local).AddTicks(2971), "29673292-1e0d-4cdd-89b7-b2c81f7ffada", "AQAAAAEAACcQAAAAEOU1F7M3ifgXoDkHqlmMWE3KSWYNP6MJmaUp6uOmZYjMx1TvRisYxn+H2LlqfeL61A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 352, DateTimeKind.Local).AddTicks(3319), "4b751028-4cf9-44f1-9644-0b2f5c2587f3", "AQAAAAEAACcQAAAAEA1soOp6yw3yeULAq+xnmLvIxPTPLXGKlAW8CQj8NX90IxYcwnn8yPpsqajPSLSXGQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 365, DateTimeKind.Local).AddTicks(6634), "f7ae6712-c2cc-48a6-969b-1f85c25529a1", "AQAAAAEAACcQAAAAEF6zF6HFX3qYj4b45shgUytTcaLjd1MaqDuQxqliIPMYu5LsUGCr4daYreCquY+VCQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 378, DateTimeKind.Local).AddTicks(1211), "dcb8eef1-f781-4918-adf8-cea4a46c1493", "AQAAAAEAACcQAAAAELZ7HNIWfSgqS3CWNsxcJBe+DyTwE2KYcR+LL7OcGwGkxYS8RaaG9f6LMbLorNWYIA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 388, DateTimeKind.Local).AddTicks(7128), "eb2a6a06-f3d5-4411-a76c-d16568d67d55", "AQAAAAEAACcQAAAAEPXRG/4LxhTHdxDRbj+AIVvToGnYiNAwgojGPSfuHBFcG8AAJ5mHgUCYH/ODw+bh4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 400, DateTimeKind.Local).AddTicks(4400), "66b8b0d7-c2f7-4c19-b368-8a2aaede40e6", "AQAAAAEAACcQAAAAEJQ2vtT+kvFz4zoRCBXnqbtj0AQ3yknug5d5j3M8jmQBASi5RTgvdADo629FKBK7cQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 413, DateTimeKind.Local).AddTicks(5171), "4525bdc6-aa76-4599-98d9-97156a0c6d46", "AQAAAAEAACcQAAAAECWCUek/PiZ4oY/EmGE93+IXWA6JJvUrc4BTbaqfEsaOgUEerbI/fykiN5wzXwRc9A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 423, DateTimeKind.Local).AddTicks(104), "54149e4c-a694-4135-910e-992fab90d831", "AQAAAAEAACcQAAAAEH1kmmImjKueS5qUsqk0iuvrdBT4shfbyCGvfW0OHHTp+PgVcNnPpqXMzOlq/PK6wg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 436, DateTimeKind.Local).AddTicks(5932), "eb966244-5497-46c0-9874-e2c2f3c10e32", "AQAAAAEAACcQAAAAEHgmswdWByJJEriuQ6138sSv2+oycj6ojAkqBLapJ8MhySKMeWSEmWCzdTRT03N00w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 447, DateTimeKind.Local).AddTicks(577), "7d853fff-8c24-4338-9fba-1f140a89b727", "AQAAAAEAACcQAAAAEKTd6Uj9TKNbOpu7BUrYb9k+cNwV+s259xM0b0jberwjv6WY9Spjz+Wq89VvjXXQ2A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 459, DateTimeKind.Local).AddTicks(5321), "b0b01db0-5463-4487-96d6-fd4292de32a9", "AQAAAAEAACcQAAAAEIZv2BWMWVb3Y0ErIny5HiGNU7936mIVNG2JVAaOdGwlP+Y9HgoX1vaeo3kGPEIeIQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 522, DateTimeKind.Local).AddTicks(8164), "8d19d286-49d8-4f9e-9640-25e3aabbf573", "AQAAAAEAACcQAAAAEMQSZouD8KgrLToliJJX26p4M9ZZxsYOMHde2mQVDWUdrFACb5WpR+ytl/pYy9nbdA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 509, DateTimeKind.Local).AddTicks(731), "514a2fe3-f5f4-4b6e-a66d-d14cb23421b4", "AQAAAAEAACcQAAAAEMZRfK6HsIkE/ejfoU6CLEqeCHlP3Wm0Oy3a5oxJ/FPB1YZA+v5SKbqfZUR4Vam+lw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 532, DateTimeKind.Local).AddTicks(6515), "bd73a8d1-439f-4ef2-8835-ff73d4d80d68", "AQAAAAEAACcQAAAAEAYMPgkFBU3dxUILKkRlM6QWS5nNdJtJnBquOMlGTrkQGo/FnItFxdGRIwpUtDz4bw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 565, DateTimeKind.Local).AddTicks(4823), "a8a9d853-c4b9-48b6-a60f-268bdbaf7b78", "AQAAAAEAACcQAAAAEK5OqxAtThIAqHsjVoyUMX8XIRncuEQ0sY1mWyqn075UxR14pK5LRbV99l14D4f5gA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 485, DateTimeKind.Local).AddTicks(5921), "547e1805-63bb-423e-bc70-c6f16c227285", "AQAAAAEAACcQAAAAEHfHP3ewSIsEYJYASgOxubzykL7A9A7MCygpwJEfx31IQWmn70wy1LMhOZGUSeTpoQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 496, DateTimeKind.Local).AddTicks(3912), "1b3f9f5f-555b-41d4-99b2-590d937b33fc", "AQAAAAEAACcQAAAAEG/EW880I6I0aMAAQorbyJ7L49bipZzntk0Ao0SScOgM8Bm+dyA5hDg3d8eMdx4uMA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 544, DateTimeKind.Local).AddTicks(7160), "d954065e-cb2c-45ac-8aa2-62a85c98d6d3", "AQAAAAEAACcQAAAAEAp8H1qkfRBxQXcoMOQ//Rncan+VJqEnis5A07yH1UhAwQVd9TJaixU+Tr35FTx3xQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 472, DateTimeKind.Local).AddTicks(3201), "ca241c81-401a-499c-93e6-9d4204337d6e", "AQAAAAEAACcQAAAAEEWI0zRkaPmtQWN5Z3uKa24SaPTdJhRdkPwVIWBNShnCXUM9ZjsLbT1Om/vocE8sug==" });
        }
    }
}
