using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewAirPort3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 1,
                column: "AirlineName",
                value: "Ryanair");

            migrationBuilder.UpdateData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 2,
                columns: new[] { "AirlineName", "HQ" },
                values: new object[] { "Easyjet", "Paris, France" });

            migrationBuilder.UpdateData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 3,
                column: "AirlineName",
                value: "British Airways");

            migrationBuilder.UpdateData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 4,
                columns: new[] { "AirlineName", "HQ" },
                values: new object[] { "Tui Airways", "LA, USA" });

            migrationBuilder.UpdateData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 5,
                column: "AirlineName",
                value: "Virgin Atlantic");

            migrationBuilder.InsertData(
                table: "Airport",
                columns: new[] { "AirportID", "AirportName", "CountryID" },
                values: new object[,]
                {
                    { 17, "London Stansted", 826 },
                    { 18, "Luton Airport", 826 },
                    { 19, "Manchester Airport", 826 },
                    { 20, "London City Airport", 826 },
                    { 21, "Birmingham Airport", 826 },
                    { 22, "Lille Airport", 250 },
                    { 23, "Bordeaux Airport", 250 },
                    { 24, "Marseille Airport", 250 },
                    { 25, "Barcelona International Airport", 724 },
                    { 26, "Málaga Airport", 724 },
                    { 27, "Palma De Mallorca Airport", 724 }
                });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 28, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 28, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 3,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 28, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 4,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 28, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 5,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 28, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 1,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 6, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8504), new DateTime(2023, 12, 5, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 2,
                columns: new[] { "ArrivalAirportID", "ArrivalDateTime", "DepartureAirportID", "DepartureDateTime" },
                values: new object[] { 5, new DateTime(2023, 12, 10, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8508), 16, new DateTime(2023, 12, 8, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 3,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8528), new DateTime(2023, 12, 13, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 4,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 20, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8531), new DateTime(2023, 12, 18, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 5,
                columns: new[] { "AirlineID", "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { 4, new DateTime(2023, 12, 25, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8534), new DateTime(2023, 12, 23, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8533) });

            migrationBuilder.InsertData(
                table: "Flight",
                columns: new[] { "FlightID", "AirlineID", "ArrivalAirportID", "ArrivalDateTime", "BookedSeats", "DepartureAirportID", "DepartureDateTime", "FlightCost", "MaxSeats" },
                values: new object[,]
                {
                    { 6, 3, 17, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8537), 80, 16, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8536), 180, 140 },
                    { 7, 5, 18, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8539), 150, 16, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8539), 150, 180 },
                    { 8, 1, 19, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8542), 120, 16, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8541), 150, 150 },
                    { 9, 5, 20, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8545), 100, 16, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8544), 100, 140 },
                    { 10, 5, 19, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8548), 70, 1, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8547), 120, 90 },
                    { 11, 5, 19, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8550), 70, 16, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8549), 120, 90 },
                    { 12, 5, 20, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8553), 70, 16, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8552), 120, 90 },
                    { 13, 5, 21, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8556), 70, 16, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8555), 120, 90 },
                    { 14, 5, 22, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8558), 70, 16, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8557), 120, 90 },
                    { 15, 5, 23, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8561), 70, 16, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8560), 120, 90 },
                    { 16, 5, 24, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8564), 70, 16, new DateTime(2023, 11, 29, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8563), 120, 90 }
                });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8588), new DateTime(2023, 12, 12, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 8, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8591), new DateTime(2023, 12, 15, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 13, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8593), new DateTime(2023, 12, 20, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 18, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8596), new DateTime(2023, 12, 25, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 23, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8598), new DateTime(2023, 12, 30, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 12, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8619), new DateTime(2023, 12, 5, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8621), new DateTime(2023, 12, 8, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8624), new DateTime(2023, 12, 13, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8626), new DateTime(2023, 12, 18, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 30, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8628), new DateTime(2023, 12, 23, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 1,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 12, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8660), new DateTime(2023, 12, 5, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 2,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8662), new DateTime(2023, 12, 8, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 3,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 20, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8664), new DateTime(2023, 12, 13, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 4,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 25, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8667), new DateTime(2023, 12, 18, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 5,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 30, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8669), new DateTime(2023, 12, 23, 22, 34, 24, 708, DateTimeKind.Local).AddTicks(8668) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 1,
                column: "AirlineName",
                value: "Example Airline 1");

            migrationBuilder.UpdateData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 2,
                columns: new[] { "AirlineName", "HQ" },
                values: new object[] { "Example Airline 2", "France, Paris" });

            migrationBuilder.UpdateData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 3,
                column: "AirlineName",
                value: "Example Airline 3");

            migrationBuilder.UpdateData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 4,
                columns: new[] { "AirlineName", "HQ" },
                values: new object[] { "Example Airline 4", "USA, LA" });

            migrationBuilder.UpdateData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 5,
                column: "AirlineName",
                value: "Example Airline 5");

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 22, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 22, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 3,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 22, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 4,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 22, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 5,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 22, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 1,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 11, 30, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5042), new DateTime(2023, 11, 29, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 2,
                columns: new[] { "ArrivalAirportID", "ArrivalDateTime", "DepartureAirportID", "DepartureDateTime" },
                values: new object[] { 3, new DateTime(2023, 12, 4, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5046), 2, new DateTime(2023, 12, 2, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 3,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5048), new DateTime(2023, 12, 7, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 4,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5051), new DateTime(2023, 12, 12, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 5,
                columns: new[] { "AirlineID", "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { 5, new DateTime(2023, 12, 19, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5054), new DateTime(2023, 12, 17, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 11, 29, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5079), new DateTime(2023, 12, 6, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 2, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5082), new DateTime(2023, 12, 9, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 7, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5085), new DateTime(2023, 12, 14, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 12, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5087), new DateTime(2023, 12, 19, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 17, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5090), new DateTime(2023, 12, 24, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 6, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5111), new DateTime(2023, 11, 29, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 9, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5113), new DateTime(2023, 12, 2, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5116), new DateTime(2023, 12, 7, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5118), new DateTime(2023, 12, 12, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 24, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5121), new DateTime(2023, 12, 17, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 1,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 6, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5152), new DateTime(2023, 11, 29, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 2,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 9, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5155), new DateTime(2023, 12, 2, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 3,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 12, 7, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 4,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 19, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5159), new DateTime(2023, 12, 12, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 5,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 24, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5162), new DateTime(2023, 12, 17, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5161) });
        }
    }
}
