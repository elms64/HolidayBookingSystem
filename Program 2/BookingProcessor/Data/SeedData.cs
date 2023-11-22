// Authored by @Kloakk
// Initializes the database with some example data for testing

using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

public class SeedData {

    
    public static void Initialize(ModelBuilder modelBuilder){
        
        // DateTime is    YYYY MM DD  HH MM SS   Format
        //              (2023,11,08, 17,26,11)
        // Airline Seed Data
        modelBuilder.Entity<Airline>().HasData(
        new Airline { AirlineID = 1, AirlineName = "Example Airline 1", PhoneNumber = "123-456-7890", Rating = 4.5, HQ = "London, England" },
        new Airline { AirlineID = 2, AirlineName = "Example Airline 2", PhoneNumber = "987-654-3210", Rating = 3.8, HQ = "France, Paris"},
        new Airline { AirlineID = 3, AirlineName = "Example Airline 3", PhoneNumber = "555-123-4567", Rating = 4.2, HQ = "Moscow, Russia"},
        new Airline { AirlineID = 4, AirlineName = "Example Airline 4", PhoneNumber = "333-777-8888", Rating = 3.5, HQ = "USA, LA"},
        new Airline { AirlineID = 5, AirlineName = "Example Airline 5", PhoneNumber = "111-222-3333", Rating = 4.0, HQ = "Japan, Tokyo"}
    );

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
        new Airport { AirportID = 16, CountryID = 826, AirportName = "Gatwick Airport" } //UK
        
    );

        // Booking Seed Data
        modelBuilder.Entity<Booking>().HasData(
        new Booking
        {
            BookingID = 1,
            HotelBookingID = 1,
            CountryID = 826, //UK
            FlightID = 1,
            PurchaseDate = DateTime.Now,
            VehicleBookingID = 1,
            ClientID = 1,
            InsuranceBookingID = 1
        },
        new Booking
        {
            BookingID = 2,
            HotelBookingID = 2,
            CountryID = 826, //UK
            FlightID = 2,
            PurchaseDate = DateTime.Now,
            VehicleBookingID = 2,
            ClientID = 2,
            InsuranceBookingID = 2
        },
        new Booking
        {
            BookingID = 3,
            HotelBookingID = 3,
            CountryID = 826, //UK
            FlightID = 3,
            PurchaseDate = DateTime.Now,
            VehicleBookingID = 3,
            ClientID = 3,
            InsuranceBookingID = 3
        },
        new Booking
        {
            BookingID = 4,
            HotelBookingID = 4,
            CountryID = 826, //UK
            FlightID = 4,
            PurchaseDate = DateTime.Now,
            VehicleBookingID = 4,
            ClientID = 4,
            InsuranceBookingID = 4
        },
        new Booking
        {
            BookingID = 5,
            HotelBookingID = 5,
            CountryID = 826, //UK
            FlightID = 5,
            PurchaseDate = DateTime.Now,
            VehicleBookingID = 5,
            ClientID = 5,
            InsuranceBookingID = 5
        }
    );
        
