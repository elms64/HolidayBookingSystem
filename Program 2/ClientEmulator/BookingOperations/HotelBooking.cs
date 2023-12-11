// GitHub Authors: @elms64 & @Kloakk

// Creates a hotel booking PUT request and sends it over HTTP to the server

using System.Text;
using System.Text.Json;

namespace ClientEmulator
{
    public class HotelBooking
    {
        private static readonly string ConsoleAppUrl = "http://localhost:8080";
        private static readonly HttpClient httpClient = new HttpClient();
        
        public async Task<int> HotelBookingAsync(string HotelID, string RoomID, int ClientID)
        {
            string serverURL = ConsoleAppUrl + "/HotelBooking";

            var HotelBooking = new List<KeyValuePair<string, string>>();

            HotelBooking.Add(new KeyValuePair<string, string>("HotelID", HotelID));
            HotelBooking.Add(new KeyValuePair<string, string>("RoomID", RoomID));

            string jsonPayload = JsonSerializer.Serialize(HotelBooking);
            StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PutAsync(serverURL, content);

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                // Read the response content
                string responseContent = await response.Content.ReadAsStringAsync();

                // Parse the JSON response to get the HotelBookingID
                var responseObject = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(responseContent);
                if (responseObject!.TryGetValue("HotelBookingID", out JsonElement hotelBookingIDElement))
                {
                    // Extract the value from JsonElement
                    int hotelBookingID = hotelBookingIDElement.GetInt32();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Hotel booking transaction sent successfully! HotelBookingID: {hotelBookingID}");
                    Console.ResetColor();
                    return hotelBookingID;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error: Unable to parse HotelBookingID from the response.");
                    Console.ResetColor();
                    return -1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                Console.ResetColor();
                return -1;
            }
        }
    }
}