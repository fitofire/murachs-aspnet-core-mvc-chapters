using Microsoft.AspNetCore.Mvc;

namespace Ch03_Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
