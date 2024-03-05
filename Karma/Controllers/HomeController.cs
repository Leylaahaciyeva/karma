using Microsoft.AspNetCore.Mvc;

namespace Karma.Controllers;

public class HomeController : Controller
{
   public async Task<IActionResult> Index()
    {
        return View();
    }

    public async Task<IActionResult> Contact()
    {
        return View();
    }

    public async Task<IActionResult> Category()
    {
        return View();
    }
}

