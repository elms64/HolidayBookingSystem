using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class updateFlight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecificFlight");

            migrationBuilder.RenameColumn(
                name: "SpecificFlightID",
                table: "Flight",
                newName: "MaxSeats");

            migrationBuilder.RenameColumn(
                name: "AirportID",
                table: "Flight",
                newName: "DepartureAirportID");

            migrationBuilder.AddColumn<int>(
                name: "ArrivalAirportID",
                table: "Flight",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalDateTime",
                table: "Flight",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "BookedSeats",
                table: "Flight",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DepartureDateTime",
                table: "Flight",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalAirportID",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "ArrivalDateTime",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "BookedSeats",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "DepartureDateTime",
                table: "Flight");

            migrationBuilder.RenameColumn(
                name: "MaxSeats",
                table: "Flight",
                newName: "SpecificFlightID");

            migrationBuilder.RenameColumn(
                name: "DepartureAirportID",
                table: "Flight",
                newName: "AirportID");

            migrationBuilder.CreateTable(
                name: "SpecificFlight",
                columns: table => new
                {
                    SpecificFlightID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AirlineID = table.Column<int>(type: "INTEGER", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FlightID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificFlight", x => x.SpecificFlightID);
                });
        }
    }
}
