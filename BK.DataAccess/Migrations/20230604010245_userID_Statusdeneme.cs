using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class userID_Statusdeneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Cars",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OwnerId" },
                values: new object[] { new DateTime(2023, 6, 4, 4, 2, 45, 57, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OwnerId" },
                values: new object[] { new DateTime(2023, 6, 4, 4, 2, 45, 57, DateTimeKind.Local).AddTicks(30), null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OwnerId" },
                values: new object[] { new DateTime(2023, 6, 4, 4, 2, 45, 57, DateTimeKind.Local).AddTicks(40), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
