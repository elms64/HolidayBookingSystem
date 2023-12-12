

using System.Text.Json.Serialization;

namespace BookingSystemUI.Model
{

    public class Country
    {
        [JsonPropertyName("CountryID")]
        public int ID { get; set; }

        [JsonPropertyName("CountryName")]
        public string Name { get; set; }

    }

}