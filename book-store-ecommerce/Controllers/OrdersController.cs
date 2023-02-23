using book_store_ecommerce.Data.Cart;
using book_store_ecommerce.Data.Services;
using book_store_ecommerce.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace book_store_ecommerce.Controllers
{
    public class OrdersController : Controller
    {

        private readonly IBooksService _booksService;
        private readonly ShoppingCart _shoppingCart;
        public OrdersController(IBooksService booksService, ShoppingCart shoppingCart) 
        {
            _booksService= booksService;
            _shoppingCart= shoppingCart;
        }
        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();

            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal(),
            };

            return View(response);
        }

        public async Task<RedirectToActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _booksService.GetBookByIdAsync(id);

            if(item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
    }
}
