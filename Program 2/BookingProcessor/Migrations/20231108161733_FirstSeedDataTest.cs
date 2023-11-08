using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class FirstSeedDataTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airline",
                columns: new[] { "AirlineID", "AirlineName" },
                values: new object[,]
                {
                    { 1, "EasyJet" },
                    { 2, "British Airways" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 2);
        }
    }
}
