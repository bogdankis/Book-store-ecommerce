
using book_store_ecommerce.Data.Cart;
using Microsoft.AspNetCore.Mvc;

namespace book_store_ecommerce.Data.ViewModels
{
    public class ShoppingCartVM
    {

        public ShoppingCart ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }
    }
}
