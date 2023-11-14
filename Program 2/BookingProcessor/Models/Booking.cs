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

        [ForeignKey("HotelBooking")]
        [DisplayName("Hotel Booking ID")]
        public int HotelBookingID { get; set; }

        [ForeignKey("Country")]
        [DisplayName("Country ID")]
        public int CountryID { get; set; }

        [ForeignKey("Flight")]
        [DisplayName("Flight ID")]
        public int FlightID { get; set; }

        [DisplayName("Date of Purchase")]
        public DateTime PurchaseDate { get; set; }

        [ForeignKey("VehicleBooking")]
        [DisplayName("Vehicle Booking ID")]
        public int VehicleBookingID { get; set; }

        [ForeignKey("Client")]
        [DisplayName("Client ID")]
        public int ClientID { get; set; }

        [ForeignKey("InsuranceBooking")]
        [DisplayName("Insurance Booking ID")]
        public int InsuranceBookingID { get; set; }

    }
}