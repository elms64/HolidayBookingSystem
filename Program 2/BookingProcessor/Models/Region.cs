using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingProcessor.Models
{
    public class Region
    {
        [Key]
        [DisplayName("Region ID")]
        public int RegionID { get; set; }

        [ForeignKey("Country")]
        [DisplayName("Country ID")]
        public int CountryID { get; set; }

        [DisplayName("Region")]
        public string RegionName { get; set; }

        [DisplayName("Time Zone")]
        public string TimeZone { get; set; }
    }
}