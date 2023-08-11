using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Index()
        {
            Card myCard = new Card();
            myCard.CardID = 1;
            myCard.Image = "myImg.jpg";
            myCard.Text = "Text example for a template card. Simple MVC project info.";
            myCard.AlternativeText = "image of a duck";
            myCard.Title = "Card example";

            return View(myCard);
        }
    }
}
