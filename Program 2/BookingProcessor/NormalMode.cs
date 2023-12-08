// GitHub authors: @elms64, @Kloakk, @dlawlor2408 and @gjepic.

/* Normal mode of operation for Booking Processor. Listens to incoming HTTP requests and responds on a case by case basis.
*  Certain events may trigger Recovery Mode.
*  All incoming requests to this server must adhere to the expected conventions.
*  For example, to provide airport information ensure GET requests include OriginCountryID and DestinationCountryID in the header. 
*  Please see the software documentation for further information.  */

// System Libraries and Packages
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

        // Variables
        private readonly string url = "http://+:8080/";
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

                // Opens HTTP listener and awaits requests.
                using (HttpListener listener = new HttpListener())
                {
                    listener.Prefixes.Add(url);
                    listener.Start();
                    Console.WriteLine("Connection open");
                    await Task.Delay(1500);
                    Console.WriteLine($"Listening for requests on {url}");

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
                            _ = Task.Run(async () =>
                            {
                                HttpListenerRequest request = context.Request;
                                HttpListenerResponse response = context.Response;
                                Console.WriteLine($"Received request from {request.RemoteEndPoint}.");
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
                int returnedRoomID = 0;

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

                        /*if (request.Headers.Get("selectedDepartureDate") != null && DateTime.TryParse(request.Headers.Get("selectedDepartureDate"), out selectedDepartureDate))
                        {
                            Console.WriteLine($"selectedDepartureDate Header: {selectedDepartureDate}");
                        }

                        if (request.Headers.Get("selectedArrivalDate") != null && DateTime.TryParse(request.Headers.Get("selectedArrivalDate"), out selectedArrivalDate))
                        {
                            Console.WriteLine($"selectedArrivalDate Header: {selectedArrivalDate}");
                        }*/

                        // Select flights based on selected Airports for departure and arrival.
                        var matchingFlights = bookingContext.Flight
                            .Where(f =>
                                f.DepartureAirportID == selectedDepartureAirportID &&
                                f.ArrivalAirportID == selectedArrivalAirportID)
                            //f.DepartureDateTime == selectedDepartureDate &&
                            //f.ArrivalDateTime == selectedArrivalDate)
                            .Select(f => f.FlightID)
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
                        .Select(h => new { HotelID = h.HotelID, HotelName = h.HotelName })
                        .ToList();

                        // Serialize the result to JSON.
                        string hotelJsonResponse = JsonSerializer.Serialize(matchingHotels);
                        buffer = Encoding.UTF8.GetBytes(hotelJsonResponse);
                        Console.WriteLine($"Matching Hotel JSON Response: {hotelJsonResponse}");
                        break;



                    // @gjepic
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


                    /* List<string?> plans = await bookingContext.Insurance.Select(p => p.InsuranceType).ToListAsync();
                     string insuranceJsonResponse = JsonSerializer.Serialize(plans);
                     buffer = Encoding.UTF8.GetBytes(insuranceJsonResponse);
                     Console.WriteLine($"Insurance Response Response: {insuranceJsonResponse}");*/


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
                            // Handle the case where the "room" header is not present or not a valid integer.
                            Console.WriteLine("Invalid or missing 'room' header.");
                        }
                        break;

                }

                response.ContentType = "application/json";
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.Close();
            }
        }


        // @elms64
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
                    // Create a new client in the s
                    case "Client":
                        buffer = await ClientBooking(request, bookingContext);
                        break;

                    // If a normal booking request comes in, upload it to the database and return an invoice.
                    case "Booking":
                        buffer = await CreateBooking(request, bookingContext);
                        break;

                    // If a batch process comes in initiate recovery mode and check for any other batch processes.
                    case "BatchProcess":
                        buffer = Encoding.UTF8.GetBytes("Batch request received, initiating recovery mode. Please allow up to 24 hours for backup procedures to take effect");
                        InitRecoveryMode();
                        break;

                    // Creates a vehicle booking for the client. 
                    case "VehicleBooking":
                        buffer = await CreateVehicleBooking(request, bookingContext);
                        break;

                    case "InsuranceBooking":
                        buffer = await CreateInsuranceBooking(request, bookingContext);
                        break;

                    // Creates a booking for a hotel for the client.
                    case "HotelBooking":
                        buffer = await CreateHotelBooking(request, bookingContext);
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


        private async Task<byte[]> ClientBooking(HttpListenerRequest request, BookingContext bookingContext)
        {
            try
            {
                // Receive client information from an HTTP PUT request
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    string requestBody = await reader.ReadToEndAsync();

                    // Parse the JSON array
                    using (JsonDocument jsonDocument = JsonDocument.Parse(requestBody))
                    {
                        if (jsonDocument.RootElement.EnumerateArray().Any())
                        {
                            // Extract values from the array
                            string firstName = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "FirstName").GetProperty("Value").GetString();
                            string lastName = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "LastName").GetProperty("Value").GetString();
                            string birthDate = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "DoB").GetProperty("Value").GetString();
                            string email = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "Email").GetProperty("Value").GetString();
                            string phoneNumber = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "PhoneNumber").GetProperty("Value").GetString();

                            // Create a new client record.
                            Client client = new Client
                            {
                                ClientID = 0,
                                FirstName = firstName,
                                LastName = lastName,
                                BirthDate = DateTime.Parse(birthDate), // You may need to adjust the conversion based on your data type
                                Email = email,
                                PhoneNumber = phoneNumber
                            };

                            bookingContext.Client.Add(client);
                            await bookingContext.SaveChangesAsync();

                            // Now, client has the ClientID assigned by the database
                            int newClientID = client.ClientID;

                            // Create a response object
                            var responseObj = new
                            {
                                ClientID = newClientID,
                                Message = "Client created successfully",
                                Status = "Success"

                            };

                            // Respond to the client.
                            string jsonResponse = JsonSerializer.Serialize(responseObj);
                            Console.WriteLine(jsonResponse);
                            return Encoding.UTF8.GetBytes(jsonResponse);
                        }
                    }

                    return Encoding.UTF8.GetBytes("Invalid Client Data format");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}\n{ex.StackTrace}");
                return Encoding.UTF8.GetBytes("Error creating client, please try again later.");
            }
        }

        private async Task<byte[]> CreateHotelBooking(HttpListenerRequest request, BookingContext bookingContext)
        {
            try
            {
                // Receive hotel booking information from a HTTP PUT request
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    string requestBody = await reader.ReadToEndAsync();

                    // Parse the JSON array
                    using (JsonDocument jsonDocument = JsonDocument.Parse(requestBody))
                    {
                        if (jsonDocument.RootElement.EnumerateArray().Any())
                        {
                            // Extract values from the array
                            string? hotelID = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "HotelID").GetProperty("Value").GetString();
                            string? roomID = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "RoomID").GetProperty("Value").GetString();

                            // Create a new HotelBooking record.
                            HotelBooking hotelBooking = new HotelBooking
                            {
                                HotelBookingID = 0,
                                HotelID = int.Parse(hotelID!),
                                RoomID = int.Parse(roomID!),
                                CheckInDate = DateTime.Now,
                                CheckOutDate = DateTime.Now.AddDays(7),
                                BookingStatus = "Pending"
                            };

                            bookingContext.HotelBooking.Add(hotelBooking);
                            await bookingContext.SaveChangesAsync();

                            // Now, hotelBooking has the BookingID assigned by the database
                            int newHotelBookingID = hotelBooking.HotelBookingID;

                            // Create a response object
                            var responseObj = new
                            {
                                HotelBookingID = newHotelBookingID,
                                Message = "Hotel booking created successfully",
                                Status = "Success"
                            };

                            // Respond to the client.
                            string jsonResponse = JsonSerializer.Serialize(responseObj);
                            Console.WriteLine(jsonResponse);
                            return Encoding.UTF8.GetBytes(jsonResponse);
                        }
                    }

                    return Encoding.UTF8.GetBytes("Invalid HotelBooking Data format");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}\n{ex.StackTrace}");
                return Encoding.UTF8.GetBytes("Error creating HotelBooking, please try again later.");
            }
        }

        private async Task<byte[]> CreateVehicleBooking(HttpListenerRequest request, BookingContext bookingContext)
        {
            try
            {
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    string requestBody = await reader.ReadToEndAsync();

                    using (JsonDocument jsonDocument = JsonDocument.Parse(requestBody))
                    {
                        if (jsonDocument.RootElement.EnumerateArray().Any())
                        {
                            string? VehicleID = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "VehicleID").GetProperty("Value").GetString();

                            VehicleBooking vehicleBooking = new VehicleBooking
                            {
                                VehicleBookingID = 0,
                                VehicleID = int.Parse(VehicleID!),
                                PickUpDate = DateTime.Now,
                                DropOffDate = DateTime.Now.AddDays(7),
                                BookingStatus = "Pending"
                            };

                            bookingContext.VehicleBooking.Add(vehicleBooking);
                            await bookingContext.SaveChangesAsync();

                            int newVehicleBookingID = vehicleBooking.VehicleBookingID;

                            var responseObj = new
                            {
                                VehicleBookingID = newVehicleBookingID,
                                Message = "VehicleBooking Created Successfully",
                                Status = "Success"
                            };

                            string jsonResponse = JsonSerializer.Serialize(responseObj);
                            Console.WriteLine(jsonResponse);
                            return Encoding.UTF8.GetBytes(jsonResponse);



                        }
                    }
                    return Encoding.UTF8.GetBytes("Invalid HotelBooking Data format");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}\n{ex.StackTrace}");
                return Encoding.UTF8.GetBytes("Error creating vehicle booking, please try again later.");
            }
        }

        private async Task<byte[]> CreateInsuranceBooking(HttpListenerRequest request, BookingContext bookingContext)
        {
            try {
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding)){
                    
                    string requestBody = await reader.ReadToEndAsync();
                    
                     using (JsonDocument jsonDocument = JsonDocument.Parse(requestBody)){
                        if (jsonDocument.RootElement.EnumerateArray().Any()){
                            string? InsuranceID = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e=>e.GetProperty("Key").GetString()=="InsuranceID").GetProperty("Value").GetString();


                            InsuranceBooking insuranceBooking = new InsuranceBooking{
                                InsuranceBookingID = 0,
                                InsuranceID = int.Parse(InsuranceID!),
                                StartDate = DateTime.Now,
                                EndDate = DateTime.Now.AddDays(7),
                                BookingStatus = "pending"
                            };

                            bookingContext.InsuranceBooking.Add(insuranceBooking);
                            await bookingContext.SaveChangesAsync();

                            int newInsuranceBookingID = insuranceBooking.InsuranceBookingID;

                            var responseObj = new{
                                InsuranceBookingId = newInsuranceBookingID,
                                Message = "Hotel booking created successfully",
                                Status = "Success"
                            };

                            string jsonResponse = JsonSerializer.Serialize(responseObj);
                            Console.WriteLine(jsonResponse);
                            return Encoding.UTF8.GetBytes(jsonResponse);

                        }

                        return Encoding.UTF8.GetBytes("Invalid HotelBooking Data format");


                    }
                }
            }
              catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}\n{ex.StackTrace}");
                return Encoding.UTF8.GetBytes("Error creating InsruanceBooking, please try again later.");
            }
        }

        // @elms64
        // Method for creating a database entry for a new booking, performing validation checks to avoid duplicate entries. 
        private async Task<byte[]> CreateBooking(HttpListenerRequest request, BookingContext bookingContext)
        {
            try
            {
                // Receive booking information from a HTTP PUT request
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    string requestBody = await reader.ReadToEndAsync();
                    Booking? newBooking = JsonSerializer.Deserialize<Booking>(requestBody);

                    // Recalculates MD5 checksum and ensures transaction has not already been processed.
                    string recalculatedChecksum = CalcMD5.CalculateMd5(requestBody);
                    bool checksumExists = await bookingContext.Booking.AnyAsync(b => b.CheckSum == recalculatedChecksum);

                    // Do not process transaction if it is a repeat entry. 
                    if (checksumExists)
                    {
                        return Encoding.UTF8.GetBytes("This booking already exists, please do not retry transaction.");
                    }

                    // If the transaction does not already exist, upload it to the database.
                    else
                    {
                        newBooking!.OrderNumber = 0;
                        bookingContext.Booking.Add(newBooking);
                        await bookingContext.SaveChangesAsync();

                        // Returns booking information and order number to the client.
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

        // @elms64
        // Method to initiate recovery mode, used when an incoming process is a batch transaction.
        private void InitRecoveryMode()
        {
            var recoveryMode = new RecoveryMode(serviceProvider);
            recoveryMode.Run().GetAwaiter().GetResult();
        }

    }
}