using AutoMapper;
using CreditManagementSystemApp.Models;
using CreditManagementSystemApp.Repositories.Interfaces;
using CreditManagementSystemApp.Services.Interfaces;
using CreditManagementSystemApp.ViewModels.Merchant;
using NuGet.Protocol.Core.Types;

namespace CreditManagementSystemApp.Services.Implementations
{
    public class MerchantService : IMerchantService
    {
        private readonly IMerchantRepository _merchantRepository;
        private readonly IMapper _mapper;
        public MerchantService(IMerchantRepository merchantRepository, IMapper mapper)
        {
            _merchantRepository = merchantRepository;
            _mapper = mapper;
        }

        public async Task<MerchantVM> AddAsync(MerchantCreateVM createVM)
        {
            var entity = _mapper.Map<Merchant>(createVM);
            var result = await _merchantRepository.AddAsync(entity);
            if (result is null)
                return null;

            return _mapper.Map<MerchantVM>(result);
        }

        public async Task<bool> DeleteAsync(int id) => await _merchantRepository.DeleteAsync(id);

        public async Task<IEnumerable<MerchantVM>> GetAllAsync()
        {
            var datas = await _merchantRepository.GetAllAsync();

            if (datas is null)
                return null;

            return _mapper.Map<IEnumerable<MerchantVM>>(datas);
        }

        public async Task<MerchantVM> GetByIdAsync(int id)
        {
            var data = await _merchantRepository.GetByIdAsync(id);
            if (data is null)
                return null;

            var merchantVM = _mapper.Map<MerchantVM>(data);

            return merchantVM;
        }


        public async Task<MerchantVM> UpdateAsync(MerchantEditVM editVM)
        {
            var entity = _mapper.Map<Merchant>(editVM);

            var result = await _merchantRepository.UpdateAsync(entity);

            if (result is null)
            {
                return null;
            }

            var updatedVM = _mapper.Map<MerchantVM>(result);

            return updatedVM;
        }

    }

}
