namespace CreditManagementSystemApp.Models.Common
{

    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow.AddHours(4);
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow.AddHours(4);
        public bool IsDeleted { get; set; } = false;
    }
}