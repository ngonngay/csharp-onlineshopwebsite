using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class ReconfigManyToManyRelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductInCategories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 5, 15, 6, 37, 174, DateTimeKind.Local).AddTicks(9909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 1, 18, 42, 26, 947, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoriesId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, -2 },
                    { 1, -1 },
                    { 2, -1 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 1, 18, 42, 26, 947, DateTimeKind.Local).AddTicks(9),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 5, 15, 6, 37, 174, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.CreateTable(
                name: "ProductInCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCategories", x => new { x.CategoryId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 2, 2 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCategories_ProductId",
                table: "ProductInCategories",
                column: "ProductId");
        }
    }
}
