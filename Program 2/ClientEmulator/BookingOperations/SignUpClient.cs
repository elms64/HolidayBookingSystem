using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClientEmulator.Models;

namespace ClientEmulator
{
    public class SignUpClient
    {
        private static readonly string ConsoleAppUrl = "http://localhost:8080";
        private static readonly HttpClient httpClient = new HttpClient();

        public async Task<int> SignUpClientAsync()
        {
            Console.WriteLine("Enter the client's first name: ");
            string? firstName = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Enter the client's last name: ");
            string? lastName = Console.ReadLine();
            Console.WriteLine("");

            string? birthDate;
            do
            {
                Console.WriteLine("Enter the client's date of birth (yyyy/mm/dd): ");
                birthDate = Console.ReadLine();
            } while (!ValidateDate(birthDate));
            Console.WriteLine("");

            string? email;
            do
            {
                Console.WriteLine("Enter the client's email: ");
                email = Console.ReadLine();
            } while (!ValidateEmail(email));
            Console.WriteLine("");

            string? phoneNumber;
            do
            {
                Console.WriteLine("Enter the client's phone number: ");
                phoneNumber = Console.ReadLine();
            } while (!ValidatePhoneNumber(phoneNumber));
            Console.WriteLine("");

            string serverURL = ConsoleAppUrl + "/Client";
            var clientData = new List<KeyValuePair<string, string>>();
            clientData.Add(new KeyValuePair<string, string>("FirstName", firstName ?? ""));
            clientData.Add(new KeyValuePair<string, string>("LastName", lastName ?? ""));
            clientData.Add(new KeyValuePair<string, string>("BirthDate", birthDate ?? ""));
            clientData.Add(new KeyValuePair<string, string>("Email", email ?? ""));
            clientData.Add(new KeyValuePair<string, string>("PhoneNumber", phoneNumber ?? ""));

            string jsonPayload = JsonSerializer.Serialize(clientData);
            StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PutAsync(serverURL, content);

            // Read and print the response message
            string responseContent = await response.Content.ReadAsStringAsync();
            var responseObject = JsonSerializer.Deserialize<Dictionary<string, object>>(responseContent);

            if (responseObject != null && responseObject.TryGetValue("Message", out object? messageObj))
            {
                string? message = messageObj.ToString();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Response from server: {message}");
                Console.WriteLine("");
                Console.ResetColor();

                // Check if the request was successful
                if (response.IsSuccessStatusCode && responseObject.TryGetValue("ClientID", out object? clientIDObj))
                {
                    if (clientIDObj is JsonElement clientIDElement && clientIDElement.TryGetInt32(out int clientID))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Client ID resolved successfully: {clientID}");
                        Console.ResetColor();
                        return clientID;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Error: Unable to parse ClientID from the response.");
                        Console.ResetColor();
                        return -1;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error: ClientID not found in the response.");
                    Console.ResetColor();
                    return -1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error: Unable to parse the response message.");
                Console.WriteLine("");
                Console.ResetColor();
                return -1;
            }
        }

        private bool ValidateDate(string? date)
        {
            if (DateTime.TryParseExact(date, "yyyy/MM/dd", null, System.Globalization.DateTimeStyles.None, out _))
            {
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error: Invalid date format. Please enter the date in yyyy/mm/dd format.");
                Console.WriteLine("");
                Console.ResetColor();
                return false;
            }
        }

        private bool ValidateEmail(string? email)
        {
            // Add your email validation logic here.
            // Example: Check if the email matches a valid email pattern.
            if (Regex.IsMatch(email!, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error: Invalid email format. Please enter a valid email address.");
                Console.WriteLine("");
                Console.ResetColor();
                return false;
            }
        }

        private bool ValidatePhoneNumber(string? phoneNumber)
        {
            // Add your phone number validation logic here.
            // Example: Check if the phone number matches a valid pattern.
            if (Regex.IsMatch(phoneNumber!, @"^\d{11}$"))
            {
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error: Invalid phone number format. Please enter a valid 11-digit phone number.");
                Console.WriteLine("");
                Console.ResetColor();
                return false;
            }
        }
    }
}
