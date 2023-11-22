using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "5da3d3d5-efc6-4f44-9c2f-d86839013b59", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMHHXpFghYarMLDaty2ztLHLLE9m0uhelqBgBg4nvfwcAtiHSEtQW+NT5tm/ksLCvg==", null, false, "749bec99-02d7-4941-8e14-dfeafe2477ff", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(7858), new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(7873), new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(8188), new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(8190), new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(8378), new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(8380), new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(8382), new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(8383), new DateTime(2023, 11, 22, 11, 55, 13, 15, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(5782), new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(5802), new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6150), new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6153), new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6349), new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6352), new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6356) });
        }
    }
}
