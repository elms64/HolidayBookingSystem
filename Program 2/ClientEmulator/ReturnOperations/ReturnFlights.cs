// GitHub Authors: @elms64 & @Kloakk

// Returns a list of flights based on a given departure airport and arrival airport. 

using System.Text.Json;

namespace ClientEmulator
{
    public class ReturnFlights
    {
        private static readonly string ConsoleAppUrl = "http://localhost:8080";
        
        public async Task ReturnFlightsList(string departureAirport, string arrivalAirport)
        {
            try
            {
                string targetURL = ConsoleAppUrl + "/Flight";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("selectedDepartureAirportID", departureAirport);
                    client.DefaultRequestHeaders.Add("selectedArrivalAirportID", arrivalAirport);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine($"Sending request to: {targetURL}");
                    Console.WriteLine($"Departure Airport ID: {departureAirport}, Arrival Airport ID: {arrivalAirport}");
                    Console.WriteLine("");
                    Console.ResetColor();

                    HttpResponseMessage response = await client.GetAsync(targetURL);

                    if (response.IsSuccessStatusCode)
                    {
                        string flightJsonResponse = await response.Content.ReadAsStringAsync();
                        var flightInfo = JsonSerializer.Deserialize<List<int>>(flightJsonResponse);
                        foreach (var flightId in flightInfo!)
                        {
                            Console.WriteLine($"Flight ID: {flightId}");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Error: {response.StatusCode}");
                        Console.ResetColor();
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"HTTP Request Error: {ex.Message}");
                Console.ResetColor();
            }
            catch (TaskCanceledException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Task Canceled Error: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}