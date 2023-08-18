using Microsoft.AspNetCore.Mvc;

namespace Assignment_ASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
