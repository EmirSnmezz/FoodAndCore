using Microsoft.AspNetCore.Mvc;

namespace FoodAndCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
