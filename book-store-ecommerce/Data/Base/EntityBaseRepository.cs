using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace book_store_ecommerce.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        // created configuration for writers

        private readonly AppDbContext _context;
        
        public EntityBaseRepository(AppDbContext context)  // inject db context in constructor
        {
            
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync(); //saves to database new writer
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entitytEntry = _context.Entry<T>(entity);
            entitytEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync(); //saves to database deleted writer
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await _context.Set<T>().ToListAsync();
            return result;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity); // returns an instance for a given entity instance.
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync(); //saves to database modified writer

        }
    }
}
