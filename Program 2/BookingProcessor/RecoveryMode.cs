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
        private readonly string batchURL = "http://localhost:8080/batch-processes";
        private readonly IServiceProvider serviceProvider;
        public RecoveryMode(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public async Task Run()
        {
            try
            {
                while (await HasBatchProcesses())
                {
                    // Send a GET request to retrieve batch processes
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.GetAsync(batchURL);
                        if (response.IsSuccessStatusCode)
                        {
                            string batchProcessData = await response.Content.ReadAsStringAsync();
                            Console.WriteLine("Retrieved the following backed up transactions:" + batchProcessData);
                            
                            // Process batch processes 
                            ProcessBatchProcesses(batchProcessData);
                        }
                        else
                        {
                            Console.WriteLine($"Error retrieving batch processes. Status code: {response.StatusCode}");
                        }
                    }
                }

                // Switch back to Normal Mode after processing all batch processes
                SwitchToNormalMode();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred in Recovery Mode: {ex.Message}");
            }
        }

        // Checks if Program 1 has any batch processes stored
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

        private static void ProcessBatchProcesses(string batchProcessData)
        {

        }

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
