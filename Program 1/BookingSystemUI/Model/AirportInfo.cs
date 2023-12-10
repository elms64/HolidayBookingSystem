using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookingSystemUI.Model
{
    public class AirportInfo
    {
        [JsonPropertyName("OriginAirports")]
        public List<Airport> DepartureAirports { get; set; }

        [JsonPropertyName("DestinationAirports")]
        public List<Airport> ArrivalAirports { get; set; }
    }
}
