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
        private static readonly string ConsoleAppUrl = "http://localhost:8080";
        private static string? origin;
        private static string? destination;
        private static readonly HttpClient httpClient = new HttpClient();


        public async Task ReturnVehicleList()
        {
            try
            {
                string targetURL = ConsoleAppUrl + "/Vehicle";
                using (HttpClient client = new HttpClient())
                {
                    Console.WriteLine($"Sending request to: {targetURL}");

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