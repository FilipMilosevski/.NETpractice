using Microsoft.AspNetCore.Mvc;
using Mvc2.Models;
using Mvc2.MyFolder;
using System.Diagnostics;

namespace Mvc2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly F123NorthwindContext _context;

        public HomeController(ILogger<HomeController> logger,F123NorthwindContext injectedContext)
        {
            _logger = logger;
            _context = injectedContext;
        }

        public IActionResult Index()
        {
            HomeIndexViewModel model = new HomeIndexViewModel(
                 VisitorCount: Random.Shared.Next(1, 100),
                 Categories: _context.Categories.ToList(),
                 Products: _context.Products.ToList(),
                 Suppliers: _context.Suppliers.ToList(),
                 Employees: _context.Employees.ToList(),
                 Orders: _context.Orders.ToList(),
                 OrderDetails: _context.OrderDetails.ToList(),
                 Customers: _context.Customers.ToList(),
                 Shippers: _context.Shippers.ToList()
                 );
            return View(model);
        }
        public IActionResult ProductDetail(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest("You must pass a product ID in the route, for example, /Home/ProductDetail/21");
            }
            Product product = _context.Products.SingleOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound($"ProductId {id} not found.");
            }
            return View(product);
        }

        public IActionResult Privacy()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}