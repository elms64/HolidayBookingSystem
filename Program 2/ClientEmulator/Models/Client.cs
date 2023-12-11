// GitHub Authors: @elms64, @Kloakk

/* Model for all expected datatypes relating to Clients.
   Setup with Entity Framework Core to interact with the database programmatically */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClientEmulator.Models
{
    public class Client
    {
        [Key]
        [DisplayName("Client ID")]
        public int ClientID { get; set; }

        [DisplayName("First Name")]
        public string? FirstName { get; set; }

        [DisplayName("Last Name")]
        public string? LastName { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime BirthDate { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }
    }
}