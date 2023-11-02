using Microsoft.EntityFrameworkCore;

namespace BookingProcessor.Models
{
    public class BookingContext : DbContext
    {
        public DbSet<Airline> Airline { get; set; }
        public DbSet<Airport> Airport { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Destination> Destination { get; set ; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Insurance> Insurance { get; set; }
        public DbSet<Plan> Plan { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<SpecificFlight> SpecificFlight { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<VehicleHire> VehicleHire { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Data/booking_data.db");
        }
    }
}
