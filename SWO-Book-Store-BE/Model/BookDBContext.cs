using Microsoft.EntityFrameworkCore;

namespace SWO_Book_Store_BE.Model
{
    public class BookDBContext:DbContext
    {
        public BookDBContext(DbContextOptions<BookDBContext> options) : base(options)
        {

        }
        public DbSet<BookModel> BookModel { get; set; }
    }
}
