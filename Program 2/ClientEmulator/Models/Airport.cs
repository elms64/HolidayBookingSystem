// GitHub Authors: @gjepic

/* Model for all expected datatypes relating to Airports.
   Setup with Entity Framework Core to interact with the database programmatically */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientEmulator.Models
{
public class Airport 
{
    [Key]
    [DisplayName("Airport ID")]
    public int AirportID { get; set; }
    
    [ForeignKey("Country")]
    [DisplayName("Country ID")]
    public int CountryID { get; set; }
    
    [DisplayName("Airport Name")]
    public string? AirportName { get; set; }

    
}
}