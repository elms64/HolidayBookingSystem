// GitHub Authors: @elms64 & @Kloakk

// Returns a list of hotels based on a given destination.

using System.Text.Json;
using ClientEmulator.Models;

namespace ClientEmulator
{
    public class ReturnHotels
    {
        private static readonly string ConsoleAppUrl = "http://localhost:8080";

        public async Task ReturnHotelsList(string destination)
        {
            try
            {
                string targetURL = ConsoleAppUrl + "/Hotel";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("destination", destination);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine($"Sending request to: {targetURL}");
                    Console.WriteLine($"Hotels for Country ID: {destination}");
                    Console.WriteLine("");
                    Console.ResetColor();

                    HttpResponseMessage response = await client.GetAsync(targetURL);

                    if (response.IsSuccessStatusCode)
                    {
                        string hotelJsonResponse = await response.Content.ReadAsStringAsync();
                        var hotels = JsonSerializer.Deserialize<List<Hotel>>(hotelJsonResponse);
                        foreach (var hotel in hotels!)
                        {
                            Console.WriteLine($"HotelID: {hotel.HotelID} HotelName: {hotel.HotelName}");
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