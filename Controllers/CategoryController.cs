using Microsoft.AspNetCore.Mvc;

namespace FoodAndCore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
