namespace CsKitchen.Models
{
    public class Recipe
    {
        public int recipeId { get; set; }
        // stores ingredients as a list of strings
        public string[] ingredients { get; set; }
        // stores instructions as a list of strings
        public string[] instructions { get; set; }
        // stores the name of the recipe
        public string recipeName { get; set; }
        public string authorName { get; set; }
    }
}