// GitHub Authors: @elms64 & @Kloakk

// Returns a list of rooms based on a given hotel

using System.Text.Json;
using ClientEmulator.Models;

namespace ClientEmulator
{
    public class ReturnRooms
    {
        private static readonly string ConsoleAppUrl = "http://localhost:8080";

        public async Task ReturnRoomsList(string selectedHotelID)
        {
            try
            {
                string targetURL = ConsoleAppUrl + "/Room";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("room", selectedHotelID);

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Sending request to: {targetURL}");
                    Console.WriteLine($"Selected Hotel ID: {selectedHotelID}");
                    Console.WriteLine("");
                    Console.ResetColor();
                    HttpResponseMessage response = await client.GetAsync(targetURL);

                    if (response.IsSuccessStatusCode)
                    {
                        string roomJsonResponse = await response.Content.ReadAsStringAsync();

                        if (roomJsonResponse.StartsWith("["))
                        {
                            var rooms = JsonSerializer.Deserialize<List<Room>>(roomJsonResponse);
                            foreach (var room in rooms!)
                            {
                                Console.WriteLine($"RoomID: {room.RoomID} RoomType: {room.RoomType}");
                            }
                        }
                        else
                        {
                            var room = JsonSerializer.Deserialize<Room>(roomJsonResponse);
                            Console.WriteLine($"RoomID: {room!.RoomID} RoomType: {room.RoomType}");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Error: {response.StatusCode}");
                        Console.ResetColor();
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"HTTP Request Error: {ex.Message}");
                Console.ResetColor();
            }
            catch (TaskCanceledException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Task Canceled Error: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}