// GitHub Authors: @elms64, @Kloakk
/* Model for all expected datatypes relating to Flights.
   Setup with Entity Framework Core to interact with the database programmatically */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingProcessor.Models
{
    public class Flight
    {
        [Key]
        [DisplayName("Flight ID")]
        public int FlightID { get; set; }

        [ForeignKey("Airport")]
        [DisplayName("Departure Airport ID ")]
        public int DepartureAirportID { get; set; }

        [ForeignKey("Airport")]
        [DisplayName("Arrival Airport ID")]
        public int ArrivalAirportID { get; set; }

        [ForeignKey("Airline")]
        [DisplayName("Airline ID")]
        public int AirlineID { get; set; }

        [DisplayName("Booked Seats")]
        public int BookedSeats { get; set; }
        
        [DisplayName("Max Seats")]
        public int MaxSeats { get; set; }
        
        [DisplayName ("Departure Date Time")]
        public DateTime DepartureDateTime { get; set; }

        [DisplayName ("Arrival Date Time")]
        public DateTime ArrivalDateTime { get; set; }

        [DisplayName ("Flight Cost")]
        public int FlightCost { get; set; } 

    }
}