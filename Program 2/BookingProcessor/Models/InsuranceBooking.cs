using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingProcessor.Models 
{
    public class InsuranceBooking
    {
        [Key]
        [DisplayName("Insurance Booking ID")]
        public int InsuranceBookingID { get; set; }

        [ForeignKey("Insurance")]
        [DisplayName("Insurance ID")]
        public int InsuranceID { get; set; }

        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

    }
}