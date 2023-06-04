using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class userID_Statusask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 3, 53, 59, 346, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 3, 53, 59, 346, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 3, 53, 59, 346, DateTimeKind.Local).AddTicks(9310));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
