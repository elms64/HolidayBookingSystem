using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookingProcessor.Models
{
    public class Vehicle
    {
        [Key]
        [DisplayName("Vehicle ID")]
        public int VehicleID { get; set; }

        [DisplayName("Body Type")]
        public string BodyType { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        [DisplayName("Hire Rate")]
        public decimal HireRate { get; set; }
    }
}