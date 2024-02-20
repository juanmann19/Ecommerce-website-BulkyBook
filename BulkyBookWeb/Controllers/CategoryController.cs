using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public CategoryController(ApplicationDBContext db)
        {
            _dbContext = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _dbContext.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
