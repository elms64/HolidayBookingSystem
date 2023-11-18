using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookingProcessor.Models;
using System;

namespace BookingProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<BookingContext>(options =>
                    options.UseSqlite("Data Source=booking_data.db"))
                .BuildServiceProvider();

            // First run in recovery mode to check if there any batch processes outstanding
            var recoveryMode = new RecoveryMode(serviceProvider);
            recoveryMode.Run().GetAwaiter().GetResult();

            // After running in recovery mode, initiate normal mode
            var normalMode = new NormalMode(serviceProvider);
            normalMode.Run().GetAwaiter().GetResult();

        }
    }
}
