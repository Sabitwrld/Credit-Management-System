using CreditManagementSystemApp.Models.Common;

namespace CreditManagementSystemApp.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
