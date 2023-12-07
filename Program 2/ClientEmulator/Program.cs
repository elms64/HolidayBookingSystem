// GitHub Authors: @elms64, @Kloakk & @dlawlor2408

/* Client Emulator for front end interaction testing with backend server */

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ClientEmulator.Models;

namespace ClientEmulator
{
    class Program
    {
        // Declare ConsoleAppUrl as a static field
        private static string ConsoleAppUrl = "http://localhost:8080";
        private static string? origin;
        private static string? destination;
        private static string? departureAirport;
        private static string? arrivalAirport;
        private static string? bookingData;

        static async Task Main(string[] args)
        {
            // Initialize the booking process
            await BookingInit();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static async Task BookingInit()
        {
            // Get destination from user input
            // Enter 826 for UK
            Console.WriteLine("Where From");
            origin = Console.ReadLine();

            // Get origin from user input
            // Enter 724 for Spain
            Console.WriteLine("Where To");
            destination = Console.ReadLine();

            Console.WriteLine("Departure Date: " + DateTime.Now);
            Console.WriteLine("Return Date: " + DateTime.Now.AddDays(7));

            // Initiate the flight process
            await Flight();
        }

        public class AirportInfo
        {
            public List<Airport> OriginAirports { get; set; }
            public List<Airport> DestinationAirports { get; set; }
        }

        public class FlightInfo
        {
            public List<Flight> SelectedFlights { get; set; }
        }

        public class HotelInfo
        {
            public List<Hotel> matchingHotels { get; set; }
        }

        public class InsuranceInfo
        {
            public List<Insurance> matchingInsurance { get; set; }
        }

        private static async Task Flight()
        {
            try
            {
                string targetURL = ConsoleAppUrl + "/Airport";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("OriginCountryID", origin);
                    client.DefaultRequestHeaders.Add("DestinationCountryID", destination);
                    Console.WriteLine($"Sending request to: {targetURL}");
                    Console.WriteLine($"Headers: DestinationCountryID={destination}, OriginCountryID={origin}");
                    HttpResponseMessage response = await client.GetAsync(targetURL);

                    if (response.IsSuccessStatusCode)
                    {
                        string flightAirportJsonResponse = await response.Content.ReadAsStringAsync();
                        var airportInfo = JsonSerializer.Deserialize<AirportInfo>(flightAirportJsonResponse);
                        foreach (var originAirport in airportInfo.OriginAirports)
                        {
                            Console.WriteLine(originAirport.ToString());
                        }

                        Console.WriteLine("Enter the ID of your desired departure airport:");
                        string departureAirport = Console.ReadLine();

                        foreach (var destinationAirport in airportInfo.DestinationAirports)
                        {
                            Console.WriteLine(destinationAirport.ToString());
                        }

                        Console.WriteLine("Enter the ID of your desired arrival airport:");
                        string arrivalAirport = Console.ReadLine();

                        await ReturnFlights(departureAirport, arrivalAirport);

                        Console.WriteLine(" ✈  Please select the flight ID you wish to book: ✈ ");
                        string selectedFlightID = Console.ReadLine();

                        await ReturnHotels(destination);

                        Console.WriteLine("🏠 Please enter the ID of the hotel you wish to stay in: 🏠 ");
                        string selectedHotelID = Console.ReadLine();

                        await ReturnRooms(selectedHotelID);

                        Console.WriteLine("Please enter the ID of the room you wish to book:");
                        string selectedRoom = Console.ReadLine();

                        Console.WriteLine("Now you have created your hotel booking, would you like insurance?");
                        string insuranceInput = Console.ReadLine();
                        if (insuranceInput == "Y")
                        {
                            await ReturnInsurancePlans();
                            Console.WriteLine("Please select the type of insurance you would like:");
                            string selectedInsurance = Console.ReadLine();
                        }


                        Console.WriteLine("Do you need to hire a car?");
                        string carInput = Console.ReadLine();
                        if (carInput == "Y")
                        {
                            await ReturnAvailableCars();
                            Console.WriteLine("Please select the ID of the car you wish to hire:");
                            string selectedCar = Console.ReadLine();
                        }


                        Console.WriteLine("You have now completed the booking enquiry. Please review your booking information:");
                        Console.WriteLine(bookingData);
                        Console.WriteLine("Please type 'continue' if you are happy to proceed or 'cancel' to back out of the transaction:");
                        string userConfirmation = Console.ReadLine();
                        if (userConfirmation == "continue")
                        {
                            await ProcessBooking();

                        }
                        else if (userConfirmation == "cancel")
                        {
                            Console.WriteLine("Booking cancelled, would you like to close the application?");
                            // Could integrate option to either cancel and exit or restart, maintaining the booking info
                        }
                        else
                        {
                            // catch exception
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

        private static async Task ReturnFlights(string departureAirport, string arrivalAirport)
        {
            try
            {
                string targetURL = ConsoleAppUrl + "/Flight";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("selectedDepartureAirportID", departureAirport);
                    client.DefaultRequestHeaders.Add("selectedArrivalAirportID", arrivalAirport);
                    Console.WriteLine($"Sending request to: {targetURL}");
                    Console.WriteLine($"Headers: DestinationCountryID={destination}, OriginCountryID={origin}");
                    HttpResponseMessage response = await client.GetAsync(targetURL);

                    if (response.IsSuccessStatusCode)
                    {
                        string flightJsonResponse = await response.Content.ReadAsStringAsync();
                        var flightInfo = JsonSerializer.Deserialize<List<int>>(flightJsonResponse);
                        foreach (var flightId in flightInfo)
                        {
                            Console.WriteLine($"Flight ID: {flightId}");
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

        private static async Task ReturnHotels(string destination)
        {
            try
            {
                string targetURL = ConsoleAppUrl + "/Hotel";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("destination", destination);
                    Console.WriteLine($"Sending request to: {targetURL}");
                    Console.WriteLine($"Headers: destination={destination}");
                    HttpResponseMessage response = await client.GetAsync(targetURL);

                    if (response.IsSuccessStatusCode)
                    {
                        string hotelJsonResponse = await response.Content.ReadAsStringAsync();
                        var hotels = JsonSerializer.Deserialize<List<Hotel>>(hotelJsonResponse);
                        foreach (var hotel in hotels)
                        {
                            Console.WriteLine($"HotelID: {hotel.HotelID} HotelName: {hotel.HotelName}");
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

        private static async Task ReturnRooms(string selectedHotelID)
        {
            try
            {
                string targetURL = ConsoleAppUrl + "/Room";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("room", selectedHotelID);
                    Console.WriteLine($"Sending request to: {targetURL}");
                    Console.WriteLine($"Headers: room={selectedHotelID}");
                    HttpResponseMessage response = await client.GetAsync(targetURL);

                    if (response.IsSuccessStatusCode)
                    {
                        string roomJsonResponse = await response.Content.ReadAsStringAsync();

                        if (roomJsonResponse.StartsWith("["))
                        {
                            var rooms = JsonSerializer.Deserialize<List<Room>>(roomJsonResponse);
                            foreach (var room in rooms)
                            {
                                Console.WriteLine($"RoomID: {room.RoomID} RoomType: {room.RoomType}");
                            }
                        }
                        else
                        {
                            var room = JsonSerializer.Deserialize<Room>(roomJsonResponse);
                            Console.WriteLine($"RoomID: {room.RoomID} RoomType: {room.RoomType}");
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




        private static async Task ReturnInsurancePlans()
        {
            try
            {
                string targetURL = ConsoleAppUrl + "/Insurance";
                using (HttpClient client = new HttpClient())
                {
                    Console.WriteLine($"Sending request to: {targetURL}");

                    HttpResponseMessage response = await client.GetAsync(targetURL);

                    if (response.IsSuccessStatusCode)
                    {
                        string insuranceJsonResponse = await response.Content.ReadAsStringAsync();
                        var insuranceList = JsonSerializer.Deserialize<List<Insurance>>(insuranceJsonResponse);

                        foreach (var insurance in insuranceList)
                        {
                            Console.WriteLine($"Insurance ID: {insurance.InsuranceID}, Insurance Type: {insurance.InsuranceName}");
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

        private static async Task ReturnAvailableCars()
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

                        foreach (var vehicle in vehicleList)
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

        private static async Task ProcessBooking()
        {
            // // Allow the DB to auto increment order number
            // newBooking!.OrderNumber = 0;
            // bookingContext.Booking.Add(bookingData);
            // await bookingContext.SaveChangesAsync();

            // // Returns booking information and order number to the client.
            // newBooking.OrderNumber = newBooking.OrderNumber;
            // string jsonResponse = JsonSerializer.Serialize(newBooking);
            // byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);
            // return buffer;
        }




    }
}

