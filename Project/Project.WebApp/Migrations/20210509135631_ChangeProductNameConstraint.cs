using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class ChangeProductNameConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Products_Name",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 20, 56, 29, 303, DateTimeKind.Local).AddTicks(4742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 5, 15, 6, 37, 174, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 9, 20, 56, 29, 331, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 9, 20, 56, 29, 331, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 9, 20, 56, 29, 331, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 9, 20, 56, 29, 331, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "39509a24-6770-40b1-9900-d6886103294b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "c82ce07c-dbd6-4ae0-ae0e-6f919140bce7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "e3929860-e313-430a-895b-80f64599f1dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "9a8836e9-4e11-4f66-aadd-d59177d77ac2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 581, DateTimeKind.Local).AddTicks(8779), "a4270806-845f-413e-ae34-b673848f2c45", "AQAAAAEAACcQAAAAEEhUTOCPhNi1FQl4k1ZNveskbS6nyyeH300zHGT/85aX6dZN+MVd665wNeR8ZfZsQg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 343, DateTimeKind.Local).AddTicks(9358), "027bfe24-178f-4841-9a62-7f315813e027", "AQAAAAEAACcQAAAAEHKnfv/UImkdbxPV+QoU7L7skQfkkAi6RWV6azwglJWfgCiAPku6lLrNSEsilScrYg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 352, DateTimeKind.Local).AddTicks(2016), "ff3d3d1a-2ac1-40b0-a3d9-f8f99499d656", "AQAAAAEAACcQAAAAEMMYxw/jEKmFKp19X6H+96NvegJgvKIbQWcl1JPhiyioVlltEFO19s1p4YWxtlMXLA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 362, DateTimeKind.Local).AddTicks(9896), "1679eedf-fea7-476b-ae02-a201f8edfb39", "AQAAAAEAACcQAAAAECZvFpiUwAMgIx5Gk0p+rzsUsz7zr3oZdHUdVOnGinL4EBqAnOWkAlDTMk0S7J8foA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 372, DateTimeKind.Local).AddTicks(4815), "e5ece825-0590-4e1d-a7df-fc0e62e8aae0", "AQAAAAEAACcQAAAAEMRyfGbKVB1I82Gwp3u8SrbnOwnwwPL9K8/FPsSQCVJ9U2kb7b8HO0qNltc1LXRnww==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 383, DateTimeKind.Local).AddTicks(9040), "51b30c51-85dc-48b4-8a2f-addad3bfb92c", "AQAAAAEAACcQAAAAEEknKIqZImmI9pc3q2jR+a5LilHd2ipScCYdLwV9ZCS+VyvL8pbvlbs/EOzf0hyGlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 396, DateTimeKind.Local).AddTicks(7360), "760db4b6-f7b8-469e-b80f-912d5b4d43dd", "AQAAAAEAACcQAAAAEE/BkDFFJliawJ0LsxNVhTklEQePShSEOZ9PTqPROjFwcAHMveY7T7V/Te/T+NrYSg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 405, DateTimeKind.Local).AddTicks(5734), "82ef1d3d-1cc7-4f23-9f8c-ced8fc955e63", "AQAAAAEAACcQAAAAEOxThQzRudHhbeGBv2KGrfWhQGSwRmCMbst8zKwQFx84q0lG8xq4p1SyjSLbUYbQKA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 414, DateTimeKind.Local).AddTicks(232), "394fdff9-04f8-47b3-b067-70162d2034de", "AQAAAAEAACcQAAAAELenC0ZYE6e7zaBkl5Q5YG5s4MCzOHa/5Eubebw2DUBpM8bF3IaQBQk+Pf5f041AzA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 422, DateTimeKind.Local).AddTicks(7746), "56b25496-80b9-456d-b319-0d146513be64", "AQAAAAEAACcQAAAAEC0fBLye0I77hjt7Z4gt3yoyPGAMrN1wjDc4XwH/ZsJ2wsXPQeEetgOSIQqxY9SOPQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 431, DateTimeKind.Local).AddTicks(5646), "2dd7b9c4-897b-4c07-ab06-a2e8943ed0d6", "AQAAAAEAACcQAAAAENjrM9PXvvs0YiImUenQWWTvc9f4pzPaLBtQ/7CQTq+1EoUyuY2SnKQnZ42Fpco2FA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 440, DateTimeKind.Local).AddTicks(221), "42b06e1f-c7b6-42b9-a972-57cf0fe02003", "AQAAAAEAACcQAAAAEDeBdto8aGqSW4Yc18gHPNlh+CiW7mcPJgksMYDn++gjYO/JyLy+PTUxaFdI+Me+fA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 448, DateTimeKind.Local).AddTicks(1791), "0e81e2bd-1425-41e4-8b22-5bab311f271e", "AQAAAAEAACcQAAAAEFygF4ZcBJ4hiJeN6256jl6DGAWQc5ApAqFPAkki47MBY/hhQJ0dbQJkU+y4nje3XA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 456, DateTimeKind.Local).AddTicks(9159), "68315420-d6f4-4d8a-aea0-90b807dd9797", "AQAAAAEAACcQAAAAEP66f3c+wpewKeBHHYyrCwsXdSJadMpApETrrl/3DJdFHvWcw/jY53vwaGAOShGXZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 465, DateTimeKind.Local).AddTicks(5250), "972c8306-a47d-498d-a805-8d488fdd5361", "AQAAAAEAACcQAAAAEK6cVHOTU1zby5Et1NA8LHwgMi1S8CoF9ozPbJTU9YX/sc1J1+amgvvgYbcYMOCt0A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 473, DateTimeKind.Local).AddTicks(9907), "3dc4d288-9ce4-422a-9dc5-a9f17d1d61b1", "AQAAAAEAACcQAAAAEABjmQm6kRoeihlIPNplfco/1DhBfnpEs4YayGyFPsRGRapdPt6td6FnFdopW9Q3AA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 482, DateTimeKind.Local).AddTicks(8358), "598bd3d0-1918-4c98-af34-83e8f281a802", "AQAAAAEAACcQAAAAEF+Sop0KB7W/vh4QIvfWAP02L0NRaJm0Kd8qezMokp5pcEWgcT77c65Lu/7zR4wvcQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 490, DateTimeKind.Local).AddTicks(8183), "ca210634-8acf-48f9-915d-608b8a01f00f", "AQAAAAEAACcQAAAAEJOgtwUs+VikuR2KBYUNbsRhY76frghxingEOgC9KZ3KaQZDoketsrsSu3owF3ydEg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 498, DateTimeKind.Local).AddTicks(9774), "1e9f4f72-92b2-4bd8-ba09-9c32752a7430", "AQAAAAEAACcQAAAAEM/meRcd5SDOSA7da/4zWUsbez6F14kYy2N+W3p07MZnsFGFd4vzbIf+8IE/tVS6MQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 507, DateTimeKind.Local).AddTicks(1355), "ef34e217-c453-495b-8a7a-6aad005f5f78", "AQAAAAEAACcQAAAAEAQr+nvO7L+4RegH+VcyPCvRCjuof+EOOA5X7RhpPu3cjFElTRoWEgJB+0P7DbAdjg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 515, DateTimeKind.Local).AddTicks(4491), "a8e6c7b9-a0c3-4643-994e-c217cc79d101", "AQAAAAEAACcQAAAAEGZMMH/Qg5KdUJqX6XTP/MtPS1/Za4hHoKqHyTk/G2t0r/4H/AKSrp295XTVusOzNg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 556, DateTimeKind.Local).AddTicks(9425), "afb2ffce-ed1d-48d3-b611-bbe72153ef2a", "AQAAAAEAACcQAAAAECmyS0Q80DUnfQKWhVLFInCHWzB8JGslpb4Mchj4sJzvX3ltN8rvuf2UQho8t+k41w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 548, DateTimeKind.Local).AddTicks(3607), "1047f892-2e10-45d4-8587-09b24d0399b7", "AQAAAAEAACcQAAAAENbhzn3mTtP2tWweRr1D1umqfIJ2udYFQ/8Q6+Z7k6XnVd8MVHN59Ku0T/xUlE58HA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 565, DateTimeKind.Local).AddTicks(3096), "4cd3c866-a078-41e1-a194-7c3482baecd8", "AQAAAAEAACcQAAAAEMYAJ+495nvhLobh1tICfa+/HnCfC6P0UMPd8KcN+H/es4wZnVJ2kqgSDuwd9u9nqw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 590, DateTimeKind.Local).AddTicks(1324), "c076c503-d40b-4c22-a9e6-5b2a57e61882", "AQAAAAEAACcQAAAAEDtTCyuJLYN09nWQqxlyRsn3J2M3TiKIOF+XQCBfB1u+7nmT4lAr2Cckir7Gzari4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 531, DateTimeKind.Local).AddTicks(5957), "a62e17e8-1c8d-4cfd-95b9-b2b1054d464a", "AQAAAAEAACcQAAAAEPwEeKNkFtwqJIWYW6E+upiAm/N6yErcQbOb3xdliLnr+T2RAzTHL4Nw4CK1yESVPQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 540, DateTimeKind.Local).AddTicks(748), "413bcef5-2929-4164-b747-41a91a420c97", "AQAAAAEAACcQAAAAEMLTPGdm1AnqMBu61rP+5xSI5oDpuBN39zhbhA1mtPTKxpgS+whyhNJfzt8WkXnq5A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 573, DateTimeKind.Local).AddTicks(5765), "36122e09-d592-40cc-a8ca-af04bfb6390e", "AQAAAAEAACcQAAAAEJjPyE/KPKE5EOQ9d5NoINJuZoMn1EkdlcxZ8Pb09bBo7uHEdI+3Sm02VejKhDhafg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 523, DateTimeKind.Local).AddTicks(6344), "9f7bb757-29a4-4410-b1e7-e719ffabbd9e", "AQAAAAEAACcQAAAAEPbBZl3+XjKuJ58CtI7PrKjewjUae0LxNj6laQAXtjRmBEia3dC7AMZoDaq2C4lJzA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Name",
                table: "Products",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_Name",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 5, 15, 6, 37, 174, DateTimeKind.Local).AddTicks(9909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 9, 20, 56, 29, 303, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Products_Name",
                table: "Products",
                column: "Name");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 5, 15, 6, 37, 215, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 5, 15, 6, 37, 215, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 5, 15, 6, 37, 215, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 5, 15, 6, 37, 215, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "7f7fcb48-64de-48ed-b9a8-229555143f64");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "76ad2f36-1083-4f5e-a080-73b35b14ae72");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "33a72f55-6b95-4a73-841d-98c1193366e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "44b6c4f7-d4ca-4cca-a84d-c90fd45aae95");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 638, DateTimeKind.Local).AddTicks(5218), "efc52541-c8db-4828-851c-3aa1db57437f", "AQAAAAEAACcQAAAAEGbeDzHVvZSln2UyEJjexqegKqcMxrau+U3qRTbzQvVRjzJ38EtpQoOFEz/moLtazw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 233, DateTimeKind.Local).AddTicks(4902), "54629b12-0cd0-4a75-9c3a-9cbf8b469381", "AQAAAAEAACcQAAAAEGL2ybPbYf5alaLNfHxOls/syy+2kAMmSN/1WmRTeXGCm4rYQJpr0NLOax8NpZDNbw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 247, DateTimeKind.Local).AddTicks(4792), "e82dd558-8500-44fb-827d-d5be61d791c1", "AQAAAAEAACcQAAAAEJRD+YxhIj7cM30IXeldMwGWZVPyTe5XNENSHNt9RokERZoH4J1drC40QxGGI527vQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 321, DateTimeKind.Local).AddTicks(8854), "bccf7114-38c8-46b1-b5a1-c8e927bfdde2", "AQAAAAEAACcQAAAAEEBoB/Oqx/v0GY+4SQBflean0UbhHmQnQEoZMhiWkd8HGglt4H3UklZvqVTKmyMGMg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 335, DateTimeKind.Local).AddTicks(4178), "f85e06ed-29f6-439f-8684-d676dfa269ee", "AQAAAAEAACcQAAAAEGADHQhjR5AAD4eKA9Iz2L7lGXvJoIHm3aC1mUDS97iudAAzIZJCw4EiIWPLQyhmxA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 348, DateTimeKind.Local).AddTicks(1103), "22443fbb-e2c7-4bcd-b3c1-dac2d68a5995", "AQAAAAEAACcQAAAAEEG6goVyiDOeBAiA218G7RAIV8mse9GxO+qIgEI5eH7GKh5CU3lY20bkTJxEAQm9fA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 361, DateTimeKind.Local).AddTicks(3671), "026b98a0-88ff-4f93-be23-baa6adc4cd35", "AQAAAAEAACcQAAAAEAi/Db8iJeHDxSUxkx39ey5UG2ScoLEkW1HlZS0MNV0yBPgBuajZHApwtK1Sd9sLkg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 373, DateTimeKind.Local).AddTicks(3575), "75a9e5a5-9190-4465-ad2f-9a6bffd9d923", "AQAAAAEAACcQAAAAEKPxKyAWZG9s9td+xiDBBv1/skSG8M4Gl6l/xG0DZV65OIysBFvQ7YkoG6NE/5HrwQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 386, DateTimeKind.Local).AddTicks(3529), "dd3bbe14-e72e-49b7-9ec9-5bddec8b457f", "AQAAAAEAACcQAAAAEOKSd2VQXtpYC3fs2nx+KHi54F+KcB9CQv+/syM7lwB4Oh57SAEN8YR2VXb8R/TyGg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 399, DateTimeKind.Local).AddTicks(2629), "f2c2ae82-3333-4c4e-89ad-2c570828b5c3", "AQAAAAEAACcQAAAAEGR8jh5wIJdCnFCzL9XZQpCuFYCXd+w/AZgUpJnTgyG9WicyBt3wHbahdMSu7Giw9g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 412, DateTimeKind.Local).AddTicks(1141), "fe715b1e-9508-4bfc-8a85-e232b3d044cc", "AQAAAAEAACcQAAAAEBei4YbA5oSu66wuWPqXw2JJqa8mEDCvZ0I0SdzaxZBnDPQDQPaazgYJ0VXOZoAROw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 423, DateTimeKind.Local).AddTicks(5742), "7d18b583-ef7d-42d1-bf5c-1bf00ec2944b", "AQAAAAEAACcQAAAAEDJqs6k54cXt66MKRVEjrjfkscPHGfBzcapXyZRJHOW2ucnQq9gDqMR65xBoGbGu5A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 436, DateTimeKind.Local).AddTicks(3663), "0c4f19f8-1f93-4421-9548-7399f5d900e0", "AQAAAAEAACcQAAAAEJpKDMY6yiCuMokT9o7Lc4eV3ahxRhDTniB5P5KX5c5JBJj9SGeypKKCkQIdf2HgRg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 448, DateTimeKind.Local).AddTicks(9411), "f705a0b7-66f6-468b-ba84-6c5250ba417c", "AQAAAAEAACcQAAAAEP+0/zISy32B6ZLbwfY5ElQPFFvAFUShc2vVY3Kox9xbEtIeXY1+KPQs5+D8sxrhUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 460, DateTimeKind.Local).AddTicks(8949), "66db44dd-5309-43f7-b64b-c254c6c86680", "AQAAAAEAACcQAAAAECGzOMrEORqoq0kuCm3dimzwC9JFSudXnUI8fXYFKTA560i3BFjFRVBK3tBToYFv5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 472, DateTimeKind.Local).AddTicks(4486), "7dd3b0e2-619e-423c-92a5-68626abae038", "AQAAAAEAACcQAAAAEBPpneGkh2tT+jik0Uf6jnddFpfhAjTYRYF1DOyqCsVe2pLQlqmm/zRx4rGAEsHjpw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 485, DateTimeKind.Local).AddTicks(7241), "28637137-1581-498a-9691-2f51635a23df", "AQAAAAEAACcQAAAAEF8SgtJY2uzVhQh6mK1I+BOcFcBrIS82p5xy/HMQP2u3aZ33mYbKcLBOr4/TM/RfbA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 498, DateTimeKind.Local).AddTicks(9067), "c86d79ba-7cb9-4358-9ce8-669454bfa588", "AQAAAAEAACcQAAAAEIY0RuRQuNkVjTR7bM5VS/4FmJV2PU1Bz+h5kUIxU3b44C4kXG1hRgteBz2sk8rvZw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 509, DateTimeKind.Local).AddTicks(6660), "267cd60b-c748-477e-98d5-37b3cc699c72", "AQAAAAEAACcQAAAAEDSMG7MpUrVQtd8V0KKjTukAdEqvcwsajL/TR0J6eYY1XgZcioHJpFlTIXUXxVHcNw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 523, DateTimeKind.Local).AddTicks(2689), "e2b085f4-8beb-43a0-85da-09c627cb988d", "AQAAAAEAACcQAAAAEID/cv8QhbdYek3aid6aHoaJG4/RB3Rs8SQgdVgJxgM7VpiqKxUK94WaLgk5VRp3ng==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 536, DateTimeKind.Local).AddTicks(2082), "f015abcf-66e7-4a1b-85b2-b96c41ffa4d4", "AQAAAAEAACcQAAAAEN2cTu9zj70FbUF+x/l28Zi2wsry9YG3cyFyaBmindu77b6xx5Z9MDQPNSjCiYBzNw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 598, DateTimeKind.Local).AddTicks(2111), "6403b5b8-5484-4dfd-81ec-b1916ce1d80f", "AQAAAAEAACcQAAAAEHAeBzFAKGUqnCpXTcDJ2pTcoi+kw62DglSgplYZdcXzuaYoNA1qG1N1tQj5/NfOiQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 585, DateTimeKind.Local).AddTicks(1838), "568c71bd-721a-4465-b203-18f307c505e8", "AQAAAAEAACcQAAAAEAK7G9GDu7+LMPRDF1gLmu1TQpjU1S6o6wVEYsJViIdzji1oNOfTfHZV4ywHN8F5zw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 611, DateTimeKind.Local).AddTicks(5167), "1cb1455d-d2a0-40f0-aeef-86507bb33e98", "AQAAAAEAACcQAAAAEIHEZfJdhys838cHioKLefi7mNzJ4Pd2XBx25vvtH+0GPoUOkPhnnwunjHbukYRmvw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 651, DateTimeKind.Local).AddTicks(4443), "d854667b-2f0b-4e25-b3c6-26e265581696", "AQAAAAEAACcQAAAAEGL0ergF9rBxrsIAO5mgx8GuGYoMrtRgXVGzAoSUIWId5+lkDE+lIoOiBTKyhOM+1g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 561, DateTimeKind.Local).AddTicks(3513), "a8507dde-6f81-46f1-a079-9ab7c7b3720b", "AQAAAAEAACcQAAAAEJPC/mQ6MZ0qJrl5nYPzFo0VRPMMeeGuq1ZUT78FIvGlgf7fwINchaEufmLRAHhhJQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 571, DateTimeKind.Local).AddTicks(8413), "49f5dd01-f699-4764-bdb1-5dab9ca28f3f", "AQAAAAEAACcQAAAAEBKuRwvt1AH0oEI0R+jmR4G7uJkaDHM1T+TkBbkarfTcJGTl8A1mT12Vwjh4KDg+Tg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 624, DateTimeKind.Local).AddTicks(9170), "a2b00b68-3c28-4d93-817e-facb7d880fc8", "AQAAAAEAACcQAAAAEDJvSAiy3sNNFEBGB7UDWx/We3qJOOZWmdqjpMsDFgnnw2WTU6gYu3kfE2PrHhDqAw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 6, 37, 549, DateTimeKind.Local).AddTicks(5976), "a30ccf9c-fd1e-4ba1-a37e-22b9264c5602", "AQAAAAEAACcQAAAAEGp2vd+GVrZD9586ZG6h7VC4e0iS2ieJ6ti4T4y033BCR15lJUni03fULiziLwSrnQ==" });
        }
    }
}
