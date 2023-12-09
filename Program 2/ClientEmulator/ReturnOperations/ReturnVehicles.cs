// GitHub Authors: @elms64 & @Kloakk

// Returns all available vehicles

/* System Libraries */
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ClientEmulator.Models;

namespace ClientEmulator
{
    public class ReturnVehicles
    {
        /* Variables */
        private static readonly string ConsoleAppUrl = "http://localhost:8080";

        public async Task ReturnVehicleList()
        {
            try
            {
                string targetURL = ConsoleAppUrl + "/Vehicle";
                using (HttpClient client = new HttpClient())
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Sending request to: {targetURL}");
                    Console.WriteLine($"Returning all vehicles");
                    Console.WriteLine("");
                    Console.ResetColor();

                    HttpResponseMessage response = await client.GetAsync(targetURL);

                    if (response.IsSuccessStatusCode)
                    {
                        string vehicleJsonResponse = await response.Content.ReadAsStringAsync();
                        var vehicleList = JsonSerializer.Deserialize<List<Vehicle>>(vehicleJsonResponse);

                        foreach (var vehicle in vehicleList!)
                        {
                            Console.WriteLine($"Vehicle ID: {vehicle.VehicleID}, Vehicle Type: {vehicle.VehicleType}");
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