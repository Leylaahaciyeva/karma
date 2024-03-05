using Microsoft.AspNetCore.Mvc;

namespace Karma.Controllers
{
	public class BlogController : Controller
    {
        public async Task<IActionResult> Blog()
        {
            return View();
        }

        public async Task<IActionResult> BlogDetails()
        {
            return View();
        }
    }
}

