using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingProcessor.Models
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
    public string AirportName { get; set; }
}
}