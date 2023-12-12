using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemUI.Model
{
    public class Vehicle
    {
        public int VehicleID { get; set; }

        public string? VehicleType { get; set; }

        public decimal PricePerDay { get; set; }

        public override string ToString()
        {
            return $"Vehicle ID: {VehicleID}\n" +
                   $"Vehicle Type: {VehicleType}\n" +
                   $"Price Per Day: {PricePerDay:C}"; // Format PricePerDay as currency
        }
    }
}
