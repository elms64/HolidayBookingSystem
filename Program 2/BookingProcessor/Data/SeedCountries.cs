// GitHub Authors: @elms64

/* Initializes the database with standardised Country data from the ISO3166 standard
   https://github.com/schourode/iso3166/blob/master/Country.cs */

// System Libraries and Packages
using BookingProcessor.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ISO3166;

namespace BookingProcessor.Data
{
    public static class SeedCountries
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            var countries = GenerateCountries();
            modelBuilder.Entity<BookingProcessor.Models.Country>().HasData(countries);
        }

        private static List<BookingProcessor.Models.Country> GenerateCountries()
        {
            var countries = new List<BookingProcessor.Models.Country>();
            var isoCountries = ISO3166.Country.List;

            foreach (var isoCountry in isoCountries)
            {
                var country = new BookingProcessor.Models.Country
                {
                    CountryID = int.Parse(isoCountry.NumericCode),
                    CountryName = isoCountry.Name,
                };

                countries.Add(country);
            }

            return countries;
        }
    }
}
