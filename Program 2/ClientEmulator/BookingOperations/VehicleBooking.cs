// GitHub Authors: @elms64 & @Kloakk

// Creates a vehicle booking PUT request and sends it over HTTP to the server

using System.Text;
using System.Text.Json;


namespace ClientEmulator
{
    public class VehicleBooking
    {
        private static readonly string ConsoleAppUrl = "http://localhost:8080";
        private static readonly HttpClient httpClient = new HttpClient();
        public async Task<int> VehicleBookingAsync(string selectedCar, int ClientID)
        {
            string serverURL = ConsoleAppUrl + "/VehicleBooking";
            
            // Convert the booking transaction to JSON and send a PUT request
            var VehicleBooking = new List<KeyValuePair<string, string>>();
            VehicleBooking.Add(new KeyValuePair<string, string>("VehicleID", selectedCar));

            string jsonPayload = JsonSerializer.Serialize(VehicleBooking);
            StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PutAsync(serverURL, content);


            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                var responseObject = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(responseContent);
                if (responseObject!.TryGetValue("VehicleBookingID", out JsonElement vehicleBookingIDElement))
                {
                    int VehicleBookingID = vehicleBookingIDElement.GetInt32();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Vehicle Booking transaction send successfully! VehicleBookingID: {VehicleBookingID}");
                    Console.ResetColor();
                    return VehicleBookingID;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error : Unable to parse vehicleBookingID from the response.");
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