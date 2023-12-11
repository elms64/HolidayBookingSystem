using System;
using BookingProcessor.Models;
using System.Net;
using System.Text;
using System.Text.Json;

namespace BookingProcessor
{
    public class CreateVehicleBooking
    {
        public async Task<byte[]> CreateVehicleBookingAsync(HttpListenerRequest request, BookingContext bookingContext)
        {
            try
            {
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    string requestBody = await reader.ReadToEndAsync();

                    using (JsonDocument jsonDocument = JsonDocument.Parse(requestBody))
                    {
                        if (jsonDocument.RootElement.EnumerateArray().Any())
                        {
                            string? VehicleID = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "VehicleID").GetProperty("Value").GetString();

                            VehicleBooking vehicleBooking = new VehicleBooking
                            {
                                VehicleBookingID = 0,
                                VehicleID = int.Parse(VehicleID!),
                                PickUpDate = DateTime.Now,
                                DropOffDate = DateTime.Now.AddDays(7),
                                BookingStatus = "Pending"
                            };

                            bookingContext.VehicleBooking.Add(vehicleBooking);
                            await bookingContext.SaveChangesAsync();

                            int newVehicleBookingID = vehicleBooking.VehicleBookingID;

                            var responseObj = new
                            {
                                VehicleBookingID = newVehicleBookingID,
                                Message = "VehicleBooking Created Successfully",
                                Status = "Success"
                            };

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
                return Encoding.UTF8.GetBytes("Error creating vehicle booking, please try again later.");
            }
        }
    }
}

