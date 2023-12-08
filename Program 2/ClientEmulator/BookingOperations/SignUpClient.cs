using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ClientEmulator.Models;

namespace ClientEmulator
{
    public class SignUpClient
    {
        private static readonly string ConsoleAppUrl = "http://localhost:8080";
        private static string? origin;
        private static string? destination;
        private static readonly HttpClient httpClient = new HttpClient();


        public async Task<int> SignUpClientAsync()
        {
            Console.WriteLine("Enter the clients first name: ");
            string? firstName = Console.ReadLine();

            Console.WriteLine("Enter the clients last name: ");
            string? lastName = Console.ReadLine();

            // Maybe we need something to specify the format. 
            Console.WriteLine("Enter the clients date of birth: ");
            string? DoB = Console.ReadLine();

            Console.WriteLine("Enter the clients Email: ");
            string? Email = Console.ReadLine();

            Console.WriteLine("Enter the clients PhoneNumber: ");
            string? PhoneNumber = Console.ReadLine();

            // PUT request
            // On response returnID. 
            string serverURL = ConsoleAppUrl + "/Client";
            var Client = new List<KeyValuePair<string, string>>();
            Client.Add(new KeyValuePair<string, string>("FirstName", firstName));
            Client.Add(new KeyValuePair<string, string>("LastName", lastName));
            Client.Add(new KeyValuePair<string, string>("DoB", DoB));
            Client.Add(new KeyValuePair<string, string>("Email", Email));
            Client.Add(new KeyValuePair<string, string>("PhoneNumber", PhoneNumber));

            string jsonPayload = JsonSerializer.Serialize(Client);
            StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PutAsync(serverURL, content);

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                // Read the response content
                string responseContent = await response.Content.ReadAsStringAsync();

                // Parse the JSON response to get the ClientID
                var responseObject = JsonSerializer.Deserialize<Dictionary<string, object>>(responseContent);
                if (responseObject.TryGetValue("ClientID", out object clientIDObj))
                {
                    if (clientIDObj is JsonElement clientIDElement && clientIDElement.TryGetInt32(out int clientID))
                    {
                        Console.WriteLine($"Client data sent successfully! ClientID: {clientID}");
                        return clientID;
                    }
                    else
                    {
                        Console.WriteLine("Error: Unable to parse ClientID from the response.");
                        return -1;
                    }
                }
                else
                {
                    Console.WriteLine("Error: ClientID not found in the response.");
                    return -1;
                }
            }
            return -1;
        }
    }
}