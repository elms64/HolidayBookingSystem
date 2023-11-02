namespace BookingProcessor.Models
{
public class Booking 
{
    public int BookingID { get; set; }
    public int UserID { get; set; }
    public int HotelID { get; set; }
    public int DestinationID { get; set; }
    public int FlightID { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int VehicleHireID { get; set; }
    public int InsuranceID { get; set; }

}
}