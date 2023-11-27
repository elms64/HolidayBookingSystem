// Authored by @gjepic

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public class returnVehicle
{

    // Method for returning a list of vehicles, the types of vehicle and their IDs
    public async Task<byte[]> getCars(IServiceProvider serviceProvider)
    {
        using (var scope = serviceProvider.CreateScope())
        {
            var bookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
            var get_vehicles = await bookingContext.Vehicle.Select(v => new { v.VehicleID, v.VehicleType, v.PricePerDay }).ToListAsync();
            Console.WriteLine("BZZZZ");
            string jsonResponse = JsonSerializer.Serialize(get_vehicles);
            return Encoding.UTF8.GetBytes(jsonResponse);
            
        }
    }
}

