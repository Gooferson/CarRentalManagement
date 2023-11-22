using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCreated",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "DataUpdated",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "DataCreated",
                table: "Colours");

            migrationBuilder.DropColumn(
                name: "DataUpdated",
                table: "Colours");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Vehicles",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Vehicles",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Makes",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Makes",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Customers",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Customers",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Bookings",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Bookings",
                newName: "DateCreated");

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

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6150), new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6151), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6153), new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6153), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6349), new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6349), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6352), new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6352), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6354), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 11, 22, 11, 49, 30, 951, DateTimeKind.Local).AddTicks(6356), "Rav4", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Vehicles",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Vehicles",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Makes",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Makes",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Customers",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Customers",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Bookings",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Bookings",
                newName: "DataCreated");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCreated",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataUpdated",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCreated",
                table: "Colours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataUpdated",
                table: "Colours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DataUpdated", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 11, 37, 47, 160, DateTimeKind.Local).AddTicks(1366), new DateTime(2023, 11, 22, 11, 37, 47, 160, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DataUpdated", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 11, 37, 47, 160, DateTimeKind.Local).AddTicks(1385), new DateTime(2023, 11, 22, 11, 37, 47, 160, DateTimeKind.Local).AddTicks(1385) });
        }
    }
}
