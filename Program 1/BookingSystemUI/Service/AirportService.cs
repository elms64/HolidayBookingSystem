using BookingSystemUI.Model;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BookingSystemUI.Service
{
    public interface IAirportService
    {
        Task<AirportInfo>? GetAirports(Country destinationCountry, Country departureCountry);
    }

    public class AirportServiceImpl : IAirportService
    {
        //TODO move this to a congif file instead of hard coding it
        private const string ConsoleAppUrl = "http://localhost:8080";

        
        public async Task<AirportInfo>? GetAirports(Country destinationCountry, Country departureCountry)
        {
            try
            {
                // Create a new HTTP client
                string targetURL = ConsoleAppUrl + "/Airport";
                using (HttpClient client = new HttpClient())
                {
                    // Add headers to the client
                    client.DefaultRequestHeaders.Add("OriginCountryID", departureCountry.ID.ToString());
                    client.DefaultRequestHeaders.Add("DestinationCountryID", destinationCountry.ID.ToString());

                    // Log the headers before sending the request
                    Console.WriteLine($"Sending request to: {targetURL}");
                    Console.WriteLine($"Headers: CountryID={departureCountry.ID}, OriginID={destinationCountry.ID}");

                    HttpResponseMessage response = await client.GetAsync(targetURL);
                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                        return null;
                    }

                    string flightAirportJsonResponse = await response.Content.ReadAsStringAsync();

                     // Log the response data to the console for debugging
                    Console.WriteLine($"Received response data: {flightAirportJsonResponse}");
                    
                    // Deserialize the JSON response
                    var airportInfo = JsonSerializer.Deserialize<AirportInfo>(flightAirportJsonResponse);
                 
                    if (airportInfo == null)
                    {

                        Console.WriteLine("Airport info null when calling /airport from the backend");
                        return null;
                    }

                    return airportInfo;

                    }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request Error: {ex.Message}");
                Console.WriteLine($"HTTP Request Error Details: {ex}");
                return null;
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine($"Task Canceled Error: {ex.Message}");
                Console.WriteLine($"Task Canceled Error Details: {ex}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.WriteLine($"Error Details: {ex}");
                return null;
            }
        }
    }

   
}
