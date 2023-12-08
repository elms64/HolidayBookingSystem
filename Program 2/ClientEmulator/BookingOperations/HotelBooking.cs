using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ClientEmulator.Models;

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
                    Console.WriteLine($"Hotel booking transaction sent successfully! HotelBookingID: {hotelBookingID}");
                    return hotelBookingID;
                }
                else
                {
                    Console.WriteLine("Error: Unable to parse HotelBookingID from the response.");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                return -1;
            }

        }
    }
}