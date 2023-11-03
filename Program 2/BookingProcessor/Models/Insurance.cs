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

        [ForeignKey("Plan")]
        [DisplayName("Plan ID")]
        public int PlanID { get; set; }

        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

        [DisplayName("Premium Cost")]
        public decimal PremiumCost { get; set; }

        public bool Active { get; set; }

    }
}