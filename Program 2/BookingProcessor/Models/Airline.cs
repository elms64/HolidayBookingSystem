using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookingProcessor.Models
{
public class Airline 
{
    [Key]
    [DisplayName("Airline ID")]
    public int AirlineID { get; set; }

    [DisplayName("Airline Name")]
    public string AirlineName { get; set; }
    
}
}