using CreditManagementSystemApp.Enums;

namespace CreditManagementSystemApp.ViewModels.Loan
{
    public class LoanVM
    {
        public int Id { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime LoanDate { get; set; }

        public decimal MonthlyPayment { get; set; }

        public Status Status { get; set; }
        public string StatusDisplay => Status.ToString();

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
    }
}
