using Filip;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppWithSqlDatabase.Pages
{
    public class CountryModel : PageModel
    {
        private SimpleDbgegoraphyContext db;
        public IEnumerable<Country>? Countries { get; set; }
        [BindProperty]
        public Country? Country { get; set; }   

        //PRV NACIN
        public CountryModel(SimpleDbgegoraphyContext injectedContext)
        {
            this.db = injectedContext;
        }

        //VTOR NACIN
        //public WorldModel(SimpleDbgegoraphyContext db)
        //{
        //    this.db = db;
        //}

        public void OnGet()
        {
            ViewData["Title"] = "World news today";

            Countries = db.Countries.OrderBy(s => s.CountryId).ThenBy(c => c.Name);
        }
        public IActionResult OnPost()
        {
            if ((Country is not null) && ModelState.IsValid)
            {
                db.Countries.Add(Country);
                db.SaveChanges();
                return RedirectToPage("/Countries");
            }
            else
            {
                return Page();
            }
        }
    }
}
