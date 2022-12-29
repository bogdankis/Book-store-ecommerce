using book_store_ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace book_store_ecommerce.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        { ////defines the shape of entities , the relationships between them, and how they map to the database

            modelBuilder.Entity<Writer_Book>().HasKey( wb => new 
            {
                wb.WriterId,
                wb.BookId

            });

            modelBuilder.Entity<Writer_Book>().HasOne(b => b.Book).WithMany(wb => wb.Writers_Books).HasForeignKey(b =>
            b.BookId);

            modelBuilder.Entity<Writer_Book>().HasOne(b => b.Writer).WithMany(wb => wb.Writers_Books).HasForeignKey(b =>
            b.WriterId);
            base.OnModelCreating(modelBuilder); // necessary for generating default autetification tables
            
        
        }

        public DbSet<Writer> Writers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Writer_Book> Writers_Books { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<PublishingHouse> PublishingHouses { get; set; }

    }
}
