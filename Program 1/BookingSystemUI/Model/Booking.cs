using BookingSystemUI.Model;


namespace BookingSystemUI.Model
{
    public class Booking
    {
        public Booking() { }

        public int OrderNumber { get; set; }

        public FlightDetails FlightDetails { get; set; }

        public override string ToString()
        {
            // Customize the string representation of the Booking object
            return $"Order Number: {OrderNumber}, Flight Details: {FlightDetails}";
        }
    }
}