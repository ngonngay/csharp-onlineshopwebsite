using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class RawCustomerAndStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 22, 10, 6, 26, 415, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 22, 10, 6, 26, 417, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 4, 22, 10, 6, 26, 417, DateTimeKind.Local).AddTicks(3934));

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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "aa420699-4c75-4413-8cb0-d6d8dff73ab0", "customer", "CUSTOMER" },
                    { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "fee95fb6-85bd-45e0-9b52-ecc0585cd74e", "staff", "STAFF" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 22, 10, 6, 26, 658, DateTimeKind.Local).AddTicks(6675), "48aa566d-edad-459e-86a8-144d9fb2adcb", "AQAAAAEAACcQAAAAEPX4muj/cfcahaJD1CJuSsvr0R0wgUpuZnTuEYHjDbU5A2E2WyKBjw/TIy0mKS9eHA==" });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "10BD711F-9576-45BA-B5B7-F00649BE04DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 463, DateTimeKind.Local).AddTicks(7756), "025867af-5b91-4be4-bb9e-fd5427c9bc94", "rawaccountcustomer4@gmail.com", true, null, false, null, "rawaccountcustomer4@gmail.com", "raw-account-customer4", "AQAAAAEAACcQAAAAEM/A/hIv2TARLl3Weeqkuiyd207V0rptWXKJWEyK+vLwj/ieEWAbeiY8PjSwdo5myA==", null, false, "", false, "raw-account-customer4" },
                    { "10BD711F-9576-45BA-B5B7-F00649BE00DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 429, DateTimeKind.Local).AddTicks(2902), "6b290b2d-065a-412d-9d6a-bd525649958b", "rawaccountcustomer0@gmail.com", true, null, false, null, "rawaccountcustomer0@gmail.com", "raw-account-customer0", "AQAAAAEAACcQAAAAEOi8m1pmaJdJFz0t7ErerqI76UJVgi+jb+8pD0quFs7lQUc3W8XFj9zNlAYwpgZ5zg==", null, false, "", false, "raw-account-customer0" },
                    { "10BD711F-9576-45BA-B5B7-F00649BE01DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 438, DateTimeKind.Local).AddTicks(7297), "3bf0fc88-0b21-47ef-bfda-89e9a2f501c1", "rawaccountcustomer1@gmail.com", true, null, false, null, "rawaccountcustomer1@gmail.com", "raw-account-customer1", "AQAAAAEAACcQAAAAEEwtkuJC0Mp+BPTMY2SDAYUsMb5hswh0FlcIUqX9YAiMXmRpsE2GNjvzTsDg0oGbxA==", null, false, "", false, "raw-account-customer1" },
                    { "11BD711F-9596-45BA-B5B7-F00649BE09DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 588, DateTimeKind.Local).AddTicks(7130), "01e83e78-1270-47d6-a7bf-8c1be3736355", "rawaccountstaff9@gmail.com", true, null, false, null, "rawaccountstaff9@gmail.com", "raw-account-staff9", "AQAAAAEAACcQAAAAEBXu88r38mu+AH1pjisteEpsu0XkbXaDgb5sz3X6BJz49uZnG0Akr+WTA5YPzt9mGg==", null, false, "", false, "raw-account-staff9" },
                    { "11BD711F-9586-45BA-B5B7-F00649BE08DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 580, DateTimeKind.Local).AddTicks(3819), "548df25e-6d4c-46af-9761-c40fc1112343", "rawaccountstaff8@gmail.com", true, null, false, null, "rawaccountstaff8@gmail.com", "raw-account-staff8", "AQAAAAEAACcQAAAAEFIdLvc3p4ET3KOcWbbj378hyxQszwFVK5I8lgKZxiR8HSRBS+uX3kSTOXYAy815Kg==", null, false, "", false, "raw-account-staff8" },
                    { "11BD711F-9576-45BA-B5B7-F00649BE07DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 572, DateTimeKind.Local).AddTicks(3743), "1ba2dac8-fa2f-45fd-ba46-15bd99a3525c", "rawaccountstaff7@gmail.com", true, null, false, null, "rawaccountstaff7@gmail.com", "raw-account-staff7", "AQAAAAEAACcQAAAAEMqjb31Zd08lB5I3Y4RzOOJOZ1FKnKasEE+X5MwnZjHasu3c8LOYsena5f4i6uB5+A==", null, false, "", false, "raw-account-staff7" },
                    { "11BD711F-9566-45BA-B5B7-F00649BE06DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 564, DateTimeKind.Local).AddTicks(1702), "66d19ddb-4eb5-440a-ad86-eb0f539f8bab", "rawaccountstaff6@gmail.com", true, null, false, null, "rawaccountstaff6@gmail.com", "raw-account-staff6", "AQAAAAEAACcQAAAAEHYiyVOz0FsH/sANrmlZNkGuiisCOyxQuG/dexez/f/PIsRSDGncwxV8rpNho9CNcQ==", null, false, "", false, "raw-account-staff6" },
                    { "10BD711F-9576-45BA-B5B7-F00649BE02DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 447, DateTimeKind.Local).AddTicks(689), "c1579171-678e-473e-86eb-43d8288e9089", "rawaccountcustomer2@gmail.com", true, null, false, null, "rawaccountcustomer2@gmail.com", "raw-account-customer2", "AQAAAAEAACcQAAAAEMylsi9+jMpUOOuH7WN/DHVonUdeKnlhH47VpWqqN2EArggZL3rvodUw8DkxsK8S/Q==", null, false, "", false, "raw-account-customer2" },
                    { "11BD711F-9546-45BA-B5B7-F00649BE04DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 546, DateTimeKind.Local).AddTicks(7303), "9eef9be6-f0a9-4901-98c7-25f88846f78e", "rawaccountstaff4@gmail.com", true, null, false, null, "rawaccountstaff4@gmail.com", "raw-account-staff4", "AQAAAAEAACcQAAAAEFpOQg7mBICFqU/Ypn15VxWJYZj2lEs5YxfaALrocvlSMEpepkkv9E/ZiWE4CaQINw==", null, false, "", false, "raw-account-staff4" },
                    { "11BD711F-9536-45BA-B5B7-F00649BE03DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 537, DateTimeKind.Local).AddTicks(7039), "79aef824-eba6-4f02-a26d-bb3ea2ab3e39", "rawaccountstaff3@gmail.com", true, null, false, null, "rawaccountstaff3@gmail.com", "raw-account-staff3", "AQAAAAEAACcQAAAAENIaXlrnc+MUARddbqMezJI/1HQAICOhspxJpwjQwHhhVdZiN5466+EsJ5mooGku9w==", null, false, "", false, "raw-account-staff3" },
                    { "11BD711F-9526-45BA-B5B7-F00649BE02DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 529, DateTimeKind.Local).AddTicks(5953), "a32511f0-2793-4e2f-ba72-9e482c7e5d92", "rawaccountstaff2@gmail.com", true, null, false, null, "rawaccountstaff2@gmail.com", "raw-account-staff2", "AQAAAAEAACcQAAAAEBD+BKLUul6nSEZVnEp6RAh2GpBN8WDg0gpmYmMKELOsUNFDu4iu2PsV5nv2D+5tpA==", null, false, "", false, "raw-account-staff2" },
                    { "11BD711F-9516-45BA-B5B7-F00649BE01DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 521, DateTimeKind.Local).AddTicks(4569), "bb59d6ba-7a8e-443f-93a6-e6cc08a9f8b7", "rawaccountstaff1@gmail.com", true, null, false, null, "rawaccountstaff1@gmail.com", "raw-account-staff1", "AQAAAAEAACcQAAAAEMPhxKzpOeibIsmJd8mzgZPQxoVcnYRFT0++HZ0vSEPrE/rFg03arSAZScxFH9D6QA==", null, false, "", false, "raw-account-staff1" },
                    { "11BD711F-9506-45BA-B5B7-F00649BE00DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 513, DateTimeKind.Local).AddTicks(7178), "a9a41f3f-7880-4178-9183-db5e0acd6566", "rawaccountstaff0@gmail.com", true, null, false, null, "rawaccountstaff0@gmail.com", "raw-account-staff0", "AQAAAAEAACcQAAAAEFwO94SkIqNR4Ql27/ryVO4jN0+RRK1sJnGN+Ib17nRHsLZL7UNEJlG2qkuBVP9ppg==", null, false, "", false, "raw-account-staff0" },
                    { "10BD711F-9576-45BA-B5B7-F00649BE09DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 504, DateTimeKind.Local).AddTicks(6471), "735ab7f4-a363-4e6d-94ec-25cab00ef9dd", "rawaccountcustomer9@gmail.com", true, null, false, null, "rawaccountcustomer9@gmail.com", "raw-account-customer9", "AQAAAAEAACcQAAAAEEyvd23SSVlC26JVeAqssgdqia+vFb87/l9ujAXBWU9gUkq1s0vP+PzyDDCFOVssSQ==", null, false, "", false, "raw-account-customer9" },
                    { "10BD711F-9576-45BA-B5B7-F00649BE08DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 496, DateTimeKind.Local).AddTicks(9197), "2a550ec4-273d-4f97-ae03-ad841b11e591", "rawaccountcustomer8@gmail.com", true, null, false, null, "rawaccountcustomer8@gmail.com", "raw-account-customer8", "AQAAAAEAACcQAAAAEGAGlNvSuiFr5v17K963hMt3sJ1gVpt+AzNtjkSJyl0RXGfKRBhNolIdUddbxN7AAw==", null, false, "", false, "raw-account-customer8" },
                    { "10BD711F-9576-45BA-B5B7-F00649BE07DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 488, DateTimeKind.Local).AddTicks(1516), "62c32711-6648-4c81-b784-1fd9c3ac2420", "rawaccountcustomer7@gmail.com", true, null, false, null, "rawaccountcustomer7@gmail.com", "raw-account-customer7", "AQAAAAEAACcQAAAAEJpnARaRxfTTpxj0DmGdgQb9L12HDUIUrf1s2fddHtu1kRm0NhttOKqZoVEMUdHyCA==", null, false, "", false, "raw-account-customer7" },
                    { "10BD711F-9576-45BA-B5B7-F00649BE06DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 480, DateTimeKind.Local).AddTicks(4617), "1b604a1d-6881-489c-bc00-f1ea8ea1dd69", "rawaccountcustomer6@gmail.com", true, null, false, null, "rawaccountcustomer6@gmail.com", "raw-account-customer6", "AQAAAAEAACcQAAAAEO7Fjgdl2FjXH6Fhjm3HqazDMsbUTHF1W3ikUtkPrtnqevByFHlLw4rZs/9L1Vs4dQ==", null, false, "", false, "raw-account-customer6" },
                    { "10BD711F-9576-45BA-B5B7-F00649BE05DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 471, DateTimeKind.Local).AddTicks(8202), "0374ecf3-9bfc-419f-9c82-69316fb467be", "rawaccountcustomer5@gmail.com", true, null, false, null, "rawaccountcustomer5@gmail.com", "raw-account-customer5", "AQAAAAEAACcQAAAAEMzyUVbG96wq3sCR56coAuu+0KS8RC/YnTHXXaNrUe6pT+0A5iEplrYBQ3arI4bCIg==", null, false, "", false, "raw-account-customer5" },
                    { "10BD711F-9576-45BA-B5B7-F00649BE03DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 454, DateTimeKind.Local).AddTicks(9830), "ef2511fc-de17-42f9-9e78-06472bb3967b", "rawaccountcustomer3@gmail.com", true, null, false, null, "rawaccountcustomer3@gmail.com", "raw-account-customer3", "AQAAAAEAACcQAAAAEAypkgw5qfyiLQbpOW1a4IVeP4pgmkpjnq1d08AKU12x0eONZ1f4rTngqJQ7Qfc0YQ==", null, false, "", false, "raw-account-customer3" },
                    { "11BD711F-9556-45BA-B5B7-F00649BE05DE", 0, null, new DateTime(2021, 4, 22, 10, 6, 26, 555, DateTimeKind.Local).AddTicks(4685), "3856574f-adc9-4ec4-a2cf-15d22831297d", "rawaccountstaff5@gmail.com", true, null, false, null, "rawaccountstaff5@gmail.com", "raw-account-staff5", "AQAAAAEAACcQAAAAEP7F7XhIU4mGMdkI38Id1KhXmHDylIUlLlBTXUXEMPhLvOxUagbYZ9KkU63NmIZLWA==", null, false, "", false, "raw-account-staff5" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE00DE" },
                    { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9576-45BA-B5B7-F00649BE07DE" },
                    { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9566-45BA-B5B7-F00649BE06DE" },
                    { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9556-45BA-B5B7-F00649BE05DE" },
                    { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9546-45BA-B5B7-F00649BE04DE" },
                    { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9536-45BA-B5B7-F00649BE03DE" },
                    { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9526-45BA-B5B7-F00649BE02DE" },
                    { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9516-45BA-B5B7-F00649BE01DE" },
                    { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                    { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE09DE" },
                    { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE08DE" },
                    { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE07DE" },
                    { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE06DE" },
                    { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE05DE" },
                    { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE04DE" },
                    { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE03DE" },
                    { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE02DE" },
                    { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE01DE" },
                    { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9586-45BA-B5B7-F00649BE08DE" },
                    { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9596-45BA-B5B7-F00649BE09DE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE00DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE01DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE02DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE03DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE04DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE05DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE06DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE07DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE08DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8D04DCC2-969A-435D-BBA4-DF3F315983DC", "10BD711F-9576-45BA-B5B7-F00649BE09DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9506-45BA-B5B7-F00649BE00DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9516-45BA-B5B7-F00649BE01DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9526-45BA-B5B7-F00649BE02DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9536-45BA-B5B7-F00649BE03DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9546-45BA-B5B7-F00649BE04DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9556-45BA-B5B7-F00649BE05DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9566-45BA-B5B7-F00649BE06DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9576-45BA-B5B7-F00649BE07DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9586-45BA-B5B7-F00649BE08DE" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1D04DCC2-969A-435D-BBA4-DF3F315983DC", "11BD711F-9596-45BA-B5B7-F00649BE09DE" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE");

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
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 44, 34, DateTimeKind.Local).AddTicks(9371), "68310544-f2a4-4d79-a19c-217204ba067b", "AQAAAAEAACcQAAAAEPnxx6dZzpf560y6bqKVtrT/O00qhsorOJlh9+7lQsZwDYVoU9qwczhEkRmwO8Rx3g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 43, 994, DateTimeKind.Local).AddTicks(2824), "385d28a5-00be-4d05-8344-8c422c0cc0d6", "AQAAAAEAACcQAAAAEO7O1MQzEepViDom4M92EZdZmOyk6vLdXq4MhJdJu5YRkkpGxps6vzUsh/RD/7UDEA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 43, 981, DateTimeKind.Local).AddTicks(865), "0c9fe468-5065-4385-9017-f12d682d133a", "AQAAAAEAACcQAAAAEJ3TvLHx9CjnwLKz8h/1FAod0F69IHc7UKj6OaGMqVNqu5UIAi43AFuSY1mToegGhQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 44, 7, DateTimeKind.Local).AddTicks(4995), "12b9e24d-44d0-46b4-ba8d-88a034ee5d9b", "AQAAAAEAACcQAAAAEL5NaBgD7tyn/YSUyPqun/5Skw8D1TmTfO7SiM484vOlnMJnOmzh3wdowA7qq039Iw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 44, 47, DateTimeKind.Local).AddTicks(9798), "2ddf5415-8770-4ad9-bbb3-f9dc926f12cb", "AQAAAAEAACcQAAAAEMgWz24ygUeae2U9B5Xc43RHYm9ZkSWpijZHwHvwP4V5F0CBNr+rTodG+yiaERMGOQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 43, 954, DateTimeKind.Local).AddTicks(8141), "d10c226b-9069-4503-9db5-02b85c6a0e28", "AQAAAAEAACcQAAAAEOP7bfHfX8ITG1tKZx9NHY4IpqDbMg6SnK5k44jxxwFVe0NnoSuM/tlE+hbvXVHtbQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 43, 966, DateTimeKind.Local).AddTicks(7843), "26114fce-2357-4a05-a45c-20fc5fb579be", "AQAAAAEAACcQAAAAENiPClXMtKTVJYR28tXxlqmz0Tp1QNsyvdKeMq/OJhlUlUn9MbXatRewSYBHhmQtGA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 44, 20, DateTimeKind.Local).AddTicks(8268), "f76dc31c-0bb5-4909-b001-db6a3d21e0a0", "AQAAAAEAACcQAAAAEEJID3FhuL/TSdfOKdKWsz99Hy6ONHu04CruOGRrmid+Ycg2Is/q+9QY9fN5+hi+Ig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 52, 43, 941, DateTimeKind.Local).AddTicks(5729), "11074662-3ab4-4aa8-8c46-a6782d4dc91f", "AQAAAAEAACcQAAAAEKYPQPPwAIspnn5gySLIPtlkXrV9AlUoRAIGPQmMWSKAJH157RRLiR37IANUlI63kQ==" });
        }
    }
}
