using System.ComponentModel.DataAnnotations;

namespace IntroToUsers_Lab5.Models.ViewModels
{
    public class CreateAccountVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Starting deposit must be greater than zero.")]
        public decimal StartingDeposit { get; set; }
    }
}
