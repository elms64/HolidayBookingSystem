// GitHub Authors: @elms64 & @Kloakk

// Client Emulator for front end interaction testing with backend server 

using System.Data;
using ClientEmulator.Models;
using System.Text;
using System.Net;

namespace ClientEmulator
{
    class Emulator
    {
        /* Variables */
        private static readonly string ConsoleAppUrl = "http://localhost:8080";
        private static string? origin;
        private static string? destination;
        private static readonly HttpClient httpClient = new HttpClient();

        /* Constructor */
        static async Task Main(string[] args)
        {
            // Start the HTTP listener on a separate thread
            _ = Task.Run(StartHttpListener);

            // Check if there are any stored batch processes and send to server.
            await ShowLoadingBar();

            SplashScreen();

            await Task.Delay(1800);
            await SendBatches();

            // Initialize the booking process.
            await Task.Delay(1000);
            await BookingInit();

            // Once operations are complete, press any key to exit the application.
            Console.WriteLine("Press any key to exit...");
            Console.WriteLine("");
            Console.ReadKey();
            Environment.Exit(0);

            await Task.Delay(Timeout.Infinite); // Keep the main thread alive
        }

        /* Methods */
        private static async Task ShowLoadingBar()
        {

            for (int i = 0; i < 50; i++)
            {
                Console.Write("*");
                await Task.Delay(1);
            }


            await Task.Delay(200); // Pause for 0.4 seconds

        }

        private static async void SplashScreen()
        {
            Console.WriteLine("");
            await Task.Delay(10);
            Console.WriteLine("*                                                *");
            await Task.Delay(10);
            Console.WriteLine("*    Booking Processor Utility                   *");
            await Task.Delay(10);
            Console.WriteLine("*                                                *");
            await Task.Delay(10);
            Console.WriteLine("*    Welcome, System Administrator!              *");
            await Task.Delay(10);
            Console.WriteLine("*                                                *");
            await Task.Delay(10);
            Console.WriteLine("*    This utility serves as a front              *");
            await Task.Delay(10);
            Console.WriteLine("*    end for the backend created. It             *");
            await Task.Delay(10);
            Console.WriteLine("*    is used to test data transfer.              *");
            await Task.Delay(10);
            Console.WriteLine("*                                                *");
            await Task.Delay(10);
            Console.WriteLine("*    Copyright © 2023 Booking Beyond             *");
            await Task.Delay(10);
            Console.WriteLine("*    Boundaries. All rights reserved.            *");
            await Task.Delay(10);
            Console.WriteLine("*                                                *");
            await Task.Delay(10);
            Console.WriteLine("*    GitHub Authors:                             *");
            await Task.Delay(10);
            Console.WriteLine("*    @elms64, @Kloakk                            *");
            await Task.Delay(10);
            Console.WriteLine("*                                                *");
            await Task.Delay(10);
            Console.WriteLine("*    For support and inquiries, please           *");
            await Task.Delay(10);
            Console.WriteLine("*    contact support@bookingbeyond.com.          *");
            await Task.Delay(10);
            Console.WriteLine("*                                                *");
            await Task.Delay(10);
            Console.WriteLine("*                                                *");
            await Task.Delay(10);
            Console.WriteLine("*    ----------------------------------------    *");
            await Task.Delay(10);
            Console.WriteLine("*                                                *");
            await Task.Delay(10);
            Console.WriteLine("*                                                *");
            await Task.Delay(10);
            Console.WriteLine("*    Thank you for choosing                      *");
            await Task.Delay(10);
            Console.WriteLine("*    Booking Beyond Boundaries!                  *");
            await Task.Delay(10);
            Console.WriteLine("*                                                *");
            await Task.Delay(10);
            for (int i = 0; i < 50; i++)
            {
                Console.Write("*");
                await Task.Delay(1);
            }
            Console.WriteLine("");
            Console.WriteLine("");

        }

        public class AirportInfo
        {
            public List<Airport>? OriginAirports { get; set; }
            public List<Airport>? DestinationAirports { get; set; }
        }

