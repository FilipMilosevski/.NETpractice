using Mvc2.MyFolder;
namespace Mvc2.Models
{
    public record HomeIndexViewModel
    (
         int VisitiorCount,
         IList<Customer> Customers,
         IList<Supplier> Suppliers
        
       
        
    );
}
