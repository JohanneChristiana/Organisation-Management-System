//------------------------------//
// Product details & this is needed
// to list all products information
//------------------------------//

using System.ComponentModel.DataAnnotations;

namespace Lab3_S4675880.Models
{
    public class ProductModel
    {
        // This will be the primary key to uniquely identify records for products
        // It is needed to distinguish an product from other products.
        [Key]
        public int ProductId { get; set; }

        // Gets full name of product
        [Display(Name = "Name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Please enter a valid name. The Name must be a string with a minimum length of 2 and a maximum length of 100.")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        // Gets Email of product
        [Range(0, 1000, ErrorMessage = "Price must be between 0 and 1000.")]
        [Required(ErrorMessage = "Price is required.")]
        public double Price { get; set; }

        // Gets full name of product
        [Display(Name = "Current Stock")]
        [Required(ErrorMessage = "Current Stock is required.")]
        public int CurrentStock { get; set; }
    }
}
