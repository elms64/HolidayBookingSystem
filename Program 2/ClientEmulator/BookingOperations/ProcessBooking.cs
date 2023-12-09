// GitHub Authors: @elms64 & @Kloakk

// Creates a booking PUT request and sends it over HTTP to the server

/* System Libraries */
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ClientEmulator.Models;
using System.Security.Cryptography;

namespace ClientEmulator
{
    public class ProcessBooking
    {

        /* Variables */
        private static readonly string ConsoleAppUrl = "http://localhost:8080";
        private static readonly HttpClient httpClient = new HttpClient();

        public async Task ProcessBookingAsync(string destination, int ClientID, int HotelBookingID, int selectedFlightID, int VehiclebookingID, int InsuranceBookingID)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sending Booking Data:");
            //Console.WriteLine($"CountryID : {destination} \n HotelBookingID : {HotelBookingID} \n FlightID : {selectedFlightID}\n VehicleBookingID : {VehiclebookingID} \n InsuranceBookingID : {InsuranceBookingID}");
            Console.WriteLine("");
            Console.ResetColor();
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

                // Console.WriteLine("Data being sent in the response:");
                foreach (var kvp in bookingData)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    Console.ResetColor();
                }

                // Call SendBookingTransaction with the populated bookingData
                await SendBookingTransaction(bookingData);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.ResetColor();
            }
        }


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

        private static async Task<int> SendBookingTransaction(List<KeyValuePair<string, string>> bookingData)
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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine("Booking transaction sent successfully!");

                    string responseContent = await response.Content.ReadAsStringAsync();

                    var responseObject = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(responseContent);
                    if (responseObject.TryGetValue("OrderNumber", out JsonElement orderNumberElement))
                    {
                        int OrderNumber = orderNumberElement.GetInt32();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Booking created successfully! Order Number: {OrderNumber}");
                        Console.ResetColor();
                        return OrderNumber;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Error: Unable to parse OrderNumber from the response.");
                        Console.ResetColor();
                        return -1;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    Console.ResetColor();

                    // If the request was unsuccessful, save it into batch transactions
                    SaveBatches svbtch = new SaveBatches();
                    await svbtch.SaveBatchProcess(jsonPayload, guid);

                    return -1; // Or handle the error accordingly
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Exception: {ex.Message}");
                Console.ResetColor();

                return -1; // Or handle the exception accordingly
            }
        }


    }
}