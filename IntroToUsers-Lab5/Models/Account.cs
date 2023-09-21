using IntroToUsers_Lab5.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace IntroToUsers_Lab5.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Deposit amount cannot be negative.")]
        public decimal Balance { get; set; }

        public string UserId { get; set; }

        // Navigation property for the user who owns this account
        public DemoUser User { get; set; }
    }
}
