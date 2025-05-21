using CreditManagementSystemApp.ViewModels.Branch;
using CreditManagementSystemApp.ViewModels.Merchant;

namespace CreditManagementSystemApp.Services.Interfaces
{
    public interface IBranchService
    {
        Task<BranchVM> GetByIdAsync(int id);
        Task<IEnumerable<BranchVM>> GetAllAsync();
        Task<BranchVM> AddAsync(BranchCreateVM createVM);
        Task<BranchVM> UpdateAsync(BranchEditVM editVM);
        Task<bool> DeleteAsync(int id);
    }
}
