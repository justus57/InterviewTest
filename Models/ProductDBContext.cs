using Microsoft.EntityFrameworkCore;

namespace InterviewTest.Models
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {

        }
        public DbSet<ProductList> ProductList { get; set;}
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductList>().Property(b => b.ProductName).IsRequired();
        }
    }
}
