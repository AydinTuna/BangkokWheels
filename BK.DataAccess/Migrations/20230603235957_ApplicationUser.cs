using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Cars",
                newName: "ApplicationUserId");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { 0, new DateTime(2023, 6, 4, 2, 59, 57, 171, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { 0, new DateTime(2023, 6, 4, 2, 59, 57, 171, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { 0, new DateTime(2023, 6, 4, 2, 59, 57, 171, DateTimeKind.Local).AddTicks(7130) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Cars",
                newName: "OwnerId");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OwnerId" },
                values: new object[] { new DateTime(2023, 6, 4, 0, 19, 51, 501, DateTimeKind.Local).AddTicks(1180), 1 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OwnerId" },
                values: new object[] { new DateTime(2023, 6, 4, 0, 19, 51, 501, DateTimeKind.Local).AddTicks(1200), 5 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OwnerId" },
                values: new object[] { new DateTime(2023, 6, 4, 0, 19, 51, 501, DateTimeKind.Local).AddTicks(1200), 4 });
        }
    }
}
