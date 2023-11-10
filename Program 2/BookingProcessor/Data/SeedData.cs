using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

public class SeedData {

    
    public static void Initialize(ModelBuilder modelBuilder){
        
        //DateTime is    YYYY MM DD  HH MM SS   Format
        //              (2023,11,08, 17,26,11)
        //Airline Seed Data
        modelBuilder.Entity<Airline>().HasData(
          
            new Airline {AirlineID = 1, AirlineName = "EasyJet"},
            new Airline {AirlineID = 2, AirlineName = "British Airways"}
        );


        //Airport Seed Data
        modelBuilder.Entity<Airport>().HasData(
            new Airport {AirportID = 1, AirportName = "Gatwick"},
            new Airport {AirportID = 2, AirportName = "Luton"}
        );

        //Booking Seed Data
        modelBuilder.Entity<Booking>().HasData(
            new Booking {BookingID = 1, UserID = 1, HotelID = 1, DestinationID = 1, FlightID = 1, PurchaseDate = new DateTime(2023,11,08), VehicleHireID = 1, InsuranceID = 1},

             new Booking { BookingID = 2, UserID = 2, HotelID = 2, DestinationID = 2, FlightID = 2, PurchaseDate = new DateTime(2023,11,08), VehicleHireID = 2, InsuranceID = 2}
        );
        

        //Country Seed Data
        modelBuilder.Entity<Country>().HasData(
            new Country { CountryID = 1, CountryName = "England", Climate = "Temperate" },
            new Country { CountryID = 2, CountryName = "Wales", Climate = "Incredibly Unbelievably Rainy" },
            new Country { CountryID = 3, CountryName = "France", Climate = "Varied" },
            new Country { CountryID = 4, CountryName = "Italy", Climate = "Mediterranean" },
            new Country { CountryID = 5, CountryName = "Germany", Climate = "Diverse" },
            new Country { CountryID = 6, CountryName = "Spain", Climate = "Mediterranean" },
            new Country { CountryID = 7, CountryName = "USA", Climate = "Diverse" },
            new Country { CountryID = 8, CountryName = "Japan", Climate = "Varied" },
            new Country { CountryID = 9, CountryName = "Brazil", Climate = "Tropical" },
            new Country { CountryID = 10, CountryName = "Canada", Climate = "Varied" }
        );

        //Destination Seed Data
        modelBuilder.Entity<Destination>().HasData(
            new Destination {DestinationID = 1, RegionID = 1, DestinationName = "London"},
            new Destination {DestinationID = 2, RegionID = 1, DestinationName = "Cornwall"},
            new Destination {DestinationID = 3, RegionID = 2, DestinationName = "Dubai"}
        );

        //Flight Seed Data
        modelBuilder.Entity<Flight>().HasData( 
            new Flight {FlightID = 1,  AirlineID = 1, MaxSeats = 100, BookedSeats = 5, DepartureAirportID = 1, ArrivalAirportID = 1, ArrivalDateTime = new DateTime (2023,11,08, 17,26,11), DepartureDateTime = new DateTime (2023,12,08, 17,26,11)},
            new Flight {FlightID = 2,  AirlineID = 2, MaxSeats = 100, BookedSeats = 5, DepartureAirportID = 1, ArrivalAirportID = 1, ArrivalDateTime = new DateTime (2024,01,08, 17,26,11), DepartureDateTime = new DateTime (2024,01,08, 17,26,11)}
        );
        
         //Hotel Seed Data
         //I think the int on phoneNumber needs to be a long or whatever is is. 07914545060 is too big or something.
         //Maybe also convert the int Rating to Float rating - for ratings like 4.3, 4.9 etc. 
        modelBuilder.Entity<Hotel>().HasData(
            new Hotel {HotelID = 1, HotelName = "The Lismoyne", DestinationID = 1, AddressLine1 = "SampleAddressLine1", AddressLine2 = "SampleAddressLine2", City = "Fleet", Postcode = "GU51 4HG", Telephone = 01252810170, Rating = 4},
            new Hotel {HotelID = 2, HotelName = "The Four Seasons", DestinationID = 2, AddressLine1 = "SampleAddress2Line1", AddressLine2 = "SampleAddress2Line2", City = "Farnborough", Postcode = "GU52 3EB", Telephone = 01252810171, Rating = 5}    
        );

        //Insurance Seed Data
        //Also use of a float datatype for the cost?
        modelBuilder.Entity<Insurance>().HasData(
            new Insurance {InsuranceID = 1, PlanID = 1, StartDate = new DateTime (2023,11,08), EndDate = new DateTime (2023,12,08), PremiumCost = 100, Active = true}
        );

        //Plan Seed Data
        modelBuilder.Entity<Plan>().HasData(
            new Plan {PlanID = 1, CoverType = "Comprehensive", Cost = 100},
            new Plan {PlanID = 2, CoverType = "Comprehensive", Cost = 100}
        );

        //Reigon Seed Data
        modelBuilder.Entity<Region>().HasData(
            new Region {RegionID = 1, CountryID = 1, RegionName = "London", TimeZone = "GMT"}
        );

        //Room Seed Data
        modelBuilder.Entity<Room>().HasData(
            new Room {RoomID = 1, HotelID = 1, RoomType = "Double", RoomNo = 69, PricePerNight = 100, Available = true}
        );

        //User Seed Data
        modelBuilder.Entity<User>().HasData(
            new User {UserID = 1, Username = "Alex", Email = "Kloakk2@gmail.com", FirstName = "Alex", LastName = "Lovelock", BirthDate = new DateTime (2003,08,22), Password = "Admin1", Telephone = "01252810170"}
        );

        //Vehicle Seed Data
        modelBuilder.Entity<Vehicle>().HasData(
            new Vehicle {VehicleID = 1, BodyType = "Coupe", Make = "BMW", Model = "3 Series", HireRate = 500}
        );

        //VehileHire Seed Data
        modelBuilder.Entity<VehicleHire>().HasData(
            new VehicleHire{VehicleHireID = 1, VehicleID = 1, UserID = 1, CollectionDepot = "FCoT", ReturnDepot = "FCoT", CollectionDate = new DateTime (2023,11,08), ReturnDate = new DateTime (2023,12,08), DailyRate = 600, RentalStatus = "Unavailable"}
        );


    }
}