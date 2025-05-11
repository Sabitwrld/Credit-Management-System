using CreditManagementSystemApp.Models.Common;

namespace CreditManagementSystemApp.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        
    }
}
