using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class FlightCost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FlightCost",
                table: "Flight",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 1,
                column: "FlightCost",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "FlightID",
                keyValue: 2,
                column: "FlightCost",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlightCost",
                table: "Flight");
        }
    }
}
