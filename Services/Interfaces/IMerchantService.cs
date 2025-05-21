using CreditManagementSystemApp.Models;
using CreditManagementSystemApp.ViewModels.Merchant;

namespace CreditManagementSystemApp.Services.Interfaces
{
    public interface IMerchantService
    {
        Task<MerchantVM> GetByIdAsync(int id);
        Task<IEnumerable<MerchantVM>> GetAllAsync();
        Task<MerchantVM> AddAsync(MerchantCreateVM createVM);
        Task<MerchantVM> UpdateAsync(MerchantEditVM editVM);
        Task<bool> DeleteAsync(int id);
    }
}
