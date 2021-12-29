using book_store_ecommerce.Models;

namespace book_store_ecommerce.Data.Services
{
    public interface IWritersService
    {
        Task<IEnumerable<Writer>> GetAllAsync(); //  async implementation
        Task<Writer> GetByIdAsync(int id);
        Task AddAsync(Writer writer);
        Writer Update(int id, Writer newWriter);
        void Delete(int id);
    }
}
