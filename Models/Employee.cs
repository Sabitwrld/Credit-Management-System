namespace CreditManagementSystemApp.Models
{
    public class Employee : Person
    {
        public string EmployeeId { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
