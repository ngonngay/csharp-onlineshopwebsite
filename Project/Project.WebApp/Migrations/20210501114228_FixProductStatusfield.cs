using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class FixProductStatusfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 1, 18, 42, 26, 947, DateTimeKind.Local).AddTicks(9),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 1, 18, 27, 50, 243, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.AddColumn<int>(
                name: "productStatus",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 42, 26, 987, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 42, 26, 987, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 42, 26, 986, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 42, 26, 987, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "b6f3b04f-b73a-4f24-a3f4-822643006153");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "b426ef6b-bd91-41b1-8e6f-4c1a6d1f050b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "4a916f7b-6203-4a9c-bcc8-117dc08b8a29");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "98f90514-ce95-4a11-a54d-c895e94b7f94");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 320, DateTimeKind.Local).AddTicks(7238), "aee6d9e4-c33e-4400-bd1e-1817d9f1b815", "AQAAAAEAACcQAAAAEDjg5jSMq1JK9CiFSDW+xXsUooCaiTBN79+DuFv9E2yYuqZBKjYxwxrRRzs+uBmF3g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 3, DateTimeKind.Local).AddTicks(1113), "ea5c8956-413e-4b59-8618-cfaeb7ab9762", "AQAAAAEAACcQAAAAEER38xjFATysBFQzX7I/ZyxW1e54h6Dk5MviVpTFEgyquHg0956YDdeogQDKSqLj6g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 13, DateTimeKind.Local).AddTicks(1862), "588d3ebd-b261-40e9-88ea-6058257a3ee5", "AQAAAAEAACcQAAAAEIpA+vHa6j1G8nfTL9lEAaH9mjBtMbW2kVKc7U3uXUYqnK7nSCc4SB/LtPGcG3D9qQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 26, DateTimeKind.Local).AddTicks(8577), "82a1595b-7a5a-4eef-b87c-7c9a564f11a5", "AQAAAAEAACcQAAAAEHkH/gDvaK0UH/g1MZSAYvh1IgcuCC8x57DxLFa9i7FFK9f6WMseinajAl4/xfLfsQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 37, DateTimeKind.Local).AddTicks(4523), "e81e246e-7ac2-42c9-ac16-32483711805e", "AQAAAAEAACcQAAAAEO7dja27zvoye+VA6/QoNVDS6xK+8UDvZOCMT4GgrOpM9lQ3TZboD9a22enRk1gIEw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 50, DateTimeKind.Local).AddTicks(9630), "62885959-c606-442b-8371-71e7e968473d", "AQAAAAEAACcQAAAAEPpny70JPnT5cNjb7tKeW0UdJds/Z+iziCBUqVPGobH0dmy3eXMeuakn/JGkixXFmQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 61, DateTimeKind.Local).AddTicks(3980), "0ccaff57-efaf-4652-8578-f27f90c491a3", "AQAAAAEAACcQAAAAEAM25RWQigmjcApcZGBLG0/GNX8PQqesixTmrfHi6YxA7p3qymkUwya4DZWtEH2cTA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 73, DateTimeKind.Local).AddTicks(1007), "1e7e5679-b3f2-4dca-a86b-cc202fe3e036", "AQAAAAEAACcQAAAAEJeamX57H9XqWQpkCwIo1XWh61CPco+TVo8EdvWVV6DiH++bYc/mXa0/uhgOXa1svg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 82, DateTimeKind.Local).AddTicks(372), "95c9d14b-6d72-4d32-b887-44f1978a7429", "AQAAAAEAACcQAAAAEKMJayDKwFsGPUU3vGkr2g0lmaP83OnlbeSBQrVZr8dbNbEc6mf4C3IEsHTMlOvBNg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 93, DateTimeKind.Local).AddTicks(8523), "d5fa7ecd-5ea0-46db-aced-266451f65682", "AQAAAAEAACcQAAAAEFJDq/8UN0UCUV94D0QbEOCVfd/9UFEhr+YfGTLGIqJh5BpOXWhQOV4/Ix7Dbed7YQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 103, DateTimeKind.Local).AddTicks(9408), "b1129147-0316-42d3-b66c-41474d7f85e1", "AQAAAAEAACcQAAAAENoZSbxL+oCNKABAp+a1ZfOpJ74ZXzh/lomWh9YGGnXPDsku6uhcbV/qm9Oh8CBy+w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 117, DateTimeKind.Local).AddTicks(2115), "954b4251-e11f-4e90-8a78-849a612c7e9b", "AQAAAAEAACcQAAAAEMah9C5a5APXQXO3z8FzG9qjukz4wE+y0Alun1ZGHXbfmShrHlTY0KcjgfRsyDuVqA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 130, DateTimeKind.Local).AddTicks(1370), "3fc37ed0-9db4-4e61-8e9a-ae8e29586785", "AQAAAAEAACcQAAAAEGMOYmcVRlAQJSjcB/uRVJRwxfThY0y3tZRGIi5Vhvl0nT2vKystmOG2Yl1fhjoKfQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 141, DateTimeKind.Local).AddTicks(6478), "b401d6c7-44bf-4c34-a777-143e3b00238f", "AQAAAAEAACcQAAAAEPDBLIQOxHzQ2z1/rqppi1YfCyKCTzLvgsUxgJj9El3K10NIjxZuQPlhYnLpzv654Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 153, DateTimeKind.Local).AddTicks(4100), "ef11980a-2111-4a52-bf41-c038b950965b", "AQAAAAEAACcQAAAAECcSoXBWZfqEZPQExEUVhILth7OIi1P/xKCJtt77DIQ01G89TwCz6v4szXt4t8Pu7w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 165, DateTimeKind.Local).AddTicks(2805), "378c988f-2b84-4aa5-8ef1-3cf21d5e30b6", "AQAAAAEAACcQAAAAEKhWmJ3g91pdVLpsL7pk0mvPTiUA5newDKJvIBI2Wo/a5n8KHXoIoMJZNoM0S0lxZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 178, DateTimeKind.Local).AddTicks(4780), "d2e853b4-9c00-47cc-89ad-9dc056508c35", "AQAAAAEAACcQAAAAEItna3wTcox++VnJciv1/gc1vK70ei4+EDuEX3NjoILMo6/5OhircDxKdtybVBoseA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 191, DateTimeKind.Local).AddTicks(6059), "ca992b1a-f309-4fe2-b942-a1c3917118ef", "AQAAAAEAACcQAAAAENpEHKliFTdda4d6wPz4bL2K2N9DcbkGBedEsdsCJiRkYpBlhCxFBH0KB4AVOZPAuQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 204, DateTimeKind.Local).AddTicks(5319), "3df13ec2-f7c2-4bab-b0d5-57bbb0ef3e84", "AQAAAAEAACcQAAAAEH4f3wWIR+C8jcwRMlD3SdNaQYRY1e8UyLf/JnPbJMz/P+JpMOzDnRHS+86naV/Qag==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 217, DateTimeKind.Local).AddTicks(5616), "bfa34620-b747-45ab-8c43-33445d68b938", "AQAAAAEAACcQAAAAECv+cYpgwf2GMyiMsIJj3Ygq4YRrkLR5ZBBaZPXbLq5l/K2wUuDvW3dcvN5pvyEhdw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 231, DateTimeKind.Local).AddTicks(513), "fcfba331-6da3-48ec-903d-3462f889924a", "AQAAAAEAACcQAAAAEIY6arTfuTGrv7pBZ3c0293ZKv/6+jnEcOgYgECmx5zHK8AET8V8bOsShq70Mv/ENw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 293, DateTimeKind.Local).AddTicks(2046), "3e2419ac-46db-4c62-b9fe-432924a42b4d", "AQAAAAEAACcQAAAAEKhlXYoe2Jg+rrVsbiMjAKxxqkgg8MJpFZAJt9Xd7got64EPyAD9eHulL5NsP7QW6w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 282, DateTimeKind.Local).AddTicks(4403), "fb439493-99b6-42fc-ac39-90dd6fde932b", "AQAAAAEAACcQAAAAEPUAXUwaS6k6YLEhczJs4gOBaSMNrh88Vh8+6VwncNbeXBZvNTp6q1/vwBSnSdxXgg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 301, DateTimeKind.Local).AddTicks(4449), "c66f4684-1be4-4eac-96e5-619303338977", "AQAAAAEAACcQAAAAEMufIeK8obmxXLIKYwPqVLVTAXtSQ2P2LQxUND/umiu8nlDK2NV/yNQVtUoUG7edkg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 330, DateTimeKind.Local).AddTicks(8357), "6e45f3fe-7181-4fba-b527-279adcbb5023", "AQAAAAEAACcQAAAAEGesioZG4RxzWn8VB1sAhTjzpTX+ENtVqnTyX2FuGj4bn6WJxit9Q14ebDaGpEO1ew==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 256, DateTimeKind.Local).AddTicks(64), "bbe45d36-1a38-472a-9346-69e0fb770f08", "AQAAAAEAACcQAAAAEOjF7Oxj3pAjCOY/Bve5kTg0w0At2eUjMBWyvTbYgnaPLBDsfxRPWUt35pvY5UnriQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 269, DateTimeKind.Local).AddTicks(5395), "8e757f67-e470-4b7f-a9a7-27d85ffb5115", "AQAAAAEAACcQAAAAENZ+/jLwWTbAE97MRjeUAD4wlXYFGHdRHEd+Jp0k+BF/2sZou9E3ttYaeRzxN9LVyg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 310, DateTimeKind.Local).AddTicks(1685), "be12abda-0dda-4839-93fe-deb66a8cc92d", "AQAAAAEAACcQAAAAEBvsVEU8WZjGksmkM7WdzoFvPpusQhi+cCT3vGZ3bBIrAzImd9aRRbNZMqJs/rr7Lg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 42, 27, 242, DateTimeKind.Local).AddTicks(7514), "5e6279b3-d6a7-4eca-b086-5e40d70ce8f1", "AQAAAAEAACcQAAAAEOAIQ3+AHtZGoasDTHXejYmb/1V0mtb1KbYlCrONJIVo5YWDiPIwgp8LZ5oc9F24tQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "productStatus",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 1, 18, 27, 50, 243, DateTimeKind.Local).AddTicks(7689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 1, 18, 42, 26, 947, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
