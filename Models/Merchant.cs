using CreditManagementSystemApp.Models.Common;

namespace CreditManagementSystemApp.Models
{
    public class Merchant : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public ICollection<Branch> Branches { get; set; } = new List<Branch>();
    }
}
