using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CreditManagementSystemApp.ViewModels.Category
{
    public class CategoryEditVM
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        [Display(Name = "Category Name")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Name can only contain letters, numbers, and spaces.")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        [Display(Name = "Description")]
        [RegularExpression(@"^[a-zA-Z0-9\s.,]+$", ErrorMessage = "Description can only contain letters, numbers, spaces, periods, and commas.")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public List<SelectListItem> ParentCategories { get; set; } = new List<SelectListItem>();
    }
}
