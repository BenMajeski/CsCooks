using CsKitchen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CsKitchen.Controllers
{
    public class HomeController : Controller
    {
        private RecipeContext context { get; set; }
        public HomeController(RecipeContext ctx) => context = ctx;
        

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubmitRecipe(Recipe newRecipe)
        {
            if (ModelState.IsValid)
            {
                context.Recipes.Add(newRecipe);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Index", newRecipe);
        }

        [HttpGet]
        public IActionResult SeeRecipe()
        {
            var allRecipes = context.Recipes.ToList();
            return View(allRecipes);
        }

    }
}