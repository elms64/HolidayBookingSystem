// Authored by @elms64 and @Kloakk

using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookingProcessor
{
    public class NormalMode
    {

        /* Define the URL and port number to listen for HTTP requests. 
        Default configuration is any available local IP on port 8080. */
        private readonly string url = "http://+:8080/";
        private readonly IServiceProvider serviceProvider;
        private int OriginID;
        private int CountryID;
        public NormalMode(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        // Main operating method, listens for HTTP requests and processes them accordingly.
        public async Task Run()
        {
            ConsoleUtils.PrintWithDotsAsync("Normal mode initializing", 4, 500).Wait();
            await Task.Delay(100);

            using (HttpListener listener = new HttpListener())
            {
                listener.Prefixes.Add(url);
                listener.Start();
                Console.WriteLine("Connection open");
                await Task.Delay(1500);
                Console.WriteLine($"Listening for requests on {url}");

                while (true)
                {
                    // Logs any incoming requests and responses in the console
                    HttpListenerContext context = listener.GetContext();
                    HttpListenerRequest request = context.Request;
                    HttpListenerResponse response = context.Response;
                    Console.WriteLine($"Received request from {request.RemoteEndPoint}.");
                    Console.WriteLine($"Request URL: {request.Url}");
                    Console.WriteLine($"HTTP Method: {request.HttpMethod}");

                    // Extract request type from the URL
                    string requestType = ExtractRequestType(request.Url);

                    // Decide how to process requests based on incoming information. 
                    if (request.HttpMethod == "GET")
                    {
                        await HandleGetRequest(response, requestType);
                    }
                    else if (request.HttpMethod == "PUT")
                    {
                        await HandlePutRequest(request, response);
                    }
                    // Any other request types e.g POST will be denied.
                    else
                    {
                        string responseString = "Invalid request";
                        byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                        response.ContentLength64 = buffer.Length;
                        response.OutputStream.Write(buffer, 0, buffer.Length);
                        response.Close();
                    }

                    Console.WriteLine("Response sent.");
                }
            }
        }

        // Define the ExtractRequestType inline
        private string ExtractRequestType(Uri url)
        {
            // Assuming the requestType is the last segment of the path
            return url.Segments.Last().TrimEnd('/');
        }


        // How to handle incoming GET requests
        private async Task HandleGetRequest(HttpListenerResponse response, string requestType)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var bookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
                byte[] buffer;

                switch (requestType)
                {
                    // Return all Countries from Country Table.
                    case "Country":
                        var countries = await bookingContext.Country
                            .Select(c => new { CountryID = c.CountryID, CountryName = c.CountryName })
                            .ToListAsync();
                        string countryJsonResponse = JsonSerializer.Serialize(countries);
                        buffer = Encoding.UTF8.GetBytes(countryJsonResponse);
                        break;

                    // Return all Hotels from Hotel Table.
                    case "Hotel":
                        List<string?> hotels = await bookingContext.Hotel.Select(h => h.HotelName).ToListAsync();
                        string hotelJsonResponse = JsonSerializer.Serialize(hotels);
                        buffer = Encoding.UTF8.GetBytes(hotelJsonResponse);
                        break;

                    // Return all Flights from Flight Table.
                    case "Flight":
                        List<int> flights = await bookingContext.Flight.Select(f => f.FlightID).ToListAsync();
                        string flightJsonResponse = JsonSerializer.Serialize(flights);
                        buffer = Encoding.UTF8.GetBytes(flightJsonResponse);
                        break;

                    // Return all Airports from Airport Table.
                    case "Airport":
                        List<string?> airports = await bookingContext.Airport.Select(a => a.AirportName).ToListAsync();
                        string airportJsonResponse = JsonSerializer.Serialize(airports);
                        buffer = Encoding.UTF8.GetBytes(airportJsonResponse);
                        break;

                    // Return all Vehicles from Vehicle Table.
                    case "Vehicle":
                        List<string?> vehicles = await bookingContext.Vehicle.Select(v => v.VehicleType).ToListAsync();
                        string vehicleJsonResponse = JsonSerializer.Serialize(vehicles);
                        buffer = Encoding.UTF8.GetBytes(vehicleJsonResponse);
                        break;

                    // Return all Hotels from Hotel Table.
                    case "Insurance":
                        List<string?> plans = await bookingContext.Insurance.Select(p => p.InsuranceType).ToListAsync();
                        string insuranceJsonResponse = JsonSerializer.Serialize(plans);
                        buffer = Encoding.UTF8.GetBytes(insuranceJsonResponse);
                        break;


                    //this would be getting something from a given value, selectedID in this example.
                    case "Test":
                        int selectedID = 1;
                        List<int> test = await bookingContext.Flight.Where(f => f.FlightID == selectedID).Select(f => f.FlightID).ToListAsync();
                        string test2 = JsonSerializer.Serialize(test);
                        buffer = Encoding.UTF8.GetBytes(test2);
                        break;

                    default:
                        // Handle unknown request type
                        buffer = Encoding.UTF8.GetBytes("Unknown request type");
                        break;
                }

                response.ContentType = "application/json";
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.Close();
            }
        }


        // How to handle incoming PUT requests
        public async Task HandlePutRequest(HttpListenerRequest request, HttpListenerResponse response)
        {

        }

        // Determine if an incoming POST request is a stored transaction.
        private bool IsBatchProcess(string requestData)
        {
            return requestData.Contains("BATCH_PROCESS");
        }

        // Method to initiate recovery mode, used when an incoming process is a batch transaction.
        private void InitRecoveryMode()
        {
            var recoveryMode = new RecoveryMode(serviceProvider);
            recoveryMode.Run().GetAwaiter().GetResult();
        }





    }
}