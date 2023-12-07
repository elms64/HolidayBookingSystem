// GitHub Authors: @gjepic

/* Model for all expected datatypes relating to Countries.
   Setup with Entity Framework Core to interact with the database programmatically */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingProcessor.Models
{
    public class Country 
    {
        [Key]
        [DisplayName("Country ID")]
        public int CountryID { get; set; }

        [DisplayName("Country Name")]
        public string? CountryName { get; set; }

    }
}