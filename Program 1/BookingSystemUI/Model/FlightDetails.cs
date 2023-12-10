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
    public class FlightDetails
    {

        public int DepartureAirportID { get; set; }

        public int ArrivalAirportID { get; set; }

        public DateTime DepartureDateTime { get; set; }

        public DateTime ArrivalDateTime { get; set; }

        public Country ArrivalCountry {  get; set; }

        public Country DepartureCountry { get; set; }
        public override string ToString()
        {
            // Customize the string representation of the FlightDetails object
            return $"Departure Airport ID: {DepartureAirportID}, Arrival Airport ID: {ArrivalAirportID}, " +
                   $"Departure DateTime: {DepartureDateTime}, Arrival DateTime: {ArrivalDateTime}, " +
                   $"Departure Country: {DepartureCountry.Name}, Arrival Country: {ArrivalCountry.Name}";
        }
    }
}
