// Authored by @elms64

using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookingProcessor
{
    public class RecoveryMode
    {
        // Sends a broadcast message to all hosts on a local network to check for batch transactions.
        private readonly string batchURL = "http://localhost:8080/batch-processes";
        private readonly IServiceProvider serviceProvider;
        public RecoveryMode(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        // Main method of operation for Recovery Mode.
        public async Task Run()
        {
            try
            {
                // As long as there are batch processes, this method will retrieve and process them.
                while (await HasBatchProcesses())
                {
                    // Retrieve batch processes.
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.GetAsync(batchURL);
                        if (response.IsSuccessStatusCode)
                        {
                            string batchProcessData = await response.Content.ReadAsStringAsync();
                            ConsoleUtils.PrintWithDotsAsync("Retrieved the following backed up transactions:", 3, 300).Wait();

                            // Processes batch requests
                            await ProcessBatch(batchProcessData);
                            ConsoleUtils.PrintWithDotsAsync("Batch transactions complete, switching to normal mode...", 3, 300).Wait();
                        }
                        else
                        {
                            Console.WriteLine($"Error retrieving batch processes. Status code: {response.StatusCode}");
                            ConsoleUtils.PrintWithDotsAsync("Switching to normal mode...", 3, 500).Wait();
                        }
                    }
                }
                // Switches back to Normal Mode after processing all batch processes
                SwitchToNormalMode();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred in Recovery Mode: {ex.Message}");
                ConsoleUtils.PrintWithDotsAsync("Switching to normal mode", 3, 300).Wait();
            }
        }

        // Checks if there are any batch processes stored on any hosts in the LAN.
        private async Task<bool> HasBatchProcesses()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(batchURL + "/check");
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    return bool.Parse(result);
                }
                else
                {
                    Console.WriteLine($"Error checking for batch processes. Status code: {response.StatusCode}");
                    return false;
                }
            }
        }

        // Deals with incoming batch transactions.
        private async Task ProcessBatch(string batchProcessData)
        {
            try
            {
                using (var scope = serviceProvider.CreateScope())
                {
                    var bookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
                    Booking newBooking = JsonSerializer.Deserialize<Booking>(batchProcessData);
                    newBooking.OrderNumber = 0;
                    bookingContext.Booking.Add(newBooking);
                    await bookingContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred creating scope or obtaining BookingContext: {ex.Message}");
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