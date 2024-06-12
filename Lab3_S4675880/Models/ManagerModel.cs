//------------------------------//
// Manager details & this is needed
// to list all Managers information
//------------------------------// 

using System.ComponentModel.DataAnnotations;

namespace Lab3_S4675880.Models
{
    public class ManagerModel
    {
        // This will be the primary key to uniquely identify records for managers
        // It is needed to distinguish an manager from other managers.
        [Key]
        public int ManagerId { get; set; }

        // Gets full name of manager
        [Display(Name = "Full Name")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "Please enter a valid name. The Name must be a string with a minimum length of 2 and a maximum length of 150.")]
        [Required(ErrorMessage = "Name is required.")]
        public string FullName { get; set; }

        // Gets Email of manager
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Please enter a valid email address. The Email must be a string with a minimum length of 5 and a maximum length of 100.")]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        // Gets Address of manager
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Please enter a valid address. The address must be a string with a minimum length of 10 and a maximum length of 200.")]
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        // Gets Phone number of manager
        [StringLength(15, MinimumLength = 7, ErrorMessage = "Please enter a valid phone number. The Email must be a string with a minimum length of 7 and a maximum length of 15.")]
        [Required(ErrorMessage = "Phone Number is required.")]
        public string Phone { get; set; }
    }
}
