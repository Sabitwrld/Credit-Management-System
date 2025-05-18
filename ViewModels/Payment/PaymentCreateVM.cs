using CreditManagementSystemApp.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CreditManagementSystemApp.ViewModels.Payment
{
    public class PaymentCreateVM
    {
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Amount must be non-negative.")]
        [Display(Name = "Amount")]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Required]
        [Display(Name = "Payment Date")]
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }

        [Required]
        [Display(Name = "Payment Method")]
        public PaymentMethod PaymentMethod { get; set; }
        public List<SelectListItem> PaymentMethods { get; set; } = new List<SelectListItem>();

        [Required]
        [Display(Name = "Loan")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a loan.")]
        public int LoanId { get; set; }
        public List<SelectListItem> Loans { get; set; } = new List<SelectListItem>();

        [StringLength(100)]
        [Display(Name = "Transaction ID")]
        public string TransactionId { get; set; }
    }
}
