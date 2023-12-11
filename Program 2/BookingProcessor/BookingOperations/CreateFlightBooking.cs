using System;
using BookingProcessor.Models;
using ClientEmulator.Models;
using System.Net;
using System.Text;
using System.Text.Json;

namespace BookingProcessor
{
    public class CreateFlightBooking
    {
        public async Task<byte[]> CreateFlightBookingAsync(HttpListenerRequest request, BookingContext bookingContext)
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
                            string? FlightID = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "FlightID").GetProperty("Value").GetString();
                            string? ClientID = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "ClientID").GetProperty("Value").GetString();

                            FlightBooking flightBooking = new FlightBooking
                            {
                                FlightBookingID = 0,
                                FlightID = int.TryParse(FlightID, out int flightId) ? flightId : 0,
                                ClientID = int.TryParse(ClientID, out int clientId) ? clientId : 0,
                                BookingStatus = "Pending"
                            };

                            bookingContext.FlightBooking.Add(flightBooking);
                            await bookingContext.SaveChangesAsync();

                            int newFlightBookingID = flightBooking.FlightBookingID;

                            var responseObj = new
                            {
                                FlightBookingID = newFlightBookingID,
                                Message = "My brain has turned into sludge",
                                Status = "Success.... if I don't make it to 12/12/23.... clear my search history ASAP."
                            };

                            string jsonResponse = JsonSerializer.Serialize(responseObj);
                            Console.WriteLine(jsonResponse);
                            return Encoding.UTF8.GetBytes(jsonResponse);
                        }
                        return Encoding.UTF8.GetBytes("INVALID FORMAT M8-y!");

                    }
                }

            }
            catch (Exception ex)
            {
                return Encoding.UTF8.GetBytes("Error! " + ex);
            }
        }
    }
}

