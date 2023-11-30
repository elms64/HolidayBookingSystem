// Authored by @elms64 and @Kloakk

using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
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

                    // Decide how to process requests based on the HTTP method. 
                    if (request.HttpMethod == "GET")
                    {
                        await HandleGetRequest(request, response, requestType);
                    }
                    else if (request.HttpMethod == "PUT")
                    {
                        await HandlePutRequest(request, response, requestType);
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

                        int selectedDepartureAirportID = 0;
                        int selectedArrivalAirportID = 0;

                        // Header for selectedDepartureAirportID
                        if (request.Headers.Get("selectedDepartureAirportID") != null && int.TryParse(request.Headers.Get("selectedDepartureAirportID"), out selectedDepartureAirportID))
                        {
                            Console.WriteLine($"selectedDepartureAirportID Header: {selectedDepartureAirportID}");
                        }

                        // Header for selectedArrivalAirportID
                        if (request.Headers.Get("selectedArrivalAirportID") != null && int.TryParse(request.Headers.Get("selectedArrivalAirportID"), out selectedArrivalAirportID))
                        {
                            Console.WriteLine($"selectedArrivalAirportID Header: {selectedArrivalAirportID}");
                        }

                        // Header for Selected Departure Date
                        if (request.Headers.Get("selectedDepartureDate") != null && DateTime.TryParse(request.Headers.Get("selectedDepartureDate"), out DateTime selectedDepartureDate))
                        {
                            Console.WriteLine($"selectedDepartureDate Header: {selectedDepartureDate}");
                        }

                        // Header for Selected Arrival Date
                        if (request.Headers.Get("selectedArrivalDate") != null && DateTime.TryParse(request.Headers.Get("selectedArrivalDate"), out DateTime selectedArrivalDate))
                        {
                            Console.WriteLine($"selectedArrivalDate Header: {selectedArrivalDate}");
                        }
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


        // Authored by @elms64
        // -----------------------------------------------------------------------------------------------------------------------
        // Handles incoming PUT requests and uploads bookings to the database
        public async Task HandlePutRequest(HttpListenerRequest request, HttpListenerResponse response, string requestType)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var bookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
                byte[] buffer = Array.Empty<byte>();

                // The request type may be a standard booking or a batch process. 
                switch (requestType)
                {
                    // If a normal booking request comes in, upload it to the database and return an invoice.
                    case "Booking":
                        buffer = await CreateBooking(request, bookingContext);
                        break;

                    // If a batch process comes in initiate recovery mode and check for any other batch processes.
                    case "BatchProcess":
                        buffer = Encoding.UTF8.GetBytes("Batch request received, initiating recovery mode. Please allow up to 24 hours for backup procedures to take effect");
                        InitRecoveryMode();
                        break;

                    default:
                        buffer = Encoding.UTF8.GetBytes("Invalid request type");
                        break;
                }

                response.ContentType = "application/json";
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.Close();
            }
        }

        // Method for creating a database entry for a new booking, performing validation checks to avoid duplicate entries. 
        private async Task<byte[]> CreateBooking(HttpListenerRequest request, BookingContext bookingContext)
        {
            try
            {
                // Receive booking information from a HTTP PUT request
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    string requestBody = await reader.ReadToEndAsync();
                    Booking newBooking = JsonSerializer.Deserialize<Booking>(requestBody);
                    // Recalculates MD5 checksum and ensures transaction has not already been processed
                    string recalculatedChecksum = CalcMD5.CalculateMd5(requestBody);
                    bool checksumExists = await bookingContext.Booking.AnyAsync(b => b.CheckSum == recalculatedChecksum);

                    // Do not process transaction if it is a repeat entry. 
                    if (checksumExists)
                    {
                        return Encoding.UTF8.GetBytes("This booking already exists, please do not retry transaction.");
                    }

                    // If the transaction does not already exist, upload to the database/
                    else
                    {
                        newBooking.OrderNumber = 0;
                        bookingContext.Booking.Add(newBooking);
                        await bookingContext.SaveChangesAsync();

                        // Return booking information and order number to the client
                        newBooking.OrderNumber = newBooking.OrderNumber;
                        string jsonResponse = JsonSerializer.Serialize(newBooking);
                        byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);
                        return buffer;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return Encoding.UTF8.GetBytes("Error creating booking, please try again later.");
            }
        }

        // Method to initiate recovery mode, used when an incoming process is a batch transaction.
        private void InitRecoveryMode()
        {
            var recoveryMode = new RecoveryMode(serviceProvider);
            recoveryMode.Run().GetAwaiter().GetResult();
        }

        // -----------------------------------------------------------------------------------------------------------------------

    }
}