using FoodAndCore.Models.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace FoodAndCore.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository) 
        {
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var result =  _categoryRepository.GetAll().Data;
            return View(result);
        }
    }
}
