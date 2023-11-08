using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingProcessor.Models
{
public class Room
{
    [Key]
    [DisplayName("Room ID")]
    public int RoomID { get; set; }

    [ForeignKey("Hotel")]
    [DisplayName("Hotel ID")]
    public int HotelID { get; set; }

    [DisplayName("Room Type")]
    public string RoomType { get; set; }

    [DisplayName("Room Number")]
    public int RoomNo { get; set; }

    [DisplayName("Price Per Night")]
    public decimal PricePerNight { get; set; }
    
    public bool Available { get; set; }
}
}