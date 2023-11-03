using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingProcessor.Models 
{
    public class SpecificFlight
    {
        [Key]
        [DisplayName("Specific Flight ID")]
        public int SpecificFlightID { get; set; }

        [ForeignKey("Flight")]
        [DisplayName("Flight ID")]
        public int FlightID { get; set; }

        [ForeignKey("Airline")]
        [DisplayName("Airline ID")]
        public int AirlineID { get; set; }

        [DisplayName("Departure Date")]
        public DateTime DepartureDate { get; set; }

        [DisplayName("Arrival Date")]
        public DateTime ArrivalDate { get; set; }
    }
}