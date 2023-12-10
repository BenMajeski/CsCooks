using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace CsKitchen.Models
{
    public class AdminContext : DbContext
    {
        public AdminContext(DbContextOptions<RecipeContext> options) : base(options) { }

        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
                new Admin
                {
                    userId = 2,
                    userName = "testAdminr",
                    userPassword = "testP@ssword",
                    userEmail = "testemail2@gmail.com"
                });
        }
    }
}
