using Microsoft.EntityFrameworkCore;
using BookStore.Models;

namespace BookStore.Data
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext() 
        {}

        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) 
            : base(options) 
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category> Categories { get; set; }
    }
}
