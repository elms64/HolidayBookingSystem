// GitHub authors: @elms64 and @Kloakk

/* Main entry point for the Bookings Beyond Boundaries backend server system. 
 * This program provides an introductory message to the target user (System Administrator).
 * The program provides several commands to initiate different modes of operation: Automatic, Normal and Recovery.
 * The program is part of a distributed system that allows office users to send booking requests and retrieve information from the database 
 * by communicating via HTTP to this server. It is designed for a small office LAN environment and correct network IPs 
 * will need to be configured on deployment. See the documentation for more information. */

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookingProcessor.Models;
using System;
using System.Threading.Tasks;

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

            // Exits the program when called. 
            normalMode.OnRestartRequested += async () =>
            {
                Console.WriteLine("Exiting the program.");
                await Task.Delay(1000);
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

                // Awaits user input.
                string userInput = Console.ReadLine(); //@

                // Starts automatic mode of operation, running recovery mode first. 
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    await recoveryMode.Run();
                }

                // Starts the program depending on the user input.
                else
                {
                    switch (userInput.ToLower())
                    {
                        case "recover":
                            await recoveryMode.Run();
                            break;

                        case "listen":
                            await normalMode.Run();
                            break;

                        case "exit":
                            Console.WriteLine("Exiting the program.");
                            return;

                        default:
                            Console.WriteLine("Invalid input. Please enter 'recover', 'listen', or 'exit'.");
                            return;
                    }
                }

                // After recovery mode finishes, initiate normal mode automatically.
                await normalMode.Run();
            }
        }
    }
}