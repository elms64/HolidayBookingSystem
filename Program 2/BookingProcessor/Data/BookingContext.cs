// GitHub authors: @elms64 & @gjepic

/* Entity Framework Database Context, defining Models to be scaffolded with a SQLite DB schema.
 * This code must be reconfigured to use other SQL database providers such as SQL Server or MySQL. */

// System Libraries and Packages
using Microsoft.EntityFrameworkCore;
using BookingProcessor.Data;

namespace BookingProcessor.Models
{

    public class BookingContext : DbContext
    {
        // Links all classes in the Models folder with the database context.
        public BookingContext() { }
        public DbSet<Airline> Airline { get; set; }
        public DbSet<Airport> Airport { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<HotelBooking> HotelBooking { get; set; }
        public DbSet<Insurance> Insurance { get; set; }
        public DbSet<InsuranceBooking> InsuranceBooking { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<VehicleBooking> VehicleBooking { get; set; }

        // Builds the database using SQLite.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Data/booking_data.db");
        }

        public BookingContext(DbContextOptions<BookingContext> options) : base(options)
        {

        }

        // References seed data classes to bring some test data into the database.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData.Initialize(modelBuilder);
            SeedCountries.Initialize(modelBuilder);
        }
    }
}
