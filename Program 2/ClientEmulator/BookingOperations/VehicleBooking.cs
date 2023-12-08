// GitHub Authors: @elms64 & @Kloakk

// Creates a vehicle booking PUT request and sends it over HTTP to the server

/* System Libraries */
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ClientEmulator.Models;

namespace ClientEmulator
{
    public class VehicleBooking
    {
        /* Variables */
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
                    Console.WriteLine($"Vehicle Booking transaction send successfully! VehicleBookingID: {VehicleBookingID}");
                    return VehicleBookingID;
                }
                else
                {
                    Console.WriteLine("Error : Unable to parse vehicleBookingID from the response.");
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