// GitHub Authors: @elms64 & @Kloakk

// Returns a list of flights based on a given departure airport and arrival airport. 

/* System Libraries */
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ClientEmulator.Models;

namespace ClientEmulator
{
    public class ReturnFlights
    {
        /* Variables */
        private static readonly string ConsoleAppUrl = "http://localhost:8080";
        private static string? origin;
        private static string? destination;
        

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
                    Console.WriteLine("\n");
                    Console.WriteLine($"Sending request to: {targetURL}");
                    Console.WriteLine($"Headers: DestinationCountryID={destination}, OriginCountryID={origin}");
                    Console.WriteLine("\n");
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
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request Error: {ex.Message}");
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine($"Task Canceled Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}