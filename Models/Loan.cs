using CreditManagementSystemApp.Entities;
using CreditManagementSystemApp.Enums;
using CreditManagementSystemApp.Models.Common;

namespace CreditManagementSystemApp.Models
{
    public class Loan : BaseEntity
    {
        public decimal TotalAmount { get; set; }
        public DateTime LoanDate { get; set; }
        public decimal MonthlyPayment { get; set; }
        public Status Status { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public LoanDetail LoanDetail { get; set; }
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
