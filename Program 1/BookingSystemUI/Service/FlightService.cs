using BookingSystemUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookingSystemUI.Service
{
    public interface IFlightService
    {
        Task<List<Flight>>? GetFlight(FlightDetails flightDetails);
    }

    public class FlightServiceImpl : IFlightService
    {
        //TODO move this to a congif file instead of hard coding it
        private const string ConsoleAppUrl = "http://localhost:8080";

        public async Task<List<Flight>>? GetFlight(FlightDetails flightDetails)
        {
            try
            {
                // Create a new HTTP client
                string targetURL = ConsoleAppUrl + "/Flight";
                using (HttpClient client = new HttpClient())
                {
                    // Add headers to the client
                    client.DefaultRequestHeaders.Add("selectedDepartureAirportID", flightDetails.DepartureAirportID.ToString());
                    client.DefaultRequestHeaders.Add("selectedArrivalAirportID", flightDetails.ArrivalAirportID.ToString());

                    // Log the headers before sending the request
                    Console.WriteLine($"Sending request to: {targetURL}");
                    Console.WriteLine($"Headers: DestinationID={flightDetails.DepartureAirportID}, ArrivalID={flightDetails.ArrivalAirportID}");

                    HttpResponseMessage response = await client.GetAsync(targetURL);
                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                        return null;
                    }

                    string flightJsonResponse = await response.Content.ReadAsStringAsync();

                    // Log the response data to the console for debugging
                    Console.WriteLine($"Received response data: {flightJsonResponse}");

                    // Deserialize the JSON response
                    var flight = JsonSerializer.Deserialize<List<Flight>>(flightJsonResponse);

                    if (flight == null)
                    {

                        Console.WriteLine("Airport info null when calling /airport from the backend");
                        return null;
                    }
                    MessageBox.Show(flightJsonResponse);
                    return flight;

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
