﻿using book_store_ecommerce.Models;

namespace book_store_ecommerce.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);  // add orders to the database
        Task<List<Order>> GetOrdersByUserIdAsync(string userId);    // get all orders from database
    }
}
