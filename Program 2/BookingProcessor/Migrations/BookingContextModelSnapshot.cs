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

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Rating")
                        .HasColumnType("REAL");

                    b.HasKey("AirlineID");

                    b.ToTable("Airline");

                    b.HasData(
                        new
                        {
                            AirlineID = 1,
                            AirlineName = "Example Airline 1",
                            PhoneNumber = "123-456-7890",
                            Rating = 4.5
                        },
                        new
                        {
                            AirlineID = 2,
                            AirlineName = "Example Airline 2",
                            PhoneNumber = "987-654-3210",
                            Rating = 3.7999999999999998
                        },
                        new
                        {
                            AirlineID = 3,
                            AirlineName = "Example Airline 3",
                            PhoneNumber = "555-123-4567",
                            Rating = 4.2000000000000002
                        },
                        new
                        {
                            AirlineID = 4,
                            AirlineName = "Example Airline 4",
                            PhoneNumber = "333-777-8888",
                            Rating = 3.5
                        },
                        new
                        {
                            AirlineID = 5,
                            AirlineName = "Example Airline 5",
                            PhoneNumber = "111-222-3333",
                            Rating = 4.0
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
                            AirportName = "Example Airport 1",
                            CountryID = 1
                        },
                        new
                        {
                            AirportID = 2,
                            AirportName = "Example Airport 2",
                            CountryID = 2
                        },
                        new
                        {
                            AirportID = 3,
                            AirportName = "Example Airport 3",
                            CountryID = 3
                        },
                        new
                        {
                            AirportID = 4,
                            AirportName = "Example Airport 4",
                            CountryID = 4
                        },
                        new
                        {
                            AirportID = 5,
                            AirportName = "Example Airport 5",
                            CountryID = 5
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountryID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FlightID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HotelBookingID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InsuranceBookingID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("VehicleBookingID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BookingID");

                    b.ToTable("Booking");

                    b.HasData(
                        new
                        {
                            BookingID = 1,
                            ClientID = 1,
                            CountryID = 1,
                            FlightID = 1,
                            HotelBookingID = 1,
                            InsuranceBookingID = 1,
                            PurchaseDate = new DateTime(2023, 11, 14, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(116),
                            VehicleBookingID = 1
                        },
                        new
                        {
                            BookingID = 2,
                            ClientID = 2,
                            CountryID = 2,
                            FlightID = 2,
                            HotelBookingID = 2,
                            InsuranceBookingID = 2,
                            PurchaseDate = new DateTime(2023, 11, 14, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(160),
                            VehicleBookingID = 2
                        },
                        new
                        {
                            BookingID = 3,
                            ClientID = 3,
                            CountryID = 3,
                            FlightID = 3,
                            HotelBookingID = 3,
                            InsuranceBookingID = 3,
                            PurchaseDate = new DateTime(2023, 11, 14, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(162),
                            VehicleBookingID = 3
                        },
                        new
                        {
                            BookingID = 4,
                            ClientID = 4,
                            CountryID = 4,
                            FlightID = 4,
                            HotelBookingID = 4,
                            InsuranceBookingID = 4,
                            PurchaseDate = new DateTime(2023, 11, 14, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(165),
                            VehicleBookingID = 4
                        },
                        new
                        {
                            BookingID = 5,
                            ClientID = 5,
                            CountryID = 5,
                            FlightID = 5,
                            HotelBookingID = 5,
                            InsuranceBookingID = 5,
                            PurchaseDate = new DateTime(2023, 11, 14, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(167),
                            VehicleBookingID = 5
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
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

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClientID");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            ClientID = 1,
                            BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "123-456-7890"
                        },
                        new
                        {
                            ClientID = 2,
                            BirthDate = new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            PhoneNumber = "987-654-3210"
                        },
                        new
                        {
                            ClientID = 3,
                            BirthDate = new DateTime(1992, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            PhoneNumber = "555-123-4567"
                        },
                        new
                        {
                            ClientID = 4,
                            BirthDate = new DateTime(1980, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bob.anderson@example.com",
                            FirstName = "Bob",
                            LastName = "Anderson",
                            PhoneNumber = "333-777-8888"
                        },
                        new
                        {
                            ClientID = 5,
                            BirthDate = new DateTime(1988, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "eva.williams@example.com",
                            FirstName = "Eva",
                            LastName = "Williams",
                            PhoneNumber = "111-222-3333"
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
                            CountryName = "Country 1"
                        },
                        new
                        {
                            CountryID = 2,
                            Climate = "Tropical",
                            CountryName = "Country 2"
                        },
                        new
                        {
                            CountryID = 3,
                            Climate = "Desert",
                            CountryName = "Country 3"
                        },
                        new
                        {
                            CountryID = 4,
                            Climate = "Arctic",
                            CountryName = "Country 4"
                        },
                        new
                        {
                            CountryID = 5,
                            Climate = "Mediterranean",
                            CountryName = "Country 5"
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
                            ArrivalAirportID = 2,
                            ArrivalDateTime = new DateTime(2023, 11, 22, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(238),
                            BookedSeats = 50,
                            DepartureAirportID = 1,
                            DepartureDateTime = new DateTime(2023, 11, 21, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(234),
                            FlightCost = 500,
                            MaxSeats = 100
                        },
                        new
                        {
                            FlightID = 2,
                            AirlineID = 2,
                            ArrivalAirportID = 3,
                            ArrivalDateTime = new DateTime(2023, 11, 26, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(245),
                            BookedSeats = 30,
                            DepartureAirportID = 2,
                            DepartureDateTime = new DateTime(2023, 11, 24, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(241),
                            FlightCost = 450,
                            MaxSeats = 80
                        },
                        new
                        {
                            FlightID = 3,
                            AirlineID = 3,
                            ArrivalAirportID = 4,
                            ArrivalDateTime = new DateTime(2023, 12, 1, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(248),
                            BookedSeats = 70,
                            DepartureAirportID = 3,
                            DepartureDateTime = new DateTime(2023, 11, 29, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(247),
                            FlightCost = 600,
                            MaxSeats = 120
                        },
                        new
                        {
                            FlightID = 4,
                            AirlineID = 4,
                            ArrivalAirportID = 5,
                            ArrivalDateTime = new DateTime(2023, 12, 6, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(252),
                            BookedSeats = 40,
                            DepartureAirportID = 4,
                            DepartureDateTime = new DateTime(2023, 12, 4, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(250),
                            FlightCost = 550,
                            MaxSeats = 100
                        },
                        new
                        {
                            FlightID = 5,
                            AirlineID = 5,
                            ArrivalAirportID = 1,
                            ArrivalDateTime = new DateTime(2023, 12, 11, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(255),
                            BookedSeats = 60,
                            DepartureAirportID = 5,
                            DepartureDateTime = new DateTime(2023, 12, 9, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(254),
                            FlightCost = 480,
                            MaxSeats = 80
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

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Rating")
                        .HasColumnType("REAL");

                    b.Property<int>("RoomCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("HotelID");

                    b.ToTable("Hotel");

                    b.HasData(
                        new
                        {
                            HotelID = 1,
                            AddressLine1 = "123 Main St",
                            AddressLine2 = "Apt 45",
                            City = "Cityville",
                            HotelName = "Example Hotel 1",
                            PhoneNumber = 5551234,
                            Postcode = "12345",
                            Rating = 4.0,
                            RoomCount = 50
                        },
                        new
                        {
                            HotelID = 2,
                            AddressLine1 = "456 Oak St",
                            AddressLine2 = "Suite 22",
                            City = "Townsville",
                            HotelName = "Example Hotel 2",
                            PhoneNumber = 5555678,
                            Postcode = "67890",
                            Rating = 3.5,
                            RoomCount = 40
                        },
                        new
                        {
                            HotelID = 3,
                            AddressLine1 = "789 Pine St",
                            AddressLine2 = "Unit 33",
                            City = "Villagetown",
                            HotelName = "Example Hotel 3",
                            PhoneNumber = 5559999,
                            Postcode = "10111",
                            Rating = 4.2000000000000002,
                            RoomCount = 60
                        },
                        new
                        {
                            HotelID = 4,
                            AddressLine1 = "101 Cedar St",
                            AddressLine2 = "Apt 10",
                            City = "Mountainview",
                            HotelName = "Example Hotel 4",
                            PhoneNumber = 5554321,
                            Postcode = "54321",
                            Rating = 3.7999999999999998,
                            RoomCount = 45
                        },
                        new
                        {
                            HotelID = 5,
                            AddressLine1 = "202 Birch St",
                            AddressLine2 = "Suite 5",
                            City = "Laketown",
                            HotelName = "Example Hotel 5",
                            PhoneNumber = 5551111,
                            Postcode = "87654",
                            Rating = 4.5,
                            RoomCount = 55
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.HotelBooking", b =>
                {
                    b.Property<int>("HotelBookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("HotelID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoomID")
                        .HasColumnType("INTEGER");

                    b.HasKey("HotelBookingID");

                    b.ToTable("HotelBooking");

                    b.HasData(
                        new
                        {
                            HotelBookingID = 1,
                            CheckInDate = new DateTime(2023, 11, 21, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(291),
                            CheckOutDate = new DateTime(2023, 11, 28, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(293),
                            HotelID = 1,
                            RoomID = 1
                        },
                        new
                        {
                            HotelBookingID = 2,
                            CheckInDate = new DateTime(2023, 11, 24, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(295),
                            CheckOutDate = new DateTime(2023, 12, 1, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(297),
                            HotelID = 2,
                            RoomID = 2
                        },
                        new
                        {
                            HotelBookingID = 3,
                            CheckInDate = new DateTime(2023, 11, 29, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(299),
                            CheckOutDate = new DateTime(2023, 12, 6, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(300),
                            HotelID = 3,
                            RoomID = 3
                        },
                        new
                        {
                            HotelBookingID = 4,
                            CheckInDate = new DateTime(2023, 12, 4, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(302),
                            CheckOutDate = new DateTime(2023, 12, 11, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(303),
                            HotelID = 4,
                            RoomID = 4
                        },
                        new
                        {
                            HotelBookingID = 5,
                            CheckInDate = new DateTime(2023, 12, 9, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(305),
                            CheckOutDate = new DateTime(2023, 12, 16, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(306),
                            HotelID = 5,
                            RoomID = 5
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Insurance", b =>
                {
                    b.Property<int>("InsuranceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("InsuranceType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("PricePerDay")
                        .HasColumnType("REAL");

                    b.HasKey("InsuranceID");

                    b.ToTable("Insurance");

                    b.HasData(
                        new
                        {
                            InsuranceID = 1,
                            InsuranceType = "Basic",
                            PricePerDay = 10.5
                        },
                        new
                        {
                            InsuranceID = 2,
                            InsuranceType = "Standard",
                            PricePerDay = 15.75
                        },
                        new
                        {
                            InsuranceID = 3,
                            InsuranceType = "Premium",
                            PricePerDay = 20.0
                        },
                        new
                        {
                            InsuranceID = 4,
                            InsuranceType = "Extended",
                            PricePerDay = 25.5
                        },
                        new
                        {
                            InsuranceID = 5,
                            InsuranceType = "Deluxe",
                            PricePerDay = 30.0
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.InsuranceBooking", b =>
                {
                    b.Property<int>("InsuranceBookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("InsuranceID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("InsuranceBookingID");

                    b.ToTable("InsuranceBooking");

                    b.HasData(
                        new
                        {
                            InsuranceBookingID = 1,
                            EndDate = new DateTime(2023, 11, 28, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(341),
                            InsuranceID = 1,
                            StartDate = new DateTime(2023, 11, 21, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(339)
                        },
                        new
                        {
                            InsuranceBookingID = 2,
                            EndDate = new DateTime(2023, 12, 1, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(345),
                            InsuranceID = 2,
                            StartDate = new DateTime(2023, 11, 24, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(343)
                        },
                        new
                        {
                            InsuranceBookingID = 3,
                            EndDate = new DateTime(2023, 12, 6, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(348),
                            InsuranceID = 3,
                            StartDate = new DateTime(2023, 11, 29, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(346)
                        },
                        new
                        {
                            InsuranceBookingID = 4,
                            EndDate = new DateTime(2023, 12, 11, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(351),
                            InsuranceID = 4,
                            StartDate = new DateTime(2023, 12, 4, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(350)
                        },
                        new
                        {
                            InsuranceBookingID = 5,
                            EndDate = new DateTime(2023, 12, 16, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(354),
                            InsuranceID = 5,
                            StartDate = new DateTime(2023, 12, 9, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(353)
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
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
                            HotelID = 1,
                            PricePerNight = 100m,
                            RoomNo = 101,
                            RoomType = "Standard"
                        },
                        new
                        {
                            RoomID = 2,
                            HotelID = 2,
                            PricePerNight = 150m,
                            RoomNo = 201,
                            RoomType = "Deluxe"
                        },
                        new
                        {
                            RoomID = 3,
                            HotelID = 3,
                            PricePerNight = 200m,
                            RoomNo = 301,
                            RoomType = "Suite"
                        },
                        new
                        {
                            RoomID = 4,
                            HotelID = 4,
                            PricePerNight = 110m,
                            RoomNo = 102,
                            RoomType = "Standard"
                        },
                        new
                        {
                            RoomID = 5,
                            HotelID = 5,
                            PricePerNight = 180m,
                            RoomNo = 202,
                            RoomType = "Suite"
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PricePerDay")
                        .HasColumnType("TEXT");

                    b.Property<string>("VehicleType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VehicleID");

                    b.ToTable("Vehicle");

                    b.HasData(
                        new
                        {
                            VehicleID = 1,
                            PricePerDay = 45.0m,
                            VehicleType = "Compact Car"
                        },
                        new
                        {
                            VehicleID = 2,
                            PricePerDay = 60.0m,
                            VehicleType = "SUV"
                        },
                        new
                        {
                            VehicleID = 3,
                            PricePerDay = 75.0m,
                            VehicleType = "Van"
                        },
                        new
                        {
                            VehicleID = 4,
                            PricePerDay = 100.0m,
                            VehicleType = "Luxury Car"
                        },
                        new
                        {
                            VehicleID = 5,
                            PricePerDay = 30.0m,
                            VehicleType = "Motorcycle"
                        });
                });

            modelBuilder.Entity("BookingProcessor.Models.VehicleBooking", b =>
                {
                    b.Property<int>("VehicleBookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DropOffDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PickUpDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("VehicleID")
                        .HasColumnType("INTEGER");

                    b.HasKey("VehicleBookingID");

                    b.ToTable("VehicleBooking");

                    b.HasData(
                        new
                        {
                            VehicleBookingID = 1,
                            DropOffDate = new DateTime(2023, 11, 28, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(411),
                            PickUpDate = new DateTime(2023, 11, 21, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(409),
                            VehicleID = 1
                        },
                        new
                        {
                            VehicleBookingID = 2,
                            DropOffDate = new DateTime(2023, 12, 1, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(414),
                            PickUpDate = new DateTime(2023, 11, 24, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(413),
                            VehicleID = 2
                        },
                        new
                        {
                            VehicleBookingID = 3,
                            DropOffDate = new DateTime(2023, 12, 6, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(418),
                            PickUpDate = new DateTime(2023, 11, 29, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(416),
                            VehicleID = 3
                        },
                        new
                        {
                            VehicleBookingID = 4,
                            DropOffDate = new DateTime(2023, 12, 11, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(427),
                            PickUpDate = new DateTime(2023, 12, 4, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(426),
                            VehicleID = 4
                        },
                        new
                        {
                            VehicleBookingID = 5,
                            DropOffDate = new DateTime(2023, 12, 16, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(430),
                            PickUpDate = new DateTime(2023, 12, 9, 16, 20, 59, 423, DateTimeKind.Local).AddTicks(429),
                            VehicleID = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
