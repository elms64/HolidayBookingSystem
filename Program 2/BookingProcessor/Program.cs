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
        string url = "http://+:8080/";

        var serviceProvider = new ServiceCollection()
            .AddDbContext<BookingContext>(options =>
        options.UseSqlite("Data Source=booking_data.db"))
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
             
             //   Console.WriteLine("Headers:");
             //   foreach (string key in request.Headers.AllKeys)
             //   {
             //       Console.WriteLine($"{key}: {request.Headers[key]}");
             //   }

             // && request.Url.AbsolutePath == "/flights"
             
                if (request.HttpMethod == "GET" )
                {
                    await HandleGetFlightsRequest(response, serviceProvider);
                }
                else if (request.HttpMethod == "POST")
                {
                    await HandlePostRequest(request, response); // Process POST request
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
            var BookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
            List<int> flights = await BookingContext.Flight.Select(f => f.FlightID).ToListAsync();

            string jsonResponse = JsonSerializer.Serialize(flights);
            byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);

            response.ContentType = "application/json";
            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.Close();
        }
    }

    static async Task HandlePostRequest(HttpListenerRequest request, HttpListenerResponse response){
        string requestData;
        
        using(var reader = new System.IO.StreamReader(request.InputStream, request.ContentEncoding))
        {
            requestData = reader.ReadToEnd();

            Console.WriteLine($"Recieved Program 1 Data :  {requestData}");
        }

        string responseString = "Data received successfully in Program 2";
        byte[] buffer = Encoding.UTF8.GetBytes(responseString);
        response.ContentLength64 = buffer.Length;
        response.OutputStream.Write(buffer, 0, buffer.Length);
        response.Close();


    }
}   
