using book_store_ecommerce.Data.Base;
using book_store_ecommerce.Data.ViewModels;
using book_store_ecommerce.Models;

namespace book_store_ecommerce.Data.Services
{
    public interface IBooksService: IEntityBaseRepository<Book>
    {
        Task<Book> GetBookByIdAsync(int id);
        Task<NewBookDropdownsVM> GetNewBookDropdownsValues();
        Task AddNewBookAsync(NewBookVM data);
        Task UpdateBookAsync(NewBookVM data);
    }
}
