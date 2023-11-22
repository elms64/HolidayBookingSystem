using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewAirPort : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicleType",
                table: "Vehicle",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "RoomType",
                table: "Room",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "InsuranceType",
                table: "Insurance",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Postcode",
                table: "Hotel",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "HotelName",
                table: "Hotel",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Hotel",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "Hotel",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "Hotel",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "CountryID",
                table: "Hotel",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                table: "Country",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Client",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Client",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Client",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Client",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "AirportName",
                table: "Airport",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Airline",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "AirlineName",
                table: "Airline",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "HQ",
                table: "Airline",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 1,
                column: "HQ",
                value: "London, England");

            migrationBuilder.UpdateData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 2,
                column: "HQ",
                value: "France, Paris");

            migrationBuilder.UpdateData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 3,
                column: "HQ",
                value: "Moscow, Russia");

            migrationBuilder.UpdateData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 4,
                column: "HQ",
                value: "USA, LA");

            migrationBuilder.UpdateData(
                table: "Airline",
                keyColumn: "AirlineID",
                keyValue: 5,
                column: "HQ",
                value: "Japan, Tokyo");

            migrationBuilder.UpdateData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 1,
                columns: new[] { "AirportName", "CountryID" },
                values: new object[] { "Denver International Airport", 840 });

            migrationBuilder.UpdateData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 2,
                columns: new[] { "AirportName", "CountryID" },
                values: new object[] { "Dubai International Airport", 784 });

            migrationBuilder.UpdateData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 3,
                columns: new[] { "AirportName", "CountryID" },
                values: new object[] { "Beijing Internation Airport", 156 });

            migrationBuilder.UpdateData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 4,
                columns: new[] { "AirportName", "CountryID" },
                values: new object[] { "Istanbul International Airport", 792 });

            migrationBuilder.UpdateData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 5,
                columns: new[] { "AirportName", "CountryID" },
                values: new object[] { "Heathrow Airport", 826 });

            migrationBuilder.InsertData(
                table: "Airport",
                columns: new[] { "AirportID", "AirportName", "CountryID" },
                values: new object[,]
                {
                    { 6, "Indira Gandhi International Airport", 356 },
                    { 7, "Charles de Gaulle Airport", 250 },
                    { 8, "Amsterdam Airport Schiphol", 528 },
                    { 9, "Adolfo Suárez Madrid-Barajas Airport", 724 },
                    { 10, "Tokyo Haneda Airport", 392 },
                    { 11, "Frankfurt Airport", 276 },
                    { 12, "Mexico City International Airport", 484 },
                    { 13, "Soekarno-Hatta International Airport", 360 },
                    { 14, "Toronto Pearson International Airport", 124 },
                    { 15, "São Paulo/Guarulhos International Airport", 76 },
                    { 16, "Gatwick Airport", 826 }
                });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 1,
                columns: new[] { "CountryID", "PurchaseDate" },
                values: new object[] { 826, new DateTime(2023, 11, 22, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 2,
                columns: new[] { "CountryID", "PurchaseDate" },
                values: new object[] { 826, new DateTime(2023, 11, 22, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 3,
                columns: new[] { "CountryID", "PurchaseDate" },
                values: new object[] { 826, new DateTime(2023, 11, 22, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 4,
                columns: new[] { "CountryID", "PurchaseDate" },
                values: new object[] { 826, new DateTime(2023, 11, 22, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 5,
                columns: new[] { "CountryID", "PurchaseDate" },
                values: new object[] { 826, new DateTime(2023, 11, 22, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 1,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 11, 30, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9920), new DateTime(2023, 11, 29, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 2,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9924), new DateTime(2023, 12, 2, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 3,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9926), new DateTime(2023, 12, 7, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 4,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 14, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9929), new DateTime(2023, 12, 12, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 5,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9932), new DateTime(2023, 12, 17, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 1,
                column: "CountryID",
                value: 826);

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 2,
                column: "CountryID",
                value: 826);

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 3,
                column: "CountryID",
                value: 826);

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 4,
                column: "CountryID",
                value: 826);

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 5,
                column: "CountryID",
                value: 826);

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9958), new DateTime(2023, 12, 6, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9962), new DateTime(2023, 12, 9, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 7, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9964), new DateTime(2023, 12, 14, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9967), new DateTime(2023, 12, 19, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9969), new DateTime(2023, 12, 24, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 6, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9991), new DateTime(2023, 11, 29, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9993), new DateTime(2023, 12, 2, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 14, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9995), new DateTime(2023, 12, 7, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 12, 12, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 24, 16, 45, 56, 656, DateTimeKind.Local).AddTicks(1), new DateTime(2023, 12, 17, 16, 45, 56, 656, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 1,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 6, 16, 45, 56, 656, DateTimeKind.Local).AddTicks(33), new DateTime(2023, 11, 29, 16, 45, 56, 656, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 2,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 45, 56, 656, DateTimeKind.Local).AddTicks(36), new DateTime(2023, 12, 2, 16, 45, 56, 656, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 3,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 14, 16, 45, 56, 656, DateTimeKind.Local).AddTicks(38), new DateTime(2023, 12, 7, 16, 45, 56, 656, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 4,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 45, 56, 656, DateTimeKind.Local).AddTicks(40), new DateTime(2023, 12, 12, 16, 45, 56, 656, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 5,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 24, 16, 45, 56, 656, DateTimeKind.Local).AddTicks(43), new DateTime(2023, 12, 17, 16, 45, 56, 656, DateTimeKind.Local).AddTicks(42) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 16);

            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "HQ",
                table: "Airline");

            migrationBuilder.AlterColumn<string>(
                name: "VehicleType",
                table: "Vehicle",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoomType",
                table: "Room",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InsuranceType",
                table: "Insurance",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Postcode",
                table: "Hotel",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HotelName",
                table: "Hotel",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Hotel",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "Hotel",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "Hotel",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                table: "Country",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Client",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Client",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Client",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Client",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AirportName",
                table: "Airport",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Airline",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AirlineName",
                table: "Airline",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 1,
                columns: new[] { "AirportName", "CountryID" },
                values: new object[] { "Example Airport 1", 1 });

            migrationBuilder.UpdateData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 2,
                columns: new[] { "AirportName", "CountryID" },
                values: new object[] { "Example Airport 2", 2 });

            migrationBuilder.UpdateData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 3,
                columns: new[] { "AirportName", "CountryID" },
                values: new object[] { "Example Airport 3", 3 });

            migrationBuilder.UpdateData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 4,
                columns: new[] { "AirportName", "CountryID" },
                values: new object[] { "Example Airport 4", 4 });

            migrationBuilder.UpdateData(
                table: "Airport",
                keyColumn: "AirportID",
                keyValue: 5,
                columns: new[] { "AirportName", "CountryID" },
                values: new object[] { "Example Airport 5", 5 });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 1,
                columns: new[] { "CountryID", "PurchaseDate" },
                values: new object[] { 1, new DateTime(2023, 11, 14, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 2,
                columns: new[] { "CountryID", "PurchaseDate" },
                values: new object[] { 2, new DateTime(2023, 11, 14, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 3,
                columns: new[] { "CountryID", "PurchaseDate" },
                values: new object[] { 3, new DateTime(2023, 11, 14, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 4,
                columns: new[] { "CountryID", "PurchaseDate" },
                values: new object[] { 4, new DateTime(2023, 11, 14, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 5,
                columns: new[] { "CountryID", "PurchaseDate" },
                values: new object[] { 5, new DateTime(2023, 11, 14, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 1,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5270), new DateTime(2023, 11, 21, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 2,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 11, 26, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 11, 24, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 3,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 1, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 11, 29, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 4,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 6, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 12, 4, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 5,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 12, 9, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 11, 21, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 11, 28, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 11, 24, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 12, 1, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 11, 29, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 12, 6, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 12, 11, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "HotelBooking",
                keyColumn: "HotelBookingID",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2023, 12, 9, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 12, 16, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 28, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5340), new DateTime(2023, 11, 21, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 1, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5340), new DateTime(2023, 11, 24, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 6, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5350), new DateTime(2023, 11, 29, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5350), new DateTime(2023, 12, 4, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "InsuranceBooking",
                keyColumn: "InsuranceBookingID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 16, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5350), new DateTime(2023, 12, 9, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 1,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 11, 28, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 11, 21, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 2,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 1, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 11, 24, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 3,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 6, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 11, 29, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 4,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 12, 4, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "VehicleBooking",
                keyColumn: "VehicleBookingID",
                keyValue: 5,
                columns: new[] { "DropOffDate", "PickUpDate" },
                values: new object[] { new DateTime(2023, 12, 16, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5400), new DateTime(2023, 12, 9, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5400) });
        }
    }
}
