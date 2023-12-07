// GitHub Authors: @gjepic

/* Model for all expected datatypes relating to hotel rooms.
   Setup with Entity Framework Core to interact with the database programmatically */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientEmulator.Models
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
    public string? RoomType { get; set; }

    [DisplayName("Room Number")]
    public int RoomNo { get; set; }

    [DisplayName("Price Per Night")]
    public decimal PricePerNight { get; set; }
    
    
}
}