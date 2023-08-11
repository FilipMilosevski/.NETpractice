using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Data
{
    public class Project1DbContext :DbContext
    {
       
        public Project1DbContext(DbContextOptions options) : base(options) 
        {  
        }
        public virtual DbSet<Card> Cards { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>(entity =>
            {
                entity.Property(e => e.CardID).ValueGeneratedOnAdd();
                entity.HasKey(e => e.CardID);
            }
            );
        }
    }
}
