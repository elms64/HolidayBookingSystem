using BookingSystemUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookingSystemUI.Service
{
    public interface IHotelService
    {
        Task<List<Hotel>> GetHotels(Country arrivalCountry);
    }

    public class HotelService : IHotelService

    {
        private const string ConsoleAppUrl = "http://localhost:8080";
        public async Task<List<Hotel>> GetHotels(Country arrivalCountry)
        {
            try
            {

                string targetURL = ConsoleAppUrl + "/Hotel";
                using (HttpClient client = new HttpClient())

                {
                    client.DefaultRequestHeaders.Add("destination", arrivalCountry.ID.ToString());
                    HttpResponseMessage response = await client.GetAsync(targetURL);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        var countries = JsonSerializer.Deserialize<List<Hotel>>(responseData);

                        if (countries == null)
                        {
                            return new List<Hotel>();
                        }

                        return countries;

                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                        return new List<Hotel>();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return new List<Hotel>();
            }
        }
    }
}
