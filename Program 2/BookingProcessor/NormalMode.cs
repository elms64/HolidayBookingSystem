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
                        await HandleGetRequest(request, response, requestType);
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

        // Gets the request type based on the last part of the target URL
        private string ExtractRequestType(Uri url)
        {
            return url.Segments.Last().TrimEnd('/');
        }


        // How to handle incoming GET requests
        private async Task HandleGetRequest(HttpListenerRequest request, HttpListenerResponse response, string requestType)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var bookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
                byte[] buffer = Array.Empty<byte>();


                switch (requestType)
                {
                    // Return all Countries from Country Table.
                    case "Country":
                        var countries = await bookingContext.Country
                        .Select(c => new { CountryID = c.CountryID, CountryName = c.CountryName }).ToListAsync();
                        string countryJsonResponse = JsonSerializer.Serialize(countries);
                        buffer = Encoding.UTF8.GetBytes(countryJsonResponse);
                        break;

                    // Return relevant Flights from Flight Table based on given destination and origin countries.
                    case "Airport":
                        string FlightAirportJsonResponse;

                        // Retrieve Country information from received GET request
                        int originCountryID = 0;
                        int destinationCountryID = 0;
                        if (request.Headers.Get("OriginCountryID") != null && int.TryParse(request.Headers.Get("OriginCountryID"), out originCountryID))
                        {
                            Console.WriteLine($"OriginCountryID Header: {originCountryID}");
                        }
                        if (request.Headers.Get("DestinationCountryID") != null && int.TryParse(request.Headers.Get("DestinationCountryID"), out destinationCountryID))
                        {
                            Console.WriteLine($"DestinationCountryID Header: {destinationCountryID}");
                        }

                        // Create separate lists for origin and destination airports
                        List<Airport> originAirports = bookingContext.Airport.Where(a => a.CountryID == originCountryID).ToList();
                        List<Airport> destinationAirports = bookingContext.Airport.Where(a => a.CountryID == destinationCountryID).ToList();

                        // Print the matching airports for origin

                        // Selecting Origin and Destination flight IDs
                        var airportInfo = new
                        {
                            OriginAirports = originAirports.Select(a => new { a.AirportID, a.CountryID, a.AirportName }),
                            DestinationAirports = destinationAirports.Select(a => new { a.AirportID, a.CountryID, a.AirportName })
                        };

                        // Serialize the Flight information to JSON, send and log the response
                        FlightAirportJsonResponse = JsonSerializer.Serialize(airportInfo);
                        buffer = Encoding.UTF8.GetBytes(FlightAirportJsonResponse);
                        Console.WriteLine($"Flight Airport JSON Response: {FlightAirportJsonResponse}");
                        break;

                    // TODO: Load specific flights from database based on selected Airport in previous case
                    case "Flight":
                        List<int> flight = await bookingContext.Flight.Select(f => f.FlightID).ToListAsync();
                        string flightJsonResponse = JsonSerializer.Serialize(flight);
                        buffer = Encoding.UTF8.GetBytes(flightJsonResponse);
                        break;

                    // !! Implement logic to return by destination country !!
                    // Return relevant Hotels from Hotel Table based on given detination information
                    case "Hotel":
                        List<string?> hotels = await bookingContext.Hotel.Select(h => h.HotelName).ToListAsync();
                        string hotelJsonResponse = JsonSerializer.Serialize(hotels);
                        buffer = Encoding.UTF8.GetBytes(hotelJsonResponse);
                        break;

                    // Return all Vehicles from Vehicle Table.
                    // Authored by @gjepic
                    case "Vehicle":
                        var vehicle = await bookingContext.Vehicle
                         .Select(c => new { VehicleID = c.VehicleID, VehicleType = c.VehicleType }).ToListAsync();
                        string vehicleJsonResponse = JsonSerializer.Serialize(vehicle);
                        buffer = Encoding.UTF8.GetBytes(vehicleJsonResponse);
                        break;

                    // Return all Insurance plans from Insurance Table.
                    case "Insurance":
                        List<string?> plans = await bookingContext.Insurance.Select(p => p.InsuranceType).ToListAsync();
                        string insuranceJsonResponse = JsonSerializer.Serialize(plans);
                        buffer = Encoding.UTF8.GetBytes(insuranceJsonResponse);
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
            // Should only really be booking data when creating a booking at the end of the users process.
        }

        // Determine if an incoming request is a stored transaction.
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








/*
//George code here 
*/

//Currently working on
/*private async Task GET_SPECIFIC_CAR_TYPE(HttpListenerResponse response)
{
    returnVehicleType vehicleHandler = new returnVehicleType();
    var vehicleTypeData = await vehicleHandler.getSpecificVehicleType(serviceProvider);
    Console.WriteLine("Vehicle type data sent to Program 1!");
    response.ContentType = "application/json";
    response.ContentLength64 = vehicleTypeData.Length;
    response.OutputStream.Write(vehicleTypeData, 0, vehicleTypeData.Length);
}/*

public class returnVehicleType
{

// Method for returning a list of vehicles filtered by the type of vehicle
//Currently working on
public async Task<byte[]> getSpecificVehicleType(IServiceProvider serviceProvider)
{
using (var scope = serviceProvider.CreateScope())
{

    var bookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
    var get_vehicleTypes = await bookingContext.Vehicle.Where(v => v.VehicleType).Select(v => new { v.VehicleID, v.VehicleType, v.PricePerDay }).ToListAsync();
    Console.WriteLine("BZZZZ");
    string jsonResponse = JsonSerializer.Serialize(get_vehicleTypes);
    return Encoding.UTF8.GetBytes(jsonResponse);

}*/
