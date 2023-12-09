// GitHub Authors: @elms64 & @Kloakk

// Returns a list of insurance plans

/* System Libraries */
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ClientEmulator.Models;

namespace ClientEmulator
{
    public class ReturnInsurancePlans
    {
        /* Variables */
        private static readonly string ConsoleAppUrl = "http://localhost:8080";
        
        public async Task ReturnInsuranceList()
        {
            try
            {
                string targetURL = ConsoleAppUrl + "/Insurance";
                using (HttpClient client = new HttpClient())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine($"Sending request to: {targetURL}");
                    Console.WriteLine($"Returning all insurance plans.");
                    Console.WriteLine("");
                    Console.ResetColor();

                    HttpResponseMessage response = await client.GetAsync(targetURL);

                    if (response.IsSuccessStatusCode)
                    {
                        string insuranceJsonResponse = await response.Content.ReadAsStringAsync();
                        var insuranceList = JsonSerializer.Deserialize<List<Insurance>>(insuranceJsonResponse);

                        foreach (var insurance in insuranceList!)
                        {
                            Console.WriteLine($"Insurance ID: {insurance.InsuranceID}, Insurance Type: {insurance.InsuranceName}");
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