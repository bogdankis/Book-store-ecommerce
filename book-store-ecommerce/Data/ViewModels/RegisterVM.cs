using System.ComponentModel.DataAnnotations;

namespace book_store_ecommerce.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Fullname is required")]
        public string FullName { get; set; }

        [Display(Name ="Email address")]
        [Required(ErrorMessage="Email address is required")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Confirm password")]
        [Required(ErrorMessage = "Confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage= "Passwords does not match")]
        public string ConfirmPassword { get; set; }
    }
}
