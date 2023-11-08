using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class SeedTest3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryID", "Climate", "CountryName" },
                values: new object[,]
                {
                    { 1, "Temperate", "England" },
                    { 2, "Incredibly Unbelievably Rainy", "Wales" }
                });

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "DestinationID", "DestinationName", "RegionID" },
                values: new object[,]
                {
                    { 1, "London", 1 },
                    { 2, "Cornwall", 1 },
                    { 3, "Dubai", 2 }
                });

            migrationBuilder.InsertData(
                table: "Flight",
                columns: new[] { "FlightID", "AirlineID", "ArrivalAirportID", "ArrivalDateTime", "BookedSeats", "DepartureAirportID", "DepartureDateTime", "MaxSeats" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 11, 8, 17, 26, 11, 0, DateTimeKind.Unspecified), 5, 1, new DateTime(2023, 12, 8, 17, 26, 11, 0, DateTimeKind.Unspecified), 100 },
                    { 2, 2, 1, new DateTime(2024, 1, 8, 17, 26, 11, 0, DateTimeKind.Unspecified), 5, 1, new DateTime(2024, 1, 8, 17, 26, 11, 0, DateTimeKind.Unspecified), 100 }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "HotelID", "AddressLine1", "AddressLine2", "City", "DestinationID", "HotelName", "Postcode", "Rating", "Telephone" },
                values: new object[,]
                {
                    { 1, "SampleAddressLine1", "SampleAddressLine2", "Fleet", 1, "The Lismoyne", "GU51 4HG", 4, 1252810170 },
                    { 2, "SampleAddress2Line1", "SampleAddress2Line2", "Farnborough", 2, "The Four Seasons", "GU52 3EB", 5, 1252810171 }
                });

            migrationBuilder.InsertData(
                table: "Insurance",
                columns: new[] { "InsuranceID", "Active", "EndDate", "PlanID", "PremiumCost", "StartDate" },
                values: new object[] { 1, true, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100m, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "PlanID", "Cost", "CoverType" },
                values: new object[,]
                {
                    { 1, 100m, "Comprehensive" },
                    { 2, 100m, "Comprehensive" }
                });

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "RegionID", "CountryID", "RegionName", "TimeZone" },
                values: new object[] { 1, 1, "London", "GMT" });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomID", "Available", "HotelID", "PricePerNight", "RoomNo", "RoomType" },
                values: new object[] { 1, true, 1, 100m, 69, "Double" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "BirthDate", "Email", "FirstName", "LastName", "Password", "Telephone", "Username" },
                values: new object[] { 1, new DateTime(2003, 8, 22, 17, 26, 11, 0, DateTimeKind.Unspecified), "Kloakk2@gmail.com", "Alex", "Lovelock", "Admin1", "01252810170", "Alex" });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "VehicleID", "BodyType", "HireRate", "Make", "Model" },
                values: new object[] { 1, "Coupe", 500m, "BMW", "3 Series" });

            migrationBuilder.InsertData(
                table: "VehicleHire",
                columns: new[] { "VehicleHireID", "CollectionDate", "CollectionDepot", "DailyRate", "RentalStatus", "ReturnDate", "ReturnDepot", "UserID", "VehicleID" },
                values: new object[] { 1, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "FCoT", 600m, "Unavailable", new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "FCoT", 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "DestinationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "DestinationID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "DestinationID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Insurance",
                keyColumn: "InsuranceID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "PlanID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "PlanID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Region",
                keyColumn: "RegionID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleHire",
                keyColumn: "VehicleHireID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 8, 17, 26, 11, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 8, 17, 26, 11, 0, DateTimeKind.Unspecified));
        }
    }
}
