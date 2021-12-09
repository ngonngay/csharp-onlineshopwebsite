using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class FewUpDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 16, 24, 31, 94, DateTimeKind.Local).AddTicks(1566));

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
                name: "Reviews",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    review = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    normalizeSize = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                value: "16ed19ca-7a46-4013-be4e-43eadf4825b9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "e7212342-4197-4781-adfa-ad95cc445d1f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "b4259822-f170-4949-8895-d04df8632f08");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "e76bce83-104c-4123-b26d-00782b465bb8");

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
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 490, DateTimeKind.Local).AddTicks(4694), "8116f2c3-8095-4c27-bd66-c8abd10b16b5", "AQAAAAEAACcQAAAAEO6xGzAgt8zq+WiBH0z7D8MR1GU2wYpsqZdQjnjv2P5frmXVth/0NX2XhSdR9+UqHg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 153, DateTimeKind.Local).AddTicks(5908), "b85a693d-0617-44ed-9149-286c18fc1eef", "AQAAAAEAACcQAAAAEE3sxa8mHV+OIYDQn7uA78v8ThkqUXk0Rr4aJpqvQdL1j7gcQBwATjTnB5XXvnObFA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 170, DateTimeKind.Local).AddTicks(9377), "666fbf7c-383b-400f-a417-12d02d587df4", "AQAAAAEAACcQAAAAEP68yM9FNvA1EEl26hNYeQ639IlRvOJkwNCpT89SE+im0fAeG9hRbWhDwzKpwkDUmw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 185, DateTimeKind.Local).AddTicks(6086), "9521377b-7999-4623-803b-c3aec10257ae", "AQAAAAEAACcQAAAAEGTB9bLz12hvB/oFgMj+F9Jh0lGmmbkZuUqgjvAgWdkqoC6cVMub64WBFoYr/lmq5A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 199, DateTimeKind.Local).AddTicks(7572), "4294d313-5df9-4eea-80f3-4e0b90f49300", "AQAAAAEAACcQAAAAED1mtjdwkSkvP3+o0yBY+Mi+yjSebw8fVOxMTjisA/GYoN68AFoMtRicrV7HARmlbA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 211, DateTimeKind.Local).AddTicks(9848), "45e382f5-2fe9-45cc-bab9-0784629bbe43", "AQAAAAEAACcQAAAAEPthvYHDO+ewq9aFaOm5jTDglfA+tRbaDgIy55yJK9EciZtzE4qWh2Ak+fICNtW7vQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 225, DateTimeKind.Local).AddTicks(245), "c1b3a019-39f2-4c06-a555-4c1e5d41d45f", "AQAAAAEAACcQAAAAEGxYOqUR5YaDSQnL8wcgCJ7CBbhA9s6Z0KQijPYpYEA9b2OHn+OiBuL0s61wkf95fw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 235, DateTimeKind.Local).AddTicks(9801), "68a42d6b-eaf6-499f-8b8e-4a79c94b5eac", "AQAAAAEAACcQAAAAELmI4Opf9tIkhg79Rn+KChqdx3saapuj9JHaqd9+nGCMGFTZ+XEuuauiy0gE5O33ug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 249, DateTimeKind.Local).AddTicks(3460), "611c5a24-b9de-42ce-b7e3-991baae61d05", "AQAAAAEAACcQAAAAEDyeZTNKo+c0Sdj2CSt7Y4TnbR6ND4nX9ylpTXO/ynlZ92Gof0Ku8bfBj4fYxfQWXQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 262, DateTimeKind.Local).AddTicks(3874), "8d81b8de-0308-4d22-8792-b6ad797cb706", "AQAAAAEAACcQAAAAEORecXFtbm/1txhprDCORpxc2V4O06Vx3jmIpYLnpmhaEsKw/ZIbMpydjJi93onl9g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 273, DateTimeKind.Local).AddTicks(5543), "402f969a-3a41-4480-ace3-2c30cf0d186e", "AQAAAAEAACcQAAAAEMvSt89svdispFRAAYfonEI7e8pqFXtA1NAhVhNbBr6/rExf+gCHbHdFD5GTH0Ux2w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 285, DateTimeKind.Local).AddTicks(6126), "a6cc4a4c-3df9-4a8c-a8c2-1d9e8469efe6", "AQAAAAEAACcQAAAAELZkgTTmwVjsLfnRenBLBaqUZgOSGD3luu3pyTOx65dzhos7L1+d9Xlv9BEamFxCcw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 297, DateTimeKind.Local).AddTicks(1592), "c92f1a7a-f827-4f89-93a4-3d6cab9b5dae", "AQAAAAEAACcQAAAAEIC2JfjV1hdrtz/gmL057z3OgN/kUj16K7VcmeoSdLzoFrG1jwXAIndSGdp9zUs68Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 309, DateTimeKind.Local).AddTicks(5560), "1cb57fb7-4df8-4b72-a4bf-8f3c9a13e53d", "AQAAAAEAACcQAAAAEJdmFLWqCBovx0TAROJ31j95SCCj1POe9JeeG65DxgRKT1IAaCAdgGpYyuP9vZEdgQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 324, DateTimeKind.Local).AddTicks(2933), "a24cbed2-d44a-4234-a04b-9c8346c6b3ae", "AQAAAAEAACcQAAAAEGh8L9FDr6ex/VLaAYImTclrvVqZjONbjwHYLL0E3CsAShkzQ0oBBOHQbhGdeY02Mg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 336, DateTimeKind.Local).AddTicks(8635), "79418810-320c-491d-bb76-e654f12e0095", "AQAAAAEAACcQAAAAEAm+it0KHteN5W1ImT5J5X6WUCKbB1zSTeCmASxTb4XNOBDGKrBLbF2AMVhDxWuq7g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 348, DateTimeKind.Local).AddTicks(2434), "4699ae3f-d74e-431e-91f2-40f4f4966d99", "AQAAAAEAACcQAAAAEONXTc/+RC4l4RQeiK7AG2MeVWjBuXBmRcZnFQO5MbiDV2/VVwlZ+TvuXVh6ovqQ3A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 359, DateTimeKind.Local).AddTicks(7831), "1e5b259f-da59-4c75-b23b-4f845b790359", "AQAAAAEAACcQAAAAEJaiIDCBXgxnKX1UxdgCsnqtxgERGNJRpZRY/GlweYjDusAPfw6JmUoH7cK5GgHmAQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 372, DateTimeKind.Local).AddTicks(5070), "8735c84b-b234-4272-8be2-630e60a0fb49", "AQAAAAEAACcQAAAAEPMdrz1fjPBXeQP20AwuseLWH+sG8LVVgXaSWDwbCj02qBr1VAzKmdsSZzc7m8oC4w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 385, DateTimeKind.Local).AddTicks(2565), "28163f0e-e637-4c99-8088-253d8bc8d40e", "AQAAAAEAACcQAAAAEN2LQGqjBxstqK4GPc47KZSo2hCNakljTloxzYjpVHYMgjlA5/NRFbNOOvlmLvSl+A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 394, DateTimeKind.Local).AddTicks(815), "d2c36911-623f-4dc9-af97-5a133cef3ba6", "AQAAAAEAACcQAAAAEF+5OeOzQ3xj1VKg4PUjUfIYwLQdw62TH/cMNqAh9Pd/5uCL4QTyQZKbQ4acmB5ibg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 454, DateTimeKind.Local).AddTicks(3720), "03987b53-ca3b-46dd-b2e2-476868f036eb", "AQAAAAEAACcQAAAAELCc58WYwybzYvceybxKbttWCI8l4Hrry0F7dvzrV80+uktaZay3i47FBCivVYeckA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 443, DateTimeKind.Local).AddTicks(4582), "b88b493a-34a7-437e-b5f2-a82d2f43cf97", "AQAAAAEAACcQAAAAEOgw1cURN8tbRWFSC6QODCvs3w9+tPBUTQdLgDtolEYCGjruXk/xGiztysxR6RaRGg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 467, DateTimeKind.Local).AddTicks(282), "67b32df4-5bb9-450c-a03c-d35eec570c61", "AQAAAAEAACcQAAAAEGej7oFH2Tb5kmViswwhCg8e9/4x+3Afzjb7yYD66jlkmQ+X1iMjqOAv6K01vBv/PQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 500, DateTimeKind.Local).AddTicks(4618), "1b2f791a-590b-4d82-bbec-7b9cc708333f", "AQAAAAEAACcQAAAAEJT4zQ795+C29lT3/lH7K7EYMWFVywfK05LYfZPjdgWVAVaPoJ5zkg9oOGHY9M969g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 416, DateTimeKind.Local).AddTicks(1604), "885610ec-030a-4406-916c-49f4744fc868", "AQAAAAEAACcQAAAAEHqX+ORJeBNNuJIErP9D1gLyv7wZH/qu6VYrUCW26nMST/cLsUfJmoWZh0ZgrQYYcw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 430, DateTimeKind.Local).AddTicks(922), "8b0fb3d9-5c96-4781-b25c-851e6305af24", "AQAAAAEAACcQAAAAEG4pYopyUQJbgKqXCYANWcPzOjAYQXh0s0DeM1kuVzDXeW6Yf3OnIuZEWf9fxoCLEg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 477, DateTimeKind.Local).AddTicks(5079), "b7a455b6-90f2-43d6-9a65-4b9e936f123f", "AQAAAAEAACcQAAAAEJVy8Hleegank3LBxBhUpNgoV5DWEoXhkh/rNpjRYEKH3CngYRxncqF3w4IxZfd3Uw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 24, 31, 403, DateTimeKind.Local).AddTicks(7540), "bb016119-c7b0-4097-a610-ea28b8e7c819", "AQAAAAEAACcQAAAAECeBFrDbwqZyjd574VdwgcBqPSdoArekLNtlakL4LguHzjc72KUDnW5+i47kO25aGA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ColorId", "DateCreated", "Description", "Details", "Name", "SizeId" },
                values: new object[] { 1, new DateTime(2021, 4, 23, 16, 24, 31, 133, DateTimeKind.Local).AddTicks(7802), "99% Cotton, 1% Elastane . Bền Vững Khi Giặt Máy . Skinny Ôm Sát Và Tôn Lên Những Đường Nét Quyến Rũ Của Bạn", "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS", "SKINNY", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ColorId", "DateCreated", "Description", "Details", "Name", "SizeId" },
                values: new object[] { 1, new DateTime(2021, 4, 23, 16, 24, 31, 134, DateTimeKind.Local).AddTicks(5310), "100% Cotton . Sản Phẩm Mang Đậm Phong Cách Cá Tính Và Không Kém Phần Quyến Rũ. Orginal Được Thiết Kế Để Có Thể Ôm Sát Vòng Ba Và Tôn Lên Làn Da Của Bạn", "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS", "ORGINAL SHORT", 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ColorId", "DateCreated", "Description", "Details", "IsFeatured", "Name", "Price", "SizeId" },
                values: new object[,]
                {
                    { -1, 1, new DateTime(2021, 4, 23, 16, 24, 31, 134, DateTimeKind.Local).AddTicks(5332), "100% Cotton . TOPS Với Thiết Kế Cạp Cao Sẽ Mang Lại Cho Bạn Cảm Giác Tự tin , Thích Hợp Để Phối Với Những Dạng Áo ONTOP cá tính", "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS", null, "TOPS", 200000m, 1 },
                    { -2, 1, new DateTime(2021, 4, 23, 16, 24, 31, 134, DateTimeKind.Local).AddTicks(5336), "Vâng , Đúng Như Cái Tên Của Nó, BoyFriend Sẽ Là Người Bạn Đồng Hành Của Bạn Trong Mọi Thời Điểm Của Cuộc Sống, BOYFRIEND Được Thiết Kết Để Tạo Cho Bạn Cảm Giác Thoải Mái, Sang Trọng Và An Toàn", "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS", null, "BOYFRIEND", 200000m, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorId",
                table: "Products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropIndex(
                name: "IX_Products_ColorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SizeId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DropColumn(
                name: "LastSignIn",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Description", "Details", "Name" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 415, DateTimeKind.Local).AddTicks(9628), "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Description", "Details", "Name" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 417, DateTimeKind.Local).AddTicks(3917), "Áo sơ mi nữ trắng Việt Tiến", "Áo sơ mi nữ trắng Việt Tiến", "Áo sơ mi nữ trắng Việt Tiến" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "Description", "Details", "IsFeatured", "Name", "Price" },
                values: new object[] { 6, new DateTime(2021, 4, 22, 10, 6, 26, 417, DateTimeKind.Local).AddTicks(3934), "Áo sơ mi nữ trắng Việt Tiến", "Áo sơ mi nữ trắng Việt Tiến", null, "Áo sơ mi nữ trắng Việt Tiến", 200000m });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "fee95fb6-85bd-45e0-9b52-ecc0585cd74e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "aa420699-4c75-4413-8cb0-d6d8dff73ab0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "855d7d21-32ce-4a6e-90b0-b258bfc63fac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "19f9f28f-4c0d-418b-8fe0-1a2df2735d0e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 658, DateTimeKind.Local).AddTicks(6675), "48aa566d-edad-459e-86a8-144d9fb2adcb", "AQAAAAEAACcQAAAAEPX4muj/cfcahaJD1CJuSsvr0R0wgUpuZnTuEYHjDbU5A2E2WyKBjw/TIy0mKS9eHA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 429, DateTimeKind.Local).AddTicks(2902), "6b290b2d-065a-412d-9d6a-bd525649958b", "AQAAAAEAACcQAAAAEOi8m1pmaJdJFz0t7ErerqI76UJVgi+jb+8pD0quFs7lQUc3W8XFj9zNlAYwpgZ5zg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 438, DateTimeKind.Local).AddTicks(7297), "3bf0fc88-0b21-47ef-bfda-89e9a2f501c1", "AQAAAAEAACcQAAAAEEwtkuJC0Mp+BPTMY2SDAYUsMb5hswh0FlcIUqX9YAiMXmRpsE2GNjvzTsDg0oGbxA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 447, DateTimeKind.Local).AddTicks(689), "c1579171-678e-473e-86eb-43d8288e9089", "AQAAAAEAACcQAAAAEMylsi9+jMpUOOuH7WN/DHVonUdeKnlhH47VpWqqN2EArggZL3rvodUw8DkxsK8S/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 454, DateTimeKind.Local).AddTicks(9830), "ef2511fc-de17-42f9-9e78-06472bb3967b", "AQAAAAEAACcQAAAAEAypkgw5qfyiLQbpOW1a4IVeP4pgmkpjnq1d08AKU12x0eONZ1f4rTngqJQ7Qfc0YQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 463, DateTimeKind.Local).AddTicks(7756), "025867af-5b91-4be4-bb9e-fd5427c9bc94", "AQAAAAEAACcQAAAAEM/A/hIv2TARLl3Weeqkuiyd207V0rptWXKJWEyK+vLwj/ieEWAbeiY8PjSwdo5myA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 471, DateTimeKind.Local).AddTicks(8202), "0374ecf3-9bfc-419f-9c82-69316fb467be", "AQAAAAEAACcQAAAAEMzyUVbG96wq3sCR56coAuu+0KS8RC/YnTHXXaNrUe6pT+0A5iEplrYBQ3arI4bCIg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 480, DateTimeKind.Local).AddTicks(4617), "1b604a1d-6881-489c-bc00-f1ea8ea1dd69", "AQAAAAEAACcQAAAAEO7Fjgdl2FjXH6Fhjm3HqazDMsbUTHF1W3ikUtkPrtnqevByFHlLw4rZs/9L1Vs4dQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 488, DateTimeKind.Local).AddTicks(1516), "62c32711-6648-4c81-b784-1fd9c3ac2420", "AQAAAAEAACcQAAAAEJpnARaRxfTTpxj0DmGdgQb9L12HDUIUrf1s2fddHtu1kRm0NhttOKqZoVEMUdHyCA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 496, DateTimeKind.Local).AddTicks(9197), "2a550ec4-273d-4f97-ae03-ad841b11e591", "AQAAAAEAACcQAAAAEGAGlNvSuiFr5v17K963hMt3sJ1gVpt+AzNtjkSJyl0RXGfKRBhNolIdUddbxN7AAw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 504, DateTimeKind.Local).AddTicks(6471), "735ab7f4-a363-4e6d-94ec-25cab00ef9dd", "AQAAAAEAACcQAAAAEEyvd23SSVlC26JVeAqssgdqia+vFb87/l9ujAXBWU9gUkq1s0vP+PzyDDCFOVssSQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 513, DateTimeKind.Local).AddTicks(7178), "a9a41f3f-7880-4178-9183-db5e0acd6566", "AQAAAAEAACcQAAAAEFwO94SkIqNR4Ql27/ryVO4jN0+RRK1sJnGN+Ib17nRHsLZL7UNEJlG2qkuBVP9ppg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 521, DateTimeKind.Local).AddTicks(4569), "bb59d6ba-7a8e-443f-93a6-e6cc08a9f8b7", "AQAAAAEAACcQAAAAEMPhxKzpOeibIsmJd8mzgZPQxoVcnYRFT0++HZ0vSEPrE/rFg03arSAZScxFH9D6QA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 529, DateTimeKind.Local).AddTicks(5953), "a32511f0-2793-4e2f-ba72-9e482c7e5d92", "AQAAAAEAACcQAAAAEBD+BKLUul6nSEZVnEp6RAh2GpBN8WDg0gpmYmMKELOsUNFDu4iu2PsV5nv2D+5tpA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 537, DateTimeKind.Local).AddTicks(7039), "79aef824-eba6-4f02-a26d-bb3ea2ab3e39", "AQAAAAEAACcQAAAAENIaXlrnc+MUARddbqMezJI/1HQAICOhspxJpwjQwHhhVdZiN5466+EsJ5mooGku9w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 546, DateTimeKind.Local).AddTicks(7303), "9eef9be6-f0a9-4901-98c7-25f88846f78e", "AQAAAAEAACcQAAAAEFpOQg7mBICFqU/Ypn15VxWJYZj2lEs5YxfaALrocvlSMEpepkkv9E/ZiWE4CaQINw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 555, DateTimeKind.Local).AddTicks(4685), "3856574f-adc9-4ec4-a2cf-15d22831297d", "AQAAAAEAACcQAAAAEP7F7XhIU4mGMdkI38Id1KhXmHDylIUlLlBTXUXEMPhLvOxUagbYZ9KkU63NmIZLWA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 564, DateTimeKind.Local).AddTicks(1702), "66d19ddb-4eb5-440a-ad86-eb0f539f8bab", "AQAAAAEAACcQAAAAEHYiyVOz0FsH/sANrmlZNkGuiisCOyxQuG/dexez/f/PIsRSDGncwxV8rpNho9CNcQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 572, DateTimeKind.Local).AddTicks(3743), "1ba2dac8-fa2f-45fd-ba46-15bd99a3525c", "AQAAAAEAACcQAAAAEMqjb31Zd08lB5I3Y4RzOOJOZ1FKnKasEE+X5MwnZjHasu3c8LOYsena5f4i6uB5+A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 580, DateTimeKind.Local).AddTicks(3819), "548df25e-6d4c-46af-9761-c40fc1112343", "AQAAAAEAACcQAAAAEFIdLvc3p4ET3KOcWbbj378hyxQszwFVK5I8lgKZxiR8HSRBS+uX3kSTOXYAy815Kg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 588, DateTimeKind.Local).AddTicks(7130), "01e83e78-1270-47d6-a7bf-8c1be3736355", "AQAAAAEAACcQAAAAEBXu88r38mu+AH1pjisteEpsu0XkbXaDgb5sz3X6BJz49uZnG0Akr+WTA5YPzt9mGg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 632, DateTimeKind.Local).AddTicks(4398), "d4155755-4630-41f9-8fcd-52296c5902eb", "AQAAAAEAACcQAAAAEDgVn16cfH+akAeMIxGaj5/1dbWcM8OzYeY5EsNC68lAzuc8jgK9WBXnE52tZ4+DCw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 623, DateTimeKind.Local).AddTicks(5391), "a7865b46-7a8d-4548-84f2-d8d835d12d19", "AQAAAAEAACcQAAAAEID3mYZ+gtOsZuIXsRzZU62JQgMp0xjnNsA6nkQwYL0zPnQad/dlkjCjyaPTG9gMMQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 641, DateTimeKind.Local).AddTicks(5605), "8baae519-6b56-44cd-954f-8b410dd2d61f", "AQAAAAEAACcQAAAAEKZgqd3GdVoFjAlwP/oYrAd0eZv9RHI9GJvGNptMIBdAcvWqWCiCZdccqk785P4XTA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 667, DateTimeKind.Local).AddTicks(4297), "3b8c17df-e804-4177-aef5-f00df04a783c", "AQAAAAEAACcQAAAAEEZRMvY/Ijpjx9Q0d+m/qrpxcS8p8fjVAMxG2ywtvd7CTDXIvvDsdvvSvMuGuEUnUw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 607, DateTimeKind.Local).AddTicks(76), "f4d8dd1e-adc5-49b9-9107-1857efa7b225", "AQAAAAEAACcQAAAAEEIO3TAeX4tmG2ltajyVNR1cegHxftMf9EK3jEu2BQYOYK++RxSbco2yzV+9L54zFA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 615, DateTimeKind.Local).AddTicks(5296), "cf9c6101-cb44-4eac-82ce-45d6c851036c", "AQAAAAEAACcQAAAAELns8zoJclkWXK8lRRtotpHJ4cYBVSnHsM1laHrqsvMAgPMXkq/AXUu64SLVa0Ymsw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 650, DateTimeKind.Local).AddTicks(1923), "179e8de7-22c9-4e65-857d-9e4887f6a2e3", "AQAAAAEAACcQAAAAEPH9oqihFxPqo3kbWlriXLqShWbuV5QfcZbSTYEtxIfUzOe+dVh3lI+CHYjG5aH2lg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 597, DateTimeKind.Local).AddTicks(2873), "da4e465c-fef4-4568-ae67-8ff3cacd3db8", "AQAAAAEAACcQAAAAELid9pBTl14K7UycfBkyK8M/ToXIabp9W+2GZQsz6hvQYJ+G3i6CvNFQR9L/31J79g==" });
        }
    }
}
