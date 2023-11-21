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

    [ForeignKey("Country")]
    [DisplayName("CountryID")]
    public int CountryID { get; set; }


    [DisplayName("Hotel")]
    public string HotelName { get; set; }

    [DisplayName("Address Line 1")]
    public string AddressLine1 { get; set; }

    [DisplayName("Address Line 2")]
    public string AddressLine2 { get; set; }

    public string City { get; set; }

    public string Postcode { get; set; }

    public int PhoneNumber {get; set; }

    public double Rating {get ; set; }

    public int RoomCount { get; set; }

}
}