using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class userID_Statusas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Cars",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OwnerId" },
                values: new object[] { new DateTime(2023, 6, 4, 3, 50, 44, 843, DateTimeKind.Local).AddTicks(3410), "1" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OwnerId" },
                values: new object[] { new DateTime(2023, 6, 4, 3, 50, 44, 843, DateTimeKind.Local).AddTicks(3440), "1" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OwnerId" },
                values: new object[] { new DateTime(2023, 6, 4, 3, 50, 44, 843, DateTimeKind.Local).AddTicks(3440), "1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
