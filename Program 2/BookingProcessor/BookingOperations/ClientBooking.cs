// GitHub Authors: @elms64 & @Kloakk

// Interacts with the database to upload a client record from an incoming PUT request.

/* System Libraries */
using System;
using System;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingProcessor
{
    public class ClientBooking
    {
        public async Task<byte[]> ClientBookingAsync(HttpListenerRequest request, BookingContext bookingContext)
        {
            try
            {
                // Receive client information from an HTTP PUT request
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    string requestBody = await reader.ReadToEndAsync();

                    // Parse the JSON array
                    using (JsonDocument jsonDocument = JsonDocument.Parse(requestBody))
                    {
                        if (jsonDocument.RootElement.EnumerateArray().Any())
                        {
                            // Extract values from the array
                            string? firstName = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "FirstName").GetProperty("Value").GetString();
                            string? lastName = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "LastName").GetProperty("Value").GetString();
                            string? birthDate = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "BirthDate").GetProperty("Value").GetString();
                            string? email = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "Email").GetProperty("Value").GetString();
                            string? phoneNumber = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "PhoneNumber").GetProperty("Value").GetString();
                            // Check if a client with similar details already exists
                            var existingClient = await bookingContext.Client
                                .FirstOrDefaultAsync(c =>
                                    c.FirstName == firstName &&
                                    c.LastName == lastName &&
                                    c.BirthDate == DateTime.Parse(birthDate!) &&
                                    c.Email == email &&
                                    c.PhoneNumber == phoneNumber);

                            if (existingClient != null)
                            {   
                                // If a matching client is found, return the existing client's ID
                                var existingResponseObj = new
                                {
                                    ClientID = existingClient.ClientID,
                                    Message = "Client already exists with the same details",
                                    Status = "Success"
                                };

                                string existingJsonResponse = JsonSerializer.Serialize(existingResponseObj);
                                Console.WriteLine(existingJsonResponse);
                                return Encoding.UTF8.GetBytes(existingJsonResponse);
                            }

                            // Create a new client record.
                            Client client = new Client
                            {
                                FirstName = firstName,
                                LastName = lastName,
                                BirthDate = DateTime.Parse(birthDate!), // You may need to adjust the conversion based on your data type
                                Email = email,
                                PhoneNumber = phoneNumber
                            };

                            bookingContext.Client.Add(client);
                            await bookingContext.SaveChangesAsync();

                            // Now, client has the ClientID assigned by the database
                            int newClientID = client.ClientID;

                            // Create a response object
                            var newResponseObj = new
                            {
                                ClientID = newClientID,
                                Message = "Client created successfully",
                                Status = "Success"
                            };

                            // Respond to the client.
                            string newJsonResponse = JsonSerializer.Serialize(newResponseObj);
                            Console.WriteLine(newJsonResponse);
                            return Encoding.UTF8.GetBytes(newJsonResponse);
                        }
                    }

                    return Encoding.UTF8.GetBytes("Invalid Client Data format");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}\n{ex.StackTrace}");
                return Encoding.UTF8.GetBytes("Error creating client, please try again later.");
            }
        }

    }
}