using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingProcessor
{
    public class CreateBooking
    {
        private readonly BookingContext bookingContext;

        public CreateBooking(BookingContext bookingContext)
        {
            this.bookingContext = bookingContext;
        }

        public async Task<byte[]> CreateBookingAsync(HttpListenerRequest request, BookingContext bookingContext)
        {
            try
            {
                // Receive booking information from a HTTP PUT request
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    string requestBody = await reader.ReadToEndAsync();

                    using (JsonDocument jsonDocument = JsonDocument.Parse(requestBody))
                    {
                        var arrayEnumerator = jsonDocument.RootElement.EnumerateArray();

                        string? TransactionGUIDString = arrayEnumerator.FirstOrDefault(e => e.TryGetProperty("Key", out var key) && key.GetString() == "TransactionGUID").GetProperty("Value").GetString();
                        string? CheckSum = arrayEnumerator.FirstOrDefault(e => e.TryGetProperty("Key", out var key) && key.GetString() == "CheckSum").GetProperty("Value").GetString();
                        string? HotelBookingID = arrayEnumerator.FirstOrDefault(e => e.TryGetProperty("Key", out var key) && key.GetString() == "HotelBookingID").GetProperty("Value").GetString();
                        string? CountryID = arrayEnumerator.FirstOrDefault(e => e.TryGetProperty("Key", out var key) && key.GetString() == "CountryID").GetProperty("Value").GetString();
                        string? FlightID = arrayEnumerator.FirstOrDefault(e => e.TryGetProperty("Key", out var key) && key.GetString() == "FlightID").GetProperty("Value").GetString();
                        string? PurchaseDate = arrayEnumerator.FirstOrDefault(e => e.TryGetProperty("Key", out var key) && key.GetString() == "PurchaseDate").GetProperty("Value").GetString();
                        string? VehicleBookingID = arrayEnumerator.FirstOrDefault(e => e.TryGetProperty("Key", out var key) && key.GetString() == "VehicleBookingID").GetProperty("Value").GetString();
                        string? ClientID = arrayEnumerator.FirstOrDefault(e => e.TryGetProperty("Key", out var key) && key.GetString() == "ClientID").GetProperty("Value").GetString();
                        string? InsuranceBookingID = arrayEnumerator.FirstOrDefault(e => e.TryGetProperty("Key", out var key) && key.GetString() == "InsuranceBookingID").GetProperty("Value").GetString();

                        // Recalculates MD5 checksum and ensures transaction has not already been processed.
                        string recalculatedChecksum = CalcMD5.CalculateMd5(requestBody);
                        bool checksumExists = await bookingContext.Booking.AnyAsync(b => b.CheckSum == recalculatedChecksum);

                        // Do not process transaction if it is a repeat entry.
                        if (checksumExists)
                        {
                            return Encoding.UTF8.GetBytes("This booking already exists, please do not retry transaction.");
                        }

                        // If the transaction does not already exist, upload it to the database.
                        else
                        {
                            Booking booking = new Booking
                            {
                                OrderNumber = 0,
                                TransactionGUID = string.IsNullOrEmpty(TransactionGUIDString) ? Guid.Empty : Guid.Parse(TransactionGUIDString),
                                CheckSum = CheckSum,
                                HotelBookingID = int.TryParse(HotelBookingID, out int hotelbookingId) ? hotelbookingId : 0,
                                CountryID = int.TryParse(CountryID, out int CountryId) ? CountryId : 0,
                                FlightID = int.TryParse(FlightID, out int flightId) ? flightId : 0,
                                PurchaseDate = DateTime.Now,
                                VehicleBookingID = int.TryParse(VehicleBookingID, out int vehicleBookingId) ? vehicleBookingId : 0,
                                ClientID = int.TryParse(ClientID, out int ClientId) ? ClientId : 0,
                                InsuranceBookingID = int.TryParse(InsuranceBookingID, out int insuranceBookingId) ? insuranceBookingId : 0
                            };

                            // Add the new booking to the context
                            bookingContext.Booking.Add(booking);
                            await bookingContext.SaveChangesAsync();

                            using (var context = new BookingContext())
                            {
                                int hotelBookingIDValue = int.Parse(HotelBookingID);
                                // Assuming HotelBookingID is a variable available in your class
                                var status = context.HotelBooking.FirstOrDefault(b => b.HotelBookingID == hotelBookingIDValue);
                                if (status != null)
                                {
                                    status.BookingStatus = "confirmed";
                                    context.SaveChanges();
                                }

                                int VehicleBookingIDValue = int.Parse(VehicleBookingID);
                                var status2 = context.VehicleBooking.FirstOrDefault(b => b.VehicleBookingID == VehicleBookingIDValue);
                                if (status2 != null)
                                {
                                    status2.BookingStatus = "confirmed";
                                    context.SaveChanges();
                                }

                                int InsuranceBookingIDValue = int.Parse(InsuranceBookingID);
                                var status3 = context.InsuranceBooking.FirstOrDefault(b => b.InsuranceBookingID == InsuranceBookingIDValue);
                                if (status3 != null)
                                {
                                    status3.BookingStatus = "confirmed";
                                    context.SaveChanges();
                                }

                            }


                            int newOrderNumberID = booking.OrderNumber;

                            var responseObj = new
                            {
                                OrderNumber = newOrderNumberID,
                                Message = "Booking Created Successfully",
                                Status = "Success"
                            };




                            string jsonResponse = JsonSerializer.Serialize(responseObj);
                            Console.WriteLine(jsonResponse);
                            return Encoding.UTF8.GetBytes(jsonResponse);




                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception during booking creation: {ex}");
                return Encoding.UTF8.GetBytes("Error creating booking, please try again later.");
            }
        }



    }
}
