using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airline",
                columns: table => new
                {
                    AirlineID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AirlineName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airline", x => x.AirlineID);
                });

            migrationBuilder.CreateTable(
                name: "Airport",
                columns: table => new
                {
                    AirportID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryID = table.Column<int>(type: "INTEGER", nullable: false),
                    AirportName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airport", x => x.AirportID);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserID = table.Column<int>(type: "INTEGER", nullable: false),
                    HotelID = table.Column<int>(type: "INTEGER", nullable: false),
                    DestinationID = table.Column<int>(type: "INTEGER", nullable: false),
                    FlightID = table.Column<int>(type: "INTEGER", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VehicleHireID = table.Column<int>(type: "INTEGER", nullable: false),
                    InsuranceID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingID);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryName = table.Column<string>(type: "TEXT", nullable: false),
                    Climate = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "Destination",
                columns: table => new
                {
                    DestinationID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RegionID = table.Column<int>(type: "INTEGER", nullable: false),
                    DestinationName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination", x => x.DestinationID);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                columns: table => new
                {
                    FlightID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DepartureAirportID = table.Column<int>(type: "INTEGER", nullable: false),
                    ArrivalAirportID = table.Column<int>(type: "INTEGER", nullable: false),
                    AirlineID = table.Column<int>(type: "INTEGER", nullable: false),
                    BookedSeats = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxSeats = table.Column<int>(type: "INTEGER", nullable: false),
                    DepartureDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ArrivalDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.FlightID);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    HotelID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HotelName = table.Column<string>(type: "TEXT", nullable: false),
                    DestinationID = table.Column<int>(type: "INTEGER", nullable: false),
                    AddressLine1 = table.Column<string>(type: "TEXT", nullable: false),
                    AddressLine2 = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Postcode = table.Column<string>(type: "TEXT", nullable: false),
                    Telephone = table.Column<int>(type: "INTEGER", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.HotelID);
                });

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    InsuranceID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PlanID = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PremiumCost = table.Column<decimal>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.InsuranceID);
                });

            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    PlanID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CoverType = table.Column<string>(type: "TEXT", nullable: false),
                    Cost = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => x.PlanID);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    RegionID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryID = table.Column<int>(type: "INTEGER", nullable: false),
                    RegionName = table.Column<string>(type: "TEXT", nullable: false),
                    TimeZone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.RegionID);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    RoomID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HotelID = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomType = table.Column<string>(type: "TEXT", nullable: false),
                    RoomNo = table.Column<int>(type: "INTEGER", nullable: false),
                    PricePerNight = table.Column<decimal>(type: "TEXT", nullable: false),
                    Available = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Telephone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehicleID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BodyType = table.Column<string>(type: "TEXT", nullable: false),
                    Make = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    HireRate = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleHire",
                columns: table => new
                {
                    VehicleHireID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehicleID = table.Column<int>(type: "INTEGER", nullable: false),
                    UserID = table.Column<int>(type: "INTEGER", nullable: false),
                    CollectionDepot = table.Column<string>(type: "TEXT", nullable: false),
                    ReturnDepot = table.Column<string>(type: "TEXT", nullable: false),
                    CollectionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DailyRate = table.Column<decimal>(type: "TEXT", nullable: false),
                    RentalStatus = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleHire", x => x.VehicleHireID);
                });

            migrationBuilder.InsertData(
                table: "Airline",
                columns: new[] { "AirlineID", "AirlineName" },
                values: new object[,]
                {
                    { 1, "EasyJet" },
                    { 2, "British Airways" }
                });

            migrationBuilder.InsertData(
                table: "Airport",
                columns: new[] { "AirportID", "AirportName", "CountryID" },
                values: new object[,]
                {
                    { 1, "Gatwick", 0 },
                    { 2, "Luton", 0 }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingID", "DestinationID", "FlightID", "HotelID", "InsuranceID", "PurchaseDate", "UserID", "VehicleHireID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, 2, 2, 2, 2, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryID", "Climate", "CountryName" },
                values: new object[,]
                {
                    { 1, "Temperate", "England" },
                    { 2, "Incredibly Unbelievably Rainy", "Wales" }
                });

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "DestinationID", "DestinationName", "RegionID" },
                values: new object[,]
                {
                    { 1, "London", 1 },
                    { 2, "Cornwall", 1 },
                    { 3, "Dubai", 2 }
                });

            migrationBuilder.InsertData(
                table: "Flight",
                columns: new[] { "FlightID", "AirlineID", "ArrivalAirportID", "ArrivalDateTime", "BookedSeats", "DepartureAirportID", "DepartureDateTime", "MaxSeats" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 11, 8, 17, 26, 11, 0, DateTimeKind.Unspecified), 5, 1, new DateTime(2023, 12, 8, 17, 26, 11, 0, DateTimeKind.Unspecified), 100 },
                    { 2, 2, 1, new DateTime(2024, 1, 8, 17, 26, 11, 0, DateTimeKind.Unspecified), 5, 1, new DateTime(2024, 1, 8, 17, 26, 11, 0, DateTimeKind.Unspecified), 100 }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "HotelID", "AddressLine1", "AddressLine2", "City", "DestinationID", "HotelName", "Postcode", "Rating", "Telephone" },
                values: new object[,]
                {
                    { 1, "SampleAddressLine1", "SampleAddressLine2", "Fleet", 1, "The Lismoyne", "GU51 4HG", 4, 1252810170 },
                    { 2, "SampleAddress2Line1", "SampleAddress2Line2", "Farnborough", 2, "The Four Seasons", "GU52 3EB", 5, 1252810171 }
                });

            migrationBuilder.InsertData(
                table: "Insurance",
                columns: new[] { "InsuranceID", "Active", "EndDate", "PlanID", "PremiumCost", "StartDate" },
                values: new object[] { 1, true, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100m, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "PlanID", "Cost", "CoverType" },
                values: new object[,]
                {
                    { 1, 100m, "Comprehensive" },
                    { 2, 100m, "Comprehensive" }
                });

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "RegionID", "CountryID", "RegionName", "TimeZone" },
                values: new object[] { 1, 1, "London", "GMT" });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomID", "Available", "HotelID", "PricePerNight", "RoomNo", "RoomType" },
                values: new object[] { 1, true, 1, 100m, 69, "Double" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "BirthDate", "Email", "FirstName", "LastName", "Password", "Telephone", "Username" },
                values: new object[] { 1, new DateTime(2003, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kloakk2@gmail.com", "Alex", "Lovelock", "Admin1", "01252810170", "Alex" });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "VehicleID", "BodyType", "HireRate", "Make", "Model" },
                values: new object[] { 1, "Coupe", 500m, "BMW", "3 Series" });

            migrationBuilder.InsertData(
                table: "VehicleHire",
                columns: new[] { "VehicleHireID", "CollectionDate", "CollectionDepot", "DailyRate", "RentalStatus", "ReturnDate", "ReturnDepot", "UserID", "VehicleID" },
                values: new object[] { 1, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "FCoT", 600m, "Unavailable", new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "FCoT", 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airline");

            migrationBuilder.DropTable(
                name: "Airport");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Destination");

            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "Plan");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "VehicleHire");
        }
    }
}
