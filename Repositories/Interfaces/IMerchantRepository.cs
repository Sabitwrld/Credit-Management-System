using CreditManagementSystemApp.Models;

namespace CreditManagementSystemApp.Repositories.Interfaces
{
    public interface IMerchantRepository : IGenericRepository<Merchant>
    {
        Task<IEnumerable<Merchant>> GetAllWithDetailsAsync();
    }

}
