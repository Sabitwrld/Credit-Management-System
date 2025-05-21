using CreditManagementSystemApp.Data;
using CreditManagementSystemApp.Models;
using CreditManagementSystemApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CreditManagementSystemApp.Repositories.Implementations
{
    public class MerchantRepository<TEntity> : GenericRepository<Merchant>, IMerchantRepository
    {
        public MerchantRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Merchant>> GetAllWithDetailsAsync()
        {
            return await _context.Set<Merchant>()
                .Include(m => m.Branches)
                .ToListAsync();
        }
    }
}