        private static async Task StartHttpListener()
        {
            string url = "http://localhost:8081/"; // Choose the desired URL and port
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add(url);
            listener.Start();

            try
            {
                while (true)
                {
                    // Wait for an incoming request
                    HttpListenerContext context = await listener.GetContextAsync();

                    // Process the request
                    if (context.Request.HttpMethod == "GET" && context.Request.Url!.PathAndQuery == "/batchrecovery")
                    {
                        // Handle incoming GET request here
                        List<string> batchResponse = RetrieveBatchData();

                        // Send a response to the client with batch data
                        context.Response.StatusCode = (int)HttpStatusCode.OK;
                        using (StreamWriter writer = new StreamWriter(context.Response.OutputStream))
                        {
                            foreach (string jsonData in batchResponse)
                            {
                                await writer.WriteAsync(jsonData);
                                await writer.WriteAsync(Environment.NewLine); // Add newline between JSON files
                            }
                        }
                    }
                    if (context.Request.HttpMethod == "POST" && context.Request.Url!.PathAndQuery == "/servernotifications")
                    {
                        // Handle incoming POST request indicating batch processed
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Notification received: Batch processed successfully.");
                        Console.ResetColor();

                        // Retrieve the TransactionGUID from the request headers
                        string? transactionGuidHeader = context.Request.Headers.Get("TransactionGUID");
                        if (Guid.TryParse(transactionGuidHeader, out Guid transactionGuid))
                        {
                            // Trigger a method to delete batches with a filename equal to the given GUID
                            DeleteBatchByGuid(transactionGuid);

                            // Notify the client somehow that this has happened
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Deleted batches with TransactionGUID: " + transactionGuid);
                            Console.ResetColor();
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Invalid TransactionGUID in the notification.");
                        }

                        // Send a response to the server acknowledging the notification
                        context.Response.StatusCode = (int)HttpStatusCode.OK;
                        using (StreamWriter writer = new StreamWriter(context.Response.OutputStream))
                        {
                            await writer.WriteAsync("Notification received");
                        }
                    }

                    // Close the response stream
                    context.Response.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Stop the listener when finished
                listener.Stop();
            }
        }

        private static void DeleteBatchByGuid(Guid transactionGuid)
        {
            try
            {
                // Assuming the batches are stored in a folder named "BatchRequests"
                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BatchRequests");

                if (Directory.Exists(folderPath))
                {
                    // Get all files in the directory
                    string[] files = Directory.GetFiles(folderPath);

                    // Filter files by TransactionGUID
                    var matchingFiles = files.Where(file => Path.GetFileNameWithoutExtension(file) == transactionGuid.ToString());

                    // Delete matching files
                    foreach (var file in matchingFiles)
                    {
                        File.Delete(file);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting batches: {ex.Message}");
            }
        }

        // Initialises the booking process based on a chosen destination, country of origin and dates which
        // are based on the current time for a 7 day holiday for testing purposes. 
        private static async Task BookingInit()
        {
            // Get destination from user input
            // Enter 826 for UK (due to SeedData availability)
            // Also entering the ID as this is only a simulation of front end, and that's how it would process a selected country
            Console.WriteLine("What Country Are You Travelling From?");
            origin = Console.ReadLine();
            Console.WriteLine("");

            // Get origin from user input
            // Enter 724 for Spain (due to SeedData availability)
            // Also entering the ID as this is only a simulation of front end, and that's how it would process a selected country
            Console.WriteLine("What Country Are You Travelling To?");
            destination = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Departure Date: " + DateTime.Now);
            Console.WriteLine("Return Date: " + DateTime.Now.AddDays(7));
            Console.WriteLine("");

            // Initiate the flight process
            await Booking();
        }

        // Main process for retrieving the rest of the booking information from the user.
        public static async Task Booking()
        {
            try
            {
                /* Booking Stage 1: Flights */
                /* ------------------------------------------------------------------------------------------ */

                ReturnAirports rtnAir = new ReturnAirports(ConsoleAppUrl, origin!, destination!);

                // Get origin airports
                List<Airport> originAirports = await rtnAir.GetOriginAirportsAsync();
                foreach (var originAirport in originAirports)
                {
                    Console.WriteLine($"Airport ID: {originAirport.AirportID}, Name: {originAirport.AirportName}");
                }

                // Collect the departure airport and arrival airport from the user.
                Console.WriteLine("");
                Console.WriteLine("Enter the ID of your desired departure airport:");
                string departureAirport = Console.ReadLine()!;
                Console.WriteLine("");

                // Get destination airports
                List<Airport> destinationAirports = await rtnAir.GetDestinationAirportsAsync();
                foreach (var destinationAirport in destinationAirports)
                {
                    Console.WriteLine($"Airport ID: {destinationAirport.AirportID}, Name: {destinationAirport.AirportName}");
                }

                Console.WriteLine("");
                Console.WriteLine("Enter the ID of your desired arrival airport:");
                string arrivalAirport = Console.ReadLine()!;

                // Return flights based on the chosen airports.
                ReturnFlights rtnflight = new ReturnFlights();
                await rtnflight.ReturnFlightsList(departureAirport, arrivalAirport);

                // Choose and confirm flight.
                Console.WriteLine("");
                Console.WriteLine(" ✈  Please select the flight ID you wish to book: ✈ ");
                string selectedFlightID = Console.ReadLine()!;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You have selected Flight ID: " + selectedFlightID);
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Are you happy to proceed?");

                string confirmFlight = GetUserConfirmation();
                Console.WriteLine("");
                int FlightBookingID = 0;
                int clientID = 0;

                // Enter client details if happy to proceed with flight booking.
                if (confirmFlight == "Yes")
                {
                    SignUpClient sgnclt = new SignUpClient();
                    clientID = await sgnclt.SignUpClientAsync();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Client details confirmed.");
                    Console.WriteLine("");
                    Console.ResetColor();

                    FlightBooking fltbk = new FlightBooking();
                    FlightBookingID = await fltbk.FlightBookingAsync(selectedFlightID, clientID);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Flight booking ID: " + FlightBookingID + " set to pending.");
                    Console.ResetColor();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Cancelling transaction... exiting application...");
                    Console.ResetColor();
                    Environment.Exit(0);
                }

                /* ------------------------------------------------------------------------------------------ */

                /* Booking Stage 2: Hotel Room */
                /* ------------------------------------------------------------------------------------------ */

                // Continue to booking a hotel.
                ReturnHotels rtnHotels = new ReturnHotels();
                await rtnHotels.ReturnHotelsList(destination!);

                Console.WriteLine("🏠 Please enter the ID of the hotel you wish to stay in: 🏠 ");
                string selectedHotelID = Console.ReadLine()!;

                // Return rooms in the selected hotel.
                ReturnRooms rtnrms = new ReturnRooms();
                await rtnrms.ReturnRoomsList(selectedHotelID!);

                // Choose hotel room and confirm hotel booking.
                Console.WriteLine("Please enter the ID of the room you wish to book:");
                string selectedRoom = Console.ReadLine()!;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("You have selected room ID: " + selectedRoom + " in the hotel ID: " + selectedHotelID);
                Console.WriteLine("");
                Console.ResetColor();
                Console.WriteLine("Are you happy to proceed with your hotel booking?");
                string confirmHotelBooking = GetUserConfirmation();
                Console.WriteLine("");
                int HotelBookingID = 0;
                if (confirmHotelBooking == "Yes")
                {
                    HotelBooking htlbk = new HotelBooking();
                    HotelBookingID = await htlbk.HotelBookingAsync(selectedHotelID, selectedRoom, clientID);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hotel booking ID: " + HotelBookingID + " set to pending.");
                    Console.ResetColor();
                    Console.WriteLine("");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Cancelling transaction... exiting application...");
                    Console.ResetColor();
                    Environment.Exit(0);
                }

                /* ------------------------------------------------------------------------------------------ */

                /* Booking Stage 3: Insurance */
                /* ------------------------------------------------------------------------------------------ */

                // Continue to booking insurance.
                Console.WriteLine("Now you have created your hotel booking, would you like insurance?");
                string insuranceInput = GetUserConfirmation();
                string selectedInsurance = "";
                int InsuranceBookingID = 0;
                if (insuranceInput == "Yes")
                {
                    // Return insurance plans to the user.
                    ReturnInsurancePlans rtnInsurance = new ReturnInsurancePlans();
                    await rtnInsurance.ReturnInsuranceList();

                    Console.WriteLine("Please select the type of insurance you would like:");
                    selectedInsurance = Console.ReadLine()!;

                    // Confirm insurance and create booking.
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine("You have selected Insurance ID: " + selectedInsurance);
                    Console.WriteLine("");
                    Console.ResetColor();
                    Console.WriteLine("Are you happy to proceed?");
                    string confirmInsurance = GetUserConfirmation();
                    Console.WriteLine("");

                    if (confirmInsurance == "Yes")
                    {
                        InsuranceBooking insbk = new InsuranceBooking();
                        InsuranceBookingID = await insbk.InsuranceBookingAsync(selectedInsurance, clientID);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Insurance booking ID: " + selectedInsurance + " set to pending.");
                        Console.ResetColor();
                        Console.WriteLine("");
                    }

                    // Insurance is optional so continue booking if cancelled.
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Insurance cancelled, continuing transaction...");
                        Console.ResetColor();
                    }
                }
                /* ------------------------------------------------------------------------------------------ */

                /* Booking Stage 4: Car Hire */
                /* ------------------------------------------------------------------------------------------ */

                // Continue to booking a car hire.
                string selectedCar = "";
                Console.WriteLine("Do you need to hire a car? Type Yes / Nox");
                string carInput = GetUserConfirmation();
                int VehicleBookingID = 0;
                if (carInput == "Yes")
                {
                    // Return all available car types to the user.
                    ReturnVehicles rtnvhcl = new ReturnVehicles();
                    await rtnvhcl.ReturnVehicleList();

                    Console.WriteLine("Please select the ID of the car you wish to hire:");
                    selectedCar = Console.ReadLine()!;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine("You have selected the car ID: " + selectedCar);
                    Console.WriteLine("");
                    Console.ResetColor();
                    Console.WriteLine("Are you happy to proceed with the car hire booking?  Type Yes / No " );
                    string confirmVehicle = GetUserConfirmation();
                    Console.WriteLine("");

                    if (confirmVehicle == "Yes")
                    {
                        VehicleBooking vclbkg = new VehicleBooking();
                        VehicleBookingID = await vclbkg.VehicleBookingAsync(selectedCar, clientID);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Vehicle booking ID: " + VehicleBookingID + " status set to pending.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.ResetColor();

                    }

                    // Vehicles are optional so continue transaction if cancelled
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Vehicle booking cancelled, continuing transaction...");
                        Console.ResetColor();
                    }
                }
                /* ------------------------------------------------------------------------------------------ */

                /* Booking Stage 5: Final Confirmation */
                /* ------------------------------------------------------------------------------------------ */

                // Complete final booking confirmation and change previous bookings from pending to confirmed.

                // Print order information to user from stored variables
                Console.WriteLine("You have now completed the booking enquiry. Please review your booking information:");
                Console.WriteLine("-- order information here --");

                // Allow user to confirm booking or cancel the transaction.
                Console.WriteLine("Are you are happy to proceed? Type 'yes' to continue or 'cancel' to back out of the transaction:");
                string userConfirmation = GetUserConfirmation();
                Console.WriteLine("");
                if (userConfirmation == "Yes")
                {
                    ProcessBooking probk = new ProcessBooking();
                    await probk.ProcessBookingAsync(destination!, clientID, HotelBookingID, FlightBookingID, VehicleBookingID, InsuranceBookingID);
                    Console.WriteLine("");
                    Console.WriteLine("You have reached the end of the booking process. Please restart to create a new transaction.");
                    Console.WriteLine("");
                }
                else if (userConfirmation == "cancel")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Booking cancelled, would you like to close the application?");
                    Console.ResetColor();
                    // Could integrate option to either cancel and exit or restart, maintaining the booking info
                    // Change previous bookings to cancelled or perhaps delete them altogether
                }
                /* ------------------------------------------------------------------------------------------ */

            }
            catch (HttpRequestException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"HTTP Request Error: {ex.Message}");
                Console.ResetColor();
            }
            catch (TaskCanceledException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Task Canceled Error: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.ResetColor();
            }
        }

