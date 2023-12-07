// GitHub Authors: @gjepic

/* Model for all expected datatypes relating to Insurance.
   Setup with Entity Framework Core to interact with the database programmatically */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientEmulator.Models
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