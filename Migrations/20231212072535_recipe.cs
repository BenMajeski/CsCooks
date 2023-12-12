using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CsKitchen.Migrations
{
    /// <inheritdoc />
    public partial class recipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    recipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ingredients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    directions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    recipeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.recipeId);
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "recipeId", "authorName", "directions", "ingredients", "recipeName" },
                values: new object[,]
                {
                    { 1, "John Doe", "Spread peanut butter using a butter knife; Spread jelly using butter knife", "2 slices of bread; One tablespoon of peanut butter, One tablespoon of jelly", "Peanut Butter & Jelly Sandwich" },
                    { 2, "Jane Doe", "Toast bread until golden brown; Spread peanut butter using butter knife", "2 slices of bread; Two tablespoons of peanut butter", "Peanut Butter Toast" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
