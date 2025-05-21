using AutoMapper;
using CreditManagementSystemApp.Entities;
using CreditManagementSystemApp.Models;
using CreditManagementSystemApp.ViewModels.Branch;
using CreditManagementSystemApp.ViewModels.Category;
using CreditManagementSystemApp.ViewModels.Customer;
using CreditManagementSystemApp.ViewModels.Employee;
using CreditManagementSystemApp.ViewModels.Loan;
using CreditManagementSystemApp.ViewModels.LoanDetail;
using CreditManagementSystemApp.ViewModels.Merchant;
using CreditManagementSystemApp.ViewModels.Payment;
using CreditManagementSystemApp.ViewModels.Product;

namespace CreditManagementSystemApp.Profiles
{
    public class CustomProfile : Profile
    {
        public CustomProfile()
        {
            CreateMap<Merchant, MerchantVM>().ReverseMap();
            CreateMap<Merchant, MerchantCreateVM>().ReverseMap();
            CreateMap<Merchant, MerchantEditVM>().ReverseMap();
            CreateMap<MerchantVM, MerchantCreateVM>().ReverseMap();
            CreateMap<MerchantVM, MerchantEditVM>().ReverseMap();

            CreateMap<Branch, BranchVM>().ReverseMap();
            CreateMap<Branch, BranchCreateVM>().ReverseMap();
            CreateMap<Branch, BranchEditVM>().ReverseMap();
            CreateMap<BranchVM, BranchCreateVM>().ReverseMap();
            CreateMap<BranchVM, BranchEditVM>().ReverseMap();

        }
    }
}
