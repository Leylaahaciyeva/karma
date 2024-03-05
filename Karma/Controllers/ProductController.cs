using Microsoft.AspNetCore.Mvc;

namespace Karma.Controllers
{
	public class ProductController : Controller
    {
        public async Task<IActionResult> Details()
        {
            return View();
        }
    }
}

