using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PlanKryptoWeb.Pages;

public class AboutModel : PageModel
{
    public void OnGet()
    {
        ViewData["Title"] = "About";
    }
}