        // Allows user input to be more flexible. Case insentive and accepts Yes or Y etc. Catches errors in a loop.
        private static string GetUserConfirmation()
        {
            while (true)
            {
                string? input = Console.ReadLine()?.Trim().ToLower();

                if (input == "yes" || input == "y")
                {
                    return "Yes";
                }
                else if (input == "no" || input == "n")
                {
                    return "No";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.WriteLine("Are you happy to proceed?");
                }
            }
        }

        // Gets any batch files stored that need to be processed. 
        private static List<string> RetrieveBatchData()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BatchRequests");
            List<string> batchData = new List<string>();

            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath);

                if (files.Any())
                {
                    foreach (string filePath in files)
                    {
                        string jsonContent = File.ReadAllText(filePath);

                        batchData.Add(jsonContent);
                    }
                }
            }

            return batchData;
        }

        // Defines the expected format for JSON data.
        public class JsonDataItem
        {
            public string? Key { get; set; }
            public string? Value { get; set; }
            public Guid TransactionGUID { get; set; }
        }

        // Sends batches as a POST request to the server. 
        private static async Task SendBatches()
        {
            try
            {
                List<string> batchData = RetrieveBatchData();

                if (batchData.Any())
                {
                    using (HttpClient client = new HttpClient())
                    {
                        string endpoint = $"{ConsoleAppUrl}/BatchProcess";

                        // Combine the batch data into a JSON array string
                        string jsonArray = "[" + string.Join(",", batchData) + "]";

                        var content = new StringContent(jsonArray, Encoding.UTF8, "application/json");

                        var response = await client.PostAsync(endpoint, content);

                        if (response.IsSuccessStatusCode)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Batch data sent successfully to {endpoint}");
                            Console.WriteLine();
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Failed to send batch data to {endpoint}. Status code: {response.StatusCode}");
                            Console.WriteLine();
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("No batch data found in the BatchRequests folder.");
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }
            catch (HttpRequestException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"HTTP Request Error: {ex.Message}");
                Console.WriteLine("Attempted to send batches but the server is unavailable. Try again later.");
                Console.WriteLine();
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.WriteLine();
                Console.ResetColor();
            }
        }
    }
}