﻿// <auto-generated />
using System;
using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookingProcessor.Migrations
{
    [DbContext(typeof(BookingContext))]
    partial class BookingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("BookingProcessor.Models.Airline", b =>
                {
                    b.Property<int>("AirlineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AirlineName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AirlineID");

                    b.ToTable("Airline");

                    b.HasData(
                        new
                        {
                            AirlineID = 1,
                            AirlineName = "EasyJet"
                        },
                        new
                        {
                            AirlineID = 2,
                            AirlineName = "British Airways"
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Airport", b =>
                {
                    b.Property<int>("AirportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AirportName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CountryID")
                        .HasColumnType("INTEGER");

                    b.HasKey("AirportID");

                    b.ToTable("Airport");

                    b.HasData(
                        new
                        {
                            AirportID = 1,
                            AirportName = "Gatwick",
                            CountryID = 0
                        },
                        new
                        {
                            AirportID = 2,
                            AirportName = "Luton",
                            CountryID = 0
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DestinationID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FlightID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HotelID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InsuranceID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VehicleHireID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BookingID");

                    b.ToTable("Booking");

                    b.HasData(
                        new
                        {
                            BookingID = 1,
                            DestinationID = 1,
                            FlightID = 1,
                            HotelID = 1,
                            InsuranceID = 1,
                            PurchaseDate = new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserID = 1,
                            VehicleHireID = 1
                        },
                        new
                        {
                            BookingID = 2,
                            DestinationID = 2,
                            FlightID = 2,
                            HotelID = 2,
                            InsuranceID = 2,
                            PurchaseDate = new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserID = 2,
                            VehicleHireID = 2
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Climate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CountryID");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            CountryID = 1,
                            Climate = "Temperate",
                            CountryName = "England"
                        },
                        new
                        {
                            CountryID = 2,
                            Climate = "Incredibly Unbelievably Rainy",
                            CountryName = "Wales"
                        },
                        new
                        {
                            CountryID = 3,
                            Climate = "Varied",
                            CountryName = "France"
                        },
                        new
                        {
                            CountryID = 4,
                            Climate = "Mediterranean",
                            CountryName = "Italy"
                        },
                        new
                        {
                            CountryID = 5,
                            Climate = "Diverse",
                            CountryName = "Germany"
                        },
                        new
                        {
                            CountryID = 6,
                            Climate = "Mediterranean",
                            CountryName = "Spain"
                        },
                        new
                        {
                            CountryID = 7,
                            Climate = "Diverse",
                            CountryName = "USA"
                        },
                        new
                        {
                            CountryID = 8,
                            Climate = "Varied",
                            CountryName = "Japan"
                        },
                        new
                        {
                            CountryID = 9,
                            Climate = "Tropical",
                            CountryName = "Brazil"
                        },
                        new
                        {
                            CountryID = 10,
                            Climate = "Varied",
                            CountryName = "Canada"
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Destination", b =>
                {
                    b.Property<int>("DestinationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DestinationName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RegionID")
                        .HasColumnType("INTEGER");

                    b.HasKey("DestinationID");

                    b.ToTable("Destination");

                    b.HasData(
                        new
                        {
                            DestinationID = 1,
                            DestinationName = "London",
                            RegionID = 1
                        },
                        new
                        {
                            DestinationID = 2,
                            DestinationName = "Cornwall",
                            RegionID = 1
                        },
                        new
                        {
                            DestinationID = 3,
                            DestinationName = "Dubai",
                            RegionID = 2
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Flight", b =>
                {
                    b.Property<int>("FlightID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AirlineID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArrivalAirportID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ArrivalDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("BookedSeats")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DepartureAirportID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DepartureDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("FlightCost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxSeats")
                        .HasColumnType("INTEGER");

                    b.HasKey("FlightID");

                    b.ToTable("Flight");

                    b.HasData(
                        new
                        {
                            FlightID = 1,
                            AirlineID = 1,
                            ArrivalAirportID = 1,
                            ArrivalDateTime = new DateTime(2023, 11, 8, 17, 26, 11, 0, DateTimeKind.Unspecified),
                            BookedSeats = 5,
                            DepartureAirportID = 1,
                            DepartureDateTime = new DateTime(2023, 12, 8, 17, 26, 11, 0, DateTimeKind.Unspecified),
                            FlightCost = 0,
                            MaxSeats = 100
                        },
                        new
                        {
                            FlightID = 2,
                            AirlineID = 2,
                            ArrivalAirportID = 1,
                            ArrivalDateTime = new DateTime(2024, 1, 8, 17, 26, 11, 0, DateTimeKind.Unspecified),
                            BookedSeats = 5,
                            DepartureAirportID = 1,
                            DepartureDateTime = new DateTime(2024, 1, 8, 17, 26, 11, 0, DateTimeKind.Unspecified),
                            FlightCost = 0,
                            MaxSeats = 100
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Hotel", b =>
                {
                    b.Property<int>("HotelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DestinationID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Telephone")
                        .HasColumnType("INTEGER");

                    b.HasKey("HotelID");

                    b.ToTable("Hotel");

                    b.HasData(
                        new
                        {
                            HotelID = 1,
                            AddressLine1 = "SampleAddressLine1",
                            AddressLine2 = "SampleAddressLine2",
                            City = "Fleet",
                            DestinationID = 1,
                            HotelName = "The Lismoyne",
                            Postcode = "GU51 4HG",
                            Rating = 4,
                            Telephone = 1252810170
                        },
                        new
                        {
                            HotelID = 2,
                            AddressLine1 = "SampleAddress2Line1",
                            AddressLine2 = "SampleAddress2Line2",
                            City = "Farnborough",
                            DestinationID = 2,
                            HotelName = "The Four Seasons",
                            Postcode = "GU52 3EB",
                            Rating = 5,
                            Telephone = 1252810171
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Insurance", b =>
                {
                    b.Property<int>("InsuranceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("PlanID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PremiumCost")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("InsuranceID");

                    b.ToTable("Insurance");

                    b.HasData(
                        new
                        {
                            InsuranceID = 1,
                            Active = true,
                            EndDate = new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PlanID = 1,
                            PremiumCost = 100m,
                            StartDate = new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Plan", b =>
                {
                    b.Property<int>("PlanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Cost")
                        .HasColumnType("TEXT");

                    b.Property<string>("CoverType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PlanID");

                    b.ToTable("Plan");

                    b.HasData(
                        new
                        {
                            PlanID = 1,
                            Cost = 100m,
                            CoverType = "Comprehensive"
                        },
                        new
                        {
                            PlanID = 2,
                            Cost = 100m,
                            CoverType = "Comprehensive"
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Region", b =>
                {
                    b.Property<int>("RegionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeZone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RegionID");

                    b.ToTable("Region");

                    b.HasData(
                        new
                        {
                            RegionID = 1,
                            CountryID = 1,
                            RegionName = "London",
                            TimeZone = "GMT"
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Available")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HotelID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PricePerNight")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoomNo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RoomID");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            RoomID = 1,
                            Available = true,
                            HotelID = 1,
                            PricePerNight = 100m,
                            RoomNo = 69,
                            RoomType = "Double"
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserID");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            BirthDate = new DateTime(2003, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Kloakk2@gmail.com",
                            FirstName = "Alex",
                            LastName = "Lovelock",
                            Password = "Admin1",
                            Telephone = "01252810170",
                            Username = "Alex"
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BodyType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("HireRate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VehicleID");

                    b.ToTable("Vehicle");

                    b.HasData(
                        new
                        {
                            VehicleID = 1,
                            BodyType = "Coupe",
                            HireRate = 500m,
                            Make = "BMW",
                            Model = "3 Series"
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.VehicleHire", b =>
                {
                    b.Property<int>("VehicleHireID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CollectionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CollectionDepot")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("DailyRate")
                        .HasColumnType("TEXT");

                    b.Property<string>("RentalStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReturnDepot")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VehicleID")
                        .HasColumnType("INTEGER");

                    b.HasKey("VehicleHireID");

                    b.ToTable("VehicleHire");

                    b.HasData(
                        new
                        {
                            VehicleHireID = 1,
                            CollectionDate = new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollectionDepot = "FCoT",
                            DailyRate = 600m,
                            RentalStatus = "Unavailable",
                            ReturnDate = new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDepot = "FCoT",
                            UserID = 1,
                            VehicleID = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
