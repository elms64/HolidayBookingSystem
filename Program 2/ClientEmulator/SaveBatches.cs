// GitHub Authors: @elms64 & @Kloakk

// Saves a booking transaction as a JSON file to a batch process folder

using System.Text.Json;

namespace ClientEmulator
{
    public class SaveBatches
    {
        public static async Task SaveBatchProcess(List<KeyValuePair<string, string>> bookingData, Guid guid)
        {
            try
            {
                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BatchRequests");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string fileName = guid.ToString();

                // Combine the folder path and filename to get the full file path
                string filePath = Path.Combine(folderPath, fileName);

                // Serialize the bookingData to JSON
                string jsonData = JsonSerializer.Serialize(bookingData);

                // Write the JSON data to the file asynchronously
                await File.WriteAllTextAsync(filePath, jsonData);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Transaction has been saved as a batch process at: {filePath}");
                Console.ResetColor();
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"An error occurred while saving to JSON file: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}