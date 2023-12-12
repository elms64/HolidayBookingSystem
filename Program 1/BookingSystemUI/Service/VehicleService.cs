using BookingSystemUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookingSystemUI.Service
{
    public interface IVehicleService
    {
        Task<List<Vehicle>> GetVehicle();

    }
    public class VehicleService : IVehicleService
    {
        private const string ConsoleAppUrl = "http://localhost:8080";

        
        public async Task<List<Vehicle>> GetVehicle()
        {
            try
            {

                string targetURL = ConsoleAppUrl + "/Vehicle";
                using (HttpClient client = new HttpClient())

                {
                    HttpResponseMessage response = await client.GetAsync(targetURL);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        var countries = JsonSerializer.Deserialize<List<Vehicle>>(responseData);

                        if (countries == null)
                        {
                            return new List<Vehicle>();
                        }

                        return countries;

                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                        return new List<Vehicle>();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return new List<Vehicle>();
            }
        }

        internal Task<List<Vehicle>> GetVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
