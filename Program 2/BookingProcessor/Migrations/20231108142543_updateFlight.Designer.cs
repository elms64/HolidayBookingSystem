﻿// <auto-generated />
using System;
using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookingProcessor.Migrations
{
    [DbContext(typeof(BookingContext))]
    [Migration("20231108142543_updateFlight")]
    partial class updateFlight
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("MaxSeats")
                        .HasColumnType("INTEGER");

                    b.HasKey("FlightID");

                    b.ToTable("Flight");
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
                });
#pragma warning restore 612, 618
        }
    }
}