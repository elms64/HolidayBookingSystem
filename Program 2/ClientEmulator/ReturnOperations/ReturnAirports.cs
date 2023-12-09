// GitHub Authors: @elms64 & @Kloakk

// Returns a list of airports based on a given country of origin and destination.

/* System Libraries */
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ClientEmulator.Models;

namespace ClientEmulator
{
    public class ReturnAirports
    {
        /* Variables */
        private readonly string ConsoleAppUrl;
        private readonly string origin;
        private readonly string destination;

        public ReturnAirports(string consoleAppUrl, string origin, string destination)
        {
            ConsoleAppUrl = consoleAppUrl;
            this.origin = origin;
            this.destination = destination;
        }

        public async Task<List<Airport>> GetOriginAirportsAsync()
        {
            return await GetAirportsAsync("Origin");
        }

        public async Task<List<Airport>> GetDestinationAirportsAsync()
        {
            return await GetAirportsAsync("Destination");
        }

        private async Task<List<Airport>> GetAirportsAsync(string type)
        {
            try
            {
                string targetURL = ConsoleAppUrl + "/Airport";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("OriginCountryID", origin);
                    client.DefaultRequestHeaders.Add("DestinationCountryID", destination);
                    Console.WriteLine($"Sending request to: {targetURL}");
                    Console.WriteLine($"Headers: DestinationCountryID={destination}, OriginCountryID={origin}");
                    HttpResponseMessage response = await client.GetAsync(targetURL);

                    if (response.IsSuccessStatusCode)
                    {
                        string airportJsonResponse = await response.Content.ReadAsStringAsync();
                        var airportInfo = JsonSerializer.Deserialize<Emulator.AirportInfo>(airportJsonResponse);

                        return type.ToLower() switch
                        {
                            "origin" => airportInfo?.OriginAirports ?? new List<Airport>(),
                            "destination" => airportInfo?.DestinationAirports ?? new List<Airport>(),
                            _ => new List<Airport>(),
                        };
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                        return new List<Airport>();
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request Error: {ex.Message}");
                return new List<Airport>();
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine($"Task Canceled Error: {ex.Message}");
                return new List<Airport>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return new List<Airport>();
            }
        }
    }
}
