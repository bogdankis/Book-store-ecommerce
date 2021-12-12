using book_store_ecommerce.Models;

namespace book_store_ecommerce.Data.Services
{
    public interface IWritersService
    {
        Task<IEnumerable<Writer>> GetAll(); // fir async implementation
        Writer GetById(int id);
        void Add(Writer writer);
        Writer Update(int id, Writer newWriter);
        void Delete(int id);
    }
}
