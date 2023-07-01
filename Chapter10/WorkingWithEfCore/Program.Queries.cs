using Microsoft.EntityFrameworkCore;
using Packt.Shared;

partial class Program
{
    static void QueryingCategories()
    {
        using (Northwind db = new Northwind())
        {
            SectionTitle("Categories and how many products they have");
            // a querry to get all categories and their related products
            IQueryable<Category> categories = db.Categories?.Include(c => c.Products);

            if ((categories is null) || (!categories.Any()))
            {
                Fail("No categories found");
                return;
            }
            foreach (Category category in categories)
            {
                WriteLine($"{category.CategoryName} has {category.Products.Count} products ");
                WriteLine("They have");
                foreach (Product product in category.Products)
                {
                    WriteLine($"   *   {product.ProductName}");
                }
            }


        }
    }

    static void QueryingProducts()
    {
        using (Northwind db = new Northwind())
        {
            SectionTitle("Products name and their categort name");
            IQueryable<Product> products = db.Products?.Include(product => product.Category);
            if ((products is null) || (!products.Any()))
            {
                Fail("No products found!");
                return;
            }
            foreach (Product pro in products)
            {
                WriteLine($"{pro.ProductName} is in {pro.Category.CategoryName} category");

            }
        }
    }

}
