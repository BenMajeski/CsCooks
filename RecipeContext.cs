using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace CsKitchen.Models
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options) { }

        public DbSet<Recipe> Recipies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    recipeId = 1,
                    recipeName = "Peanut Butter & Jelly Sandwich",
                    authorName = "John Doe",
                    ingredients = new string[] { "2 slices of bread", "One tablespoon of peanut butter", "One tablespoon of jelly" },
                    instructions = new string[] {"Spread peanut butter using a butter knife", "Spread jelly using butter knife"}

                },
                new Recipe
                {
                    recipeId = 2,
                    recipeName = "Peanut Butter Toast",
                    authorName = "Jane Doe",
                    ingredients = new string[] { "2 slices of bread", "Two tablespoons of peanut butter" },
                    instructions = new string[] { "Toast bread until golden brown", "Spread peanut butter using butter knife" }

                });
}
    }
}
