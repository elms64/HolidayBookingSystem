// GitHub Authors: @elms64, @Kloakk

/* Client Emulator for front end interaction testing with backend server */

/* System Libraries */
using System;
using System.Data;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ClientEmulator.Models;
using System.Security.Cryptography;
using System.Text;

namespace ClientEmulator
{
    class Program
    {
        /* Variables */
        private static readonly string ConsoleAppUrl = "http://localhost:8080";
        private static string? origin;
        private static string? destination;
        private static readonly HttpClient httpClient = new HttpClient();

        /* Constructor */
        static async Task Main(string[] args)
        {
            // Initialize the booking process
            await BookingInit();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /* Data Classes */
        public class AirportInfo
        {
            public List<Airport>? OriginAirports { get; set; }
            public List<Airport>? DestinationAirports { get; set; }
        }
        public class FlightInfo
        {
            public List<Flight>? SelectedFlights { get; set; }
        }
        public class HotelInfo
        {
            public List<Hotel>? matchingHotels { get; set; }
        }
        public class InsuranceInfo
        {
            public List<Insurance>? matchingInsurance { get; set; }
        }

        /* Methods */
        // Initialises the booking process based on a chosen destination, country of origin and dates which
        // are based on the current time for a 7 day holiday for testing purposes. 
        private static async Task BookingInit()
        {
            // Get destination from user input
            // Enter 826 for UK
            Console.WriteLine("Where From");
            origin = Console.ReadLine();

            // Get origin from user input
            // Enter 724 for Spain
            Console.WriteLine("Where To");
            //CountryID in booking bit at the bottom
            destination = Console.ReadLine();

            Console.WriteLine("Departure Date: " + DateTime.Now);
            Console.WriteLine("Return Date: " + DateTime.Now.AddDays(7));

            // Initiate the flight process
            await Booking();
        }

        // Main process for retrieving the rest of the booking information from the user.
        public static async Task Booking()
        {
            try
            {
                /* Initiate the booking process by sending a GET request to the server with a selected country of origin
                   and a destinatin country. If communication is successful the server will reply with details of airports
                   matching the chosen countries and begin the session. */
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
                        /* Booking Stage 1: Airports, Client Signup and Flights. */
                        /* ------------------------------------------------------------------------------------------ */

                        // Collect the departure airport and arrival airport from the user.
                        string flightAirportJsonResponse = await response.Content.ReadAsStringAsync();
                        var airportInfo = JsonSerializer.Deserialize<AirportInfo>(flightAirportJsonResponse);
                        foreach (var originAirport in airportInfo!.OriginAirports!)
                        {
                            Console.WriteLine(originAirport.ToString());
                        }
                        Console.WriteLine("Enter the ID of your desired departure airport:");
                        string departureAirport = Console.ReadLine()!;

                        foreach (var destinationAirport in airportInfo!.DestinationAirports!)
                        {
                            Console.WriteLine(destinationAirport.ToString());
                        }
                        Console.WriteLine("Enter the ID of your desired arrival airport:");
                        string arrivalAirport = Console.ReadLine()!;

                        // Return flights based on the chosen airports.
                        await ReturnFlights(departureAirport, arrivalAirport);

                        // Choose and confirm flight.
                        Console.WriteLine(" ✈  Please select the flight ID you wish to book: ✈ ");
                        string selectedFlightID = Console.ReadLine()!;
                        Console.WriteLine("You have selected Flight ID: " + selectedFlightID);
                        Console.WriteLine("Are you happy to proceed?");
                        string confirmFlight = Console.ReadLine();
                        int FlightBookingID = 0;
                        int clientID = 0;
                        // Enter client details if happy to proceed with flight booking.
                        if (confirmFlight == "Yes")
                        {
                            clientID = await SignUpClient();
                            Console.WriteLine("Client details confirmed.");
                            FlightBookingID = await FlightBooking(selectedFlightID, clientID);
                            Console.WriteLine("Flight booking set to pending.");
                        }
                        else
                        {
                            Console.WriteLine("Cancelling transaction... exiting application...");
                            Environment.Exit(0);
                        }
                        /* ------------------------------------------------------------------------------------------ */


                        /* Booking Stage 2: Hotel Room */
                        /* ------------------------------------------------------------------------------------------ */

                        // Continue to booking a hotel.
                        await ReturnHotels(destination!);
                        Console.WriteLine("🏠 Please enter the ID of the hotel you wish to stay in: 🏠 ");
                        string selectedHotelID = Console.ReadLine()!;

                        // Return rooms in the selected hotel.
                        await ReturnRooms(selectedHotelID!);

                        // Choose hotel room and confirm hotel booking.
                        Console.WriteLine("Please enter the ID of the room you wish to book:");
                        string selectedRoom = Console.ReadLine()!;
                        Console.WriteLine("You have selected room ID: " + selectedRoom + " in the hotel ID: " + selectedHotelID);
                        Console.WriteLine("Are you happy to proceed with your hotel booking?");
                        string confirmHotelBooking = Console.ReadLine();
                        int HotelBookingID = 0;
                        if (confirmHotelBooking == "Yes")
                        {
                            HotelBookingID = await HotelBooking(selectedHotelID, selectedRoom, clientID);
                            Console.WriteLine("Hotel booking set to pending.");
                        }
                        else
                        {
                            Console.WriteLine("Cancelling transaction... exiting application...");
                            Environment.Exit(0);
                        }
                        /* ------------------------------------------------------------------------------------------ */



                        /* Booking Stage 3: Insurance */
                        /* ------------------------------------------------------------------------------------------ */

                        // Continue to booking insurance.
                        Console.WriteLine("Now you have created your hotel booking, would you like insurance?");
                        string insuranceInput = Console.ReadLine()!;
                        string selectedInsurance = "";
                        int InsuranceBookingID = 0;
                        if (insuranceInput == "Y")
                        {
                            // Return insurance plans to the user.
                            await ReturnInsurancePlans();
                            Console.WriteLine("Please select the type of insurance you would like:");
                            selectedInsurance = Console.ReadLine()!;

                            // Confirm insurance and create booking.
                            Console.WriteLine("You have selected: " + selectedInsurance + " insurance.");
                            Console.WriteLine("Are you happy to proceed?");
                            string confirmInsurance = Console.ReadLine();
                            
                            if (confirmInsurance == "Yes")
                            {
                                InsuranceBookingID = await InsuranceBooking(selectedInsurance, clientID);
                                Console.WriteLine("Insurance booking set to pending.");
                            }

                            // Insurance is optional so continue booking if cancelled.
                            else
                            {
                                Console.WriteLine("Insurance cancelled, continuing transaction...");
                            }
                        }
                        /* ------------------------------------------------------------------------------------------ */


                        /* Booking Stage 4: Car Hire */
                        /* ------------------------------------------------------------------------------------------ */

                        // Continue to booking a car hire.
                        string selectedCar = "";
                        Console.WriteLine("Do you need to hire a car?");
                        string carInput = Console.ReadLine()!;
                        int VehicleBookingID = 0;
                        if (carInput == "Y")
                        {
                            // Return all available car types to the user.
                            await ReturnAvailableCars();
                            Console.WriteLine("Please select the ID of the car you wish to hire:");
                            selectedCar = Console.ReadLine()!;
                            Console.WriteLine("You have chosen the car ID: " + selectedCar);
                            Console.WriteLine("Are you happy to proceed with the car hire booking?");
                            string confirmVehicle = Console.ReadLine();
                            
                            
                            if (confirmVehicle == "Yes")
                            {
                                VehicleBookingID = await VehicleBooking(selectedCar, clientID);
                                Console.WriteLine("Vehicle booking " + VehicleBookingID + "status set to pending.");
                            }

                            // Vehicles are optional so continue transaction if cancelled
                            else
                            {
                                Console.WriteLine("Vehicle booking cancelled, continuing transaction...");
                            }
                        }
                        /* ------------------------------------------------------------------------------------------ */


                        /* Booking Stage 5: Final Confirmation */
                        /* ------------------------------------------------------------------------------------------ */

                        // Complete final booking confirmation and change previous bookings from pending to confirmed.

                        // Print order information to user from stored variables
                        Console.WriteLine("You have now completed the booking enquiry. Please review your booking information:");
                        Console.WriteLine("order information here");

                        // Allow user to confirm booking or cancel the transaction.
                        Console.WriteLine("Please type 'continue' if you are happy to proceed or 'cancel' to back out of the transaction:");
                        string userConfirmation = Console.ReadLine()!;
                        if (userConfirmation == "continue")
                        {
                            // Previously handled it by running them all at the end. Have refactored but left here just in case. 
                            //int HotelBookingID = await HotelBooking(selectedHotelID, selectedRoom);
                            //int VehicleBookingID = await VehicleBooking(selectedCar);
                            //int InsuranceBookingID = await InsuranceBooking(selectedInsurance);
                            await ProcessBooking(destination!, clientID, HotelBookingID, FlightBookingID, VehicleBookingID, InsuranceBookingID);

                        }
                        else if (userConfirmation == "cancel")
                        {
                            Console.WriteLine("Booking cancelled, would you like to close the application?");
                            // Could integrate option to either cancel and exit or restart, maintaining the booking info
                            // Change previous bookings to cancelled or perhaps delete them altogether
                        }
                        /* ------------------------------------------------------------------------------------------ */

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


        /* Methods */
        /* The following methods are used to return information to the user via HTTP GET requests and send information to the 
           backend server via PUT requests. These methods are called earlier in the program to run through the booking process. */


        // Returns flight information relevant to the chosen departure and arrival airports. 
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
                        foreach (var flightId in flightInfo!)
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

        // Returns information about available hotels in the selected destination country.
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
                        foreach (var hotel in hotels!)
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

        // Returns information about available rooms in the selected hotel. 
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
                            foreach (var room in rooms!)
                            {
                                Console.WriteLine($"RoomID: {room.RoomID} RoomType: {room.RoomType}");
                            }
                        }
                        else
                        {
                            var room = JsonSerializer.Deserialize<Room>(roomJsonResponse);
                            Console.WriteLine($"RoomID: {room!.RoomID} RoomType: {room.RoomType}");
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

        // Returns information about available insurance plans to the user. 
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

                        foreach (var insurance in insuranceList!)
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

        // Returns available car rentals from the server to the user.
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

        // Collects information about a new client and sends it to the server for processing, retrieving the new Client ID.
        private static async Task<int> SignUpClient()
        {
            Console.WriteLine("Enter the clients first name: ");
            string? firstName = Console.ReadLine();

            Console.WriteLine("Enter the clients last name: ");
            string? lastName = Console.ReadLine();

            // Maybe we need something to specify the format. 
            Console.WriteLine("Enter the clients date of birth: ");
            string? DoB = Console.ReadLine();

            Console.WriteLine("Enter the clients Email: ");
            string? Email = Console.ReadLine();

            Console.WriteLine("Enter the clients PhoneNumber: ");
            string? PhoneNumber = Console.ReadLine();

            // PUT request
            // On response returnID. 
            string serverURL = ConsoleAppUrl + "/Client";
            var Client = new List<KeyValuePair<string, string>>();
            Client.Add(new KeyValuePair<string, string>("FirstName", firstName));
            Client.Add(new KeyValuePair<string, string>("LastName", lastName));
            Client.Add(new KeyValuePair<string, string>("DoB", DoB));
            Client.Add(new KeyValuePair<string, string>("Email", Email));
            Client.Add(new KeyValuePair<string, string>("PhoneNumber", PhoneNumber));

            string jsonPayload = JsonSerializer.Serialize(Client);
            StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PutAsync(serverURL, content);

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                // Read the response content
                string responseContent = await response.Content.ReadAsStringAsync();

                // Parse the JSON response to get the ClientID
                var responseObject = JsonSerializer.Deserialize<Dictionary<string, object>>(responseContent);
                if (responseObject.TryGetValue("ClientID", out object clientIDObj))
                {
                    if (clientIDObj is JsonElement clientIDElement && clientIDElement.TryGetInt32(out int clientID))
                    {
                        Console.WriteLine($"Client data sent successfully! ClientID: {clientID}");
                        return clientID;
                    }
                    else
                    {
                        Console.WriteLine("Error: Unable to parse ClientID from the response.");
                        return -1;
                    }
                }
                else
                {
                    Console.WriteLine("Error: ClientID not found in the response.");
                    return -1;
                }
            }
            return -1;
        }

        // Creates a flight booking.
        private static async Task<int> FlightBooking(string selectedFlightID, int clientID)
        {
            string serverURL = ConsoleAppUrl + "/FlightBooking";
            var FlightBooking = new List<KeyValuePair<string, string>>();
            FlightBooking.Add(new KeyValuePair<string, string>("FlightID", selectedFlightID));
            FlightBooking.Add(new KeyValuePair<string, string>("ClientID", clientID.ToString()));

            string jsonPayload = JsonSerializer.Serialize(FlightBooking);
            StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PutAsync(serverURL, content);

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                // Parse the JSON response to get the FlightBookingID
                var responseObject = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(responseContent);
                if (responseObject!.TryGetValue("FlightBookingID", out JsonElement flightBookingIDElement))
                {
                    // Extract the value from JsonElement
                    int flightBookingID = flightBookingIDElement.GetInt32();
                    Console.WriteLine($"Flight booking transaction sent successfully! FlightBookingID: {flightBookingID}");
                    return flightBookingID;
                }
                else
                {
                    Console.WriteLine("Error: Unable to parse FlightBookingID from the response.");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                return -1;
            }
        }

        private static async Task<int> HotelBooking(string HotelID, string RoomID, int ClientID)
        {
            string serverURL = ConsoleAppUrl + "/HotelBooking";

            var HotelBooking = new List<KeyValuePair<string, string>>();

            HotelBooking.Add(new KeyValuePair<string, string>("HotelID", HotelID));
            HotelBooking.Add(new KeyValuePair<string, string>("RoomID", RoomID));

            string jsonPayload = JsonSerializer.Serialize(HotelBooking);
            StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PutAsync(serverURL, content);

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                // Read the response content
                string responseContent = await response.Content.ReadAsStringAsync();

                // Parse the JSON response to get the HotelBookingID
                var responseObject = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(responseContent);
                if (responseObject!.TryGetValue("HotelBookingID", out JsonElement hotelBookingIDElement))
                {
                    // Extract the value from JsonElement
                    int hotelBookingID = hotelBookingIDElement.GetInt32();
                    Console.WriteLine($"Hotel booking transaction sent successfully! HotelBookingID: {hotelBookingID}");
                    return hotelBookingID;
                }
                else
                {
                    Console.WriteLine("Error: Unable to parse HotelBookingID from the response.");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                return -1;
            }

        }

        // Creates a vehicle booking in the database.
        private static async Task<int> VehicleBooking(string selectedCar, int ClientID)
        {
            string serverURL = ConsoleAppUrl + "/VehicleBooking";
            // Convert the booking transaction to JSON and send a PUT request

            var VehicleBooking = new List<KeyValuePair<string, string>>();
            VehicleBooking.Add(new KeyValuePair<string, string>("VehicleID", selectedCar));

            string jsonPayload = JsonSerializer.Serialize(VehicleBooking);
            StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PutAsync(serverURL, content);


            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                var responseObject = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(responseContent);
                if (responseObject!.TryGetValue("VehicleBookingID", out JsonElement vehicleBookingIDElement))
                {
                    int VehicleBookingID = vehicleBookingIDElement.GetInt32();
                    Console.WriteLine($"Vehicle Booking transaction send successfully! VehicleBookingID: {VehicleBookingID}");
                    return VehicleBookingID;
                }
                else
                {
                    Console.WriteLine("Error : Unable to parse vehicleBookingID from the response.");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                return -1;
            }
        }

        // Creates an insurance booking in the database.
        private static async Task<int> InsuranceBooking(string selectedInsurance, int ClientID)
        {
            string serverURL = ConsoleAppUrl + "/InsuranceBooking";
            // Convert the booking transaction to JSON and send a PUT request

            var InsuranceBooking = new List<KeyValuePair<string, string>>();
            InsuranceBooking.Add(new KeyValuePair<string, string>("InsuranceID", selectedInsurance));

            string jsonPayload = JsonSerializer.Serialize(InsuranceBooking);
            StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PutAsync(serverURL, content);

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                var responseObject = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(responseContent);
                if (responseObject!.TryGetValue("InsuranceBookingID", out JsonElement insuranceBookingIDElement))
                {
                    int InsuranceBookingID = insuranceBookingIDElement.GetInt32();
                    Console.WriteLine($"Vehicle Booking transaction send successfully! VehicleBookingID: {InsuranceBookingID}");
                    return InsuranceBookingID;
                }
                else
                {
                    Console.WriteLine("Error : Unable to parse insuranceBookingID from the response.");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                return -1;
            }

        }

        // Processes all the booking information into a variable to be sent via HTTP.
        private static async Task ProcessBooking(string destination, int ClientID, int HotelBookingID, int selectedFlightID, int VehiclebookingID, int InsuranceBookingID)
        {
            Console.WriteLine("Sending Booking Data!");
            Console.WriteLine($"Booking Data being sent : \n CountryID : {destination} \n HotelBookingID : {HotelBookingID} \n FlightID : {selectedFlightID}\n VehicleBookingID : {VehiclebookingID} \n InsuranceBookingID : {InsuranceBookingID}");
            try
            {
                // Create a list to store key-value pairs for booking data
                var bookingData = new List<KeyValuePair<string, string>>();

                // Add key-value pairs for each property of the Booking model
                bookingData.Add(new KeyValuePair<string, string>("OrderNumber", "0"));
                bookingData.Add(new KeyValuePair<string, string>("TransactionGUID", Guid.NewGuid().ToString()));
                bookingData.Add(new KeyValuePair<string, string>("PurchaseDate", DateTime.Now.ToString()));
                bookingData.Add(new KeyValuePair<string, string>("CountryID", destination));
                bookingData.Add(new KeyValuePair<string, string>("ClientID", ClientID.ToString()));
                bookingData.Add(new KeyValuePair<string, string>("HotelBookingID", HotelBookingID.ToString()));
                bookingData.Add(new KeyValuePair<string, string>("FlightID", selectedFlightID.ToString()));
                bookingData.Add(new KeyValuePair<string, string>("VehicleBookingID", VehiclebookingID.ToString()));
                bookingData.Add(new KeyValuePair<string, string>("InsuranceBookingID", InsuranceBookingID.ToString()));

                // Calculate checksum for the booking data
                string checksum = CalculateChecksum(JsonSerializer.Serialize(bookingData));

                // Add checksum to the booking data
                bookingData.Add(new KeyValuePair<string, string>("CheckSum", checksum));

                // Print the data being sent in the response
                Console.WriteLine("Data being sent in the response:");
                foreach (var kvp in bookingData)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }

                // Call SendBookingTransaction with the populated bookingData
                await SendBookingTransaction(bookingData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Calculate a Checksum value for the booking content
        private static string CalculateChecksum(string data)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(data));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        // Method for sending the transaction as a JSON file via HTTP PUT.
        private static async Task SendBookingTransaction(List<KeyValuePair<string, string>> bookingData)
        {
            try
            {
                // Location of Program 2 (BookingProcessor)
                string serverURL = ConsoleAppUrl + "/Booking";

                // Authorisation headers, assigns a GUID and checksum for transaction identification and validation
                Guid guid = Guid.NewGuid();
                string checksum = CalculateChecksum(JsonSerializer.Serialize(bookingData));
                httpClient.DefaultRequestHeaders.Add("X-Transaction-ID", guid.ToString());
                httpClient.DefaultRequestHeaders.Add("Checksum", checksum);
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                // Convert the booking transaction to JSON and send a PUT request
                string jsonPayload = JsonSerializer.Serialize(bookingData);
                StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(serverURL, content);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Booking transaction sent successfully!");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");

                    // If the request was unsuccessful, save it into batch transactions
                    SaveBatches svbtch = new SaveBatches();
                    await svbtch.SaveBatchProcess(jsonPayload, guid);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

    }
}