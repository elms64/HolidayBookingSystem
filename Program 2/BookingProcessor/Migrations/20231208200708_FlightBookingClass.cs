using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class FlightBookingClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 1,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 16, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5383), new DateTime(2023, 12, 15, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 2,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 20, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5387), new DateTime(2023, 12, 18, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 3,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 25, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 12, 23, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 4,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 30, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5393), new DateTime(2023, 12, 28, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 5,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2024, 1, 4, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5396), new DateTime(2024, 1, 2, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 6,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5438), new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 7,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5441), new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 8,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5444), new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 9,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5446), new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 10,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5449), new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 11,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5453), new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 12,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5455), new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 13,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5458), new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 14,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5461), new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 15,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5463), new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 16,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5466), new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 17,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5469), new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 18,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5471), new DateTime(2023, 12, 10, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 19,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5474), new DateTime(2023, 12, 11, 20, 7, 8, 441, DateTimeKind.Local).AddTicks(5473) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
