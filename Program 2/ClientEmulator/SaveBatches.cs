using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientEmulator
{
    public class SaveBatches
    {
        public async Task SaveBatchProcess(string message, Guid guid)
        {
            //MessageBox.Show(message);
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


                // Check if the file already exists (unlikely due to unique filename)
                if (!File.Exists(filePath))
                {
                    // Write the HTTP message to the JSON file asynchronously
                    await File.WriteAllTextAsync(filePath, message);

                    Console.WriteLine($"HTTP message saved to: {filePath}");
                }
                else
                {

                    Console.WriteLine($"File already exists: {filePath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving to JSON file: {ex.Message}");
            }
        }
    }
}
