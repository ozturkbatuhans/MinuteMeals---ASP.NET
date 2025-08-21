using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinuteMeals.Data;
using MinuteMeals.Models;
using System.Threading.Tasks;



namespace MinuteMeals.Controllers
{
    public class RecipesController : Controller 
    {

        private readonly RecipeDbContext _context;

        public RecipesController(RecipeDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var recipes = await _context.Recipes.ToListAsync();
            return View(recipes);
        }

        public async Task<IActionResult> Details(int id)
        {
            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe == null) return NotFound();
            return View(recipe);
        }
    }
}
