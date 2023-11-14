using Microsoft.EntityFrameworkCore;

namespace BookingProcessor.Models
{
    
    public class BookingContext : DbContext
    {

        public BookingContext(){}


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
      
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Data/booking_data.db");
        }

        public BookingContext(DbContextOptions<BookingContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData.Initialize(modelBuilder);
        }
    }
}
