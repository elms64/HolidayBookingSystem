namespace BookingProcessor.Models
{
public class Hotel
{
    public int HotelID { get; set; }
    public string HotelName { get; set; }
    public int DestinationID { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string City { get; set; }
    public string Postcode { get; set; }
    public int Telephone {get; set; }
    public int Rating {get ; set; }

}
}