using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookingProcessor.Models
{
    public class Vehicle
    {
        [Key]
        [DisplayName("Vehicle ID")]
        public int VehicleID { get; set; }
     
        [DisplayName("Vehicle Type")]
        public string VehicleType { get; set; }
    
        [DisplayName("PricePerDay")]
        public decimal PricePerDay { get; set; }
    }
}