using System.ComponentModel.DataAnnotations;

namespace IntroToUsers_Lab5.Models.ViewModels
{
    public class TransactionVM
    {
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
        public decimal Amount { get; set; }

        public Type TransactionType { get; set; }

        public enum Type { 
            withdrawals,
            deposit
        }
    }
}
