namespace BookingProcessor.Models
{
    public class Insurance
    {
        public int InsuranceID { get; set; }
        public int PlanID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal PreimumCost { get; set; }
        public bool Active { get; set; }

    }
}