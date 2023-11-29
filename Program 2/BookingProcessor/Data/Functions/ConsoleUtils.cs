// Authored by @elms64

using System;
using System.Threading.Tasks;

namespace BookingProcessor
{
    public static class ConsoleUtils
    {
        // Prints 3 dots with a console message
        public static async Task PrintWithDotsAsync(string message, int dotCount, int delay, string additionalMessage = "")
        {
            Console.Write(message);

            for (int i = 0; i < dotCount; i++)
            {
                Console.Write(".");
                await Task.Delay(1000);
            }

            Console.WriteLine();

            if (!string.IsNullOrEmpty(additionalMessage))
            {
                Console.WriteLine(additionalMessage);
            }
        }
    }
}
