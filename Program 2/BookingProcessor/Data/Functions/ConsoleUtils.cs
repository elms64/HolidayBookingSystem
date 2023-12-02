// GitHub Authors: @elms64

// Prints dots sequentially in the console. Used alongside log messages to improve the overall user experience. 

using System;
using System.Threading.Tasks;

namespace BookingProcessor
{
    public static class ConsoleUtils
    {
        // The time delay and amount of dots can be specified when calling this method. 
        public static async Task PrintWithDotsAsync(string message, int dotCount, int delay, string additionalMessage = "")
        {
            Console.Write(message);

            for (int i = 0; i < dotCount; i++)
            {
                Console.Write(".");
                await Task.Delay(800);
            }

            Console.WriteLine();

            if (!string.IsNullOrEmpty(additionalMessage))
            {
                Console.WriteLine(additionalMessage);
            }
        }
    }
}
