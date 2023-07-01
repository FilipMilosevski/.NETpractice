using LoginProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject
{
    public class LoginContext : DbContext
    {
        public DbSet<User> users { get; set; } 
        public DbSet<Role> roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($" Filename =   {Path.Combine(Environment.CurrentDirectory,"MyLogin.db")}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(r => r.Role)
                .WithMany(p => p.Users)
                .HasForeignKey(p => p.Ref_RoleID);
               
        }
    }
}
