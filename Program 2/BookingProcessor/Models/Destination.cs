using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingProcessor.Models
{
public class Destination
{
    [Key]
    [DisplayName("Destination ID")]
    public int DestinationID { get; set; }

    [ForeignKey("Destination")]
    [DisplayName("Region ID")]
    public int RegionID { get; set; }

    [DisplayName("Destination")]
    public string DestinationName { get; set; }
}
}