using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace CsKitchen.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<RecipeContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
                new User
                {
                    userId = 1,
                    userName = "testUser",
                    userPassword = "testP@ssword",
                    userEmail = "testemail@gmail.com"
    });
        }
    }
}
