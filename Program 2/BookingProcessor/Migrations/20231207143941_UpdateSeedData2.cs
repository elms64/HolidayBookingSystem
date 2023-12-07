using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 1,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "edb8aafc3832bee0d5193511931504dc", new DateTime(2023, 12, 7, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(7390), new Guid("d4887eb4-9ff5-41b6-8946-648ae7e4b9a4") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 2,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "fb0109e3f976a4745915ce62e510d7dc", new DateTime(2023, 12, 7, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8030), new Guid("eb7f6633-659f-487e-85d1-748adbb6504d") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 3,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "0752f8ff9567d7caaef667e54b7931db", new DateTime(2023, 12, 7, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8080), new Guid("0efec6fb-5bbb-4b49-8bed-b850525b0c8f") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 4,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "6717911d6fcb199f01a3dfd891b3bcb2", new DateTime(2023, 12, 7, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8110), new Guid("b2d9f19d-3613-452b-8693-b37ac4528f9d") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 5,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "5eca5e1150ab46451895476342371b22", new DateTime(2023, 12, 7, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8150), new Guid("cc648821-8908-4f31-8948-f489cee271ca") });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 1,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 15, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 2,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 12, 17, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 3,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 12, 22, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 4,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 29, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8250), new DateTime(2023, 12, 27, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 5,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2024, 1, 3, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 1, 1, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 6,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8250), new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 7,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8260), new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 8,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8260), new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 9,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8270), new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 10,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8270), new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 11,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8270), new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 12,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8280), new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 13,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8280), new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 14,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8290), new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 15,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8290), new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 16,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8300), new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 17,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8310), new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 18,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8310), new DateTime(2023, 12, 9, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 19,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8310), new DateTime(2023, 12, 10, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8360), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 17, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8360), new DateTime(2023, 12, 24, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 22, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8360), new DateTime(2023, 12, 29, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 27, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 1, 3, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 1, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 1, 6, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 1, 13, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "HotelID" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8380), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8380), 6 });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate", "HotelID" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8380), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8380), 6 });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate", "HotelID" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8380), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8390), 6 });

            migrationBuilder.InsertData(
                table: "HotelBooking",
                columns: new[] { "HotelBookingID", "CheckInDate", "CheckOutDate", "HotelID", "RoomID" },
                values: new object[,]
                {
                    { 10, new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8390), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8390), 7, 10 },
                    { 11, new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8390), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8390), 7, 11 },
                    { 12, new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8390), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8390), 7, 12 },
                    { 13, new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8400), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8400), 7, 13 },
                    { 14, new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8400), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8400), 8, 14 },
                    { 15, new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8400), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8400), 8, 15 },
                    { 16, new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8410), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8410), 8, 16 },
                    { 17, new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8410), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8410), 8, 17 },
                    { 18, new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8410), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8410), 9, 18 },
                    { 19, new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8410), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8420), 9, 19 },
                    { 20, new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8420), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8420), 9, 20 },
                    { 21, new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8420), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8420), 9, 21 }
                });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8450), new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8460), new DateTime(2023, 12, 17, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 29, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8460), new DateTime(2023, 12, 22, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 3, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8460), new DateTime(2023, 12, 27, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8460), new DateTime(2024, 1, 1, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 1,
                column: "HotelID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "HotelID",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 3,
                column: "HotelID",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "HotelID",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 5,
                column: "HotelID",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 7,
                column: "HotelID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 8,
                column: "HotelID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 9,
                columns: new[] { "HotelID", "RoomNo" },
                values: new object[] { 6, 204 });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomID", "HotelID", "PricePerNight", "RoomNo", "RoomType" },
                values: new object[,]
                {
                    { 10, 7, 180m, 216, "Standard" },
                    { 11, 7, 180m, 108, "Standard" },
                    { 12, 7, 180m, 109, "Standard" },
                    { 13, 7, 180m, 110, "Standard" },
                    { 14, 8, 180m, 134, "Standard" },
                    { 15, 8, 180m, 142, "Standard" },
                    { 16, 8, 180m, 172, "Standard" },
                    { 17, 8, 180m, 222, "Standard" },
                    { 18, 9, 180m, 212, "Standard" },
                    { 19, 9, 180m, 112, "Standard" },
                    { 20, 9, 180m, 104, "Standard" },
                    { 21, 9, 180m, 120, "Standard" }
                });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 1,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8540), new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 2,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8540), new DateTime(2023, 12, 17, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 3,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 29, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8540), new DateTime(2023, 12, 22, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 4,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2024, 1, 3, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8540), new DateTime(2023, 12, 27, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 5,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2024, 1, 8, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8550), new DateTime(2024, 1, 1, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8550) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 21);

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

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 17,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 18,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 12, 9, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 19,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2750), new DateTime(2023, 12, 10, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2750) });

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

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 1, 6, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2820), new DateTime(2024, 1, 13, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate", "HotelID" },
                values: new object[] { new DateTime(2023, 12, 14, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2820), new DateTime(2023, 12, 21, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2820), 7 });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate", "HotelID" },
                values: new object[] { new DateTime(2023, 12, 14, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 12, 21, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2830), 8 });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate", "HotelID" },
                values: new object[] { new DateTime(2023, 12, 14, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 12, 21, 13, 8, 52, 930, DateTimeKind.Local).AddTicks(2830), 9 });

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

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 1,
                column: "HotelID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "HotelID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 3,
                column: "HotelID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "HotelID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 5,
                column: "HotelID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 7,
                column: "HotelID",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 8,
                column: "HotelID",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 9,
                columns: new[] { "HotelID", "RoomNo" },
                values: new object[] { 9, 202 });

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
    }
}
