//------------------------------//
// Client details & this is needed
// to list all Clients information
//------------------------------//   

using System.ComponentModel.DataAnnotations;

namespace Lab3_S4675880.Models
{
    public class ClientModel
    {
        // This will be the primary key to uniquely identify records for clients
        // It is needed to distinguish an client from other clients.
        [Key]
        public int ClientId { get; set; }

        // Gets full name of client
        [Display(Name = "Full Name")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "Please enter a valid name. The Name must be a string with a minimum length of 2 and a maximum length of 150.")]
        [Required(ErrorMessage = "Name is required.")]
        public string FullName { get; set; }

        // Gets Email of client
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Please enter a valid email address. The Email must be a string with a minimum length of 5 and a maximum length of 100.")]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        // Gets Address of client
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Please enter a valid address. The address must be a string with a minimum length of 10 and a maximum length of 200.")]
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        // Gets Phone number of client
        [StringLength(15, MinimumLength = 7, ErrorMessage = "Please enter a valid phone number. The Email must be a string with a minimum length of 7 and a maximum length of 15.")]
        [Required(ErrorMessage = "Phone Number is required.")]
        public string Phone { get; set; }

        // Gets Subscription of client
        [Required(ErrorMessage = "Subscription is required.")]
        [RegularExpression("^(Free Trial|Standard|Premium|Enterprise)$", ErrorMessage = "Please enter a valid subscription: Free Trial|Standard|Premium|Enterprise")]
        public string Subscription { get; set; }

        // Gets Discount of client (Y/N)
        [Display(Name = "Discount (Y or N)")]
        [StringLength(1, ErrorMessage = "Please enter if you would like a discount or not. Y = Yes and N = No")] // limits user to only put one digit
        [Required(ErrorMessage = "Discount is required.")]
        [RegularExpression("^[YN]$", ErrorMessage = "Please enter a valid discount option. Y = Yes and N = No")]
        public string Discount { get; set; }

        // Gets Price of client
        [Range(0, 1000, ErrorMessage = "Price must be between 0 and 1000.")]
        [Required(ErrorMessage = "Price is required.")]
        public double Price { get; set; }

        // To know when the subscription was purchased
        // Date
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; }
    }
}
