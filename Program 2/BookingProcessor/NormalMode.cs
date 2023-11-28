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
            await Task.Delay(1500);
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

                    // Decide how to process requests based on incoming information. 
                    if (request.HttpMethod == "GET")
                    {
                        await HandleGetRequest(response);
                    }
                    else if (request.HttpMethod == "POST")
                    {
                        await HandlePostRequest(request, response);
                    }

                    // Any other request types such as DELETE or PUT will be denied.
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

        // How to handle incoming GET requests
        private async Task HandleGetRequest(HttpListenerResponse response)
        {
            // Response for Flight information requests
            using (var scope = serviceProvider.CreateScope())
            {
                var bookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
                List<int> flights = await bookingContext.Flight.Select(f => f.FlightID).ToListAsync();
                string jsonResponse = JsonSerializer.Serialize(flights);
                byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);
                response.ContentType = "application/json";
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.Close();
            }

            // Response for Airport information requests
            using (var scope = serviceProvider.CreateScope())
            {
                var bookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
                List<string?> airports = await bookingContext.Airport.Select(f => f.AirportName).ToListAsync();
                string jsonResponse = JsonSerializer.Serialize(airports);
                byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);
                response.ContentType = "application/json";
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.Close();
            }
        }

        // How to handle incoming POST requests
        public async Task HandlePostRequest(HttpListenerRequest request, HttpListenerResponse response)
        {
            string requestData;
            using (var reader = new System.IO.StreamReader(request.InputStream, request.ContentEncoding))
            {
                requestData = reader.ReadToEnd();
                Console.WriteLine($"Received Program 1 Data: {requestData}");
            }

            string responseString = "Data received successfully";
            byte[] buffer = Encoding.UTF8.GetBytes(responseString);

            // Response for POST requests of Country data
            if (requestData == "SEND_COUNTRY")
            {
                SEND_COUNTRY(response);
            }
            else if (requestData.StartsWith("SELECTED_"))
            {
                REQUEST_FLIGHTS_BY_COUNTRYID(requestData, request);
                Console.WriteLine("Hey");
            }

            // Response for POST requests of batch processing, initiates recovery mode.
            else if (IsBatchProcess(requestData))
            {
                ConsoleUtils.PrintWithDotsAsync("Initiating recovery mode...", 3, 500).Wait();
                InitRecoveryMode();
            }
            else
            {
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
            }

            response.Close();
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


        private async Task SEND_COUNTRY(HttpListenerResponse response)
        {
            returnCountry countryHandler = new returnCountry();
            var countryData = await countryHandler.sendCountry(serviceProvider);
            Console.WriteLine("Country data sent to Program 1!");
            response.ContentType = "application/json";
            response.ContentLength64 = countryData.Length;
            response.OutputStream.Write(countryData, 0, countryData.Length);
        }

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
        }

        private async Task GET_CARS(HttpListenerResponse response)
        {
            returnVehicle vehicleHandler = new returnVehicle();
            var vehicleData = await vehicleHandler.getCars(serviceProvider);
            Console.WriteLine("Vehicle data sent to Program 1!");
            response.ContentType = "application/json";
            response.ContentLength64 = vehicleData.Length;
            response.OutputStream.Write(vehicleData, 0, vehicleData.Length);
        }
    }
}