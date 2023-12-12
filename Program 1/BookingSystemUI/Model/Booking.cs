using BookingSystemUI.Model;


namespace BookingSystemUI.Model
{
    public class Booking
    {
        public Booking() { }

        public int OrderNumber { get; set; }

        public FlightDetails FlightDetails { get; set; }
        public Hotel Hotel { get; set; }    
        public Flight Flight { get; set; }
        public Vehicle Vehicle { get; set; }

        public Insurance Insurance { get; set; }
        public Basket Basket { get; set; }

        public override string ToString()
        {
            // Customize the string representation of the Booking object
            return $"Order Number: {OrderNumber}, Flight Details: {FlightDetails}";
        }
    }
}