// GitHub Authors: @elms64, @Kloakk

/* Model for all expected datatypes relating to hotel booking information.
   Setup with Entity Framework Core to interact with the database programmatically */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientEmulator.Models
{
    public class HotelBooking
    {
        [Key]
        [DisplayName("Hotel Booking ID")]
        public int HotelBookingID { get; set; }

        [DisplayName("HotelID")]
        public int HotelID { get; set; }
        
        [DisplayName("RoomID")]
        public int RoomID { get; set; }

        [ForeignKey("Client")]
        [DisplayName("Client ID")]
        public int ClientID { get; set; }

        [DisplayName("CheckInDate")]
        public DateTime CheckInDate { get; set; } 


        [DisplayName("CheckOutDate")]
        public DateTime CheckOutDate { get; set; } 

        [DisplayName("Booking Status")]
        public string? BookingStatus { get; set; }


    }
}