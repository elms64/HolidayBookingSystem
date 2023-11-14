using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airline",
                columns: new[] { "AirlineID", "AirlineName", "PhoneNumber", "Rating" },
                values: new object[,]
                {
                    { 1, "Example Airline 1", "123-456-7890", 4.5 },
                    { 2, "Example Airline 2", "987-654-3210", 3.7999999999999998 },
                    { 3, "Example Airline 3", "555-123-4567", 4.2000000000000002 },
                    { 4, "Example Airline 4", "333-777-8888", 3.5 },
                    { 5, "Example Airline 5", "111-222-3333", 4.0 }
                });

            migrationBuilder.InsertData(
                table: "Airport",
                columns: new[] { "AirportID", "AirportName", "CountryID" },
                values: new object[,]
                {
                    { 1, "Example Airport 1", 1 },
                    { 2, "Example Airport 2", 2 },
                    { 3, "Example Airport 3", 3 },
                    { 4, "Example Airport 4", 4 },
                    { 5, "Example Airport 5", 5 }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingID", "ClientID", "CountryID", "FlightID", "HotelBookingID", "InsuranceBookingID", "PurchaseDate", "VehicleBookingID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, 1, new DateTime(2023, 11, 14, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(116), 1 },
                    { 2, 2, 2, 2, 2, 2, new DateTime(2023, 11, 14, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(160), 2 },
                    { 3, 3, 3, 3, 3, 3, new DateTime(2023, 11, 14, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(162), 3 },
                    { 4, 4, 4, 4, 4, 4, new DateTime(2023, 11, 14, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(165), 4 },
                    { 5, 5, 5, 5, 5, 5, new DateTime(2023, 11, 14, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(167), 5 }
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientID", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John", "Doe", "123-456-7890" },
                    { 2, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "Jane", "Smith", "987-654-3210" },
                    { 3, new DateTime(1992, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice.johnson@example.com", "Alice", "Johnson", "555-123-4567" },
                    { 4, new DateTime(1980, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.anderson@example.com", "Bob", "Anderson", "333-777-8888" },
                    { 5, new DateTime(1988, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "eva.williams@example.com", "Eva", "Williams", "111-222-3333" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryID", "Climate", "CountryName" },
                values: new object[,]
                {
                    { 1, "Temperate", "Country 1" },
                    { 2, "Tropical", "Country 2" },
                    { 3, "Desert", "Country 3" },
                    { 4, "Arctic", "Country 4" },
                    { 5, "Mediterranean", "Country 5" }
                });

            migrationBuilder.InsertData(
                table: "Flight",
                columns: new[] { "FlightID", "AirlineID", "ArrivalAirportID", "ArrivalDateTime", "BookedSeats", "DepartureAirportID", "DepartureDateTime", "FlightCost", "MaxSeats" },
                values: new object[,]
                {
                    { 1, 1, 2, new DateTime(2023, 11, 22, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(238), 50, 1, new DateTime(2023, 11, 21, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(234), 500, 100 },
                    { 2, 2, 3, new DateTime(2023, 11, 26, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(245), 30, 2, new DateTime(2023, 11, 24, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(241), 450, 80 },
                    { 3, 3, 4, new DateTime(2023, 12, 1, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(248), 70, 3, new DateTime(2023, 11, 29, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(247), 600, 120 },
                    { 4, 4, 5, new DateTime(2023, 12, 6, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(252), 40, 4, new DateTime(2023, 12, 4, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(250), 550, 100 },
                    { 5, 5, 1, new DateTime(2023, 12, 11, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(255), 60, 5, new DateTime(2023, 12, 9, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(254), 480, 80 }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "HotelID", "AddressLine1", "AddressLine2", "City", "HotelName", "PhoneNumber", "Postcode", "Rating", "RoomCount" },
                values: new object[,]
                {
                    { 1, "123 Main St", "Apt 45", "Cityville", "Example Hotel 1", 5551234, "12345", 4.0, 50 },
                    { 2, "456 Oak St", "Suite 22", "Townsville", "Example Hotel 2", 5555678, "67890", 3.5, 40 },
                    { 3, "789 Pine St", "Unit 33", "Villagetown", "Example Hotel 3", 5559999, "10111", 4.2000000000000002, 60 },
                    { 4, "101 Cedar St", "Apt 10", "Mountainview", "Example Hotel 4", 5554321, "54321", 3.7999999999999998, 45 },
                    { 5, "202 Birch St", "Suite 5", "Laketown", "Example Hotel 5", 5551111, "87654", 4.5, 55 }
                });

            migrationBuilder.InsertData(
                table: "HotelBooking",
                columns: new[] { "HotelBookingID", "CheckInDate", "CheckOutDate", "HotelID", "RoomID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 21, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(291), new DateTime(2023, 11, 28, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(293), 1, 1 },
                    { 2, new DateTime(2023, 11, 24, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(295), new DateTime(2023, 12, 1, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(297), 2, 2 },
                    { 3, new DateTime(2023, 11, 29, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(299), new DateTime(2023, 12, 6, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(300), 3, 3 },
                    { 4, new DateTime(2023, 12, 4, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(302), new DateTime(2023, 12, 11, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(303), 4, 4 },
                    { 5, new DateTime(2023, 12, 9, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(305), new DateTime(2023, 12, 16, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(306), 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Insurance",
                columns: new[] { "InsuranceID", "InsuranceType", "PricePerDay" },
                values: new object[,]
                {
                    { 1, "Basic", 10.5 },
                    { 2, "Standard", 15.75 },
                    { 3, "Premium", 20.0 },
                    { 4, "Extended", 25.5 },
                    { 5, "Deluxe", 30.0 }
                });

            migrationBuilder.InsertData(
                table: "InsuranceBooking",
                columns: new[] { "InsuranceBookingID", "EndDate", "InsuranceID", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 28, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(341), 1, new DateTime(2023, 11, 21, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(339) },
                    { 2, new DateTime(2023, 12, 1, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(345), 2, new DateTime(2023, 11, 24, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(343) },
                    { 3, new DateTime(2023, 12, 6, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(348), 3, new DateTime(2023, 11, 29, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(346) },
                    { 4, new DateTime(2023, 12, 11, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(351), 4, new DateTime(2023, 12, 4, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(350) },
                    { 5, new DateTime(2023, 12, 16, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(354), 5, new DateTime(2023, 12, 9, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(353) }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomID", "HotelID", "PricePerNight", "RoomNo", "RoomType" },
                values: new object[,]
                {
                    { 1, 1, 100m, 101, "Standard" },
                    { 2, 2, 150m, 201, "Deluxe" },
                    { 3, 3, 200m, 301, "Suite" },
                    { 4, 4, 110m, 102, "Standard" },
                    { 5, 5, 180m, 202, "Suite" }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "VehicleID", "PricePerDay", "VehicleType" },
                values: new object[,]
                {
                    { 1, 45.0m, "Compact Car" },
                    { 2, 60.0m, "SUV" },
                    { 3, 75.0m, "Van" },
                    { 4, 100.0m, "Luxury Car" },
                    { 5, 30.0m, "Motorcycle" }
                });

            migrationBuilder.InsertData(
                table: "VehicleBooking",
                columns: new[] { "VehicleBookingID", "DropOffDate", "PickUpDate", "VehicleID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 28, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(411), new DateTime(2023, 11, 21, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(409), 1 },
                    { 2, new DateTime(2023, 12, 1, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(414), new DateTime(2023, 11, 24, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(413), 2 },
                    { 3, new DateTime(2023, 12, 6, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(418), new DateTime(2023, 11, 29, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(416), 3 },
                    { 4, new DateTime(2023, 12, 11, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(427), new DateTime(2023, 12, 4, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(426), 4 },
                    { 5, new DateTime(2023, 12, 16, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(430), new DateTime(2023, 12, 9, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(429), 5 }
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

            migrationBuilder.DeleteData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Insurance",
                keyColumn: "InsuranceID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Insurance",
                keyColumn: "InsuranceID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Insurance",
                keyColumn: "InsuranceID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Insurance",
                keyColumn: "InsuranceID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Insurance",
                keyColumn: "InsuranceID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 5);
        }
    }
}
