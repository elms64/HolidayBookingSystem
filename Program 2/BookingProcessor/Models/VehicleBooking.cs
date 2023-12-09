// GitHub Authors: @gjepic

/* Model for all expected datatypes relating to vehicle booking information.
   Setup with Entity Framework Core to interact with the database programmatically */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingProcessor.Models
{
    public class VehicleBooking
    {
        [Key]
        [DisplayName("Vehicle Booking ID")]
        public int VehicleBookingID { get; set; }

        [ForeignKey("Vehicle")]
        [DisplayName("Vehicle ID")]
        public int VehicleID { get; set;  }

        [DisplayName("Pick Up Date")]
        public DateTime PickUpDate { get; set; }

        [DisplayName("Drop Off Date")]
        public DateTime DropOffDate { get; set; }

        [DisplayName("Booking Status")]
        public string? BookingStatus { get; set; }
    }
}