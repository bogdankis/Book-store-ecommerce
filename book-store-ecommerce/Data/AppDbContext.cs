using Microsoft.EntityFrameworkCore;

namespace book_store_ecommerce.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Writer_Book>().HasKey( wb => new
            {
                wb.WriterId,
            });

            base.OnModelCreating(modelBuilder); // necessary for generating default autetification tables
        
        }
    }
}
