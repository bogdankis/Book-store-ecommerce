using book_store_ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace book_store_ecommerce.Data.Services
{
    public class WritersService : IWritersService
    {
        private readonly AppDbContext _context;
        public WritersService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Writer writer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Writer>> GetAll()
        {
            var result = await _context.Writers.ToListAsync();
            return result;
        }

        public Writer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Writer Update(int id, Writer newWriter)
        {
            throw new NotImplementedException();
        }
    }
}
