using CreditManagementSystemApp.Enums;

namespace CreditManagementSystemApp.ViewModels.Payment
{
    public class PaymentVM
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string PaymentMethodDisplay => PaymentMethod.ToString();
        public string TransactionId { get; set; }
        public int LoanId { get; set; }
        public string LoanInfo { get; set; }
    }
}
