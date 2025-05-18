using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CreditManagementSystemApp.ViewModels.Branch
{
    public class BranchCreateVM
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Branch Name")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Branch name can only contain letters, numbers, and spaces.")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        [Display(Name = "Branch Address")]
        [RegularExpression(@"^[a-zA-Z0-9\s,.-]+$", ErrorMessage = "Branch address can only contain letters, numbers, spaces, commas, periods, and hyphens.")]
        public string Address { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 10)]
        [Display(Name = "Branch Phone Number")]
        [RegularExpression(@"^\+?[0-9\s-]+$", ErrorMessage = "Branch phone number can only contain numbers, spaces, hyphens, and an optional leading plus sign.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Merchant")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a merchant.")]
        public int MerchantId { get; set; }
        public List<SelectListItem> Merchants { get; set; } = new List<SelectListItem>();
    }
}
