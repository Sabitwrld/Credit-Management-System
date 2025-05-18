namespace CreditManagementSystemApp.ViewModels.Employee
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string EmployeeId { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
    }
}
