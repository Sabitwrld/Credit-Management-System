using CreditManagementSystemApp.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CreditManagementSystemApp.ViewModels.LoanDetail
{
    public class LoanDetailCreateVM
    {
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Total debt must be non-negative.")]
        [Display(Name = "Total Debt")]
        [DataType(DataType.Currency)]
        public decimal TotalDebt { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Amount paid must be non-negative.")]
        [Display(Name = "Amount Paid")]
        [DataType(DataType.Currency)]
        public decimal AmountPaid { get; set; }

        [Required]
        [Display(Name = "Status")]
        public Status Status { get; set; }
        public List<SelectListItem> StatusList { get; set; } = new List<SelectListItem>();

        [Required]
        [Display(Name = "Loan")]
        public int LoanId { get; set; }
        public List<SelectListItem> Loans { get; set; } = new List<SelectListItem>();
    }
}
