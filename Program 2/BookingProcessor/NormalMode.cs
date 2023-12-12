// GitHub authors: @elms64, @Kloakk, @dlawlor2408.

/* Normal mode of operation for Booking Processor. Listens to incoming HTTP requests and responds on a case by case basis.
*  Certain events may trigger Recovery Mode.
*  All incoming requests to this server must adhere to the expected conventions.
*  For example, to provide airport information ensure GET requests include OriginCountryID and DestinationCountryID in the header. 
*  Please see the software documentation for further information.  */

using System.Net;
using System.Text;
using System.Text.Json;
using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookingProcessor
{
    public class NormalMode
    {
        /* Define the URL and port number to listen for HTTP requests. 
           Default configuration is any available local IP on port 8080. */

        // Variables
        private readonly string url = "http://+:8080/";
        private HttpListener? listener;
        public event Action? OnRestartRequested;
        private readonly IServiceProvider serviceProvider;
        public NormalMode(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        // @elms64, @Kloakk
        // Main operating method, listens for HTTP requests and processes them accordingly.
        public async Task Run()
        {
            ConsoleUtils.PrintWithDotsAsync("Normal mode initializing", 3, 500).Wait();
            await Task.Delay(100);

            CancellationTokenSource cts = new CancellationTokenSource();

            // Allows the user to press ESC to exit the application and restart.
            using (cts)
            {
                Console.WriteLine("Press ESC to exit.");

                _ = Task.Run(async () =>
                {
                    while (true)
                    {
                        if (cts.Token.IsCancellationRequested)
                        {
                            OnRestartRequested?.Invoke();
                            break;
                        }

                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                        {
                            cts.Cancel();
                        }

                        await Task.Delay(100);
                    }
                });

                try
                {
                    // Opens HTTP listener and awaits requests.
                    listener = new HttpListener();
                    listener.Prefixes.Add(url);
                    listener.Start();
                    Console.WriteLine("Connection open");
                    await Task.Delay(1500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Listening for requests on {url}");
                    Console.ResetColor();

                    try
                    {
                        while (true)
                        {
                            // Check for cancellation before accepting a new request
                            if (cts.Token.IsCancellationRequested)
                            {
                                break;
                            }

                            // Asynchronously wait for an incoming request
                            HttpListenerContext context = await listener.GetContextAsync();

                            // Process the request on a separate thread
                            await Task.Run(async () =>
                            {
                                try
                                {
                                    HttpListenerRequest request = context.Request;
                                    HttpListenerResponse response = context.Response;
                                    Console.WriteLine("");
                                    Console.WriteLine($"Received request from: {request.RemoteEndPoint}.");
                                    Console.WriteLine($"Request URL: {request.Url}");
                                    Console.WriteLine($"HTTP Method: {request.HttpMethod}");

                                    // Extract request type from the URL.
                                    string requestType = ExtractRequestType(request.Url!);

                                    // Decide how to process requests based on the HTTP method. 
                                    if (request.HttpMethod == "GET")
                                    {
                                        await HandleGetRequest(request, response, requestType);
                                    }
                                    else if (request.HttpMethod == "PUT")
                                    {
                                        await HandlePutRequest(request, response, requestType);
                                    }
                                    else if (request.HttpMethod == "POST")
                                    {
                                        await HandlePostRequest(request, response, requestType, listener);
                                    }
                                    // Any other request types will be denied.
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
                                catch (Exception ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine($"Exception processing request: {ex}");
                                    Console.ResetColor();
                                }
                            });
                        }
                    }
                    catch (HttpListenerException ex) when (ex.ErrorCode == 995) // 995 is the code for operation aborted
                    {
                        // The listener was stopped or disposed, nothing to worry about
                    }
                    finally
                    {
                        listener.Close(); // Close the listener when done
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Exception starting listener: {ex}");
                    Console.ResetColor();
                }
            }
        }

        // Gets the request type based on the last part of the target URL.
        private string ExtractRequestType(Uri url)
        {
            return url.Segments.Last().TrimEnd('/');
        }

        // How to handle incoming GET requests.
        private async Task HandleGetRequest(HttpListenerRequest request, HttpListenerResponse response, string requestType)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var bookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
                byte[] buffer = Array.Empty<byte>();

                int originID;
                int destinationID = 0;
                // To process different types of requests, different cases are defined for every use case.
                switch (requestType)
                {
                    // @Kloakk
                    // Returns all Countries from Country Table.
                    case "Country":
                        var countries = await bookingContext.Country
                        .Select(c => new { CountryID = c.CountryID, CountryName = c.CountryName }).ToListAsync();
                        string countryJsonResponse = JsonSerializer.Serialize(countries);
                        buffer = Encoding.UTF8.GetBytes(countryJsonResponse);
                        break;

                    // @Kloakk
                    // Returns relevant Flights from Flight Table based on given destination and origin countries.
                    case "Airport":
                        string AirportJsonResponse;

                        // Incoming HTTP request will be expected to have an OriginCountryID and DestinationCountryID in its header.
                        int originCountryID = 0;
                        int destinationCountryID = 0;
                        if (request.Headers.Get("OriginCountryID") != null && int.TryParse(request.Headers.Get("OriginCountryID"), out originCountryID))
                        {
                            Console.WriteLine($"OriginCountryID Header: {originCountryID}");
                            originID = originCountryID;
                        }
                        if (request.Headers.Get("DestinationCountryID") != null && int.TryParse(request.Headers.Get("DestinationCountryID"), out destinationCountryID))
                        {
                            Console.WriteLine($"DestinationCountryID Header: {destinationCountryID}");
                            destinationID = destinationCountryID;
                        }
                        // Create separate lists for origin and destination airports that are in the countries specified in the HTTP request. 
                        List<Airport> originAirports = bookingContext.Airport.Where(a => a.CountryID == originCountryID).ToList();
                        List<Airport> destinationAirports = bookingContext.Airport.Where(a => a.CountryID == destinationCountryID).ToList();
                        var airportInfo = new
                        {
                            OriginAirports = originAirports.Select(a => new { a.AirportID, a.CountryID, a.AirportName }),
                            DestinationAirports = destinationAirports.Select(a => new { a.AirportID, a.CountryID, a.AirportName })
                        };
                        // Serialize the new Airport information to JSON, send and log the response.
                        AirportJsonResponse = JsonSerializer.Serialize(airportInfo);
                        buffer = Encoding.UTF8.GetBytes(AirportJsonResponse);
                        Console.WriteLine($"Flight Airport JSON Response: {AirportJsonResponse}");
                        break;

                    // @dlawlor2408 and @Kloakk
                    // Loads specific flights from database based on selected Airport in previous case.
                    case "Flight":
                        int selectedDepartureAirportID = 0;
                        int selectedArrivalAirportID = 0;
                        DateTime selectedDepartureDate = DateTime.MinValue;
                        DateTime selectedArrivalDate = DateTime.MinValue;

                        // Extract and parse headers.
                        if (request.Headers.Get("selectedDepartureAirportID") != null && int.TryParse(request.Headers.Get("selectedDepartureAirportID"), out selectedDepartureAirportID))
                        {
                            Console.WriteLine($"selectedDepartureAirportID Header: {selectedDepartureAirportID}");
                        }

                        if (request.Headers.Get("selectedArrivalAirportID") != null && int.TryParse(request.Headers.Get("selectedArrivalAirportID"), out selectedArrivalAirportID))
                        {
                            Console.WriteLine($"selectedArrivalAirportID Header: {selectedArrivalAirportID}");
                        }

                        // Date logic is commented out for testing we are using the time of now and a holiday of a week but this code can allow user input if included.

                        /*if (request.Headers.Get("selectedDepartureDate") != null && DateTime.TryParse(request.Headers.Get("selectedDepartureDate"), out selectedDepartureDate))
                        {
                            Console.WriteLine($"selectedDepartureDate Header: {selectedDepartureDate}");
                        }

                        if (request.Headers.Get("selectedArrivalDate") != null && DateTime.TryParse(request.Headers.Get("selectedArrivalDate"), out selectedArrivalDate))
                        {
                            Console.WriteLine($"selectedArrivalDate Header: {selectedArrivalDate}");
                        }*/

                        // Select flights based on selected Airports for departure and arrival.
                        Console.WriteLine(bookingContext.Flight);
                        var matchingFlights = bookingContext.Flight
                            .Where(f =>
                                f.DepartureAirportID == selectedDepartureAirportID &&
                                f.ArrivalAirportID == selectedArrivalAirportID)
                            //f.DepartureDateTime == selectedDepartureDate &&
                            //f.ArrivalDateTime == selectedArrivalDate)
                            .Select(f => f)
                            .ToList();

                        // Serialize the matching Flight information to JSON, sends and logs the response.
                        string flightJsonResponse = JsonSerializer.Serialize(matchingFlights);
                        buffer = Encoding.UTF8.GetBytes(flightJsonResponse);
                        Console.WriteLine($"Matching Flight JSON Response: {flightJsonResponse}");
                        break;

                    // @Kloakk
                    // Return Hotels from Hotel Table based on given destination information.
                    case "Hotel":

                        if (request.Headers.Get("destination") != null && int.TryParse(request.Headers.Get("destination"), out destinationID))
                        {
                            Console.WriteLine($"destination Header: {destinationID}");
                        }

                        var matchingHotels = bookingContext.Hotel
                        .Where(h => h.CountryID == destinationID)
                        .Select(h => h)
                        .ToList();

                        // Serialize the result to JSON.
                        string hotelJsonResponse = JsonSerializer.Serialize(matchingHotels);
                        buffer = Encoding.UTF8.GetBytes(hotelJsonResponse);
                        Console.WriteLine($"Matching Hotel JSON Response: {hotelJsonResponse}");
                        break;

                    // @Kloakk
                    // Returns all Vehicles from Vehicle Table.
                    case "Vehicle":
                        var vehicle = await bookingContext.Vehicle
                        .Select(c => new { VehicleID = c.VehicleID, VehicleType = c.VehicleType }).ToListAsync();
                        string vehicleJsonResponse = JsonSerializer.Serialize(vehicle);
                        buffer = Encoding.UTF8.GetBytes(vehicleJsonResponse);
                        break;

                    // Returns all Insurance plans from Insurance Table.
                    case "Insurance":
                        var Insurance = await bookingContext.Insurance
                        .Select(i => new { InsuranceID = i.InsuranceID, InsuranceName = i.InsuranceType }).ToListAsync();
                        string insuranceJsonResponse = JsonSerializer.Serialize(Insurance);
                        buffer = Encoding.UTF8.GetBytes(insuranceJsonResponse);
                        Console.WriteLine(insuranceJsonResponse);
                        break;

                    case "Room":
                        if (request.Headers.Get("room") != null && int.TryParse(request.Headers.Get("room"), out int selectedHotelID))
                        {
                            Console.WriteLine($"room Header: {selectedHotelID}");

                            var matchingRooms = bookingContext.Room
                                .Where(r => r.HotelID == selectedHotelID)
                                .Select(r => new { RoomID = r.RoomID, HotelID = r.HotelID, RoomType = r.RoomType, PricePerNight = r.PricePerNight })
                                .ToList();

                            // Serialize the result to JSON.
                            string roomJsonResponse = JsonSerializer.Serialize(matchingRooms);
                            buffer = Encoding.UTF8.GetBytes(roomJsonResponse);
                            Console.WriteLine($"Matching Hotel JSON Response: {roomJsonResponse}");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Invalid or missing 'room' header.");
                            Console.ResetColor();
                        }
                        break;
                }

                response.ContentType = "application/json";
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.OutputStream.Flush();
                response.Close();
            }
        }

        // @elms64, @Kloakk
        // Handles incoming PUT requests and uploads bookings to the database.
        public async Task HandlePutRequest(HttpListenerRequest request, HttpListenerResponse response, string requestType)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var bookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
                byte[] buffer = Array.Empty<byte>();

                // The request type may be a standard booking or a batch process. 
                switch (requestType)
                {
                    // Create a new client in the server
                    case "Client":
                        ClientBooking clbk = new ClientBooking();
                        buffer = await clbk.ClientBookingAsync(request, bookingContext);
                        break;

                    // If a normal booking request comes in, upload it to the database and return an invoice.
                    case "Booking":
                        CreateBooking crtbk = new CreateBooking(bookingContext);
                        buffer = await crtbk.CreateBookingAsync(request, bookingContext);
                        break;

                    // Creates a vehicle booking for the client. 
                    case "VehicleBooking":
                        CreateVehicleBooking vclbk = new CreateVehicleBooking();
                        buffer = await vclbk.CreateVehicleBookingAsync(request, bookingContext);
                        break;

                    case "InsuranceBooking":
                        CreateInsuranceBooking insbk = new CreateInsuranceBooking();
                        buffer = await insbk.CreateInsuranceBookingAsync(request, bookingContext);
                        break;

                    // Creates a booking for a hotel for the client.
                    case "HotelBooking":
                        CreateHotelBooking htlbk = new CreateHotelBooking();
                        buffer = await htlbk.CreateHotelBookingAsync(request, bookingContext);
                        break;

                    case "FlightBooking":
                        CreateFlightBooking fltbk = new CreateFlightBooking();
                        buffer = await fltbk.CreateFlightBookingAsync(request, bookingContext);
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

        // Handles incoming POST requests.
        public async Task HandlePostRequest(HttpListenerRequest request, HttpListenerResponse response, string requestType, HttpListener listener)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var bookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
                byte[] buffer = Array.Empty<byte>();

                // The request type may be a batch process.
                switch (requestType)
                {
                    // If a batch process comes in, initiate recovery mode and check for any other batch processes.
                    case "BatchProcess":
                        buffer = Encoding.UTF8.GetBytes("Batch request received, initiating recovery mode. Please allow up to 24 hours for backup procedures to take effect");

                        // Read the JSON data from the request stream
                        string jsonData = await new StreamReader(request.InputStream).ReadToEndAsync();

                        // Initiate recovery mode by sending the JSON data
                        listener.Close();
                        InitRecoveryMode(jsonData);
                        break;

                    default:
                        buffer = Encoding.UTF8.GetBytes("Invalid request type for POST");
                        break;
                }

                response.ContentType = "application/json";
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.Close();
            }
        }

        // @elms64
        // Method to initiate recovery mode, used when an incoming process is a batch transaction.
        private void InitRecoveryMode(string jsonData)
        {
            var recoveryMode = new RecoveryMode(serviceProvider);
            recoveryMode.Run(jsonData).GetAwaiter().GetResult();
        }

    }
}