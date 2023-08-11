using Microsoft.EntityFrameworkCore;
using Project1.Data.Entities;
using Project1.Models;

namespace Project1.Data
{
    public class Project1DbContext :DbContext
    {
       
        public Project1DbContext(DbContextOptions options) : base(options)  {  }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<User> Users { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductReview>().HasKey(nameof(ProductReview.ProductID), nameof(ProductReview.UserID));

        }
    }
}
