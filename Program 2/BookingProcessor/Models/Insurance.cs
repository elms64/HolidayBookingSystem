using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingProcessor.Models
{
    public class Insurance
    {
        [Key]
        [DisplayName("Insurance ID")]
        public int InsuranceID { get; set; }

        [DisplayName("Insurance Type")]
        public string? InsuranceType { get; set; }

        [DisplayName("Price Per Day")]
        public double PricePerDay { get; set; }
    }
}