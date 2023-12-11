// GitHub Authors: @elms64, @Kloakk
/* Model for all expected datatypes relating to flight booking information.
   Setup with Entity Framework Core to interact with the database programmatically */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientEmulator.Models
{
    public class FlightBooking
    {
        [Key]
        [DisplayName("Flight Booking ID")]
        public int FlightBookingID { get; set; }

        [ForeignKey("Flight")]
        [DisplayName("Flight ID")]
        public int FlightID { get; set; }

        [ForeignKey("Client")]
        [DisplayName("Client ID")]
        public int ClientID { get; set; }

        [DisplayName("Booking Status")]
        public string? BookingStatus { get; set; }

    }
}