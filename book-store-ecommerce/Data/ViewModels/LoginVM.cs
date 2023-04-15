using System.ComponentModel.DataAnnotations;

namespace book_store_ecommerce.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name ="Email address")]
        [Required(ErrorMessage="Email address is required")]
        public string EmailAddress { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
