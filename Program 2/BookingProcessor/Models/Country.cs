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