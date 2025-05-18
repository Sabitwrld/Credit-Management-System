using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CreditManagementSystemApp.ViewModels.Employee
{
    public class EmployeeEditVM
    {
        public int Id { get; set; }
        [Display(Name = "Image URL")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(150)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Phone]
        [StringLength(20)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Employee ID")]
        public string EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Position")]
        public string Position { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Salary must be non-negative.")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [Required]
        [Display(Name = "Branch")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a branch.")]
        public int BranchId { get; set; }
        public List<SelectListItem> Branches { get; set; } = new List<SelectListItem>();
    }
}
