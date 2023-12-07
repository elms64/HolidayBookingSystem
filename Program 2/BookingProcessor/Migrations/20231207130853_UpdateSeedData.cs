using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 1,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "09d04e0da6e9dbb479710330e6f9afc4", new DateTime(2023, 12, 7, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(1690), new Guid("86c128a3-553b-45f4-8ebf-fe91ad03dedc") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 2,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "6e7b6ac917d0525228f3d98d075f655c", new DateTime(2023, 12, 7, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2410), new Guid("a2af2a5f-3d3c-423d-804e-8ff05ddef31a") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 3,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "4bed0fabaca51e3cf8cc26dd111a7d9e", new DateTime(2023, 12, 7, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2480), new Guid("0094f7f8-e688-4133-ba2b-acc4b1a4aaae") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 4,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "babb1e9cdca8284243451cf7cf664813", new DateTime(2023, 12, 7, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2520), new Guid("cf04687f-d26c-4270-aab9-37483521f440") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 5,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "1e6ce33ba58e00902d44398096000326", new DateTime(2023, 12, 7, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2570), new Guid("97cbefb0-1082-4d55-a8c8-9597e833deee") });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 1,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 15, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2670), new DateTime(2023, 12, 14, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 2,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2680), new DateTime(2023, 12, 17, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 3,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 24, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2680), new DateTime(2023, 12, 22, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 4,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 29, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2690), new DateTime(2023, 12, 27, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 5,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2024, 1, 3, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2690), new DateTime(2024, 1, 1, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 6,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2690), new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 7,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 8,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 9,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2710), new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 10,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2710), new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 11,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2710), new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 12,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2720), new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 13,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2720), new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 14,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 15,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 16,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.InsertData(
                table: "Flight",
                columns: new[] { "FlightID", "AirlineID", "ArrivalAirportID", "ArrivalDateTime", "BookedSeats", "DepartureAirportID", "DepartureDateTime", "FlightCost", "MaxSeats" },
                values: new object[,]
                {
                    { 17, 5, 9, new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2740), 70, 5, new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2740), 120, 90 },
                    { 18, 5, 9, new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2740), 70, 5, new DateTime(2023, 12, 9, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2740), 120, 90 },
                    { 19, 5, 9, new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2750), 70, 5, new DateTime(2023, 12, 10, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2750), 120, 90 }
                });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 1,
                column: "HotelName",
                value: "Premier Inn");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 2,
                column: "HotelName",
                value: "Marriott");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 3,
                column: "HotelName",
                value: "Holiday Inn");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 4,
                column: "HotelName",
                value: "Hilton Hotel");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 5,
                column: "HotelName",
                value: "IHG");

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "HotelID", "AddressLine1", "AddressLine2", "City", "CountryID", "HotelName", "PhoneNumber", "Postcode", "Rating", "RoomCount" },
                values: new object[,]
                {
                    { 6, "202 Birch St", "Suite 5", "Laketown", 724, "Premier Inn", 5551111, "87654", 4.5, 55 },
                    { 7, "456 West St", "Suite 22", "Madrid", 724, "Marriott", 5555678, "67890", 3.5, 40 },
                    { 8, "456 Oak St", "Suite 22", "Sevilla", 724, "Holiday Inn", 5555678, "67890", 3.5, 40 },
                    { 9, "456 Oak St", "Suite 22", "Sevilla", 724, "Marriott", 5555678, "67890", 3.5, 40 }
                });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2800), new DateTime(2023, 12, 21, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2810), new DateTime(2023, 12, 24, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 22, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2810), new DateTime(2023, 12, 29, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 27, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2810), new DateTime(2024, 1, 3, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 1, 1, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2820), new DateTime(2024, 1, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.InsertData(
                table: "HotelBooking",
                columns: new[] { "HotelBookingID", "CheckInDate", "CheckOutDate", "HotelID", "RoomID" },
                values: new object[,]
                {
                    { 6, new DateTime(2024, 1, 6, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2820), new DateTime(2024, 1, 13, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2820), 6, 6 },
                    { 7, new DateTime(2023, 12, 14, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2820), new DateTime(2023, 12, 21, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2820), 7, 7 },
                    { 8, new DateTime(2023, 12, 14, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 12, 21, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2830), 8, 8 },
                    { 9, new DateTime(2023, 12, 14, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 12, 21, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2830), 9, 9 }
                });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 21, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2860), new DateTime(2023, 12, 14, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 24, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 12, 17, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 29, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 12, 22, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 3, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 12, 27, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2880), new DateTime(2024, 1, 1, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomID", "HotelID", "PricePerNight", "RoomNo", "RoomType" },
                values: new object[,]
                {
                    { 6, 6, 180m, 122, "Standard" },
                    { 7, 7, 180m, 42, "Standard" },
                    { 8, 8, 180m, 222, "Standard" },
                    { 9, 9, 180m, 202, "Standard" }
                });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 1,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 21, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2940), new DateTime(2023, 12, 14, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 2,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 24, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2940), new DateTime(2023, 12, 17, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 3,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 29, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2950), new DateTime(2023, 12, 22, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 4,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2024, 1, 3, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2950), new DateTime(2023, 12, 27, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 5,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2950), new DateTime(2024, 1, 1, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2950) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 1,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "b5aa77103079fff929c4ffe6b0b112cf", new DateTime(2023, 11, 29, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7050), new Guid("85b72c18-b180-4e3d-bfb1-11f822105c11") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 2,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "fc7d01d4b69ed3e7e77d87ebfe653eab", new DateTime(2023, 11, 29, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7490), new Guid("d6e92daa-ea28-41ee-b0c0-8c88504c918d") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 3,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "b32949e862ed1e6445fdc344fc2d3a90", new DateTime(2023, 11, 29, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7540), new Guid("ce390bf0-554b-45f4-97fa-4b94d82cefe6") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 4,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "4c1a7bdd043957ed663979d92ce554ca", new DateTime(2023, 11, 29, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7570), new Guid("dd3070ba-c9dd-4bf5-8ee1-7cde74f47ce9") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 5,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "822b35a6f332edbf29ee81da2276a023", new DateTime(2023, 11, 29, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7600), new Guid("7018ab15-191d-4893-bd88-11e273e95d52") });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 1,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 7, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 12, 6, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 2,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 11, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7670), new DateTime(2023, 12, 9, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 3,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 16, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7670), new DateTime(2023, 12, 14, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 4,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 21, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7680), new DateTime(2023, 12, 19, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 5,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 26, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7680), new DateTime(2023, 12, 24, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 6,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7680), new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 7,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7690), new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 8,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7690), new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 9,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7690), new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 10,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7690), new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 11,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 12,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 13,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 14,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 15,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 16,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 11, 30, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 1,
                column: "HotelName",
                value: "Example Hotel 1");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 2,
                column: "HotelName",
                value: "Example Hotel 2");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 3,
                column: "HotelName",
                value: "Example Hotel 3");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 4,
                column: "HotelName",
                value: "Example Hotel 4");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 5,
                column: "HotelName",
                value: "Example Hotel 5");

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 6, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 12, 13, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 9, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 12, 16, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 12, 21, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7750), new DateTime(2023, 12, 26, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 24, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7750), new DateTime(2023, 12, 31, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 13, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7770), new DateTime(2023, 12, 6, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 16, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 12, 9, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 21, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 12, 14, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 26, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 12, 19, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 12, 24, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 1,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 13, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 12, 6, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 2,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 16, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 12, 9, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 3,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 21, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 12, 14, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 4,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 26, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 12, 19, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 5,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 12, 24, 23, 29, 29, 569, DateTimeKind.Local).AddTicks(7830) });
        }
    }
}
