using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class aaaaaaaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 11, 15, 12, 41, 878, DateTimeKind.Local).AddTicks(4619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 9, 20, 56, 29, 303, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.AlterColumn<bool>(
                name: "IsFeatured",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 41, 925, DateTimeKind.Local).AddTicks(7476), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 41, 925, DateTimeKind.Local).AddTicks(7474), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 41, 925, DateTimeKind.Local).AddTicks(2730), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 41, 925, DateTimeKind.Local).AddTicks(7454), true });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "26bfb4e3-d69d-442b-affc-0a8d514fe97f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "67132fb9-6738-4946-84e7-0c33bd7506e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "d43c0ea4-74ff-4c74-a863-a1412f474268");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "3fcf5bea-fb4a-4276-9c4d-9a43c36727e0");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 296, DateTimeKind.Local).AddTicks(5128), "7bad66c3-c5d1-4c71-b573-c1c6aae8169d", "AQAAAAEAACcQAAAAEBlaBwiQ3AEOlvz5GCunfV7/R36t8XGbiBNY0/70tN4WOvcSdfioKIlQ+8VPMqe/eg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 41, 947, DateTimeKind.Local).AddTicks(7873), "7e74dc2c-9aac-4073-8c67-34776d4e6dfe", "AQAAAAEAACcQAAAAEMi5Tt9DBNk2AzlUslop/GRglbbS9zPmPCeDsXTM3cZdt99i3RuHtsXfNmFbsEk9mg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 41, 961, DateTimeKind.Local).AddTicks(2141), "dfbed6e2-2cbc-4f21-816d-e9498ad5e8cc", "AQAAAAEAACcQAAAAELU+dUgEZXniT4JIH3v3VOP4WtBcggrPyoe8VWAuTEpVgQYvjH6E9LQDH9GymvrefA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 41, 975, DateTimeKind.Local).AddTicks(643), "894c452d-f75d-4dbf-ab45-525713eb8418", "AQAAAAEAACcQAAAAEKaDDQZovPAQecAzn/s6xhoztXUw8GpWI0GrU5MCfK600cjX6iCSHWdDOsje3IAFGw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 41, 987, DateTimeKind.Local).AddTicks(582), "b9b66388-1d1e-4397-a326-1427452a7899", "AQAAAAEAACcQAAAAEJCugtL508cqnxC/PjrjISbzUYXzRh7+Mb/WESXDkr39zz8D3wZA1ojxwZuxS07Tgw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 41, 998, DateTimeKind.Local).AddTicks(2106), "2ca1672d-c8db-4da7-952b-2ecc635f6f22", "AQAAAAEAACcQAAAAEIFwfZicxMLXKPItK3NPTncwtgLr3iazwhyxDJbBJDZ9sQk+9DsTNTQEy518xfv6vQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 10, DateTimeKind.Local).AddTicks(2333), "318b0803-e5e6-495f-aa6a-b2c3983a528b", "AQAAAAEAACcQAAAAEMvwQW+ZJ/k5Iv/XLdXhhOuNY6rjg+qMsDpbUzqKnIzZN9m7HAw97EMgfuYxt071eQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 25, DateTimeKind.Local).AddTicks(1743), "e523cfda-1102-45ac-9ec6-ac808e8d416a", "AQAAAAEAACcQAAAAEBcFG1CEaCK2u8XfMGaUkUC8Mq9Pvc8CdDRvS9vcrpqEMGEL8jM/zog1ZJBRJpjRmg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 38, DateTimeKind.Local).AddTicks(6544), "712b7d8b-ddc6-4bef-801f-fe9e70d88d24", "AQAAAAEAACcQAAAAEFTCoqC2C1PxqXjG9NtBrxkIb+w+FONfvtkfKU67cOoHfc6NzWQVh+AewX40Ci64vg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 51, DateTimeKind.Local).AddTicks(3934), "593b9798-18df-4767-9a4a-b40c32732765", "AQAAAAEAACcQAAAAECoVmnFccmtWHsXRU/2PEMbQpjmwd5znFIjUdw/S3cWWYmzs7hO8zzSvD9uDMjh21w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 67, DateTimeKind.Local).AddTicks(9150), "d3afa44e-ac0b-47e9-a9aa-0d4063f0f911", "AQAAAAEAACcQAAAAEFpdqrtd4GAwQ6/YgtZJ0gc9oNzbPagHUI9LmrqKtb4mhvWR1g0GPec8j/3fxSBoSg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 82, DateTimeKind.Local).AddTicks(1643), "e780f2c0-f226-4fa5-bbd1-3284b7e995d3", "AQAAAAEAACcQAAAAEFChYst4u9zPYVzb/tDsF6cqt0LUGQXi9IqB37aR8kKq1fvt/WGcCZPZdp0Ndl0pUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 93, DateTimeKind.Local).AddTicks(6760), "bb0c9707-d405-4657-9baa-713eb3ba604b", "AQAAAAEAACcQAAAAEFChmoPy9Y9M+0N5NNDEhbfqJ4BVb9fmskSziCaJmzEgL3ls64WXOGPqh9JwNyLw8Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 107, DateTimeKind.Local).AddTicks(1019), "5c6bc3b7-db53-454f-a5e1-259e0981ee0b", "AQAAAAEAACcQAAAAEMJHtaBlCBkhm1y0aJn//Ao1c3QS782BLETKXmI+38D4RfTXFIYuPGv4gzXKb0VmAg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 116, DateTimeKind.Local).AddTicks(4505), "3d9105a7-7f11-4eca-8577-5b1396966bba", "AQAAAAEAACcQAAAAEMKvz0p13/1JFwi9dtoz9+omahFJrmI1lB8FWu0TA8Scmx7pH0JAtEOqEJ/zydvblA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 129, DateTimeKind.Local).AddTicks(766), "d11a475e-0729-4654-bd41-5a3fd8a7b9a7", "AQAAAAEAACcQAAAAELHjGP1d4+zh4QdssOpex5+P89Q8S3uQ9PMV2O9jmkWVv1mRKVV6ZNw6OullxeZItw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 142, DateTimeKind.Local).AddTicks(8649), "e30c191b-08d7-4e7b-89fd-d987c2451203", "AQAAAAEAACcQAAAAEN1G0kaGm9GAMWYP6FvDo3l3Xm40eKfVPUoXCbGiX33ZIEb/aTHg7mqPTslehlmY0g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 155, DateTimeKind.Local).AddTicks(5615), "a9fb6446-1976-4162-873e-b8282bc84742", "AQAAAAEAACcQAAAAECFhvsI8hclukcfIxCwx5QWkc+inHbKG9wJnslgpDY5Zz7SiU9507gY6+m5tNqUPaw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 168, DateTimeKind.Local).AddTicks(8209), "bbe9064f-7c32-48a8-8970-d9f318456ca8", "AQAAAAEAACcQAAAAEJg49U9y/POOc6Vlk2ZkUbUQHAwu17A/M8vr/YrvON0xoV3SuyqJvkhU1r9Hvch7zQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 182, DateTimeKind.Local).AddTicks(4489), "459f3405-0a94-4438-9677-56a9a73bc485", "AQAAAAEAACcQAAAAEJKvZOXWGG1RU3/Z6M9RjPvijSHG2WhW9L538+A2Dfwd/T0PAbrxzWkadRmx2B/ifA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 197, DateTimeKind.Local).AddTicks(5983), "95702bbe-a1df-433b-aa9f-af0b31fe1439", "AQAAAAEAACcQAAAAEGWJIBFzoIOcHcz7CBrRm4gcRD6l8uBFh5OihtzGN0m+7KrexJkX46BrnqkwYZthDw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 258, DateTimeKind.Local).AddTicks(607), "cf21053a-3dcc-4979-af84-770be77d0e40", "AQAAAAEAACcQAAAAENruCC8n7eHVhAiydKVeOVznFp68Qm746VQpJidC4oV7mHf+Vh/yk0BFOIwrrUpoIg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 245, DateTimeKind.Local).AddTicks(9213), "cc875d28-1ed6-4e67-b47b-67bea50cdf60", "AQAAAAEAACcQAAAAEHoRWy0kBG9xAxZ/7uUPH+3jOBh8pN7lf50jelGgBRl/PQv++LO5fK6KBDsanfoVpg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 271, DateTimeKind.Local).AddTicks(477), "b6ffdabc-d12d-49ba-9052-f514fb7500b8", "AQAAAAEAACcQAAAAED4pXyrQPQ9qjxSeEEgcRW1CRpO2EMVDME1bUrMiNNu23+yazSqgL8T5H2rh3HC7mw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 307, DateTimeKind.Local).AddTicks(394), "e5453c71-5f33-4a62-ab4a-b21bbfc1f090", "AQAAAAEAACcQAAAAEGfDOT3tVPfS9XNzADY29v+LPxaEwFFE7K2L07nBzSI64n3IkqdHCWGbF7Qf8KO9jg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 219, DateTimeKind.Local).AddTicks(3783), "b2abf4ca-cad8-4894-8e86-b5f86ebea63e", "AQAAAAEAACcQAAAAEI2702GikctGg/EYGNXYFBX3uM15las+6xgdfGh2GINb0YBgULTe7I22IrhaXe8P9g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 232, DateTimeKind.Local).AddTicks(6131), "9e9232fb-9e55-4cac-9641-11aa053c71f0", "AQAAAAEAACcQAAAAEAw7eL4l59fqtkWnPFoKwpTMZni4Uk6TUtV7oGvJ0NX0ZpQGo/jXVOlOauvor7i2sg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 285, DateTimeKind.Local).AddTicks(3246), "5182edd8-b83f-47af-b3bd-b2fb3bf75a20", "AQAAAAEAACcQAAAAEKsI/kXZpZeH/RffR5xwqml4xfSAtjtpe//DNfTjD0e4h4Ow3eVmQ4v7xt7ceaJ1vA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 209, DateTimeKind.Local).AddTicks(3251), "cfd10cf2-445a-403b-986d-076fdb9df02f", "AQAAAAEAACcQAAAAEGO8+z1sxJohvIW+No9cd6kIKITzgKcRTnhGToJYausaTHtpRGZXnnpl3bqpOXW/zg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 20, 56, 29, 303, DateTimeKind.Local).AddTicks(4742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 11, 15, 12, 41, 878, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.AlterColumn<bool>(
                name: "IsFeatured",
                table: "Products",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 331, DateTimeKind.Local).AddTicks(6464), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 331, DateTimeKind.Local).AddTicks(6461), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 331, DateTimeKind.Local).AddTicks(3310), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2021, 5, 9, 20, 56, 29, 331, DateTimeKind.Local).AddTicks(6453), null });

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
        }
    }
}
