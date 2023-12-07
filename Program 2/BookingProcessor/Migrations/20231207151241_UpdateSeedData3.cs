using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 1,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "2d1cb06919607ae6e07b0501995a7f6a", new DateTime(2023, 12, 7, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(6300), new Guid("2c947752-0fc2-4edf-a926-dd146f41b324") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 2,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "e1df1efcee8df7c49908b9491bcd41bb", new DateTime(2023, 12, 7, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7230), new Guid("41dfac7e-318f-4d46-b1a7-19edc08e25d2") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 3,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "e0e7ac66dbfc51f8172f29069749caee", new DateTime(2023, 12, 7, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7290), new Guid("11ac82c9-c626-488d-9177-b7a316e74997") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 4,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "bd2cdbac0b5d0d421c4e9c2b57be83d1", new DateTime(2023, 12, 7, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7330), new Guid("1ce4f6ac-07fb-469d-b61f-dc0507e4eda0") });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "OrderNumber",
                keyValue: 5,
                columns: new[] { "CheckSum", "PurchaseDate", "TransactionGUID" },
                values: new object[] { "3e3fe1365d2ad177c147d55accfb84fc", new DateTime(2023, 12, 7, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7370), new Guid("ca0ab2c8-8fa8-430c-a159-9b5f5973d355") });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 1,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 15, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7450), new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 2,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 19, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7460), new DateTime(2023, 12, 17, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 3,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 24, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7460), new DateTime(2023, 12, 22, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 4,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7470), new DateTime(2023, 12, 27, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 5,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2024, 1, 3, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7470), new DateTime(2024, 1, 1, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 6,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7470), new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 7,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7480), new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 8,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7480), new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 9,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7490), new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 10,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7490), new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 11,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7490), new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 12,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7500), new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 13,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7500), new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 14,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7500), new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 15,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7500), new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 16,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7510), new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 17,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7510), new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 18,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7520), new DateTime(2023, 12, 9, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 19,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7520), new DateTime(2023, 12, 10, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7570), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7570), new DateTime(2023, 12, 24, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 22, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7570), new DateTime(2023, 12, 29, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 27, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7580), new DateTime(2024, 1, 3, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7580), new DateTime(2024, 1, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 1, 6, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7580), new DateTime(2024, 1, 13, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7580), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7590), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7590), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7590), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 11,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7600), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 12,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7600), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 13,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7600), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 14,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7610), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 15,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7610), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 16,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7610), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 17,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7610), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 18,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7620), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 19,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7620), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 20,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7620), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 21,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7630), new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.InsertData(
                table: "Insurance",
                columns: new[] { "InsuranceID", "InsuranceType", "PricePerDay" },
                values: new object[,]
                {
                    { 6, "Presidential", 30.0 },
                    { 7, "Cheddar", 30000.0 }
                });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 24, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 12, 17, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 12, 22, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 3, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7670), new DateTime(2023, 12, 27, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7670), new DateTime(2024, 1, 1, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 1,
                column: "RoomType",
                value: "Single");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "RoomType",
                value: "Double");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "RoomType",
                value: "Single");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 6,
                column: "RoomType",
                value: "Single");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 9,
                column: "RoomType",
                value: "Double");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 11,
                column: "RoomType",
                value: "Double");

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 1,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 21, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7730), new DateTime(2023, 12, 14, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 2,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 24, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 12, 17, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 3,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 29, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 12, 22, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 4,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2024, 1, 3, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 12, 27, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 5,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7740), new DateTime(2024, 1, 1, 15, 12, 41, 555, DateTimeKind.Local).AddTicks(7740) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurance",
                keyColumn: "InsuranceID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Insurance",
                keyColumn: "InsuranceID",
                keyValue: 7);

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
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8380), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8380), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8380), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8390), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 11,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8390), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 12,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8390), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 13,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8400), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 14,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8400), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 15,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8400), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 16,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8410), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 17,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8410), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 18,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8410), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 19,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8410), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 20,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8420), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 21,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8420), new DateTime(2023, 12, 21, 14, 39, 41, 138, DateTimeKind.Local).AddTicks(8420) });

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
                column: "RoomType",
                value: "Standard");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "RoomType",
                value: "Deluxe");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "RoomType",
                value: "Standard");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 6,
                column: "RoomType",
                value: "Standard");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 9,
                column: "RoomType",
                value: "Standard");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 11,
                column: "RoomType",
                value: "Standard");

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
    }
}
