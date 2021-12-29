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
        public async Task AddAsync(Writer writer)
        {
           await _context.Writers.AddAsync(writer);
           await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Writer>> GetAllAsync()
        {
            var result = await _context.Writers.ToListAsync();
            return result;
        }

        public async Task<Writer> GetByIdAsync(int id)
        {
            var results = await _context.Writers.FirstOrDefaultAsync(n => n.Id == id);
            return results;
        }

        public Writer Update(int id, Writer newWriter)
        {
            throw new NotImplementedException();
        }
    }
}
