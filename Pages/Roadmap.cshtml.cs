using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PlanKryptoWeb.Pages;

public class RoadmapModel : PageModel
{
    public void OnGet()
    {
        ViewData["Title"] = "Roadmap";
    }
}
