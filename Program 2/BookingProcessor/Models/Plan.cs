using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookingProcessor.Models 
{
    public class Plan
    {
        [Key]
        [DisplayName("Plan ID")]
        public int PlanID { get; set; }

        [DisplayName("Type of Cover")]
        public string CoverType { get; set; }
        
        public decimal Cost { get; set; }
        
    }
}