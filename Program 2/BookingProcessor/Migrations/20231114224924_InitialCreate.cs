using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    AirlineName = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<double>(type: "REAL", nullable: false)
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
                    HotelBookingID = table.Column<int>(type: "INTEGER", nullable: false),
                    CountryID = table.Column<int>(type: "INTEGER", nullable: false),
                    FlightID = table.Column<int>(type: "INTEGER", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VehicleBookingID = table.Column<int>(type: "INTEGER", nullable: false),
                    ClientID = table.Column<int>(type: "INTEGER", nullable: false),
                    InsuranceBookingID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingID);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryID);
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
                    ArrivalDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FlightCost = table.Column<int>(type: "INTEGER", nullable: false)
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
                    AddressLine1 = table.Column<string>(type: "TEXT", nullable: false),
                    AddressLine2 = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Postcode = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Rating = table.Column<double>(type: "REAL", nullable: false),
                    RoomCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.HotelID);
                });

            migrationBuilder.CreateTable(
                name: "HotelBooking",
                columns: table => new
                {
                    HotelBookingID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HotelID = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomID = table.Column<int>(type: "INTEGER", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelBooking", x => x.HotelBookingID);
                });

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    InsuranceID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InsuranceType = table.Column<string>(type: "TEXT", nullable: false),
                    PricePerDay = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.InsuranceID);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceBooking",
                columns: table => new
                {
                    InsuranceBookingID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InsuranceID = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceBooking", x => x.InsuranceBookingID);
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
                    PricePerNight = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehicleID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehicleType = table.Column<string>(type: "TEXT", nullable: false),
                    PricePerDay = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBooking",
                columns: table => new
                {
                    VehicleBookingID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehicleID = table.Column<int>(type: "INTEGER", nullable: false),
                    PickUpDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DropOffDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBooking", x => x.VehicleBookingID);
                });

            migrationBuilder.InsertData(
                table: "Airline",
                columns: new[] { "AirlineID", "AirlineName", "PhoneNumber", "Rating" },
                values: new object[,]
                {
                    { 1, "Example Airline 1", "123-456-7890", 4.5 },
                    { 2, "Example Airline 2", "987-654-3210", 3.7999999999999998 },
                    { 3, "Example Airline 3", "555-123-4567", 4.2000000000000002 },
                    { 4, "Example Airline 4", "333-777-8888", 3.5 },
                    { 5, "Example Airline 5", "111-222-3333", 4.0 }
                });

            migrationBuilder.InsertData(
                table: "Airport",
                columns: new[] { "AirportID", "AirportName", "CountryID" },
                values: new object[,]
                {
                    { 1, "Example Airport 1", 1 },
                    { 2, "Example Airport 2", 2 },
                    { 3, "Example Airport 3", 3 },
                    { 4, "Example Airport 4", 4 },
                    { 5, "Example Airport 5", 5 }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingID", "ClientID", "CountryID", "FlightID", "HotelBookingID", "InsuranceBookingID", "PurchaseDate", "VehicleBookingID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, 1, new DateTime(2023, 11, 14, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5210), 1 },
                    { 2, 2, 2, 2, 2, 2, new DateTime(2023, 11, 14, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5230), 2 },
                    { 3, 3, 3, 3, 3, 3, new DateTime(2023, 11, 14, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5240), 3 },
                    { 4, 4, 4, 4, 4, 4, new DateTime(2023, 11, 14, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5240), 4 },
                    { 5, 5, 5, 5, 5, 5, new DateTime(2023, 11, 14, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5240), 5 }
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientID", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John", "Doe", "123-456-7890" },
                    { 2, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "Jane", "Smith", "987-654-3210" },
                    { 3, new DateTime(1992, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice.johnson@example.com", "Alice", "Johnson", "555-123-4567" },
                    { 4, new DateTime(1980, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.anderson@example.com", "Bob", "Anderson", "333-777-8888" },
                    { 5, new DateTime(1988, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "eva.williams@example.com", "Eva", "Williams", "111-222-3333" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryID", "CountryName" },
                values: new object[,]
                {
                    { 4, "Afghanistan" },
                    { 8, "Albania" },
                    { 10, "Antarctica" },
                    { 12, "Algeria" },
                    { 16, "American Samoa" },
                    { 20, "Andorra" },
                    { 24, "Angola" },
                    { 28, "Antigua and Barbuda" },
                    { 31, "Azerbaijan" },
                    { 32, "Argentina" },
                    { 36, "Australia" },
                    { 40, "Austria" },
                    { 44, "Bahamas" },
                    { 48, "Bahrain" },
                    { 50, "Bangladesh" },
                    { 51, "Armenia" },
                    { 52, "Barbados" },
                    { 56, "Belgium" },
                    { 60, "Bermuda" },
                    { 64, "Bhutan" },
                    { 68, "Bolivia, Plurinational State of" },
                    { 70, "Bosnia and Herzegovina" },
                    { 72, "Botswana" },
                    { 74, "Bouvet Island" },
                    { 76, "Brazil" },
                    { 84, "Belize" },
                    { 86, "British Indian Ocean Territory" },
                    { 90, "Solomon Islands" },
                    { 92, "Virgin Islands, British" },
                    { 96, "Brunei Darussalam" },
                    { 100, "Bulgaria" },
                    { 104, "Myanmar" },
                    { 108, "Burundi" },
                    { 112, "Belarus" },
                    { 116, "Cambodia" },
                    { 120, "Cameroon" },
                    { 124, "Canada" },
                    { 132, "Cabo Verde" },
                    { 136, "Cayman Islands" },
                    { 140, "Central African Republic" },
                    { 144, "Sri Lanka" },
                    { 148, "Chad" },
                    { 152, "Chile" },
                    { 156, "China" },
                    { 158, "Taiwan, Province of China" },
                    { 162, "Christmas Island" },
                    { 166, "Cocos (Keeling) Islands" },
                    { 170, "Colombia" },
                    { 174, "Comoros" },
                    { 175, "Mayotte" },
                    { 178, "Congo" },
                    { 180, "Congo, the Democratic Republic of the" },
                    { 184, "Cook Islands" },
                    { 188, "Costa Rica" },
                    { 191, "Croatia" },
                    { 192, "Cuba" },
                    { 196, "Cyprus" },
                    { 203, "Czechia" },
                    { 204, "Benin" },
                    { 208, "Denmark" },
                    { 212, "Dominica" },
                    { 214, "Dominican Republic" },
                    { 218, "Ecuador" },
                    { 222, "El Salvador" },
                    { 226, "Equatorial Guinea" },
                    { 231, "Ethiopia" },
                    { 232, "Eritrea" },
                    { 233, "Estonia" },
                    { 234, "Faroe Islands" },
                    { 238, "Falkland Islands (Malvinas)" },
                    { 239, "South Georgia and the South Sandwich Islands" },
                    { 242, "Fiji" },
                    { 246, "Finland" },
                    { 248, "Åland Islands" },
                    { 250, "France" },
                    { 254, "French Guiana" },
                    { 258, "French Polynesia" },
                    { 260, "French Southern Territories" },
                    { 262, "Djibouti" },
                    { 266, "Gabon" },
                    { 268, "Georgia" },
                    { 270, "Gambia" },
                    { 275, "Palestine, State of" },
                    { 276, "Germany" },
                    { 288, "Ghana" },
                    { 292, "Gibraltar" },
                    { 296, "Kiribati" },
                    { 300, "Greece" },
                    { 304, "Greenland" },
                    { 308, "Grenada" },
                    { 312, "Guadeloupe" },
                    { 316, "Guam" },
                    { 320, "Guatemala" },
                    { 324, "Guinea" },
                    { 328, "Guyana" },
                    { 332, "Haiti" },
                    { 334, "Heard Island and McDonald Islands" },
                    { 336, "Holy See" },
                    { 340, "Honduras" },
                    { 344, "Hong Kong" },
                    { 348, "Hungary" },
                    { 352, "Iceland" },
                    { 356, "India" },
                    { 360, "Indonesia" },
                    { 364, "Iran, Islamic Republic of" },
                    { 368, "Iraq" },
                    { 372, "Ireland" },
                    { 376, "Israel" },
                    { 380, "Italy" },
                    { 384, "Côte d'Ivoire" },
                    { 388, "Jamaica" },
                    { 392, "Japan" },
                    { 398, "Kazakhstan" },
                    { 400, "Jordan" },
                    { 404, "Kenya" },
                    { 408, "Korea, Democratic People's Republic of" },
                    { 410, "Korea, Republic of" },
                    { 414, "Kuwait" },
                    { 417, "Kyrgyzstan" },
                    { 418, "Lao People's Democratic Republic" },
                    { 422, "Lebanon" },
                    { 426, "Lesotho" },
                    { 428, "Latvia" },
                    { 430, "Liberia" },
                    { 434, "Libya" },
                    { 438, "Liechtenstein" },
                    { 440, "Lithuania" },
                    { 442, "Luxembourg" },
                    { 446, "Macao" },
                    { 450, "Madagascar" },
                    { 454, "Malawi" },
                    { 458, "Malaysia" },
                    { 462, "Maldives" },
                    { 466, "Mali" },
                    { 470, "Malta" },
                    { 474, "Martinique" },
                    { 478, "Mauritania" },
                    { 480, "Mauritius" },
                    { 484, "Mexico" },
                    { 492, "Monaco" },
                    { 496, "Mongolia" },
                    { 498, "Moldova, Republic of" },
                    { 499, "Montenegro" },
                    { 500, "Montserrat" },
                    { 504, "Morocco" },
                    { 508, "Mozambique" },
                    { 512, "Oman" },
                    { 516, "Namibia" },
                    { 520, "Nauru" },
                    { 524, "Nepal" },
                    { 528, "Netherlands" },
                    { 531, "Curaçao" },
                    { 533, "Aruba" },
                    { 534, "Sint Maarten (Dutch part)" },
                    { 535, "Bonaire, Sint Eustatius and Saba" },
                    { 540, "New Caledonia" },
                    { 548, "Vanuatu" },
                    { 554, "New Zealand" },
                    { 558, "Nicaragua" },
                    { 562, "Niger" },
                    { 566, "Nigeria" },
                    { 570, "Niue" },
                    { 574, "Norfolk Island" },
                    { 578, "Norway" },
                    { 580, "Northern Mariana Islands" },
                    { 581, "United States Minor Outlying Islands" },
                    { 583, "Micronesia, Federated States of" },
                    { 584, "Marshall Islands" },
                    { 585, "Palau" },
                    { 586, "Pakistan" },
                    { 591, "Panama" },
                    { 598, "Papua New Guinea" },
                    { 600, "Paraguay" },
                    { 604, "Peru" },
                    { 608, "Philippines" },
                    { 612, "Pitcairn" },
                    { 616, "Poland" },
                    { 620, "Portugal" },
                    { 624, "Guinea-Bissau" },
                    { 626, "Timor-Leste" },
                    { 630, "Puerto Rico" },
                    { 634, "Qatar" },
                    { 638, "Réunion" },
                    { 642, "Romania" },
                    { 643, "Russian Federation" },
                    { 646, "Rwanda" },
                    { 652, "Saint Barthélemy" },
                    { 654, "Saint Helena, Ascension and Tristan da Cunha" },
                    { 659, "Saint Kitts and Nevis" },
                    { 660, "Anguilla" },
                    { 662, "Saint Lucia" },
                    { 663, "Saint Martin (French part)" },
                    { 666, "Saint Pierre and Miquelon" },
                    { 670, "Saint Vincent and the Grenadines" },
                    { 674, "San Marino" },
                    { 678, "Sao Tome and Principe" },
                    { 682, "Saudi Arabia" },
                    { 686, "Senegal" },
                    { 688, "Serbia" },
                    { 690, "Seychelles" },
                    { 694, "Sierra Leone" },
                    { 702, "Singapore" },
                    { 703, "Slovakia" },
                    { 704, "Viet Nam" },
                    { 705, "Slovenia" },
                    { 706, "Somalia" },
                    { 710, "South Africa" },
                    { 716, "Zimbabwe" },
                    { 724, "Spain" },
                    { 728, "South Sudan" },
                    { 729, "Sudan" },
                    { 732, "Western Sahara" },
                    { 740, "Suriname" },
                    { 744, "Svalbard and Jan Mayen" },
                    { 748, "Eswatini" },
                    { 752, "Sweden" },
                    { 756, "Switzerland" },
                    { 760, "Syrian Arab Republic" },
                    { 762, "Tajikistan" },
                    { 764, "Thailand" },
                    { 768, "Togo" },
                    { 772, "Tokelau" },
                    { 776, "Tonga" },
                    { 780, "Trinidad and Tobago" },
                    { 784, "United Arab Emirates" },
                    { 788, "Tunisia" },
                    { 792, "Turkey" },
                    { 795, "Turkmenistan" },
                    { 796, "Turks and Caicos Islands" },
                    { 798, "Tuvalu" },
                    { 800, "Uganda" },
                    { 804, "Ukraine" },
                    { 807, "North Macedonia" },
                    { 818, "Egypt" },
                    { 826, "United Kingdom of Great Britain and Northern Ireland" },
                    { 831, "Guernsey" },
                    { 832, "Jersey" },
                    { 833, "Isle of Man" },
                    { 834, "Tanzania, United Republic of" },
                    { 840, "United States of America" },
                    { 850, "Virgin Islands, U.S." },
                    { 854, "Burkina Faso" },
                    { 858, "Uruguay" },
                    { 860, "Uzbekistan" },
                    { 862, "Venezuela, Bolivarian Republic of" },
                    { 876, "Wallis and Futuna" },
                    { 882, "Samoa" },
                    { 887, "Yemen" },
                    { 894, "Zambia" }
                });

            migrationBuilder.InsertData(
                table: "Flight",
                columns: new[] { "FlightID", "AirlineID", "ArrivalAirportID", "ArrivalDateTime", "BookedSeats", "DepartureAirportID", "DepartureDateTime", "FlightCost", "MaxSeats" },
                values: new object[,]
                {
                    { 1, 1, 2, new DateTime(2023, 11, 22, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5270), 50, 1, new DateTime(2023, 11, 21, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5270), 500, 100 },
                    { 2, 2, 3, new DateTime(2023, 11, 26, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280), 30, 2, new DateTime(2023, 11, 24, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280), 450, 80 },
                    { 3, 3, 4, new DateTime(2023, 12, 1, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280), 70, 3, new DateTime(2023, 11, 29, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280), 600, 120 },
                    { 4, 4, 5, new DateTime(2023, 12, 6, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280), 40, 4, new DateTime(2023, 12, 4, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280), 550, 100 },
                    { 5, 5, 1, new DateTime(2023, 12, 11, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280), 60, 5, new DateTime(2023, 12, 9, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5280), 480, 80 }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "HotelID", "AddressLine1", "AddressLine2", "City", "HotelName", "PhoneNumber", "Postcode", "Rating", "RoomCount" },
                values: new object[,]
                {
                    { 1, "123 Main St", "Apt 45", "Cityville", "Example Hotel 1", 5551234, "12345", 4.0, 50 },
                    { 2, "456 Oak St", "Suite 22", "Townsville", "Example Hotel 2", 5555678, "67890", 3.5, 40 },
                    { 3, "789 Pine St", "Unit 33", "Villagetown", "Example Hotel 3", 5559999, "10111", 4.2000000000000002, 60 },
                    { 4, "101 Cedar St", "Apt 10", "Mountainview", "Example Hotel 4", 5554321, "54321", 3.7999999999999998, 45 },
                    { 5, "202 Birch St", "Suite 5", "Laketown", "Example Hotel 5", 5551111, "87654", 4.5, 55 }
                });

            migrationBuilder.InsertData(
                table: "HotelBooking",
                columns: new[] { "HotelBookingID", "CheckInDate", "CheckOutDate", "HotelID", "RoomID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 21, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 11, 28, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5310), 1, 1 },
                    { 2, new DateTime(2023, 11, 24, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 12, 1, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5310), 2, 2 },
                    { 3, new DateTime(2023, 11, 29, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 12, 6, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5320), 3, 3 },
                    { 4, new DateTime(2023, 12, 4, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 12, 11, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5320), 4, 4 },
                    { 5, new DateTime(2023, 12, 9, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 12, 16, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5320), 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Insurance",
                columns: new[] { "InsuranceID", "InsuranceType", "PricePerDay" },
                values: new object[,]
                {
                    { 1, "Basic", 10.5 },
                    { 2, "Standard", 15.75 },
                    { 3, "Premium", 20.0 },
                    { 4, "Extended", 25.5 },
                    { 5, "Deluxe", 30.0 }
                });

            migrationBuilder.InsertData(
                table: "InsuranceBooking",
                columns: new[] { "InsuranceBookingID", "EndDate", "InsuranceID", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 28, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5340), 1, new DateTime(2023, 11, 21, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5340) },
                    { 2, new DateTime(2023, 12, 1, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5340), 2, new DateTime(2023, 11, 24, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5340) },
                    { 3, new DateTime(2023, 12, 6, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5350), 3, new DateTime(2023, 11, 29, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5350) },
                    { 4, new DateTime(2023, 12, 11, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5350), 4, new DateTime(2023, 12, 4, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5350) },
                    { 5, new DateTime(2023, 12, 16, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5350), 5, new DateTime(2023, 12, 9, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5350) }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomID", "HotelID", "PricePerNight", "RoomNo", "RoomType" },
                values: new object[,]
                {
                    { 1, 1, 100m, 101, "Standard" },
                    { 2, 2, 150m, 201, "Deluxe" },
                    { 3, 3, 200m, 301, "Suite" },
                    { 4, 4, 110m, 102, "Standard" },
                    { 5, 5, 180m, 202, "Suite" }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "VehicleID", "PricePerDay", "VehicleType" },
                values: new object[,]
                {
                    { 1, 45.0m, "Compact Car" },
                    { 2, 60.0m, "SUV" },
                    { 3, 75.0m, "Van" },
                    { 4, 100.0m, "Luxury Car" },
                    { 5, 30.0m, "Motorcycle" }
                });

            migrationBuilder.InsertData(
                table: "VehicleBooking",
                columns: new[] { "VehicleBookingID", "DropOffDate", "PickUpDate", "VehicleID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 28, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 11, 21, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390), 1 },
                    { 2, new DateTime(2023, 12, 1, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 11, 24, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390), 2 },
                    { 3, new DateTime(2023, 12, 6, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 11, 29, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390), 3 },
                    { 4, new DateTime(2023, 12, 11, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 12, 4, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5390), 4 },
                    { 5, new DateTime(2023, 12, 16, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5400), new DateTime(2023, 12, 9, 22, 49, 24, 135, DateTimeKind.Local).AddTicks(5400), 5 }
                });
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
                name: "Client");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "HotelBooking");

            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "InsuranceBooking");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "VehicleBooking");
        }
    }
}
