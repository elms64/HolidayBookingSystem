// GitHub Authors: @Kloakk, @elms64 and @dlawlor2408

/* Initializes the database with some example data for testing.
 * The data structure uses the following DateTime format:      YYYY MM DD  HH MM SS     
                                                              (2023,11,08, 17,26,11) */

// System Libraries and Packages
using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using BookingProcessor;
using System.Text.Json;

public class SeedData
{
    public static void Initialize(ModelBuilder modelBuilder)
    {
        // Airline Seed Data
        modelBuilder.Entity<Airline>().HasData(
        new Airline { AirlineID = 1, AirlineName = "Ryanair", PhoneNumber = "123-456-7890", Rating = 4.5, HQ = "London, England" },
        new Airline { AirlineID = 2, AirlineName = "Easyjet", PhoneNumber = "987-654-3210", Rating = 3.8, HQ = "Paris, France" },
        new Airline { AirlineID = 3, AirlineName = "British Airways", PhoneNumber = "555-123-4567", Rating = 4.2, HQ = "Moscow, Russia" },
        new Airline { AirlineID = 4, AirlineName = "Tui Airways", PhoneNumber = "333-777-8888", Rating = 3.5, HQ = "LA, USA" },
        new Airline { AirlineID = 5, AirlineName = "Virgin Atlantic", PhoneNumber = "111-222-3333", Rating = 4.0, HQ = "Japan, Tokyo" }
        );

        // @dlawlor2408
        // Airport Seed Data
   
         // @dlawlor2408
// Airport Seed Data
modelBuilder.Entity<Airport>().HasData(
    new Airport { AirportID = 1, CountryID = 840, AirportName = "Denver International Airport" }, //USA
    new Airport { AirportID = 2, CountryID = 784, AirportName = "Dubai International Airport" },  //Dubai
    new Airport { AirportID = 3, CountryID = 156, AirportName = "Beijing Internation Airport" },  //China
    new Airport { AirportID = 4, CountryID = 792, AirportName = "Istanbul International Airport" }, //Turkey
    new Airport { AirportID = 5, CountryID = 826, AirportName = "Heathrow Airport" }, //UK
    new Airport { AirportID = 6, CountryID = 356, AirportName = "Indira Gandhi International Airport" }, //India
    new Airport { AirportID = 7, CountryID = 250, AirportName = "Charles de Gaulle Airport" }, //France
    new Airport { AirportID = 8, CountryID = 528, AirportName = "Amsterdam Airport Schiphol" }, //Amsterdam
    new Airport { AirportID = 9, CountryID = 724, AirportName = "Adolfo Suárez Madrid-Barajas Airport" },//Spain
    new Airport { AirportID = 10, CountryID = 392, AirportName = "Tokyo Haneda Airport" }, //Jpn
    new Airport { AirportID = 11, CountryID = 276, AirportName = "Frankfurt Airport" }, //Germany
    new Airport { AirportID = 12, CountryID = 484, AirportName = "Mexico City International Airport" }, //Mexico
    new Airport { AirportID = 13, CountryID = 360, AirportName = "Soekarno-Hatta International Airport" }, //Indonesia
    new Airport { AirportID = 14, CountryID = 124, AirportName = "Toronto Pearson International Airport" }, //Canada
    new Airport { AirportID = 15, CountryID = 76, AirportName = "São Paulo/Guarulhos International Airport" }, //Brazil
    new Airport { AirportID = 16, CountryID = 826, AirportName = "Gatwick Airport" }, //UK
    new Airport { AirportID = 17, CountryID = 826, AirportName = "London Stansted" }, //UK
    new Airport { AirportID = 18, CountryID = 826, AirportName = "Luton Airport" }, //UK
    new Airport { AirportID = 19, CountryID = 826, AirportName = "Manchester Airport" }, //UK
    new Airport { AirportID = 20, CountryID = 826, AirportName = "London City Airport" }, //UK
    new Airport { AirportID = 21, CountryID = 826, AirportName = "Birmingham Airport" }, //UK
    new Airport { AirportID = 22, CountryID = 250, AirportName = "Lille Airport" }, //FRANCE
    new Airport { AirportID = 23, CountryID = 250, AirportName = "Bordeaux Airport" }, //FRANCE
    new Airport { AirportID = 24, CountryID = 250, AirportName = "Marseille Airport" }, //FRANCE
    new Airport { AirportID = 25, CountryID = 724, AirportName = "Barcelona International Airport" }, //SPAIN
    new Airport { AirportID = 26, CountryID = 724, AirportName = "Málaga Airport" }, //SPAIN
    new Airport { AirportID = 27, CountryID = 724, AirportName = "Palma De Mallorca Airport" }, //SPAIN
    new Airport { AirportID = 28, CountryID = 724, AirportName = "Ibiza Airport" }, // Spain
    new Airport { AirportID = 29, CountryID = 724, AirportName = "Las Palmas Airport" }, // Spain
    new Airport { AirportID = 30, CountryID = 300, AirportName = "Athens International Airport" }, // Greece
    new Airport { AirportID = 31, CountryID = 300, AirportName = "Thessaloniki Airport" }, // Greece
    new Airport { AirportID = 32, CountryID = 300, AirportName = "Heraklion International Airport" }, // Greece
    new Airport { AirportID = 33, CountryID = 300, AirportName = "Rhodes International Airport" }, // Greece
    new Airport { AirportID = 34, CountryID = 300, AirportName = "Santorini International Airport" }, // Greece
    new Airport { AirportID = 35, CountryID = 380, AirportName = "Rome Fiumicino Airport" }, // Italy
    new Airport { AirportID = 36, CountryID = 380, AirportName = "Milan Malpensa Airport" }, // Italy
    new Airport { AirportID = 37, CountryID = 380, AirportName = "Venice Marco Polo Airport" }, // Italy
    new Airport { AirportID = 38, CountryID = 380, AirportName = "Naples International Airport" }, // Italy
    new Airport { AirportID = 39, CountryID = 380, AirportName = "Florence Airport" }, // Italy
    new Airport { AirportID = 40, CountryID = 208, AirportName = "Stockholm Arlanda Airport" }, // Sweden
    new Airport { AirportID = 41, CountryID = 208, AirportName = "Copenhagen Airport" }, // Denmark
    new Airport { AirportID = 42, CountryID = 208, AirportName = "Oslo Gardermoen Airport" }, // Norway
    new Airport { AirportID = 43, CountryID = 208, AirportName = "Helsinki-Vantaa Airport" }, // Finland
    new Airport { AirportID = 44, CountryID = 276, AirportName = "Berlin Brandenburg Airport" }, // Germany
    new Airport { AirportID = 45, CountryID = 276, AirportName = "Munich Airport" }, // Germany
    new Airport { AirportID = 46, CountryID = 276, AirportName = "Hamburg Airport" }, // Germany
    new Airport { AirportID = 47, CountryID = 276, AirportName = "Düsseldorf Airport" }, // Germany
    new Airport { AirportID = 48, CountryID = 826, AirportName = "Belfast International Airport" }, // UK (Northern Ireland)
    new Airport { AirportID = 49, CountryID = 372, AirportName = "Dublin Airport" }, // Ireland
    new Airport { AirportID = 50, CountryID = 372, AirportName = "Cork Airport" }, // Ireland
    new Airport { AirportID = 51, CountryID = 276, AirportName = "Cologne Bonn Airport" }, //Germany
    new Airport { AirportID = 60, CountryID = 276, AirportName = "Berlin Brandenburg Airport" },  //Germany
    new Airport { AirportID = 52, CountryID = 203, AirportName = "Prague Václav Havel Airport" },  //Czekh republic
    new Airport { AirportID = 61, CountryID = 203, AirportName = "Brno-Turany Airport" },  //Czekh republic
    new Airport { AirportID = 53, CountryID = 348, AirportName = "Budapest Ferenc Liszt International Airport" }, //Hungary
    new Airport { AirportID = 62, CountryID = 348, AirportName = "Debrecen International Airport" },  //Hungary
    new Airport { AirportID = 54, CountryID = 40, AirportName = "Vienna International Airport" },  //Austria
    new Airport { AirportID = 63, CountryID = 40, AirportName = "Salzburg Airport" }, //Austria
    new Airport { AirportID = 55, CountryID = 642, AirportName = "Bucharest Henri Coandă International Airport" },
    new Airport { AirportID = 64, CountryID = 642, AirportName = "Cluj-Napoca International Airport" }, //South Africa
    new Airport { AirportID = 56, CountryID = 710, AirportName = "Cape Town International Airport" },  //South Africa
    new Airport { AirportID = 58, CountryID = 710, AirportName = "OR Tambo International Airport" },  //South Africa
    new Airport { AirportID = 59, CountryID = 710, AirportName = "King Shaka International Airport" }, //South Africa
    new Airport { AirportID = 65, CountryID = 710, AirportName = "Johannesburg Lanseria International Airport" },  //South Africa
    new Airport { AirportID = 72, CountryID = 710, AirportName = "Port Elizabeth International Airport" },
    new Airport { AirportID = 73, CountryID = 710, AirportName = "George Airport" },  //Bulgaria
    new Airport { AirportID = 57, CountryID = 100, AirportName = "Sofia Airport" },  //Bulgaria
    new Airport { AirportID = 66, CountryID = 100, AirportName = "Varna Airport" },  //Bulgaria
    new Airport { AirportID = 74, CountryID = 100, AirportName = "Burgas Airport" },  //Bulgaria
    new Airport { AirportID = 75, CountryID = 100, AirportName = "Plovdiv Airport" },  //Bulgaria
    new Airport { AirportID = 76, CountryID = 100, AirportName = "Sofia West Airport" }, //Bulgaria
    new Airport { AirportID = 77, CountryID = 826, AirportName = "Edinburgh Airport" },  // UK
    new Airport { AirportID = 78, CountryID = 826, AirportName = "Cardiff Airport" },    // UK
    new Airport { AirportID = 79, CountryID = 372, AirportName = "Shannon Airport" }    // Ireland
   
);



     // @dlawlor2

        /*
        // @elms64
        // Booking Seed Data
        modelBuilder.Entity<Booking>().HasData(
            CreateBooking(1, 1, 826, 1, DateTime.Now, 1, 1, 1),
            CreateBooking(2, 2, 826, 2, DateTime.Now, 2, 2, 2),
            CreateBooking(3, 3, 826, 3, DateTime.Now, 3, 3, 3),
            CreateBooking(4, 4, 826, 4, DateTime.Now, 4, 4, 4),
            CreateBooking(5, 5, 826, 5, DateTime.Now, 5, 5, 5)
        );

        // Creates a Booking entity and calculates the checksum.
        Booking CreateBooking(int orderNumber, int hotelBookingID, int countryID, int flightID, DateTime purchaseDate,
            int vehicleBookingID, int clientID, int insuranceBookingID)
        {
            var booking = new Booking
            {
                OrderNumber = orderNumber,
                HotelBookingID = hotelBookingID,
                CountryID = countryID,
                FlightID = flightID,
                PurchaseDate = purchaseDate,
                VehicleBookingID = vehicleBookingID,
                ClientID = clientID,
                InsuranceBookingID = insuranceBookingID,
                TransactionGUID = Guid.NewGuid(),
                CheckSum = CalcMD5.CalculateMd5(GetBookingJson(orderNumber, hotelBookingID, countryID, flightID, purchaseDate, vehicleBookingID, clientID, insuranceBookingID))
            };

            return booking;
        }

        // Converts bookings to JSON for use with checksum calculation.
        string GetBookingJson(int orderNumber, int hotelBookingID, int countryID, int flightID, DateTime purchaseDate,
            int vehicleBookingID, int clientID, int insuranceBookingID)
        {
            var bookingInfo = new
            {
                OrderNumber = orderNumber,
                HotelBookingID = hotelBookingID,
                CountryID = countryID,
                FlightID = flightID,
                PurchaseDate = purchaseDate,
                VehicleBookingID = vehicleBookingID,
                ClientID = clientID,
                InsuranceBookingID = insuranceBookingID
            };
            return JsonSerializer.Serialize(bookingInfo);
        } */

        /*// @Kloakk
        // Client Seed Data
        modelBuilder.Entity<Client>().HasData(
            new Client { ClientID = 1, FirstName = "John", LastName = "Doe", BirthDate = new DateTime(1990, 1, 1), Email = "john.doe@example.com", PhoneNumber = "123-456-7890" },
            new Client { ClientID = 2, FirstName = "Jane", LastName = "Smith", BirthDate = new DateTime(1985, 5, 15), Email = "jane.smith@example.com", PhoneNumber = "987-654-3210" },
            new Client { ClientID = 3, FirstName = "Alice", LastName = "Johnson", BirthDate = new DateTime(1992, 8, 20), Email = "alice.johnson@example.com", PhoneNumber = "555-123-4567" },
            new Client { ClientID = 4, FirstName = "Bob", LastName = "Anderson", BirthDate = new DateTime(1980, 3, 10), Email = "bob.anderson@example.com", PhoneNumber = "333-777-8888" },
            new Client { ClientID = 5, FirstName = "Eva", LastName = "Williams", BirthDate = new DateTime(1988, 11, 5), Email = "eva.williams@example.com", PhoneNumber = "111-222-3333" }
        ); */

        // @dlawlor2408
        // Flight Seed Data
        modelBuilder.Entity<Flight>().HasData(
            new Flight
            {
                FlightID = 1,
                DepartureAirportID = 1,
                ArrivalAirportID = 2,
                AirlineID = 1,
                BookedSeats = 50,
                MaxSeats = 100,
                DepartureDateTime = DateTime.Now.AddDays(7),
                ArrivalDateTime = DateTime.Now.AddDays(8),
                FlightCost = 500
            },
            new Flight
            {
                FlightID = 2,
                DepartureAirportID = 16, //Gatwick
                ArrivalAirportID = 5, //Heathrow
                AirlineID = 2,
                BookedSeats = 30,
                MaxSeats = 80,
                DepartureDateTime = DateTime.Now.AddDays(10),
                ArrivalDateTime = DateTime.Now.AddDays(12),
                FlightCost = 450
            },
            new Flight
            {
                FlightID = 3,
                DepartureAirportID = 3,
                ArrivalAirportID = 4,
                AirlineID = 3,
                BookedSeats = 70,
                MaxSeats = 120,
                DepartureDateTime = DateTime.Now.AddDays(15),
                ArrivalDateTime = DateTime.Now.AddDays(17),
                FlightCost = 600
            },
            new Flight
            {
                FlightID = 4,
                DepartureAirportID = 4,
                ArrivalAirportID = 5,
                AirlineID = 4,
                BookedSeats = 40,
                MaxSeats = 100,
                DepartureDateTime = DateTime.Now.AddDays(20),
                ArrivalDateTime = DateTime.Now.AddDays(22),
                FlightCost = 550
            },
            new Flight
            {
                FlightID = 5,
                DepartureAirportID = 5,
                ArrivalAirportID = 1,
                AirlineID = 4,
                BookedSeats = 60,
                MaxSeats = 80,
                DepartureDateTime = DateTime.Now.AddDays(25),
                ArrivalDateTime = DateTime.Now.AddDays(27),
                FlightCost = 480
            },
              new Flight
              {
                  FlightID = 6,
                  DepartureAirportID = 16,//Gatwick Airport
                  ArrivalAirportID = 17, //Stansted Airport
                  AirlineID = 3,
                  BookedSeats = 80,
                  MaxSeats = 140,
                  DepartureDateTime = DateTime.Now.AddDays(1),
                  ArrivalDateTime = DateTime.Now.AddDays(1),
                  FlightCost = 180
              },
              new Flight
              {
                  FlightID = 7,
                  DepartureAirportID = 16,//Gatwick Airport
                  ArrivalAirportID = 18, //Luton Airport
                  AirlineID = 5,
                  BookedSeats = 150,
                  MaxSeats = 180,
                  DepartureDateTime = DateTime.Now.AddDays(1),
                  ArrivalDateTime = DateTime.Now.AddDays(1),
                  FlightCost = 150
              },
              new Flight
              {
                  FlightID = 8,
                  DepartureAirportID = 16,//Gatwick Airport
                  ArrivalAirportID = 19, //Manchester Airport
                  AirlineID = 1,
                  BookedSeats = 120,
                  MaxSeats = 150,
                  DepartureDateTime = DateTime.Now.AddDays(1),
                  ArrivalDateTime = DateTime.Now.AddDays(1),
                  FlightCost = 150
              },
             new Flight
             {
                 FlightID = 9,
                 DepartureAirportID = 16,//Gatwick Airport
                 ArrivalAirportID = 20, //Manchester Airport
                 AirlineID = 5,
                 BookedSeats = 100,
                 MaxSeats = 140,
                 DepartureDateTime = DateTime.Now.AddDays(1),
                 ArrivalDateTime = DateTime.Now.AddDays(1),
                 FlightCost = 100
             },
             new Flight
             {
                 FlightID = 10,
                 DepartureAirportID = 1,//Gatwick Airport
                 ArrivalAirportID = 19, //Manchester Airport
                 AirlineID = 5,
                 BookedSeats = 70,
                 MaxSeats = 90,
                 DepartureDateTime = DateTime.Now.AddDays(1),
                 ArrivalDateTime = DateTime.Now.AddDays(1),
                 FlightCost = 120
             },
             new Flight
             {
                 FlightID = 11,
                 DepartureAirportID = 16,//Gatwick Airport
                 ArrivalAirportID = 19, //Manchester Airport
                 AirlineID = 5,
                 BookedSeats = 70,
                 MaxSeats = 90,
                 DepartureDateTime = DateTime.Now.AddDays(1),
                 ArrivalDateTime = DateTime.Now.AddDays(1),
                 FlightCost = 120
             },
             new Flight
             {
                 FlightID = 12,
                 DepartureAirportID = 16,//Gatwick Airport
                 ArrivalAirportID = 20, //Manchester Airport
                 AirlineID = 5,
                 BookedSeats = 70,
                 MaxSeats = 90,
                 DepartureDateTime = DateTime.Now.AddDays(1),
                 ArrivalDateTime = DateTime.Now.AddDays(1),
                 FlightCost = 120
             },
             new Flight
             {
                 FlightID = 13,
                 DepartureAirportID = 16,//Gatwick Airport
                 ArrivalAirportID = 21, //Manchester Airport
                 AirlineID = 5,
                 BookedSeats = 70,
                 MaxSeats = 90,
                 DepartureDateTime = DateTime.Now.AddDays(1),
                 ArrivalDateTime = DateTime.Now.AddDays(1),
                 FlightCost = 120
             },
             new Flight
             {
                 FlightID = 14,
                 DepartureAirportID = 16,//Gatwick Airport
                 ArrivalAirportID = 22, //Lille Airport
                 AirlineID = 5,
                 BookedSeats = 70,
                 MaxSeats = 90,
                 DepartureDateTime = DateTime.Now.AddDays(1),
                 ArrivalDateTime = DateTime.Now.AddDays(1),
                 FlightCost = 120
             },
             new Flight
             {
                 FlightID = 15,
                 DepartureAirportID = 16,//Gatwick Airport
                 ArrivalAirportID = 23, //Bordeaux Airport
                 AirlineID = 5,
                 BookedSeats = 70,
                 MaxSeats = 90,
                 DepartureDateTime = DateTime.Now.AddDays(1),
                 ArrivalDateTime = DateTime.Now.AddDays(1),
                 FlightCost = 120
             },
              new Flight
              {
                  FlightID = 16,
                  DepartureAirportID = 16,//Gatwick Airport
                  ArrivalAirportID = 24, //Marseille Airport
                  AirlineID = 5,
                  BookedSeats = 70,
                  MaxSeats = 90,
                  DepartureDateTime = DateTime.Now.AddDays(1),
                  ArrivalDateTime = DateTime.Now.AddDays(1),
                  FlightCost = 120
              },

               new Flight
               {
                   FlightID = 17,
                   DepartureAirportID = 5,//Heathrow airport
                   ArrivalAirportID = 9, //Adolfo Suárez Madrid-Barajas Airport
                   AirlineID = 5,
                   BookedSeats = 70,
                   MaxSeats = 90,
                   DepartureDateTime = DateTime.Now.AddDays(1),
                   ArrivalDateTime = DateTime.Now.AddDays(1),
                   FlightCost = 120
               },

              new Flight
              {
                  FlightID = 18,
                  DepartureAirportID = 5,//Heathrow airport
                  ArrivalAirportID = 9, //Adolfo Suárez Madrid-Barajas Airport
                  AirlineID = 5,
                  BookedSeats = 70,
                  MaxSeats = 90,
                  DepartureDateTime = DateTime.Now.AddDays(2),
                  ArrivalDateTime = DateTime.Now.AddDays(1),
                  FlightCost = 120
              },
              new Flight
              {
                  FlightID = 19,
                  DepartureAirportID = 5,//Heathrow airport
                  ArrivalAirportID = 9, //Adolfo Suárez Madrid-Barajas Airport
                  AirlineID = 5,
                  BookedSeats = 70,
                  MaxSeats = 90,
                  DepartureDateTime = DateTime.Now.AddDays(3),
                  ArrivalDateTime = DateTime.Now.AddDays(1),
                  FlightCost = 120
              }

        );

        // @dlawlor2408
        // Hotel Seed Data
        modelBuilder.Entity<Hotel>().HasData(
          new Hotel
          {
              HotelID = 1,
              HotelName = "Premier Inn",
              CountryID = 826, //UK
              AddressLine1 = "123 Main St",
              AddressLine2 = "Apt 45",
              City = "Cityville",
              Postcode = "12345",
              PhoneNumber = 5551234,
              Rating = 4,
              RoomCount = 50
          },
          new Hotel
          {
              HotelID = 2,
              HotelName = "Marriott",
              CountryID = 826, //UK
              AddressLine1 = "456 Oak St",
              AddressLine2 = "Suite 22",
              City = "Townsville",
              Postcode = "67890",
              PhoneNumber = 5555678,
              Rating = 3.5,
              RoomCount = 40
          },
          new Hotel
          {
              HotelID = 3,
              HotelName = "Holiday Inn",
              CountryID = 826, //UK
              AddressLine1 = "789 Pine St",
              AddressLine2 = "Unit 33",
              City = "Villagetown",
              Postcode = "10111",
              PhoneNumber = 5559999,
              Rating = 4.2,
              RoomCount = 60
          },
          new Hotel
          {
              HotelID = 4,
              HotelName = "Hilton Hotel",
              CountryID = 826, //UK
              AddressLine1 = "101 Cedar St",
              AddressLine2 = "Apt 10",
              City = "Mountainview",
              Postcode = "54321",
              PhoneNumber = 5554321,
              Rating = 3.8,
              RoomCount = 45
          },
          new Hotel
          {
              HotelID = 5,
              HotelName = "IHG",
              CountryID = 826, //UK
              AddressLine1 = "202 Birch St",
              AddressLine2 = "Suite 5",
              City = "Laketown",
              Postcode = "87654",
              PhoneNumber = 5551111,
              Rating = 4.5,
              RoomCount = 55
          },
           new Hotel
           {
               HotelID = 6,
               HotelName = "Premier Inn",
               CountryID = 724, //UK
               AddressLine1 = "202 Birch St",
               AddressLine2 = "Suite 5",
               City = "Laketown",
               Postcode = "87654",
               PhoneNumber = 5551111,
               Rating = 4.5,
               RoomCount = 55
           },
           new Hotel
           {
               HotelID = 7,
               HotelName = "Marriott",
               CountryID = 724, //spain
               AddressLine1 = "456 West St",
               AddressLine2 = "Suite 22",
               City = "Madrid",
               Postcode = "67890",
               PhoneNumber = 5555678,
               Rating = 3.5,
               RoomCount = 40
           },
           new Hotel
           {
               HotelID = 8,
               HotelName = "Holiday Inn",
               CountryID = 724, //spain
               AddressLine1 = "456 Oak St",
               AddressLine2 = "Suite 22",
               City = "Sevilla",
               Postcode = "67890",
               PhoneNumber = 5555678,
               Rating = 3.5,
               RoomCount = 40
           },
            new Hotel
            {
                HotelID = 9,
                HotelName = "Marriott",
                CountryID = 724, //spain
                AddressLine1 = "456 Oak St",
                AddressLine2 = "Suite 22",
                City = "Sevilla",
                Postcode = "67890",
                PhoneNumber = 5555678,
                Rating = 3.5,
                RoomCount = 40
            }

      );

        /* Hotel Booking Seed Data
        modelBuilder.Entity<HotelBooking>().HasData(
           new HotelBooking { HotelBookingID = 1, HotelID = 1, RoomID = 1, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
           new HotelBooking { HotelBookingID = 2, HotelID = 2, RoomID = 2, CheckInDate = DateTime.Now.AddDays(10), CheckOutDate = DateTime.Now.AddDays(17) },
           new HotelBooking { HotelBookingID = 3, HotelID = 3, RoomID = 3, CheckInDate = DateTime.Now.AddDays(15), CheckOutDate = DateTime.Now.AddDays(22) },
           new HotelBooking { HotelBookingID = 4, HotelID = 4, RoomID = 4, CheckInDate = DateTime.Now.AddDays(20), CheckOutDate = DateTime.Now.AddDays(27) },
           new HotelBooking { HotelBookingID = 5, HotelID = 5, RoomID = 5, CheckInDate = DateTime.Now.AddDays(25), CheckOutDate = DateTime.Now.AddDays(32) },
           new HotelBooking { HotelBookingID = 6, HotelID = 6, RoomID = 6, CheckInDate = DateTime.Now.AddDays(30), CheckOutDate = DateTime.Now.AddDays(37) },
           new HotelBooking { HotelBookingID = 7, HotelID = 6, RoomID = 7, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
           new HotelBooking { HotelBookingID = 8, HotelID = 6, RoomID = 8, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
           new HotelBooking { HotelBookingID = 9, HotelID = 6, RoomID = 9, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
           new HotelBooking { HotelBookingID = 10, HotelID = 7, RoomID = 10, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
           new HotelBooking { HotelBookingID = 11, HotelID = 7, RoomID = 11, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
           new HotelBooking { HotelBookingID = 12, HotelID = 7, RoomID = 12, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
           new HotelBooking { HotelBookingID = 13, HotelID = 7, RoomID = 13, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
           new HotelBooking { HotelBookingID = 14, HotelID = 8, RoomID = 14, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
           new HotelBooking { HotelBookingID = 15, HotelID = 8, RoomID = 15, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
           new HotelBooking { HotelBookingID = 16, HotelID = 8, RoomID = 16, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
           new HotelBooking { HotelBookingID = 17, HotelID = 8, RoomID = 17, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
           new HotelBooking { HotelBookingID = 18, HotelID = 9, RoomID = 18, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
           new HotelBooking { HotelBookingID = 19, HotelID = 9, RoomID = 19, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
           new HotelBooking { HotelBookingID = 20, HotelID = 9, RoomID = 20, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
           new HotelBooking { HotelBookingID = 21, HotelID = 9, RoomID = 21, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) }

       ); */

        // Insurance Seed Data
        modelBuilder.Entity<Insurance>().HasData(
            new Insurance { InsuranceID = 1, InsuranceType = "Basic", PricePerDay = 10.5 },
            new Insurance { InsuranceID = 2, InsuranceType = "Standard", PricePerDay = 15.75 },
            new Insurance { InsuranceID = 3, InsuranceType = "Premium", PricePerDay = 20.0 },
            new Insurance { InsuranceID = 4, InsuranceType = "Extended", PricePerDay = 25.5 },
            new Insurance { InsuranceID = 5, InsuranceType = "Deluxe", PricePerDay = 30.0 },
            new Insurance { InsuranceID = 6, InsuranceType = "Presidential", PricePerDay = 30.0 },
            new Insurance { InsuranceID = 7, InsuranceType = "Cheddar", PricePerDay = 30000.0 }
        );

        /*// @gjepic
        // Insurance Booking Seed Data
        modelBuilder.Entity<InsuranceBooking>().HasData(
            new InsuranceBooking { InsuranceBookingID = 1, InsuranceID = 1, StartDate = DateTime.Now.AddDays(7), EndDate = DateTime.Now.AddDays(14) },
            new InsuranceBooking { InsuranceBookingID = 2, InsuranceID = 2, StartDate = DateTime.Now.AddDays(10), EndDate = DateTime.Now.AddDays(17) },
            new InsuranceBooking { InsuranceBookingID = 3, InsuranceID = 3, StartDate = DateTime.Now.AddDays(15), EndDate = DateTime.Now.AddDays(22) },
            new InsuranceBooking { InsuranceBookingID = 4, InsuranceID = 4, StartDate = DateTime.Now.AddDays(20), EndDate = DateTime.Now.AddDays(27) },
            new InsuranceBooking { InsuranceBookingID = 5, InsuranceID = 5, StartDate = DateTime.Now.AddDays(25), EndDate = DateTime.Now.AddDays(32) }
        ); */

        // Room Seed Data
        modelBuilder.Entity<Room>().HasData(
            new Room { RoomID = 1, HotelID = 6, RoomType = "Single", RoomNo = 101, PricePerNight = 100 },
            new Room { RoomID = 2, HotelID = 7, RoomType = "Double", RoomNo = 201, PricePerNight = 150 },
            new Room { RoomID = 3, HotelID = 8, RoomType = "Suite", RoomNo = 301, PricePerNight = 200 },
            new Room { RoomID = 4, HotelID = 9, RoomType = "Double", RoomNo = 102, PricePerNight = 110 },
            new Room { RoomID = 5, HotelID = 9, RoomType = "Suite", RoomNo = 202, PricePerNight = 180 },
            new Room { RoomID = 6, HotelID = 6, RoomType = "Single", RoomNo = 122, PricePerNight = 180 },
            new Room { RoomID = 7, HotelID = 6, RoomType = "Double", RoomNo = 042, PricePerNight = 180 },
            new Room { RoomID = 8, HotelID = 6, RoomType = "Double", RoomNo = 222, PricePerNight = 180 },
            new Room { RoomID = 9, HotelID = 6, RoomType = "Double", RoomNo = 204, PricePerNight = 180 },
            new Room { RoomID = 10, HotelID = 7, RoomType = "Double", RoomNo = 216, PricePerNight = 180 },
            new Room { RoomID = 11, HotelID = 7, RoomType = "Double", RoomNo = 108, PricePerNight = 180 },
            new Room { RoomID = 12, HotelID = 7, RoomType = "Suite", RoomNo = 109, PricePerNight = 180 },
            new Room { RoomID = 13, HotelID = 7, RoomType = "Double", RoomNo = 110, PricePerNight = 180 },
            new Room { RoomID = 14, HotelID = 8, RoomType = "Double", RoomNo = 134, PricePerNight = 180 },
            new Room { RoomID = 15, HotelID = 8, RoomType = "Suite", RoomNo = 142, PricePerNight = 180 },
            new Room { RoomID = 16, HotelID = 8, RoomType = "Single", RoomNo = 172, PricePerNight = 180 },
            new Room { RoomID = 17, HotelID = 8, RoomType = "Single", RoomNo = 222, PricePerNight = 180 },
            new Room { RoomID = 18, HotelID = 9, RoomType = "Suite", RoomNo = 212, PricePerNight = 180 },
            new Room { RoomID = 19, HotelID = 9, RoomType = "Double", RoomNo = 112, PricePerNight = 180 },
            new Room { RoomID = 20, HotelID = 9, RoomType = "Double", RoomNo = 104, PricePerNight = 180 },
            new Room { RoomID = 21, HotelID = 9, RoomType = "Suite", RoomNo = 120, PricePerNight = 180 }


        );

        // Vehicle Seed Data
        modelBuilder.Entity<Vehicle>().HasData(
            new Vehicle { VehicleID = 1, VehicleType = "Compact Car", PricePerDay = 45.0m },
            new Vehicle { VehicleID = 2, VehicleType = "SUV", PricePerDay = 60.0m },
            new Vehicle { VehicleID = 3, VehicleType = "Van", PricePerDay = 75.0m },
            new Vehicle { VehicleID = 4, VehicleType = "Luxury Car", PricePerDay = 100.0m },
            new Vehicle { VehicleID = 5, VehicleType = "Motorcycle", PricePerDay = 30.0m }
        );

        /* Vehicle Booking Seed Data
        modelBuilder.Entity<VehicleBooking>().HasData(
            new VehicleBooking { VehicleBookingID = 1, VehicleID = 1, PickUpDate = DateTime.Now.AddDays(7), DropOffDate = DateTime.Now.AddDays(14) },
            new VehicleBooking { VehicleBookingID = 2, VehicleID = 2, PickUpDate = DateTime.Now.AddDays(10), DropOffDate = DateTime.Now.AddDays(17) },
            new VehicleBooking { VehicleBookingID = 3, VehicleID = 3, PickUpDate = DateTime.Now.AddDays(15), DropOffDate = DateTime.Now.AddDays(22) },
            new VehicleBooking { VehicleBookingID = 4, VehicleID = 4, PickUpDate = DateTime.Now.AddDays(20), DropOffDate = DateTime.Now.AddDays(27) },
            new VehicleBooking { VehicleBookingID = 5, VehicleID = 5, PickUpDate = DateTime.Now.AddDays(25), DropOffDate = DateTime.Now.AddDays(32) }
        ); */











    }
}

