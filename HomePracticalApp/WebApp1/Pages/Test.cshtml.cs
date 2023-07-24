using Filip;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebApp1.Pages
{
    public class TestModel : PageModel
    {
        public IEnumerable<string>? Tests { get; set; }



        public void OnGet()
        {
            ViewData["Title"] = "TEST NOW";
            Tests = new[] { "History", "Law", "Economy","Sport","Travel" };
        }
      
      
    }
}
