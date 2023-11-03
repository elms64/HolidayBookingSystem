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
        [DisplayName("Airport ID")]
        public int AirportID { get; set; }

        [ForeignKey("Airline")]
        [DisplayName("Airline ID")]
        public int AirlineID { get; set; }

        [ForeignKey("SpecificFlight")]
        [DisplayName("Specific Flight ID")]
        public int SpecificFlightID { get; set; }
    }
}