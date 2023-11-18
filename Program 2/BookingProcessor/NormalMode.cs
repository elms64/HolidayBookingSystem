//Authored by @elms64 and @Kloakk

using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookingProcessor
{
    public class NormalMode
    {
        /* Define the URL and port number to listen for HTTP requests. 
        Default configuration is any available local IP on port 8080. */
        private readonly string url = "http://+:8080/";
        private readonly IServiceProvider serviceProvider;
        public NormalMode(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        //Main operating method, listens for HTTP requests and processes them accordingly.
        public async Task Run()
        {
            using (HttpListener listener = new HttpListener())
            {
                listener.Prefixes.Add(url);
                listener.Start();
                Console.WriteLine($"Listening for requests on {url}");

                while (true)
                {
                    // Logs any incoming requests and responses in the console
                    HttpListenerContext context = listener.GetContext();
                    HttpListenerRequest request = context.Request;
                    HttpListenerResponse response = context.Response;
                    Console.WriteLine($"Received request from {request.RemoteEndPoint}.");
                    Console.WriteLine($"Request URL: {request.Url}");
                    Console.WriteLine($"HTTP Method: {request.HttpMethod}");

                    // Decide how to process requests based on incoming information. 
                    if (request.HttpMethod == "GET")
                    {
                        await HandleGetFlightsRequest(response);
                    }
                    else if (request.HttpMethod == "POST")
                    {
                        await HandlePostRequest(request, response);
                    }
                    else
                    {
                        string responseString = "Invalid request";
                        byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                        response.ContentLength64 = buffer.Length;
                        response.OutputStream.Write(buffer, 0, buffer.Length);
                        response.Close();
                    }

                    Console.WriteLine("Response sent.");
                }
            }
        }

        private async Task HandleGetFlightsRequest(HttpListenerResponse response)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var bookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
                List<int> flights = await bookingContext.Flight.Select(f => f.FlightID).ToListAsync();

                string jsonResponse = JsonSerializer.Serialize(flights);
                byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);

                response.ContentType = "application/json";
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.Close();
            }
        }

        public async Task HandlePostRequest(HttpListenerRequest request, HttpListenerResponse response)
        {
            string requestData;

            using (var reader = new System.IO.StreamReader(request.InputStream, request.ContentEncoding))
            {
                requestData = reader.ReadToEnd();
                Console.WriteLine($"Received Program 1 Data: {requestData}");
            }

            string responseString = "Data received successfully in Program 2";
            byte[] buffer = Encoding.UTF8.GetBytes(responseString);

            if (requestData == "SEND_COUNTRY")
            {
                returnCountry countryHandler = new returnCountry();
                var countryData = await countryHandler.sendCountry(serviceProvider);
                Console.WriteLine("Country data sent to Program 1!");
                response.ContentType = "application/json";
                response.ContentLength64 = countryData.Length;
                response.OutputStream.Write(countryData, 0, countryData.Length);
            }

            else if (IsBatchProcess(requestData))
            {
                InitRecoveryMode();
                string recoveryMessage = "Initiating recovery mode...";
                byte[] recoveryBuffer = Encoding.UTF8.GetBytes(recoveryMessage);
                response.ContentLength64 = recoveryBuffer.Length;
                response.OutputStream.Write(recoveryBuffer, 0, recoveryBuffer.Length);
            }

            else
            {
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
            }

            response.Close();
        }

        private bool IsBatchProcess(string requestData)
        {
            return requestData.Contains("BATCH_PROCESS");
        }

        private void InitRecoveryMode()
        {
            var recoveryMode = new RecoveryMode(serviceProvider);
            recoveryMode.Run().GetAwaiter().GetResult();
        }
    }
}
