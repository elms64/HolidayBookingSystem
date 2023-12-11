using System;
using BookingProcessor.Models;
using System.Net;
using System.Text;
using System.Text.Json;

namespace BookingProcessor
{
    public class CreateHotelBooking
    {
        public async Task<byte[]> CreateHotelBookingAsync(HttpListenerRequest request, BookingContext bookingContext)
        {
            try
            {
                // Receive hotel booking information from a HTTP PUT request
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    string requestBody = await reader.ReadToEndAsync();

                    // Parse the JSON array
                    using (JsonDocument jsonDocument = JsonDocument.Parse(requestBody))
                    {
                        if (jsonDocument.RootElement.EnumerateArray().Any())
                        {
                            // Extract values from the array
                            string? hotelID = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "HotelID").GetProperty("Value").GetString();
                            string? roomID = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "RoomID").GetProperty("Value").GetString();

                            // Create a new HotelBooking record.
                            HotelBooking hotelBooking = new HotelBooking
                            {
                                HotelBookingID = 0,
                                HotelID = int.Parse(hotelID!),
                                RoomID = int.Parse(roomID!),
                                CheckInDate = DateTime.Now,
                                CheckOutDate = DateTime.Now.AddDays(7),
                                BookingStatus = "Pending"
                            };

                            bookingContext.HotelBooking.Add(hotelBooking);
                            await bookingContext.SaveChangesAsync();

                            // Now, hotelBooking has the BookingID assigned by the database
                            int newHotelBookingID = hotelBooking.HotelBookingID;

                            // Create a response object
                            var responseObj = new
                            {
                                HotelBookingID = newHotelBookingID,
                                Message = "Hotel booking created successfully",
                                Status = "Success"
                            };

                            // Respond to the client.
                            string jsonResponse = JsonSerializer.Serialize(responseObj);
                            Console.WriteLine(jsonResponse);
                            return Encoding.UTF8.GetBytes(jsonResponse);
                        }
                    }

                    return Encoding.UTF8.GetBytes("Invalid HotelBooking Data format");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}\n{ex.StackTrace}");
                return Encoding.UTF8.GetBytes("Error creating HotelBooking, please try again later.");
            }
        }
    }
}

