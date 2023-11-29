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

        // Define the ExtractRequestType inline
        private string ExtractRequestType(Uri url)
        {
            // Assuming the requestType is the last segment of the path
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

                    // Return all Hotels from Hotel Table.
                    case "Hotel":
                        List<string?> hotels = await bookingContext.Hotel.Select(h => h.HotelName).ToListAsync();
                        string hotelJsonResponse = JsonSerializer.Serialize(hotels);
                        buffer = Encoding.UTF8.GetBytes(hotelJsonResponse);
                        break;

                    // Return all Flights from Flight Table.
                    case "Flight":
                        // Extract headers from the flight request
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

                        // Separate lists for origin and destination airports
                        List<Airport> originAirports = bookingContext.Airport.Where(a => a.CountryID == originCountryID).ToList();
                        List<Airport> destinationAirports = bookingContext.Airport.Where(a => a.CountryID == destinationCountryID).ToList();

                        // Print the matching airports for origin
                        foreach (var airport in originAirports)
                        {
                            Console.WriteLine($"Origin - AirportID: {airport.AirportID}, CountryID: {airport.CountryID}, AirportName: {airport.AirportName}");
                        }

                        // Print the matching airports for destination
                        foreach (var airport in destinationAirports)
                        {
                            Console.WriteLine($"Destination - AirportID: {airport.AirportID}, CountryID: {airport.CountryID}, AirportName: {airport.AirportName}");
                        }

                       
                        // Now you have the extracted header values (originCountryID and destinationCountryID), you can use them as needed

                        // Assuming you have a variable named "context" that represents your DbContext


                        // Print to the console before sending


                        // Use received origin and dest. country data to send airports availble for each country back.
                        // Maybe have an option on front end to land in any airport in the country??

                        // airport data from front end ----> arrives in backend

                        // return flights to and from applicable airports
                        // send data to front end. 


                        // Retrieve Airports by selected origin 


                        // Retrieve flights based on the chosen departure airport


                        // Print to the console before sending

                        break;

                    // Return all Airports from Airport Table.
                    case "Airport":
                        List<string?> airports = await bookingContext.Airport.Select(a => a.AirportName).ToListAsync();
                        string airportJsonResponse = JsonSerializer.Serialize(airports);
                        buffer = Encoding.UTF8.GetBytes(airportJsonResponse);
                        break;

                    // Return all Vehicles from Vehicle Table.
                    // Authored by @gjepic
                    case "Vehicle":
                        var vehicle = await bookingContext.Vehicle
                         .Select(c => new { VehicleID = c.VehicleID, VehicleType = c.VehicleType }).ToListAsync();
                        string vehicleJsonResponse = JsonSerializer.Serialize(vehicle);
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

                    // Authored by Dylan 
                    // Implement Dylan's code from mainbranch when P1 has refactored sending stuff
                    case "FlightsById":
                        // Implement Dylan's code from mainbranch when P1 has refactored sending stuff
                        /*
                        private async Task REQUEST_FLIGHTS_BY_COUNTRYID(string requestData, HttpListenerRequest request)
                        {
                            // Output headers
                            Console.WriteLine("Headers received in REQUEST_FLIGHTS_BY_COUNTRYID:");
                            foreach (string key in request.Headers.AllKeys)
                            {
                                Console.WriteLine($"{key}: {request.Headers[key]}");
                            }

                            // Extract OriginID and CountryID from headers
                            if (int.TryParse(request.Headers["OriginID"], out int originID) && int.TryParse(request.Headers["CountryID"], out int countryID))
                            {
                                try
                                {
                                    // Use the took out values to ask the database for thr flight data
                                    using (var scope = serviceProvider.CreateScope())
                                    {
                                        var bookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();


                                        var flights = await bookingContext.Flight
                                            .Include(f => f.DepartureAirport)
                                            .Include(f => f.ArrivalAirport)
                                            .Where(f =>
                                                f.DepartureAirport.CountryID == countryID &&
                                                f.ArrivalAirport.AirportID == originID)
                                            .ToListAsync();

                                        // Serialize the flight data to JSON
                                        string jsonResponse = JsonSerializer.Serialize(flights);
                                        byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);

                                        // Send the data as the response
                                        var response = requestContext.Response;
                                        response.ContentType = "application/json";
                                        response.ContentLength64 = buffer.Length;
                                        response.OutputStream.Write(buffer, 0, buffer.Length);
                                        response.Close();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    // Handle any exceptions 
                                    Console.WriteLine($"Error querying the database: {ex.Message}");
                                }
                            }
                            else
                            {

                                Console.WriteLine("Invalid OriginID or CountryID in the request headers.");
                            }

                            break;

                            default:
                        // Handle unknown request type
                        buffer = Encoding.UTF8.GetBytes("Unknown request type");*/
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
