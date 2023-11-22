using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewAirPort2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 4, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5046), new DateTime(2023, 12, 2, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5045) });

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
                columns: new[] { "ArrivalDateTime", "DepartureDateTime" },
                values: new object[] { new DateTime(2023, 12, 19, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5054), new DateTime(2023, 12, 17, 17, 18, 26, 48, DateTimeKind.Local).AddTicks(5053) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 22, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 22, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 3,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 22, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 4,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 22, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingID",
                keyValue: 5,
                column: "PurchaseDate",
                value: new DateTime(2023, 11, 22, 16, 45, 56, 655, DateTimeKind.Local).AddTicks(9882));

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
    }
}
