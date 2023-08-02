using Mvc2.MyFolder;

namespace Mvc2.Models
{
    public record HomeIndexViewModel
    (
        int VisitorCount,
        IList<Category> Categories,
        IList<Product> Products,
        IList<Customer> Customers,
        IList<Employee> Employees,
        IList<Order> Orders,
        IList<OrderDetail> OrderDetails,
        IList<Shipper> Shippers,
        IList<Supplier> Suppliers
    );
}
