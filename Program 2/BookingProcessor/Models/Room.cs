namespace BookingProcessor.Models
{
public class Room
{
    public int RoomID { get; set; }
    public int HotelID { get; set; }
    public string RoomType { get; set; }
    public int RoomNo { get; set; }
    public decimal PricePerNight { get; set; }
    public bool Available { get; set; }
}
}