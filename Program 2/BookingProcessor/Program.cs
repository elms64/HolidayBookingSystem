﻿// Authored by @elms64 and @Kloakk

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookingProcessor.Models;
using System;
using System.Reflection;
using System.Diagnostics;

namespace BookingProcessor
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<BookingContext>(options =>
                    options.UseSqlite("Data Source=booking_data.db"))
                .BuildServiceProvider();

            NormalMode normalMode = new NormalMode(serviceProvider);
            var recoveryMode = new RecoveryMode(serviceProvider);

            // Subscribe to the restart event
            normalMode.OnRestartRequested += async () =>
            {
                Console.WriteLine("Exiting the program.");
                // Additional cleanup or preparation logic if needed

                // Delay to allow cleanup (if any)
                await Task.Delay(1000);

                // Restart the program
                // var filePath = "Program 2/BookingProcessor/Program.cs";
                // Process.Start(filePath);
                Environment.Exit(0);
            };

            while (true)
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("*                                                *");
                Console.WriteLine("*    Booking Processor Utility                   *");
                Console.WriteLine("*                                                *");
                Console.WriteLine("*    Welcome, System Administrator!              *");
                Console.WriteLine("*                                                *");
                Console.WriteLine("*    This utility processes booking data         *");
                Console.WriteLine("*    and provides recovery and normal            *");
                Console.WriteLine("*    modes of operation.                         *");
                Console.WriteLine("*                                                *");
                Console.WriteLine("*    Copyright © 2023 Booking Beyond             *");
                Console.WriteLine("*    Boundaries. All rights reserved.            *");
                Console.WriteLine("*                                                *");
                Console.WriteLine("*    GitHub Authors:                             *");
                Console.WriteLine("*    @elms64, @Kloakk, @dlawlor2408 & @gjepic    *");
                Console.WriteLine("*                                                *");
                Console.WriteLine("*    For support and inquiries, please           *");
                Console.WriteLine("*    contact support@bookingbeyond.com.          *");
                Console.WriteLine("*                                                *");
                Console.WriteLine("*    Commands:                                   *");
                Console.WriteLine("*    Type 'Recover' to initiate recovery mode.   *");
                Console.WriteLine("*    Type 'Listen' to start normal mode.         *");
                Console.WriteLine("*    Press Enter to boot the automatic startup.  *");
                Console.WriteLine("*    Type 'Exit' to exit the application.        *");
                Console.WriteLine("*                                                *");
                Console.WriteLine("*    To boot recovery mode whilst listening,     *");
                Console.WriteLine("*    Press ESC to exit then restart the server   *");
                Console.WriteLine("*                                                *");
                Console.WriteLine("*    Note: This utility requires access          *");
                Console.WriteLine("*          to a SQL database (SQLite is          *");
                Console.WriteLine("*          Implemented as an example).           *");
                Console.WriteLine("*                                                *");
                Console.WriteLine("*    Thank you for choosing                      *");
                Console.WriteLine("*    Booking Beyond Boundaries!                  *");
                Console.WriteLine("*                                                *");
                Console.WriteLine("**************************************************");
                Console.WriteLine("");
                Console.WriteLine("Press Enter or type a command to continue:");
                string userInput = Console.ReadLine(); //@


                if (string.IsNullOrWhiteSpace(userInput))
                {
                    // Automatic transition from recovery to normal mode
                    await recoveryMode.Run();
                    await normalMode.Run();
                }
                else
                {
                    switch (userInput.ToLower())
                    {
                        case "recover":

                            recoveryMode.Run().GetAwaiter().GetResult();
                            break;

                        case "listen":
                            normalMode.Run().GetAwaiter().GetResult();
                            break;

                        case "exit":
                            Console.WriteLine("Exiting the program.");
                            return;

                        default:
                            Console.WriteLine("Invalid input. Please enter 'recover', 'listen', or 'exit'.");
                            break;
                    }
                }
            }
        }
    }
}





/*
    // First run in recovery mode to check if there any batch processes outstanding
    var recoveryMode = new RecoveryMode(serviceProvider);
    recoveryMode.Run().GetAwaiter().GetResult();

    // After running in recovery mode, initiate normal mode
    var normalMode = new NormalMode(serviceProvider);
    normalMode.Run().GetAwaiter().GetResult();

}
}
}
*/