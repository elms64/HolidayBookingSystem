using System;
using BookingProcessor.Models;
using System.Net;
using System.Text;
using System.Text.Json;

namespace BookingProcessor
{
    public class CreateInsuranceBooking
    {
        public async Task<byte[]> CreateInsuranceBookingAsync(HttpListenerRequest request, BookingContext bookingContext)
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
                            string? InsuranceID = jsonDocument.RootElement.EnumerateArray().FirstOrDefault(e => e.GetProperty("Key").GetString() == "InsuranceID").GetProperty("Value").GetString();


                            InsuranceBooking insuranceBooking = new InsuranceBooking
                            {
                                InsuranceBookingID = 0,
                                InsuranceID = int.Parse(InsuranceID!),
                                StartDate = DateTime.Now,
                                EndDate = DateTime.Now.AddDays(7),
                                BookingStatus = "pending"
                            };

                            bookingContext.InsuranceBooking.Add(insuranceBooking);
                            await bookingContext.SaveChangesAsync();

                            int newInsuranceBookingID = insuranceBooking.InsuranceBookingID;

                            var responseObj = new
                            {
                                InsuranceBookingID = newInsuranceBookingID,
                                Message = "Hotel booking created successfully",
                                Status = "Success"
                            };

                            string jsonResponse = JsonSerializer.Serialize(responseObj);
                            Console.WriteLine(jsonResponse);
                            return Encoding.UTF8.GetBytes(jsonResponse);

                        }

                        return Encoding.UTF8.GetBytes("Invalid HotelBooking Data format");


                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}\n{ex.StackTrace}");
                return Encoding.UTF8.GetBytes("Error creating InsruanceBooking, please try again later.");
            }
        }
    }
}

