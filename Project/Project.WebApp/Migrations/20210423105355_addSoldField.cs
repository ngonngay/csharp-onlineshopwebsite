using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class addSoldField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 17, 53, 53, 826, DateTimeKind.Local).AddTicks(6781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 16, 24, 31, 94, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.AddColumn<int>(
                name: "sold",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 23, 17, 53, 53, 861, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 23, 17, 53, 53, 861, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 23, 17, 53, 53, 861, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 23, 17, 53, 53, 861, DateTimeKind.Local).AddTicks(4723));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sold",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 16, 24, 31, 94, DateTimeKind.Local).AddTicks(1566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 17, 53, 53, 826, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 23, 16, 24, 31, 134, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 23, 16, 24, 31, 134, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 23, 16, 24, 31, 133, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 23, 16, 24, 31, 134, DateTimeKind.Local).AddTicks(5310));

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
        }
    }
}
