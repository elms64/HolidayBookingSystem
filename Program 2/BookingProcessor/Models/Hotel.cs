using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingProcessor.Models
{
public class Hotel
{
    [Key]
    [DisplayName("Hotel ID")]
    public int HotelID { get; set; }

    [DisplayName("Hotel")]
    public string HotelName { get; set; }

    [ForeignKey("Destination")]
    public int DestinationID { get; set; }

    [DisplayName("Address Line 1")]
    public string AddressLine1 { get; set; }

    [DisplayName("Address Line 2")]
    public string AddressLine2 { get; set; }

    public string City { get; set; }

    public string Postcode { get; set; }

    public int Telephone {get; set; }

    public int Rating {get ; set; }

}
}