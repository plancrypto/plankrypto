using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PlanKryptoWeb.Pages;

public class IndexModel : PageModel
{
    public void OnGet()
    {
        ViewData["Title"] = "Home";
    }
}
