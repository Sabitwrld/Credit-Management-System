namespace CreditManagementSystemApp.Models
{
    public class Customer : Person
    {
        public decimal CreditLimit { get; set; }
        public int? UserId { get; set; }
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
