using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class SecondSeedTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airport",
                columns: new[] { "AirportID", "AirportName", "CountryID" },
                values: new object[,]
                {
                    { 1, "Gatwick", 0 },
                    { 2, "Luton", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 2);
        }
    }
}
