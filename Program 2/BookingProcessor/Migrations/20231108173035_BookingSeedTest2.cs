using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class BookingSeedTest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingID", "DestinationID", "FlightID", "HotelID", "InsuranceID", "PurchaseDate", "UserID", "VehicleHireID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, new DateTime(2023, 11, 8, 17, 26, 11, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, 2, 2, 2, 2, new DateTime(2023, 11, 8, 17, 26, 11, 0, DateTimeKind.Unspecified), 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 2);
        }
    }
}
