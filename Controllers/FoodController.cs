using Microsoft.AspNetCore.Mvc;

namespace FoodAndCore.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
