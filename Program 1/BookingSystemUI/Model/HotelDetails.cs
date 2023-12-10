using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemUI.Model
{
    public class HotelDetails
    {
        public int HotelID { get; set; }

        public int CountryID { get; set; }

        public string? HotelName { get; set; }

        public string? AddressLine1 { get; set; }

        public string? AddressLine2 { get; set; }

        public string? City { get; set; }

        public string? Postcode { get; set; }

        public int PhoneNumber { get; set; }

        public double Rating { get; set; }

        public int RoomCount { get; set; }
    }
}
