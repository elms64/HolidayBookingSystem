// GitHub authors: @elms64

/* Recovery mode of operation for Booking Processor. Sends a GET request to clients on the network to check for batch transactions 
 * If any clients respond saying that they have backed up transactions waiting to be processed, this mode of operation will 
   iterate through the process of processing them accordingly and informing the client machines the process is complete until there are no 
   remaining batch processes. 
 * Once recovery mode has completed, it will automatically trigger normal mode. There are various exceptions that may occur such as 
   communication errors, in the event of a failure normal mode will be triggered and recovery will need to run again later. */

using System.Text;
using System.Text.Json;
using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookingProcessor
{
    public class RecoveryMode
    {
        // IP can be configured to send a broadcast message to all hosts on a local network to check for batch transactions.
        // For example: http://192.168.1.255:8081/batchrecovery could be used to send a request to all hosts on a given subnet. 
        private readonly string batchURL = "http://localhost:8081/batchrecovery";
        private readonly IServiceProvider serviceProvider;
        public RecoveryMode(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        // Main method of operation for Recovery Mode.
        public async Task Run(string? jsonData)
        {
            try
            {
                if (string.IsNullOrEmpty(jsonData))
                {
                    // Recovery scenario where the server retrieves the batches from a client(s)
                    await RetrieveAndProcessBatch();
                }
                else
                {
                    // Recovery scenario where a batch is sent via POST to the server.
                    await ProcessBatch(jsonData);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ConsoleUtils.PrintWithDotsAsync("Batch transactions complete, switching to normal mode", 3, 300).Wait();
                    Console.WriteLine("");
                    Console.ResetColor();
                }

                // Switches back to Normal Mode after processing batch processes.
                SwitchToNormalMode();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"An error occurred in Recovery Mode: {ex.Message}");
                Console.ResetColor();
                Console.WriteLine("");
                ConsoleUtils.PrintWithDotsAsync("Switching to normal mode", 3, 300).Wait();
            }
        }

        private async Task RetrieveAndProcessBatch()
        {
            // Retrieve batch processes without jsonData.
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(batchURL);
                if (response.IsSuccessStatusCode)
                {
                    string batchProcessData = await response.Content.ReadAsStringAsync();

                    if (!string.IsNullOrEmpty(batchProcessData))
                    {
                        ConsoleUtils.PrintWithDotsAsync("Retrieved the following backed up transactions:", 3, 300).Wait();
                        batchProcessData = $"[{batchProcessData}]";
                        await ProcessBatch(batchProcessData);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        ConsoleUtils.PrintWithDotsAsync("Batch transactions complete, switching to normal mode", 3, 300).Wait();
                        Console.WriteLine("");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("No batch processes found.");
                        Console.ResetColor();
                        Console.WriteLine("");
                        ConsoleUtils.PrintWithDotsAsync("Switching to normal mode", 3, 500).Wait();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Error retrieving batch processes. Status code: {response.StatusCode}");
                    Console.ResetColor();
                    Console.WriteLine("");
                    ConsoleUtils.PrintWithDotsAsync("Switching to normal mode", 3, 500).Wait();
                }
            }
        }

        // Defines the JSON data structure
        public class JsonDataItem
        {
            public string? Key { get; set; }
            public string? Value { get; set; }
            public Guid TransactionGUID { get; set; }
        }

        // Processes batch requests and uploads them to the database. 
        private async Task ProcessBatch(string jsonData)
        {
            try
            {
                using (var scope = serviceProvider.CreateScope())
                {
                    var bookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
                    Console.WriteLine("");
                    Console.WriteLine($"Received JSON Data: {jsonData}");

                    var jsonDataItems = JsonSerializer.Deserialize<List<List<JsonDataItem>>>(jsonData);

                    foreach (var batchItems in jsonDataItems!)
                    {
                        var newBooking = new Booking
                        {
                            OrderNumber = Convert.ToInt32(batchItems.FirstOrDefault(item => item.Key == "OrderNumber")?.Value ?? "0"),
                            TransactionGUID = Guid.Parse(batchItems.FirstOrDefault(item => item.Key == "TransactionGUID")?.Value ?? Guid.Empty.ToString()),
                            CheckSum = batchItems.FirstOrDefault(item => item.Key == "CheckSum")?.Value,
                            HotelBookingID = Convert.ToInt32(batchItems.FirstOrDefault(item => item.Key == "HotelBookingID")?.Value ?? "0"),
                            CountryID = Convert.ToInt32(batchItems.FirstOrDefault(item => item.Key == "CountryID")?.Value ?? "0"),
                            FlightID = Convert.ToInt32(batchItems.FirstOrDefault(item => item.Key == "FlightID")?.Value ?? "0"),
                            PurchaseDate = DateTime.TryParse(batchItems.FirstOrDefault(item => item.Key == "PurchaseDate")?.Value, out var purchaseDate)
                                ? purchaseDate
                                : DateTime.MinValue,
                            VehicleBookingID = Convert.ToInt32(batchItems.FirstOrDefault(item => item.Key == "VehicleBookingID")?.Value ?? "0"),
                            ClientID = Convert.ToInt32(batchItems.FirstOrDefault(item => item.Key == "ClientID")?.Value ?? "0"),
                            InsuranceBookingID = Convert.ToInt32(batchItems.FirstOrDefault(item => item.Key == "InsuranceBookingID")?.Value ?? "0"),
                        };

                        // Check if any batches with the same GUID exist.
                        bool guidExists = await bookingContext.Booking
                            .AnyAsync(b => b.TransactionGUID == newBooking.TransactionGUID);

                        // Check if any batches with the same checksum exist.
                        bool checksumExists = await bookingContext.Booking
                            .AnyAsync(b => b.CheckSum == CalcMD5.CalculateMd5(jsonData));

                        if (guidExists || checksumExists)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("This batch process already exists, please do not retry.");
                            Console.ResetColor();
                            Console.WriteLine("");
                        }
                        else
                        {
                            bookingContext.Booking.Add(newBooking);
                            await bookingContext.SaveChangesAsync();
                            await NotifyClient(newBooking.TransactionGUID);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"An error occurred creating scope or obtaining BookingContext: {ex.Message}");
                Console.ResetColor();
                Console.WriteLine("");
            }
        }

        // Send a notification to the client that their batch has been succesfully processed. 
        private async Task NotifyClient(Guid transactionGuid)
        {
            using (HttpClient client = new HttpClient())
            {
                // Add the TransactionGUID to the request headers
                client.DefaultRequestHeaders.Add("TransactionGUID", transactionGuid.ToString());
                var content = new StringContent("Batch processed successfully", Encoding.UTF8, "application/json");

                /* Could add logic to fetch the IP of the correct host in a scenario where there are multiple hosts
                   Currently set up to send a message directly to this given IP, but would need to catch the right IP if there are multiple hosts. */
                var response = await client.PostAsync("http://localhost:8081/servernotifications", content);

                if (response.IsSuccessStatusCode)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine($"Notification sent to client (TransactionGUID: {transactionGuid}): Batch processed successfully.");
                    Console.ResetColor();
                    Console.WriteLine("");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Error sending notification to client. Status code: {response.StatusCode}");
                    Console.ResetColor();
                    Console.WriteLine("");
                }
            }
        }

        // Switches the mode of operation to normal mode. 
        private void SwitchToNormalMode()
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<BookingContext>(options =>
                    options.UseSqlite("Data Source=booking_data.db"))
                .BuildServiceProvider();

            var normalMode = new NormalMode(serviceProvider);
            normalMode.Run().GetAwaiter().GetResult();
        }
    }
}
