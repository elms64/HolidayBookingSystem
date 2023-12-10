using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookingSystemUI.Model
{
    public class Airport
    {
        [JsonPropertyName("AirportID")]
        public int ID { get; set; }

        [JsonPropertyName("AirportName")]
        public String Name { get; set; }

        [JsonPropertyName("CountryID")]
        public int CountryID { get; set; }


       
    }
}
