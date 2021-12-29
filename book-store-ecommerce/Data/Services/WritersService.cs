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

        public async Task DeleteAsync(int id)
        {
            var results = await _context.Writers.FirstOrDefaultAsync(n => n.Id == id);
            _context.Writers.Remove(results);
            await _context.SaveChangesAsync();
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

        public async Task<Writer> UpdateAsync(int id, Writer newWriter)
        {
             _context.Update(newWriter);
            await _context.SaveChangesAsync();
            return(newWriter);

        }
    }
}
