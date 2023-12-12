using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemUI.Model
{
    public class Insurance
    {
        public int InsuranceID { get; set; }

        public string? InsuranceType { get; set; }

        public double PricePerDay { get; set; }
        public override string ToString()
        {
            return $"Insurance ID: {InsuranceID}, " +
                $"Insurance Type: {InsuranceType}, " +
                $"Price Per Day: {PricePerDay}";
        }
    }
}
