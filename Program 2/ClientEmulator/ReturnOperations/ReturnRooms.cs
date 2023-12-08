// GitHub Authors: @elms64 & @Kloakk

// Returns a list of rooms based on a given hotel

/* System Libraries */
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ClientEmulator.Models;

namespace ClientEmulator
{
    public class ReturnRooms
    {
        /* Variables */
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
                    Console.WriteLine($"Headers: room={selectedHotelID}");
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
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request Error: {ex.Message}");
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine($"Task Canceled Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}