// GitHub Authors: @elms64 & @Kloakk

// Creates an insurance booking PUT request and sends it over HTTP to the server

using System.Text;
using System.Text.Json;

namespace ClientEmulator
{
    public class InsuranceBooking
    {
        private static readonly string ConsoleAppUrl = "http://localhost:8080";
        private static readonly HttpClient httpClient = new HttpClient();


        public async Task<int> InsuranceBookingAsync(string selectedInsurance, int ClientID)
        {
            string serverURL = ConsoleAppUrl + "/InsuranceBooking";
            // Convert the booking transaction to JSON and send a PUT request

            var InsuranceBooking = new List<KeyValuePair<string, string>>();
            InsuranceBooking.Add(new KeyValuePair<string, string>("InsuranceID", selectedInsurance));

            string jsonPayload = JsonSerializer.Serialize(InsuranceBooking);
            StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PutAsync(serverURL, content);

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                var responseObject = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(responseContent);
                if (responseObject!.TryGetValue("InsuranceBookingID", out JsonElement insuranceBookingIDElement))
                {
                    int InsuranceBookingID = insuranceBookingIDElement.GetInt32();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Insurance Booking transaction send successfully! InsuranceBookingID: {InsuranceBookingID}");
                    Console.ResetColor();
                    return InsuranceBookingID;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error : Unable to parse insuranceBookingID from the response.");
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