using FoodAndCore.Models.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodAndCore.Controllers
{
    public class FoodController : Controller
    {
        IFoodRepository _foodRepository;
        public FoodController(IFoodRepository foodRepository) 
        {
            _foodRepository = foodRepository;
        }
        public IActionResult Index()
        {
            var result = _foodRepository.GetAll().Data;
            return View(result);
        }
    }
}
