using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class SeedTest5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2003, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2003, 8, 22, 17, 26, 11, 0, DateTimeKind.Unspecified));
        }
    }
}
