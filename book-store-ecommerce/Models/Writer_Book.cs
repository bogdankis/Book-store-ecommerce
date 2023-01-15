namespace book_store_ecommerce.Models
{
    public class Writer_Book
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int WriterId { get; set; }
        public Writer Writer { get; set; }

    }
}