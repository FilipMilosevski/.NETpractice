
using LinqWithEfCore;
using Microsoft.EntityFrameworkCore;

partial class Program
    {
    static void FilterAndSort()
    {
        SectionTitle("Filter and sort with DbSet<>");
        using(Northwind context = new Northwind())
        {
            DbSet<Product> allProducts = context.Products;
            IQueryable<Product> filterProducts = allProducts.Where(p => p.UnitPrice < 10M);
            IQueryable<Product> sortedFilteredProducts  = filterProducts.OrderByDescending(p => p.UnitPrice);
            foreach (Product p in sortedFilteredProducts)
            {
                WriteLine("{0}: {1} costs {2:$#,##0.00}", p.ProductId, p.ProductName, p.UnitPrice);
            }
            SectionTitle(sortedFilteredProducts.ToQueryString());

        }
    }
    static void FilterAndSortNew()
    {
        SectionTitle("Filter and sort with List<>");

        using (Northwind context = new Northwind())
        {
            List<Product> allProducts = context.Products.ToList();
            List<Product> filterProducts = allProducts.Where(p => p.UnitPrice < 10M).ToList();
            List<Product> sortFilterProducts = filterProducts.OrderByDescending(p => p.UnitPrice).ToList(); 
            foreach(Product p in sortFilterProducts)
            {
                WriteLine("{0}: {1} costs {2:$#,##0.00}", p.ProductId, p.ProductName, p.UnitPrice);
            }
        }
    }
    static void FilterAndSortQuery()
    {
        SectionTitle("Filter and sort with Query");

        using (Northwind context = new Northwind())
        {
            IQueryable<Product> products =
                from product in context.Products
                where product.UnitPrice < 10M
                orderby product.UnitPrice descending
                select product;
            foreach (Product p in products)
            {
                WriteLine("{0}: {1} costs {2:$#,##0.00}", p.ProductId, p.ProductName, p.UnitPrice);
            }
            SectionTitle(products.ToQueryString());
        }
    }

    }

