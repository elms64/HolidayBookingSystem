using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystemUI
{
    public class SaveBatches
    {
        public async Task SaveBatchProcess(string message)
        {
            MessageBox.Show(message);
            try
            {
                MessageBox.Show("1");
                string folderPath = Path.Combine(Environment.CurrentDirectory, "Program 1", "Batch-Requests");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                MessageBox.Show("2");
                // Generate a unique filename using a GUID
                string fileName = $"Request_{Guid.NewGuid()}.json";

                // Combine the folder path and filename to get the full file path
                string filePath = Path.Combine(folderPath, fileName);

                MessageBox.Show("3");
                // Check if the file already exists (unlikely due to unique filename)
                if (!File.Exists(filePath))
                {
                    // Write the HTTP message to the JSON file asynchronously
                    await File.WriteAllTextAsync(filePath, message);
                    MessageBox.Show("4");
                    MessageBox.Show($"HTTP message saved to: {filePath}");
                }
                else
                {
                    MessageBox.Show("5");
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