    modelBuilder.Entity<Client>().HasData(
        new Client { ClientID = 1, FirstName = "John", LastName = "Doe", BirthDate = new DateTime(1990, 1, 1), Email = "john.doe@example.com", PhoneNumber = "123-456-7890" },
        new Client { ClientID = 2, FirstName = "Jane", LastName = "Smith", BirthDate = new DateTime(1985, 5, 15), Email = "jane.smith@example.com", PhoneNumber = "987-654-3210" },
        new Client { ClientID = 3, FirstName = "Alice", LastName = "Johnson", BirthDate = new DateTime(1992, 8, 20), Email = "alice.johnson@example.com", PhoneNumber = "555-123-4567" },
        new Client { ClientID = 4, FirstName = "Bob", LastName = "Anderson", BirthDate = new DateTime(1980, 3, 10), Email = "bob.anderson@example.com", PhoneNumber = "333-777-8888" },
        new Client { ClientID = 5, FirstName = "Eva", LastName = "Williams", BirthDate = new DateTime(1988, 11, 5), Email = "eva.williams@example.com", PhoneNumber = "111-222-3333" }
    );

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
            AirlineID = 5,
            BookedSeats = 60,
            MaxSeats = 80,
            DepartureDateTime = DateTime.Now.AddDays(25),
            ArrivalDateTime = DateTime.Now.AddDays(27),
            FlightCost = 480
        }
    );


      modelBuilder.Entity<Hotel>().HasData(
        new Hotel
        {
            HotelID = 1,
            HotelName = "Example Hotel 1",
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
            HotelName = "Example Hotel 2",
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
            HotelName = "Example Hotel 3",
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
            HotelName = "Example Hotel 4",
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
            HotelName = "Example Hotel 5",
            CountryID = 826, //UK
            AddressLine1 = "202 Birch St",
            AddressLine2 = "Suite 5",
            City = "Laketown",
            Postcode = "87654",
            PhoneNumber = 5551111,
            Rating = 4.5,
            RoomCount = 55
        }
    );


     modelBuilder.Entity<HotelBooking>().HasData(
        new HotelBooking { HotelBookingID = 1, HotelID = 1, RoomID = 1, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(14) },
        new HotelBooking { HotelBookingID = 2, HotelID = 2, RoomID = 2, CheckInDate = DateTime.Now.AddDays(10), CheckOutDate = DateTime.Now.AddDays(17) },
        new HotelBooking { HotelBookingID = 3, HotelID = 3, RoomID = 3, CheckInDate = DateTime.Now.AddDays(15), CheckOutDate = DateTime.Now.AddDays(22) },
        new HotelBooking { HotelBookingID = 4, HotelID = 4, RoomID = 4, CheckInDate = DateTime.Now.AddDays(20), CheckOutDate = DateTime.Now.AddDays(27) },
        new HotelBooking { HotelBookingID = 5, HotelID = 5, RoomID = 5, CheckInDate = DateTime.Now.AddDays(25), CheckOutDate = DateTime.Now.AddDays(32) }
    );


    // Seed data for Insurance
    modelBuilder.Entity<Insurance>().HasData(
        new Insurance { InsuranceID = 1, InsuranceType = "Basic", PricePerDay = 10.5 },
        new Insurance { InsuranceID = 2, InsuranceType = "Standard", PricePerDay = 15.75 },
        new Insurance { InsuranceID = 3, InsuranceType = "Premium", PricePerDay = 20.0 },
        new Insurance { InsuranceID = 4, InsuranceType = "Extended", PricePerDay = 25.5 },
        new Insurance { InsuranceID = 5, InsuranceType = "Deluxe", PricePerDay = 30.0 }
    );


    // Seed data for InsuranceBooking
    modelBuilder.Entity<InsuranceBooking>().HasData(
        new InsuranceBooking { InsuranceBookingID = 1, InsuranceID = 1, StartDate = DateTime.Now.AddDays(7), EndDate = DateTime.Now.AddDays(14) },
        new InsuranceBooking { InsuranceBookingID = 2, InsuranceID = 2, StartDate = DateTime.Now.AddDays(10), EndDate = DateTime.Now.AddDays(17) },
        new InsuranceBooking { InsuranceBookingID = 3, InsuranceID = 3, StartDate = DateTime.Now.AddDays(15), EndDate = DateTime.Now.AddDays(22) },
        new InsuranceBooking { InsuranceBookingID = 4, InsuranceID = 4, StartDate = DateTime.Now.AddDays(20), EndDate = DateTime.Now.AddDays(27) },
        new InsuranceBooking { InsuranceBookingID = 5, InsuranceID = 5, StartDate = DateTime.Now.AddDays(25), EndDate = DateTime.Now.AddDays(32) }
    );

    // Seed data for Room
    modelBuilder.Entity<Room>().HasData(
        new Room { RoomID = 1, HotelID = 1, RoomType = "Standard", RoomNo = 101, PricePerNight = 100 },
        new Room { RoomID = 2, HotelID = 2, RoomType = "Deluxe", RoomNo = 201, PricePerNight = 150 },
        new Room { RoomID = 3, HotelID = 3, RoomType = "Suite", RoomNo = 301, PricePerNight = 200 },
        new Room { RoomID = 4, HotelID = 4, RoomType = "Standard", RoomNo = 102, PricePerNight = 110 },
        new Room { RoomID = 5, HotelID = 5, RoomType = "Suite", RoomNo = 202, PricePerNight = 180 }
    );


    modelBuilder.Entity<Vehicle>().HasData(
        new Vehicle { VehicleID = 1, VehicleType = "Compact Car", PricePerDay = 45.0m },
        new Vehicle { VehicleID = 2, VehicleType = "SUV", PricePerDay = 60.0m },
        new Vehicle { VehicleID = 3, VehicleType = "Van", PricePerDay = 75.0m },
        new Vehicle { VehicleID = 4, VehicleType = "Luxury Car", PricePerDay = 100.0m },
        new Vehicle { VehicleID = 5, VehicleType = "Motorcycle", PricePerDay = 30.0m }
    );

    // Seed data for VehicleBooking
    modelBuilder.Entity<VehicleBooking>().HasData(
        new VehicleBooking { VehicleBookingID = 1, VehicleID = 1, PickUpDate = DateTime.Now.AddDays(7), DropOffDate = DateTime.Now.AddDays(14) },
        new VehicleBooking { VehicleBookingID = 2, VehicleID = 2, PickUpDate = DateTime.Now.AddDays(10), DropOffDate = DateTime.Now.AddDays(17) },
        new VehicleBooking { VehicleBookingID = 3, VehicleID = 3, PickUpDate = DateTime.Now.AddDays(15), DropOffDate = DateTime.Now.AddDays(22) },
        new VehicleBooking { VehicleBookingID = 4, VehicleID = 4, PickUpDate = DateTime.Now.AddDays(20), DropOffDate = DateTime.Now.AddDays(27) },
        new VehicleBooking { VehicleBookingID = 5, VehicleID = 5, PickUpDate = DateTime.Now.AddDays(25), DropOffDate = DateTime.Now.AddDays(32) }
    );

     

        
        
         
      

       


    }
}

