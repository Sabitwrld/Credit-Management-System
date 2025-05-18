using System.ComponentModel.DataAnnotations;

namespace CreditManagementSystemApp.ViewModels.Merchant
{
    public class MerchantCreateVM
    {
        [Required]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Name can only contain letters, numbers, and spaces.")]
        [DataType(DataType.Text)]
        [Display(Name = "Merchant Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Address cannot be longer than 200 characters.")]
        [RegularExpression(@"^[a-zA-Z0-9\s,.-]+$", ErrorMessage = "Address can only contain letters, numbers, spaces, commas, periods, and hyphens.")]
        [Display(Name = "Merchant Address")]
        public string Address { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Phone number cannot be longer than 15 characters.")]
        [RegularExpression(@"^\+?[0-9]*$", ErrorMessage = "Phone number must be numeric and can start with a plus sign.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Merchant Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Email cannot be longer than 100 characters.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Merchant Email")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
    }
}
