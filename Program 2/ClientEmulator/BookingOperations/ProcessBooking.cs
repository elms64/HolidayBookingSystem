// GitHub Authors: @elms64 & @Kloakk

// Creates a booking PUT request and sends it over HTTP to the server

using System.Text;
using System.Text.Json;
using System.Security.Cryptography;

namespace ClientEmulator
{
    public class ProcessBooking
    {
        private static readonly string ConsoleAppUrl = "http://localhost:8080";
        private static readonly HttpClient httpClient = new HttpClient();

        public async Task ProcessBookingAsync(string destination, int ClientID, int HotelBookingID, int FlightBookingID, int VehiclebookingID, int InsuranceBookingID)
        {
            Guid TransactionGuid = Guid.NewGuid();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sending Booking Data:");
            Console.WriteLine("");
            Console.ResetColor();
            try
            {
                // Create a list to store key-value pairs for booking data
                var bookingData = new List<KeyValuePair<string, string>>();

                // Add key-value pairs for each property of the Booking model
                bookingData.Add(new KeyValuePair<string, string>("OrderNumber", "0"));
                bookingData.Add(new KeyValuePair<string, string>("PurchaseDate", DateTime.Now.ToString()));
                bookingData.Add(new KeyValuePair<string, string>("CountryID", destination));
                bookingData.Add(new KeyValuePair<string, string>("ClientID", ClientID.ToString()));
                bookingData.Add(new KeyValuePair<string, string>("HotelBookingID", HotelBookingID.ToString()));
                bookingData.Add(new KeyValuePair<string, string>("FlightID", FlightBookingID.ToString()));
                bookingData.Add(new KeyValuePair<string, string>("VehicleBookingID", VehiclebookingID.ToString()));
                bookingData.Add(new KeyValuePair<string, string>("InsuranceBookingID", InsuranceBookingID.ToString()));

                if (bookingData.All(pair => pair.Value != null))
                {
                    // Calculate checksum for the booking data
                    string checksum = CalculateChecksum(JsonSerializer.Serialize(bookingData));

                    // Add checksum to the booking data
                    bookingData.Add(new KeyValuePair<string, string>("CheckSum", checksum));

                    // Add GUID after checksum so it is not included in the calculation.
                    bookingData.Add(new KeyValuePair<string, string>("TransactionGUID", TransactionGuid.ToString()));

                    // Print the data being sent in the response
                    foreach (var kvp in bookingData)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        Console.ResetColor();
                    }

                    // Call SendBookingTransaction with the populated bookingData
                    await SendBookingTransaction(bookingData, TransactionGuid);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error: One or more values are null.");
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.ResetColor();
            }
        }

        // Calculates a checksum on the booking content using the MD5 one way hashing algorithm.
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

        // Update JsonDataItem class to match the structure of received JSON data
        public class JsonDataItem
        {
            public string? Key { get; set; }
            public string? Value { get; set; }
            public Guid TransactionGUID { get; set; }
        }

        // Sends a booking transaction as a PUT request to the server.
        private static async Task<int> SendBookingTransaction(List<KeyValuePair<string, string>> bookingData, Guid transactionGuid)
        {
            try
            {
                string serverURL = ConsoleAppUrl + "/Booking";
                string checksum = CalculateChecksum(JsonSerializer.Serialize(bookingData));

                httpClient.DefaultRequestHeaders.Add("X-Transaction-ID", transactionGuid.ToString());
                httpClient.DefaultRequestHeaders.Add("Checksum", checksum);
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var jsonDataItems = new List<JsonDataItem>();

                foreach (var kvp in bookingData)
                {
                    jsonDataItems.Add(new JsonDataItem
                    {
                        Key = kvp.Key,
                        Value = kvp.Value,
                        TransactionGUID = transactionGuid
                    });
                }

                string jsonPayload = JsonSerializer.Serialize(jsonDataItems);
                StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(serverURL, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var responseObject = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(responseContent);

                    if (responseObject!.TryGetValue("OrderNumber", out JsonElement orderNumberElement)
                        && responseObject.TryGetValue("Message", out JsonElement messageElement))
                    {
                        int OrderNumber = orderNumberElement.GetInt32();
                        string? message = messageElement.GetString();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("");
                        Console.WriteLine($"Booking created successfully! Order Number: {OrderNumber}");
                        Console.ResetColor();

                        return OrderNumber;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    Console.WriteLine("1");
                    SaveBatches svbtch = new SaveBatches();
                    await SaveBatches.SaveBatchProcess(bookingData, transactionGuid);

                    return -1;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("2");
                SaveBatches svbtch2 = new SaveBatches();
                await SaveBatches.SaveBatchProcess(bookingData, transactionGuid);

                return -1;
            }
        }
    }
}