using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace CsKitchen.Models
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options) { }

        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    recipeId = 1,
                    recipeName = "Peanut Butter & Jelly Sandwich",
                    authorName = "John Doe",
                    ingredients = "2 slices of bread; One tablespoon of peanut butter, One tablespoon of jelly" ,
                    directions = "Spread peanut butter using a butter knife; Spread jelly using butter knife" 
                
                },
                new Recipe
                {
                    recipeId = 2,
                    recipeName = "Peanut Butter Toast",
                    authorName = "Jane Doe",
                    ingredients = "2 slices of bread; Two tablespoons of peanut butter" ,
                    directions = "Toast bread until golden brown; Spread peanut butter using butter knife"

                });
        }
    }
}