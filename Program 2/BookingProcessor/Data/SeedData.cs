using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

public class SeedData {

    
    public static void Initialize(ModelBuilder modelBuilder){
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

        



    }


}