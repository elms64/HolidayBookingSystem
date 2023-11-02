namespace BookingProcessor.Models
{
    public class VehicleHire
    {
        public int VehicleHireID { get; set; }
        public int VehicleID { get; set;  }
        public int UserID { get; set; }
        public string CollectionDepot { get; set; }
        public string ReturnDepot { get; set; }
        public DateTime CollectionDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal DailyRate { get; set; }
        public string RentalStatus { get; set; }

    }
}