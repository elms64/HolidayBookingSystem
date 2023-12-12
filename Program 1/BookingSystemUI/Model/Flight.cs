using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemUI.Model
{
    public class Flight
    {
        public int FlightID { get; set; }
        public int DepartureAirportID { get; set; }
        public int ArrivalAirportID { get; set; }
        public int AirlineID { get; set; }
        public int BookedSeats { get; set; }
        public int MaxSeats { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public int FlightCost { get; set; }

        public override string ToString()
        {
            return $"Flight ID: {FlightID}, " +
                   $"Departure Airport ID: {DepartureAirportID}, " +
                   $"Arrival Airport ID: {ArrivalAirportID}, " +
                   $"Airline ID: {AirlineID}, " +
                   $"Booked Seats: {BookedSeats}, " +
                   $"Max Seats: {MaxSeats}, " +
                   $"Departure Date Time: {DepartureDateTime}, " +
                   $"Arrival Date Time: {ArrivalDateTime}, " +
                   $"Flight Cost: {FlightCost}";
        }
    }
}
