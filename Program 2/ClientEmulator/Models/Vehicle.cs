// GitHub Authors: @gjepic

/* Model for all expected datatypes relating to Vehicles.
   Setup with Entity Framework Core to interact with the database programmatically */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClientEmulator.Models
{
    public class Vehicle
    {
        [Key]
        [DisplayName("Vehicle ID")]
        public int VehicleID { get; set; }
     
        [DisplayName("Vehicle Type")]
        public string? VehicleType { get; set; }
    
        [DisplayName("PricePerDay")]
        public decimal PricePerDay { get; set; }
    }
}