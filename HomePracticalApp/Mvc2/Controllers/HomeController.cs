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
                 Products: _context.Products.ToList()
                 );
            return View(model);
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