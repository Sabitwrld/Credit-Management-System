using CreditManagementSystemApp.Enums;

namespace CreditManagementSystemApp.ViewModels.LoanDetail
{
    public class LoanDetailVM
    {
        public int Id { get; set; }

        public decimal TotalDebt { get; set; }

        public decimal AmountPaid { get; set; }

        public decimal RemainingAmount { get; set; }

        public Status Status { get; set; }
        public string StatusDisplay => Status.ToString();

        public int LoanId { get; set; }

        public string LoanInfo { get; set; }
    }
}
