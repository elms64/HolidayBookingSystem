using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class BookingStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookingStatus",
                table: "VehicleBooking",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BookingStatus",
                table: "InsuranceBooking",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BookingStatus",
                table: "HotelBooking",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 1,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 16, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7310), new DateTime(2023, 12, 15, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 2,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7310), new DateTime(2023, 12, 18, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 3,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 25, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7320), new DateTime(2023, 12, 23, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 4,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 30, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7320), new DateTime(2023, 12, 28, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 5,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 1, 2, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 6,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7320), new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 7,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7330), new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 8,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7330), new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 9,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7330), new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 10,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7340), new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 11,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7340), new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 12,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7340), new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 13,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7350), new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 14,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7350), new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 15,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7350), new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 16,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7350), new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 17,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7360), new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 18,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7360), new DateTime(2023, 12, 10, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 19,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7360), new DateTime(2023, 12, 11, 11, 55, 55, 260, DateTimeKind.Local).AddTicks(7360) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingStatus",
                table: "VehicleBooking");

            migrationBuilder.DropColumn(
                name: "BookingStatus",
                table: "InsuranceBooking");

            migrationBuilder.DropColumn(
                name: "BookingStatus",
                table: "HotelBooking");

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 1,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 16, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2590), new DateTime(2023, 12, 15, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 2,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2590), new DateTime(2023, 12, 18, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 3,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 25, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2600), new DateTime(2023, 12, 23, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 4,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 30, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2600), new DateTime(2023, 12, 28, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 5,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2600), new DateTime(2024, 1, 2, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 6,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2600), new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 7,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2610), new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 8,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2610), new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 9,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2610), new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 10,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2620), new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 11,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2620), new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 12,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2620), new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 13,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 14,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 15,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 16,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 17,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2640), new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 18,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2640), new DateTime(2023, 12, 10, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 19,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2640), new DateTime(2023, 12, 11, 11, 37, 31, 293, DateTimeKind.Local).AddTicks(2640) });
        }
    }
}
