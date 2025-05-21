using CreditManagementSystemApp.Data;
using CreditManagementSystemApp.Models;
using CreditManagementSystemApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CreditManagementSystemApp.Repositories.Implementations
{
    public class BranchRepository<TEntity> : GenericRepository<Branch>, IBranchRepository
    {
        public BranchRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Branch>> GetAllAsync()
        {
            return await _context.Branches
                                 .Include(b => b.Merchant)
                                 .Where(b => !b.IsDeleted)
                                 .AsNoTracking()
                                 .ToListAsync();
        }

        public async Task<Branch> GetByIdAsync(int id)
        {
            return await _context.Branches
                                 .Include(b => b.Merchant)
                                 .AsNoTracking()
                                 .FirstOrDefaultAsync(b => b.Id == id && !b.IsDeleted);
        }
    }
}
