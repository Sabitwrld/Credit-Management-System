namespace CreditManagementSystemApp.ViewModels.Customer
{
    public class CustomerVM
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
        public decimal CreditLimit { get; set; }
        public int? UserId { get; set; }
    }
}
