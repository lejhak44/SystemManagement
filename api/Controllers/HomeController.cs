using Microsoft.AspNetCore.Mvc;

namespace ngJSApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
