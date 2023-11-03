using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingProcessor.Models
{
    public class VehicleHire
    {
        [Key]
        [DisplayName("Vehicle Hire ID")]
        public int VehicleHireID { get; set; }

        [ForeignKey("Vehicle")]
        [DisplayName("Vehicle ID")]
        public int VehicleID { get; set;  }

        [ForeignKey("User")]
        [DisplayName("User ID")]
        public int UserID { get; set; }

        [DisplayName("Collection Depot")]
        public string CollectionDepot { get; set; }

        [DisplayName("Return Depot")]
        public string ReturnDepot { get; set; }

        [DisplayName("Collection Date")]
        public DateTime CollectionDate { get; set; }

        [DisplayName("Return Date")]
        public DateTime ReturnDate { get; set; }

        [DisplayName("Daily Rate")]
        public decimal DailyRate { get; set; }

        [DisplayName("Rental Status")]
        public string RentalStatus { get; set; }

    }
}