using Microsoft.AspNetCore.Mvc;
using Mvc1.Models;
using Mvc1.MyFolder;
using Northwind.Mvc.Models;
using System.Diagnostics;

namespace Mvc1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly SimpleDbgegoraphyContext _context;


        public HomeController(ILogger<HomeController> logger, SimpleDbgegoraphyContext injectedContext)
		{
			_logger = logger;
			_context = injectedContext;
		}
		 
		public IActionResult Index()
		{
			HomeIndexViewModel model = new HomeIndexViewModel(

				VisitorCount: Random.Shared.Next(1, 100),
				Countries: _context.Countries.ToList(),
				CountryStats: _context.CountryStats.ToList()

			) ;
			

            return View(model);
		} 

		public IActionResult Privacy()
		{
			return View();
		}
		public IActionResult Countries1()
		{
			HomeIndexViewModel model = new HomeIndexViewModel(

				VisitorCount: Random.Shared.Next(1, 100),
				Countries: _context.Countries.ToList(),
				CountryStats: _context.CountryStats.ToList()
		);

            return View(model);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}