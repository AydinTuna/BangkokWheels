using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AdUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdDescription",
                table: "Ads",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "AdTitle",
                table: "Ads",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdDescription", "AdTitle", "CreatedAt" },
                values: new object[] { "Canavar gibi makine. 250bg Alman tankı.", "Sahibinden temiz Audi, içinde sigara bile içilmedi", new DateTime(2023, 6, 3, 15, 39, 13, 10, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdDescription", "AdTitle", "CreatedAt" },
                values: new object[] { "Canavar gibi makine. 250bg Alman tankı.", "Sahibinden temiz Audi, içinde sigara bile içilmedi", new DateTime(2023, 6, 3, 15, 39, 13, 10, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdDescription", "AdTitle", "CreatedAt" },
                values: new object[] { "Canavar gibi makine. 250bg Alman tankı.", "Sahibinden temiz Audi, içinde sigara bile içilmedi", new DateTime(2023, 6, 3, 15, 39, 13, 10, DateTimeKind.Local).AddTicks(6580) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdDescription",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "AdTitle",
                table: "Ads");

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 3, 15, 21, 56, 556, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 3, 15, 21, 56, 556, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 3, 15, 21, 56, 556, DateTimeKind.Local).AddTicks(7320));
        }
    }
}
