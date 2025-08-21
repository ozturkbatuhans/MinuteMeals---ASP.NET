using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinuteMeals.Data;
using MinuteMeals.Models;
using System.Threading.Tasks;




namespace MinuteMeals.Controllers
{
    public class ManageController : Controller
    {
        private readonly RecipeDbContext _context;

        public ManageController(RecipeDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var recipes = await _context.Recipes.ToListAsync();
            return View(recipes);
        }
    }
}
