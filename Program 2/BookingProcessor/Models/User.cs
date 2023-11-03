using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookingProcessor.Models 
{
    public class User
    {
        [Key]
        [DisplayName("User ID")]
        public int UserID { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime BirthDate { get; set; }

        public string Password { get; set; }

        public string Telephone { get; set; }
    }
}