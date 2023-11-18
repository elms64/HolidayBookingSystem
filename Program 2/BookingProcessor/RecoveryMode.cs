// Authored by @elms64

using System;
using System.Net.Http;
using System.Threading.Tasks;
using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookingProcessor
{
    public class RecoveryMode
    {
        // Sends a broadcast message to all hosts on a local network to check for batch transactions.
        private readonly string batchURL = "http://192.168.1.255:8080/batch-processes";
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
                            Console.WriteLine("Retrieved the following backed up transactions:" + batchProcessData);

                            // Processes batch requests
                            ProcessBatch(batchProcessData);
                            Console.WriteLine("Batch transactions complete, switching to normal mode...");
                        }
                        else
                        {
                            Console.WriteLine($"Error retrieving batch processes. Status code: {response.StatusCode}");
                            Console.WriteLine("Switching to normal mode...");
                        }
                    }
                }

                // Switches back to Normal Mode after processing all batch processes
                SwitchToNormalMode();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred in Recovery Mode: {ex.Message}");
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
        private static void ProcessBatch(string batchProcessData)
        {

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
