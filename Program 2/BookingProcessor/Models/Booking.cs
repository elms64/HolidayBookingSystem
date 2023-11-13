using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingProcessor.Models
{
    public class Booking 
    {
        [Key]
        [DisplayName("Booking ID")]
        public int BookingID { get; set; }

        [ForeignKey("User")]
        [DisplayName("User ID")]
        public int UserID { get; set; }

        [ForeignKey("Hotel")]
        [DisplayName("Hotel ID")]
        public int HotelID { get; set; }

        [ForeignKey("Destination")]
        [DisplayName("Destination ID")]
        public int DestinationID { get; set; }

        [ForeignKey("Flight")]
        [DisplayName("Flight ID")]
        public int FlightID { get; set; }

        [DisplayName("Date of Purchase")]
        public DateTime PurchaseDate { get; set; }

        [ForeignKey("VehicleHire")]
        [DisplayName("Vehicle Hire ID")]
        public int VehicleHireID { get; set; }

        [ForeignKey("Insurance")]
        [DisplayName("Insurance ID")]
        public int InsuranceID { get; set; }

    }
}