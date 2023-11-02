namespace BookingProcessor.Models 
{
    public class SpecificFlight
    {
        public int SpecificFlightID { get; set; }
        public int FlightID { get; set; }
        public int AirlineID { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}