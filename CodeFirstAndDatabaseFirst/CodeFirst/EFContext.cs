using CodeFirst.Categories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class EFContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }  
        public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustomerNew> CustomerNews { get; set; }


        

        private const string connectionString = "Server=.;Database=MyCodeFirst;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;";


        //private const string connectionString = "Server=.;Database=MyCodeFirst;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
