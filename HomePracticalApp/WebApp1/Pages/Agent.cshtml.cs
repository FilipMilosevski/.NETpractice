using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp1.Pages
{
    public class AgentModel : PageModel
    {
        public string AgentsFName { get; set; }
        public string AgentsLName { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Available Agents for rent";
            AgentsFName = "Filip";
        }
    }
}
