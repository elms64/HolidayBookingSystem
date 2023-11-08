using System;
using System.Net;
using System.Text;
using BookingProcessor.Models;

class Program
{
    static void Main(string[] args)
    {


        
        string url = "http://*:8080/";

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

                string responseString = "Hello, World!";
                byte[] buffer = Encoding.UTF8.GetBytes(responseString);

                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.Close();

                Console.WriteLine("Response sent.");
            }
        }

        


    }
}
