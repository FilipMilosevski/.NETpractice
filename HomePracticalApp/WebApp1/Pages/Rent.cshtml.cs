using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp1.Pages
{
    public class RentModel : PageModel
    {
        public IEnumerable<string>? Rents { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "Available cars for rent";
            Rents = new[] { "Bmw","Audi","Mercedes","Honda","Toyota" };
        }
    }
}
