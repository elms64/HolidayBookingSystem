// GitHub Authors: @elms64, @Kloakk

/* Model for all expected datatypes relating to Airlines.
   Setup with Entity Framework Core to interact with the database programmatically */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClientEmulator.Models
{
public class Airline 
{
        [Key]
        [DisplayName("Airline ID")]
        public int AirlineID { get; set; }

       
        [DisplayName("Airline Name")]
        public string? AirlineName { get; set; }

        [DisplayName("Customer Service Number")]
        public string? PhoneNumber { get; set; }

        [DisplayName("Rating")]
        public double Rating { get; set; }

        [DisplayName("HeadQuarters")]
        public string? HQ { get; set; }
        
}
}