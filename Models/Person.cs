using CreditManagementSystemApp.Models.Common;

namespace CreditManagementSystemApp.Models
{
    public abstract class Person : BaseEntity
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; } 
        public string Surname { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }


}

