// GitHub Authors: @elms64 & @Kloakk

// Creates a flight booking PUT request and sends it over HTTP to the server

using System.Text;
using System.Text.Json;

namespace ClientEmulator
{
    public class FlightBooking
    {
        private static readonly string ConsoleAppUrl = "http://localhost:8080";
        private static readonly HttpClient httpClient = new HttpClient();

        public async Task<int> FlightBookingAsync(string selectedFlightID, int clientID)
        {
            string serverURL = ConsoleAppUrl + "/FlightBooking";
            var FlightBooking = new List<KeyValuePair<string, string>>();
            FlightBooking.Add(new KeyValuePair<string, string>("FlightID", selectedFlightID));
            FlightBooking.Add(new KeyValuePair<string, string>("ClientID", clientID.ToString()));

            string jsonPayload = JsonSerializer.Serialize(FlightBooking);
            StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PutAsync(serverURL, content);

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                // Parse the JSON response to get the FlightBookingID
                var responseObject = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(responseContent);
                if (responseObject!.TryGetValue("FlightBookingID", out JsonElement flightBookingIDElement))
                {
                    // Extract the value from JsonElement
                    int flightBookingID = flightBookingIDElement.GetInt32();
                    Console.ForegroundColor = ConsoleColor.Green;    
                    Console.WriteLine($"Flight booking transaction sent successfully! FlightBookingID: {flightBookingID}");
                    Console.ResetColor();
                    return flightBookingID;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error: Unable to parse FlightBookingID from the response.");
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