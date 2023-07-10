
using Microsoft.EntityFrameworkCore;
using Packt.Shared;

partial class Program
{
    static void ShipFilter()
    {
        SectionTitle("Filter all in Shippers");
        using (FilipsContext db = new FilipsContext())
        {
            DbSet<Shipper> allShips = db.Shippers;

            foreach (Shipper ships in allShips)
            {
                WriteLine("{0} : {1} : {2}", ships.ShipperId, ships.ShipperName, ships.Phone);
            }
        }
    }
    static void CategoryFilter()
    {
        SectionTitle("Filter CategoryName and Description");
        using (FilipsContext db = new FilipsContext())
        {
            DbSet<Category> allCategories = db.Categories;
            foreach (Category category in allCategories)
            {
                WriteLine("{0} : {1}", category.CategoryName, category.Description);
            }
        }
    }
    static void EmployeeFilter()
    {
        SectionTitle("Filter with Where");
        using(FilipsContext db = new FilipsContext())
        {
            DbSet<Employee> allEmployees = db.Employees;
            IQueryable<Employee> filterEmployeees = allEmployees.Where(e => e.FirstName.Contains("a"));
            Console.WriteLine("FirstName    -    LastName    -    HireDate");
            foreach (Employee emp in filterEmployeees)
            {
                Console.WriteLine("{0} : {1,15} : {2,30}",emp.FirstName,emp.LastName, emp.BirthDate);
            }
        }
    }
    static void EmployeeFilter1()
    {
        SectionTitle("Filter Employee that have ID 5");
        using(FilipsContext db = new FilipsContext())
        {
            DbSet<Employee> allEmployees = db.Employees;
            IQueryable<Employee> filterEmployees = allEmployees.Where(e => e.EmployeeId == 5);
            Console.WriteLine("EmployeeID    -    FirstName    -    LastName");
            foreach (Employee emp in filterEmployees)
            {
                Console.WriteLine("{0,0} {1,20} {2,20}",emp.EmployeeId, emp.FirstName, emp.LastName);
            }
        }
    }
    static void SupplierFilter()
    {
        SectionTitle("Filter all suppliers from Germany");
        using(FilipsContext db = new FilipsContext())
        {
            DbSet<Supplier> allShips = db.Suppliers;
            IQueryable<Supplier> filterShips = allShips.Where(e => e.Country.Contains("usa"));
            foreach (Supplier sup in filterShips)
            {
                Console.WriteLine("{0}  {1}  {2}",sup.SupplierId,sup.SupplierName,sup.Country);
            }
        }
    }
}



    
