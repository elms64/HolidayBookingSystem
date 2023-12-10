using BookingSystemUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookingSystemUI.Service
{
    // Layer of abstraction
    public interface IBookingService
    {

        public Task<List<Country>> GetCountries();

      
    }

    public class BookingServiceImpl : IBookingService
    {
        private const string ConsoleAppUrl = "http://localhost:8080";

        // get the list of countries by calling the backend url
        public async Task<List<Country>> GetCountries()
        {
            try
            {

                string targetURL = ConsoleAppUrl + "/Country";
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(targetURL);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        var countries = JsonSerializer.Deserialize<List<Country>>(responseData);
                        
                        if (countries == null)
                        {
                            return new List<Country>();
                        }

                        return countries;
                       
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                        return new List<Country>();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return new List<Country>();
            }
        }
    }
}
