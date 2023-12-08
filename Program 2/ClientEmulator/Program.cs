// GitHub Authors: @elms64, @Kloakk & @dlawlor2408

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

                        await ReturnFlights(departureAirport, arrivalAirport);

                        Console.WriteLine(" ✈  Please select the flight ID you wish to book: ✈ ");
                        //selected Flight ID
                        string selectedFlightID = Console.ReadLine()!;

                        await ReturnHotels(destination!);

                        Console.WriteLine("🏠 Please enter the ID of the hotel you wish to stay in: 🏠 ");
                        //selected Hotel
                        string selectedHotelID = Console.ReadLine()!;

                        await ReturnRooms(selectedHotelID!);

                        Console.WriteLine("Please enter the ID of the room you wish to book:");
                        //Room booking
                        string selectedRoom = Console.ReadLine()!;

                        Console.WriteLine("Now you have created your hotel booking, would you like insurance?");
                        string insuranceInput = Console.ReadLine()!;
                        string selectedInsurance = "";
                        if (insuranceInput == "Y")
                        {
                            await ReturnInsurancePlans();
                            Console.WriteLine("Please select the type of insurance you would like:");
                            // selectedInsurance
                            selectedInsurance = Console.ReadLine()!;
                        }

                        string selectedCar = "";
                        Console.WriteLine("Do you need to hire a car?");
                        string carInput = Console.ReadLine()!;
                        if (carInput == "Y")
                        {
                            await ReturnAvailableCars();
                            Console.WriteLine("Please select the ID of the car you wish to hire:");
                            //Selected Car
                            selectedCar = Console.ReadLine()!;
                        }


                        Console.WriteLine("You have now completed the booking enquiry. Please review your booking information:");

                        // Print order information to user from stored variables:
                        Console.WriteLine("order information here");

                        Console.WriteLine("Please type 'continue' if you are happy to proceed or 'cancel' to back out of the transaction:");
                        string userConfirmation = Console.ReadLine()!;
                        if (userConfirmation == "continue")
                        {
                            int clientID = await SignUpClient();
                            int HotelBookingID = await HotelBooking(selectedHotelID, selectedRoom);
                            int VehicleBookingID =  await VehicleBooking(selectedCar);
                            int InsuranceBookingID = await InsuranceBooking(selectedInsurance);
                            await ProcessBooking(destination!, clientID.ToString(), HotelBookingID.ToString(), selectedFlightID, VehicleBookingID.ToString(), InsuranceBookingID.ToString());

                        }
                        else if (userConfirmation == "cancel")
                        {
                            Console.WriteLine("Booking cancelled, would you like to close the application?");
                            // Could integrate option to either cancel and exit or restart, maintaining the booking info
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
            Console.WriteLine("Enter the clients first name : ");
            string? firstName = Console.ReadLine();

            Console.WriteLine("Enter the clients last name : ");
            string? lastName = Console.ReadLine();

            //Maybe we need something to specify the format. 
            Console.WriteLine("Enter the clients DoB");
            string? DoB = Console.ReadLine();

            Console.WriteLine("Enter client Email");
            string? Email = Console.ReadLine();

            Console.WriteLine("Enter client PhoneNumber");
            string? PhoneNumber = Console.ReadLine();

            //PUT request
            //On response returnID. 

            string serverURL = ConsoleAppUrl + "/Client";

            var Client = new List<KeyValuePair<string, string>>();

            Client.Add(new KeyValuePair<string, string>("FirstName", firstName)); // Example vehicle booking ID <-- need to make HotelBooking at runtime
            Client.Add(new KeyValuePair<string, string>("LastName", lastName)); // Example insurance booking ID <-- need to make HotelBooking at runtime
            Client.Add(new KeyValuePair<string, string>("DoB", DoB)); // Example vehicle booking ID <-- need to make HotelBooking at runtime
            Client.Add(new KeyValuePair<string, string>("Email", Email)); // Example insurance booking ID <-- need to make HotelBooking at runtime
            Client.Add(new KeyValuePair<string, string>("PhoneNumber", PhoneNumber)); // Example insurance booking ID <-- need to make HotelBooking at runtime


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
        private static async Task<int> HotelBooking(string HotelID, string RoomID)
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

        private static async Task<int> VehicleBooking(string selectedCar)
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

        private static async Task<int> InsuranceBooking(string selectedInsurance)
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
        private static async Task ProcessBooking(string destination, string ClientID, string HotelBookingID, string selectedFlightID, string VehiclebookingID, string InsuranceBookingID)
        {
            Console.WriteLine("Sending Booking Data!");
            Console.WriteLine($"Booking Data being sent : \n CountryID : {destination} \n HotelBookingID : {HotelBookingID} \n FlightID : {selectedFlightID}\n VehicleBookingID : {VehiclebookingID} \n InsuranceBookingID : {InsuranceBookingID}");
            try
            {
                // Create a list to store key-value pairs for booking data
                var bookingData = new List<KeyValuePair<string, string>>();

                // Add key-value pairs for each property of the Booking model
                bookingData.Add(new KeyValuePair<string, string>("OrderNumber", "0")); // Example order number
                bookingData.Add(new KeyValuePair<string, string>("TransactionGUID", Guid.NewGuid().ToString()));
                bookingData.Add(new KeyValuePair<string, string>("PurchaseDate", DateTime.Now.ToString())); // Example purchase date
                bookingData.Add(new KeyValuePair<string, string>("CountryID", destination)); // Example country ID
                bookingData.Add(new KeyValuePair<string, string>("ClientID", ClientID)); // Example client ID
                bookingData.Add(new KeyValuePair<string, string>("HotelBookingID", HotelBookingID)); // Example hotel booking ID <-- need to make HotelBooking at runtime
                bookingData.Add(new KeyValuePair<string, string>("FlightID", selectedFlightID)); // Example flight ID
                bookingData.Add(new KeyValuePair<string, string>("VehicleBookingID", VehiclebookingID)); // Example vehicle booking ID <-- need to make HotelBooking at runtime
                bookingData.Add(new KeyValuePair<string, string>("InsuranceBookingID", InsuranceBookingID)); // Example insurance booking ID <-- need to make HotelBooking at runtime

                // Calculate checksum for the booking data
                string checksum = CalculateChecksum(JsonSerializer.Serialize(bookingData));

                // Add checksum to the booking data
                bookingData.Add(new KeyValuePair<string, string>("CheckSum", checksum));

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