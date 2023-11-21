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

class returnCountry
{
    public async Task<byte[]> sendCountry(IServiceProvider serviceProvider)
    {
        using (var scope = serviceProvider.CreateScope())
        {
            var bookingContext = scope.ServiceProvider.GetRequiredService<BookingContext>();
            var send_countries = await bookingContext.Country.Select(c => new { c.CountryID, c.CountryName }).ToListAsync();
            Console.WriteLine("BZZZZ");
            string jsonResponse = JsonSerializer.Serialize(send_countries);
            return Encoding.UTF8.GetBytes(jsonResponse);
            
        }
    }
}

