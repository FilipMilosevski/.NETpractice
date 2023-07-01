//using Packt.Shared;
//Northwind db = new Northwind();
//WriteLine($"Provider ={db.Database.ProviderName}");


using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Packt.Shared;
using System.Windows.Markup;

Northwind db = new Northwind();
WriteLine($"Provider: {db.Database.ProviderName}");



QueryingCategories();

QueryingProducts();

//var addResult1 = AddProduct(6, "Filip Burger", 500M);

//var addResult1 = IncreaseProductPrice("Filip", 20M);

var addResult1 = DeleteProduct("Filip");


//ovoj if e za add i increase
//if (addResult1.affected == 1) 
//{
//    WriteLine($"Added product succesfully with id: {addResult1.productId}");
//}

//ListProducts(new int[] { addResult1.productId });

if (addResult1 == 1)
{
    WriteLine($"Deleted product succesfully with that strats with Filip");
}
ListProducts();

ListProducts();

