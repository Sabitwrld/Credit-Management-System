
using CreditManagementSystemApp.Enums;
using CreditManagementSystemApp.Models.Common;
using System.Numerics;

namespace CreditManagementSystemApp.Models
{
    public class LoanDetail : BaseEntity
    {
        public decimal TotalDebt { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal RemainingAmount => TotalDebt - AmountPaid;
        public Status Status { get; set; }
        public int LoanId { get; set; }
        public Loan Loan { get; set; }
    }
}
