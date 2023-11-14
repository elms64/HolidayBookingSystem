using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookingProcessor.Models 
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

        [DisplayName("CheckInDate")]
        public DateTime CheckInDate { get; set; } 


        [DisplayName("CheckOutDate")]
         public DateTime CheckOutDate { get; set; } 
    }
}