using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CsKitchen.Models
{
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int recipeId { get; set; }
      
        public string ingredients { get; set; } = string.Empty;
        
        public string directions { get; set; } = string.Empty;
        
        public string recipeName { get; set; } = string.Empty;
        public string authorName { get; set; } = string.Empty; 
        

    }
}