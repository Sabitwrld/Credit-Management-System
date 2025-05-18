using CreditManagementSystemApp.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CreditManagementSystemApp.ViewModels.Loan
{
    public class LoanEditVM
    {
        public int Id { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Total amount must be non-negative.")]
        [Display(Name = "Total Amount")]
        [DataType(DataType.Currency)]
        public decimal TotalAmount { get; set; }

        [Required]
        [Display(Name = "Loan Date")]
        [DataType(DataType.Date)]
        public DateTime LoanDate { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Monthly payment must be non-negative.")]
        [Display(Name = "Monthly Payment")]
        [DataType(DataType.Currency)]
        public decimal MonthlyPayment { get; set; }

        [Required]
        [Display(Name = "Status")]
        public Status Status { get; set; }
        public List<SelectListItem> StatusList { get; set; } = new List<SelectListItem>();

        [Required]
        [Display(Name = "Customer")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a customer.")]
        public int CustomerId { get; set; }
        public List<SelectListItem> Customers { get; set; } = new List<SelectListItem>();

        [Required]
        [Display(Name = "Employee")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select an employee.")]
        public int EmployeeId { get; set; }
        public List<SelectListItem> Employees { get; set; } = new List<SelectListItem>();
    }
}
