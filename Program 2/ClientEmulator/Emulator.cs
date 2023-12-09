// GitHub Authors: @elms64 & @Kloakk

// Client Emulator for front end interaction testing with backend server 

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
using SQLitePCL;

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
            // Check if there are any stored batch processes and send to server.
            await ShowLoadingBar();
            await SendBatches();

            // Initialize the booking process.
            await BookingInit();

            // Once operations are complete, press any key to exit the application.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static async Task ShowLoadingBar()
        {
            Console.Clear();
            for (int i = 0; i < 60; i++)
            {
                Console.Write("*");
                await Task.Delay(10);
            }

            Console.Clear(); // Clear the console
            await Task.Delay(400);

            for (int i = 0; i < 60; i++)
            {
                Console.Write("*");
                await Task.Delay(1);
            }


            await Task.Delay(800); // Pause for 0.4 seconds
            Console.WriteLine("");
        }

        public class AirportInfo
        {
            public List<Airport>? OriginAirports { get; set; }
            public List<Airport>? DestinationAirports { get; set; }
        }

        /* Methods */

        // Initialises the booking process based on a chosen destination, country of origin and dates which
        // are based on the current time for a 7 day holiday for testing purposes. 
        private static async Task BookingInit()
        {
            // Get destination from user input
            // Enter 826 for UK (due to SeedData availability)
            // Also entering the ID as this is only a simulation of front end, and that's how it would process a selected country
            Console.WriteLine("What Country Are You Travelling From?");
            origin = Console.ReadLine();

            // Get origin from user input
            // Enter 724 for Spain (due to SeedData availability)
            // Also entering the ID as this is only a simulation of front end, and that's how it would process a selected country
            Console.WriteLine("What Country Are You Travelling To?");
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
                /* Booking Stage 1: Flights */
                /* ------------------------------------------------------------------------------------------ */

                ReturnAirports rtnAir = new ReturnAirports(ConsoleAppUrl, origin, destination);

                // Get origin airports
                List<Airport> originAirports = await rtnAir.GetOriginAirportsAsync();
                foreach (var originAirport in originAirports)
                {
                    Console.WriteLine($"Airport ID: {originAirport.AirportID}, Name: {originAirport.AirportName}");
                }

                // Collect the departure airport and arrival airport from the user.
                Console.WriteLine("Enter the ID of your desired departure airport:");
                string departureAirport = Console.ReadLine()!;
                Console.WriteLine("\n");

                // Get destination airports
                List<Airport> destinationAirports = await rtnAir.GetDestinationAirportsAsync();
                foreach (var destinationAirport in destinationAirports)
                {
                    Console.WriteLine($"Airport ID: {destinationAirport.AirportID}, Name: {destinationAirport.AirportName}");
                }

                Console.WriteLine("Enter the ID of your desired arrival airport:");
                string arrivalAirport = Console.ReadLine()!;

                // Return flights based on the chosen airports.
                ReturnFlights rtnflight = new ReturnFlights();
                await rtnflight.ReturnFlightsList(departureAirport, arrivalAirport);

                // Choose and confirm flight.
                Console.WriteLine(" ✈  Please select the flight ID you wish to book: ✈ ");
                string selectedFlightID = Console.ReadLine()!;

                Console.WriteLine("You have selected Flight ID: " + selectedFlightID);
                Console.WriteLine("\n");
                Console.WriteLine("Are you happy to proceed?");

                string confirmFlight = Console.ReadLine();
                Console.WriteLine("");
                int FlightBookingID = 0;
                int clientID = 0;

                // Enter client details if happy to proceed with flight booking.
                if (confirmFlight == "Yes")
                {
                    SignUpClient sgnclt = new SignUpClient();
                    clientID = await sgnclt.SignUpClientAsync();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine("Client details confirmed.");

                    FlightBooking fltbk = new FlightBooking();
                    FlightBookingID = await fltbk.FlightBookingAsync(selectedFlightID, clientID);

                    Console.WriteLine("Flight booking set to pending.");
                    Console.WriteLine("");
                    Console.ResetColor();
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
                Console.WriteLine("You have selected room ID: " + selectedRoom + " in the hotel ID: " + selectedHotelID);
                Console.WriteLine("");
                Console.WriteLine("Are you happy to proceed with your hotel booking?");

                string confirmHotelBooking = Console.ReadLine();
                int HotelBookingID = 0;
                if (confirmHotelBooking == "Yes")
                {
                    HotelBooking htlbk = new HotelBooking();
                    HotelBookingID = await htlbk.HotelBookingAsync(selectedHotelID, selectedRoom, clientID);
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
                    ReturnInsurancePlans rtnInsurance = new ReturnInsurancePlans();
                    await rtnInsurance.ReturnInsuranceList();

                    Console.WriteLine("Please select the type of insurance you would like:");
                    selectedInsurance = Console.ReadLine()!;

                    // Confirm insurance and create booking.
                    Console.WriteLine("You have selected: " + selectedInsurance + " insurance.");
                    Console.WriteLine("Are you happy to proceed?");
                    string confirmInsurance = Console.ReadLine();

                    if (confirmInsurance == "Yes")
                    {
                        InsuranceBooking insbk = new InsuranceBooking();
                        InsuranceBookingID = await insbk.InsuranceBookingAsync(selectedInsurance, clientID);
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
                    ReturnVehicles rtnvhcl = new ReturnVehicles();
                    await rtnvhcl.ReturnVehicleList();

                    Console.WriteLine("Please select the ID of the car you wish to hire:");
                    selectedCar = Console.ReadLine()!;
                    Console.WriteLine("You have chosen the car ID: " + selectedCar);
                    Console.WriteLine("Are you happy to proceed with the car hire booking?");
                    string confirmVehicle = Console.ReadLine();

                    if (confirmVehicle == "Yes")
                    {
                        VehicleBooking vclbkg = new VehicleBooking();
                        VehicleBookingID = await vclbkg.VehicleBookingAsync(selectedCar, clientID);
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
                    ProcessBooking probk = new ProcessBooking();
                    await probk.ProcessBookingAsync(destination!, clientID, HotelBookingID, FlightBookingID, VehicleBookingID, InsuranceBookingID);

                }
                else if (userConfirmation == "cancel")
                {
                    Console.WriteLine("Booking cancelled, would you like to close the application?");
                    // Could integrate option to either cancel and exit or restart, maintaining the booking info
                    // Change previous bookings to cancelled or perhaps delete them altogether
                }
                /* ------------------------------------------------------------------------------------------ */

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



        // Checks to see if there are any batch processes stored. If there are sends a PUT request to the server. 
        private static async Task SendBatches()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BatchRequests");
            string consoleAppUrl = "YourConsoleAppURL"; // Replace with your actual Console App URL

            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath);

                if (files.Any())
                {
                    using (HttpClient client = new HttpClient())
                    {
                        foreach (string filePath in files)
                        {
                            string jsonContent = File.ReadAllText(filePath);
                            string endpoint = $"{consoleAppUrl}/BatchProcess";

                            // Sending PUT request
                            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                            var response = await client.PutAsync(endpoint, content);

                            if (response.IsSuccessStatusCode)
                            {
                                Console.WriteLine($"File {Path.GetFileName(filePath)} sent successfully to {endpoint}");
                            }
                            else
                            {
                                Console.WriteLine($"Failed to send file {Path.GetFileName(filePath)} to {endpoint}. Status code: {response.StatusCode}");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No files found in the BatchRequests folder.");
                }
            }
            else
            {
                Console.WriteLine("BatchRequests folder not found in the project root.");
            }
        }

    }
}