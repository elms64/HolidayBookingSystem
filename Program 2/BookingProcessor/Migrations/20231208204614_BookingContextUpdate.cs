using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class BookingContextUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightBooking",
                columns: table => new
                {
                    FlightBookingID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FlightID = table.Column<int>(type: "INTEGER", nullable: false),
                    ClientID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightBooking", x => x.FlightBookingID);
                });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 1,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 16, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2047), new DateTime(2023, 12, 15, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 2,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 20, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2051), new DateTime(2023, 12, 18, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 3,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 25, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2054), new DateTime(2023, 12, 23, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 4,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 30, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2056), new DateTime(2023, 12, 28, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 5,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2024, 1, 4, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2060), new DateTime(2024, 1, 2, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 6,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2063), new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 7,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2065), new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 8,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2068), new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 9,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2071), new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 10,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2073), new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 11,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2096), new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 12,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2098), new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 13,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2101), new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 14,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2103), new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 15,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2106), new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 16,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2111), new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 17,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 18,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2116), new DateTime(2023, 12, 10, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 19,
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2118), new DateTime(2023, 12, 11, 20, 46, 14, 52, DateTimeKind.Local).AddTicks(2117) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightBooking");

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
    }
}
