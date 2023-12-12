using BookingSystemUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookingSystemUI.Service
{
    public interface IInsuranceService
    {
        Task<List<Insurance>> GetInsurance(Insurance insuranceID);

    }
    public class InsuranceService : IInsuranceService
    {
        private const string ConsoleAppUrl = "http://localhost:8080";

        public async Task<List<Insurance>> GetInsurance(Insurance insuranceID)
        {
            try
            {

                string targetURL = ConsoleAppUrl + "/Insurance";
                using (HttpClient client = new HttpClient())

                {
                    client.DefaultRequestHeaders.Add("insurance", insuranceID.ToString());
                    HttpResponseMessage response = await client.GetAsync(targetURL);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        var countries = JsonSerializer.Deserialize<List<Insurance>>(responseData);

                        if (countries == null)
                        {
                            return new List<Insurance>();
                        }

                        return countries;

                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                        return new List<Insurance>();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return new List<Insurance>();
            }
        }
    }
}
