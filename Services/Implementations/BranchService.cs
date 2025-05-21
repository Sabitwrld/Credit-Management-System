using AutoMapper;
using CreditManagementSystemApp.Models;
using CreditManagementSystemApp.Repositories.Implementations;
using CreditManagementSystemApp.Repositories.Interfaces;
using CreditManagementSystemApp.Services.Interfaces;
using CreditManagementSystemApp.ViewModels.Branch;
using CreditManagementSystemApp.ViewModels.Merchant;

namespace CreditManagementSystemApp.Services.Implementations
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IMapper _mapper;

        public BranchService(IBranchRepository branchRepository, IMapper mapper)
        {
            _branchRepository = branchRepository;
            _mapper = mapper;
        }

        public async Task<BranchVM> AddAsync(BranchCreateVM createVM)
        {
            var entity = _mapper.Map<Branch>(createVM);
            var result = await _branchRepository.AddAsync(entity);
            if (result is null)
                return null;
            
            return _mapper.Map<BranchVM>(result);
        }
        public async Task<bool> DeleteAsync(int id) => await _branchRepository.DeleteAsync(id);


        public async Task<IEnumerable<BranchVM>> GetAllAsync()
        {
            var datas = await _branchRepository.GetAllAsync();
            if (datas is null)
                return null;
            
            return _mapper.Map<IEnumerable<BranchVM>>(datas);
        }

        public async Task<BranchVM> GetByIdAsync(int id)
        {
            var data = await _branchRepository.GetByIdAsync(id);
            if (data is null)
                return null;
            
            var branchVM = _mapper.Map<BranchVM>(data);
            return branchVM;
        }

        public async Task<BranchVM> UpdateAsync(BranchEditVM editVM)
        {
            var entity = _mapper.Map<Branch>(editVM);
            var result = await _branchRepository.UpdateAsync(entity);
            if (result is null)
                return null;

            return _mapper.Map<BranchVM>(result);
        }

    }
}
