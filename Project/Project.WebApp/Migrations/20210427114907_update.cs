using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Colors_ColorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropIndex(
                name: "IX_Products_ColorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SizeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 18, 49, 5, 132, DateTimeKind.Local).AddTicks(6032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 17, 53, 53, 826, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "IsShowOnHome", "Name", "ParentId", "SortOrder", "Status" },
                values: new object[] { 3, "Sản phẩm áo thời trang nam", false, "Áo nam", null, 3, 1 });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "DateCreated", "Details" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 181, DateTimeKind.Local).AddTicks(5184), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "DateCreated", "Details" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 181, DateTimeKind.Local).AddTicks(5181), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Details" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 180, DateTimeKind.Local).AddTicks(8845), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Details" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 49, 5, 181, DateTimeKind.Local).AddTicks(5167), null });

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

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 3, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 17, 53, 53, 826, DateTimeKind.Local).AddTicks(6781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 27, 18, 49, 5, 132, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    normalizeColor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    normalizeSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "color", "normalizeColor" },
                values: new object[,]
                {
                    { 1, "Trắng", null },
                    { 2, "Đen", null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "381634ac-2636-42e3-8a7d-4a0aa5911de8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "1dbaf56a-dc38-480e-8cbe-89733dd8f30c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "d1d2e55c-50b5-42d0-9463-d132bddded50");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "eea3da27-ceed-4d8e-95cb-4875d0b0d05b");

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "normalizeSize", "size" },
                values: new object[,]
                {
                    { 2, null, "S" },
                    { 4, null, "M" },
                    { 3, null, "L" },
                    { 1, null, "XS" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 213, DateTimeKind.Local).AddTicks(9504), "0a0403d1-d79f-4355-9f9d-3299a4ba82d8", "AQAAAAEAACcQAAAAEI3qelUebSbZ5rB7U0m0Kr8LgfB63YFx4Z0harocadTo0TMqrICaZDIAsD64+G+94Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 53, 877, DateTimeKind.Local).AddTicks(1645), "5e41430e-f9b3-462a-b078-45642d40fe79", "AQAAAAEAACcQAAAAEB42aqbLRAs5xsTNtvc4JXkwfmZLq9qhKHK+UbZ9YSmSUZ46b2pt0vJUXuABOl4uXQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 53, 888, DateTimeKind.Local).AddTicks(9088), "f3c53f56-1837-4886-866e-00fd866c4a9f", "AQAAAAEAACcQAAAAEKfZmjS/1dSGMeKnh+XJA9BUGRTiZhm5du1LWhvBuNiPaZIpv1SVLHUCErnINJAfWw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 53, 900, DateTimeKind.Local).AddTicks(4168), "24904b68-f559-4afd-8941-bdaf4c8933aa", "AQAAAAEAACcQAAAAEOOgAAhU5XJFo2Om0lJsel0fjnQQ0UvTaR4HBisvxkHj7I/QsMn74yFeZ+EcHwF66g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 53, 913, DateTimeKind.Local).AddTicks(9110), "ba6bd6ad-796b-414e-8d9f-c32aed8bb5ce", "AQAAAAEAACcQAAAAEOCygDixtWnzYNI20AuoKlCaHCccUOiC94UL2Pldywdr8M90P2ZqSFoIKojl7slJtQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 53, 924, DateTimeKind.Local).AddTicks(5427), "0b05db26-452b-4ea7-b005-61b0ab522af5", "AQAAAAEAACcQAAAAENWk9LMiyvcAyoCCo/AqiVzYBOmyLH83UX9xwjQ7T/ihhsU5wQ3NqoIe4dlD7Wkixg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 53, 934, DateTimeKind.Local).AddTicks(8154), "12833121-8e26-4774-ab25-68d5319243d3", "AQAAAAEAACcQAAAAEK1Rw3Nep6NaOOUcDYcLl2W76K2zt6xRBP2vXTCEEfn8MQfPBFWZrHVc8sIZbpZnXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 53, 943, DateTimeKind.Local).AddTicks(7844), "3291a731-ad8a-4c2d-b085-ffce883d838e", "AQAAAAEAACcQAAAAEKUE8JeU2EU38i9eBMGVjZ37zB9DhrBbmRjjWjVtG6W2qY12BO9fDyAWHd21peCFxA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 53, 952, DateTimeKind.Local).AddTicks(7483), "9a40f282-4219-4bc4-af2e-27a3150006f0", "AQAAAAEAACcQAAAAEBVZRtLRHoWq6BlGQQo7g7HtuuGuPL3Cjp7isiTYgpaa4s5OR95vwA51VXGUJWsAxA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 53, 965, DateTimeKind.Local).AddTicks(7783), "dbed9f71-d984-402e-8af2-88683cd66d66", "AQAAAAEAACcQAAAAEL/Rgv89vjN246/WVdvqmdoBRJEW0JSIKTdobdQwYkt2BXoxmMCKeim6lxmHo7bFIQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 53, 979, DateTimeKind.Local).AddTicks(6424), "b049b5b8-53c9-4bb4-851c-3170669b1455", "AQAAAAEAACcQAAAAEFXPOiixJ7XBXPblD8uBX25mhbJ6RzhlkvzDAKFhvylVYmU8Vcr4mxbq3eUKAlTeGg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 53, 988, DateTimeKind.Local).AddTicks(3218), "602c7e3e-6ff2-4cc2-abdd-a93f4bfff0bc", "AQAAAAEAACcQAAAAEMsTAWLTIQIail38dsjOWKjbvglV5qsV3fj9PnrCDO0h7tOh9UwUteamPRWdoVMVkg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 53, 999, DateTimeKind.Local).AddTicks(775), "114dc0e9-51bb-4bde-8356-17bfa3f49547", "AQAAAAEAACcQAAAAEGjfB0xAwAvIGX1j7HsVqyApBYiDNNRwr8XYf9emX4sDR3GsL6PyBSDVagCFX8+fKA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 12, DateTimeKind.Local).AddTicks(5304), "86a9c255-92fb-4b7e-9fac-9b4e4ed7b5c3", "AQAAAAEAACcQAAAAEH9XcrbH6unGka6eTSKFUENZblCspNZhzdkgQPeRILRUCmNtdMbGIJUpa+XXI7XGjQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 26, DateTimeKind.Local).AddTicks(6883), "db9e2bfc-c2c1-4a5e-b668-2e67c16b6c47", "AQAAAAEAACcQAAAAEC70MOsqS7Gj5kzWBdPrdw10b54UApTMq0ZSJyM/6X4VgAqs0WUODq1wecOcPQ4oaQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 40, DateTimeKind.Local).AddTicks(6937), "e82e86da-cb39-45ea-85a0-a720ba7c3b4c", "AQAAAAEAACcQAAAAENJ22PEybZACrIsCvd+XY0YNxrtrcbBU5efBJZm+4bf7DyiT7KOs0HAKO/wm1JNDyg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 54, DateTimeKind.Local).AddTicks(2192), "f57120d2-83eb-4877-a216-702663b216f2", "AQAAAAEAACcQAAAAEFsfAoGcD3twel+X91/1dmkV546nDvjDqOtQFe8EjQFCxvL0jAy7RTNn/Im6S88XEQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 65, DateTimeKind.Local).AddTicks(8291), "52fa2236-ac7e-42fb-b73b-b61616d22d6b", "AQAAAAEAACcQAAAAEPWITJphTN+oE7D6MMvTNPJA9gLAE3Z+JCs+q3/Da5ls/nWT/ooz3JTaKL2lcS8XlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 80, DateTimeKind.Local).AddTicks(3128), "d1ef46e1-7b3f-4d73-b361-549460b828e9", "AQAAAAEAACcQAAAAEJwwfIxKyefzbWODk+QEREiGRDqMeBo5Ws3BUOgqncHFdoV/HNtoqXnnlKFgq8RprQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 100, DateTimeKind.Local).AddTicks(5800), "9486c6f6-4364-466b-a704-5403c82f0eff", "AQAAAAEAACcQAAAAEGGGva6r6dJkbP37EJ6CgFviZNXnU0cXgrr7VhY+vuN+cIBWcBCuteTFsELecKXo7Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 117, DateTimeKind.Local).AddTicks(5445), "261f0a40-f7c8-4e6c-802e-9158c9798203", "AQAAAAEAACcQAAAAELNGkT3a2jqptwnkWEtDU9ylMI/zd/u4bopLpKz2h0D+W/bJu4vW4PqVuOEqHYT6Yg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 179, DateTimeKind.Local).AddTicks(673), "3f660723-a903-430a-a39b-2638fab7c6f7", "AQAAAAEAACcQAAAAEC/a7oxM8Zevveh+HQBoX5mU6DRWWlnYsCcv16u986LfaKwkcNXbfYNl0K0FgBuWlA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 167, DateTimeKind.Local).AddTicks(1917), "e0637154-6244-44fa-a61d-04ee24281d65", "AQAAAAEAACcQAAAAEI7i5LCCLl0FpcmDB5urDv7K/1aUm+J0T27SidovyAUCbgoo09ZPxkjOlxKzuGOftA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 191, DateTimeKind.Local).AddTicks(1591), "11898508-9f2b-4a72-92eb-8e7e14cb2183", "AQAAAAEAACcQAAAAECfjk0qU5DNDRDGraFyR7VovAsMZ9xaf56xq0IXrPqvKYpp+ChHEAYqBBA411VEJZQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 228, DateTimeKind.Local).AddTicks(1064), "977ae3fb-f066-4c76-8ecf-c23b90f45b3d", "AQAAAAEAACcQAAAAEFIt03y6jpXpgE+wVdO5YR1ILNY6GKioTc4Hujyn4dnGGcTEktaIoM6NpheXH0Jclg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 140, DateTimeKind.Local).AddTicks(6961), "1c618345-abc4-41fd-8cb3-0393963a49d3", "AQAAAAEAACcQAAAAEBpm6v/NenmQ17jxETGUWy3kgNvWqTtpyazR3A4+jRzWnoA3g9vT3i3JWu93i1oUmA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 152, DateTimeKind.Local).AddTicks(9123), "8e32e150-2032-416c-afc9-742f81be7e73", "AQAAAAEAACcQAAAAEBjnh81x7mALz0jEuMOcpdMZWs0YLpEM8L3eYotgpBrh6oTbJ5NJS3/bwIpuTQ3eSw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 200, DateTimeKind.Local).AddTicks(4981), "31a598f4-f357-4441-8186-0d224fc99828", "AQAAAAEAACcQAAAAEAbpVZCAKqQGIeDLqj5HFUFdQFr4MyABgjjEh1L56l8LXNGDTglMjwsJr+SURX5meA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 17, 53, 54, 129, DateTimeKind.Local).AddTicks(3317), "941ef112-b184-4b50-8e23-d0a1f2e208a8", "AQAAAAEAACcQAAAAECs6hOdn5Y9KI6n3jmIaGbLfcnsl7CANLsYXfUxOrCpsn1cEHH78f+OaCbObrd1GAg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "ColorId", "DateCreated", "Details", "SizeId" },
                values: new object[] { 1, new DateTime(2021, 4, 23, 17, 53, 53, 861, DateTimeKind.Local).AddTicks(4736), "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "ColorId", "DateCreated", "Details", "SizeId" },
                values: new object[] { 1, new DateTime(2021, 4, 23, 17, 53, 53, 861, DateTimeKind.Local).AddTicks(4733), "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ColorId", "DateCreated", "Details", "SizeId" },
                values: new object[] { 1, new DateTime(2021, 4, 23, 17, 53, 53, 861, DateTimeKind.Local).AddTicks(144), "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ColorId", "DateCreated", "Details", "SizeId" },
                values: new object[] { 1, new DateTime(2021, 4, 23, 17, 53, 53, 861, DateTimeKind.Local).AddTicks(4723), "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorId",
                table: "Products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Colors_ColorId",
                table: "Products",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
