using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace book_store_ecommerce.Models
{
    public class ApplicationUser: IdentityUser

    {   
        [Display(Name ="Full name")]
        public string FullName { get; set; }


    }
}
