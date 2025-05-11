using CreditManagementSystemApp.Enums;
using CreditManagementSystemApp.Models;
using CreditManagementSystemApp.Models.Common;

namespace CreditManagementSystemApp.Entities
{
    public class Payment : BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.Cash;
        public string TransactionId { get; set; }

        public int LoanId { get; set; }
        public Loan Loan { get; set; }
    }
}
