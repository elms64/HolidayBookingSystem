using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "http://*:8080/";

        var serviceProvider = new ServiceCollection()
            .AddDbContext<DbContext>(options =>
                options.UseSqlite("Data Source=booking.db"))
            .BuildServiceProvider();

        using (HttpListener listener = new HttpListener())
        {
            listener.Prefixes.Add(url);
            listener.Start();
            Console.WriteLine($"Listening for requests on {url}");

            while (true)
            {
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;

                Console.WriteLine($"Received request from {request.RemoteEndPoint}.");
                Console.WriteLine($"Request URL: {request.Url}");
                Console.WriteLine($"HTTP Method: {request.HttpMethod}");
                Console.WriteLine("Headers:");
                foreach (string key in request.Headers.AllKeys)
                {
                    Console.WriteLine($"{key}: {request.Headers[key]}");
                }

                if (request.HttpMethod == "GET" && request.Url.AbsolutePath == "/flights")
                {
                    await HandleGetFlightsRequest(response, serviceProvider);
                }
                else
                {
                    // Handle other types of requests as needed
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

    static async Task HandleGetFlightsRequest(HttpListenerResponse response, IServiceProvider serviceProvider)
    {
        using (var scope = serviceProvider.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
            List<int> flights = await dbContext.Flight.Select(f => f.FlightID).ToListAsync();

            string jsonResponse = JsonSerializer.Serialize(flights);
            byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);

            response.ContentType = "application/json";
            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.Close();
        }
    }
}
