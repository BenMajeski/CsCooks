﻿// <auto-generated />
using CsKitchen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CsKitchen.Migrations
{
    [DbContext(typeof(RecipeContext))]
    [Migration("20231212072535_recipe")]
    partial class recipe
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CsKitchen.Models.Recipe", b =>
                {
                    b.Property<int>("recipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("recipeId"));

                    b.Property<string>("authorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("directions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ingredients")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("recipeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("recipeId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            recipeId = 1,
                            authorName = "John Doe",
                            directions = "Spread peanut butter using a butter knife; Spread jelly using butter knife",
                            ingredients = "2 slices of bread; One tablespoon of peanut butter, One tablespoon of jelly",
                            recipeName = "Peanut Butter & Jelly Sandwich"
                        },
                        new
                        {
                            recipeId = 2,
                            authorName = "Jane Doe",
                            directions = "Toast bread until golden brown; Spread peanut butter using butter knife",
                            ingredients = "2 slices of bread; Two tablespoons of peanut butter",
                            recipeName = "Peanut Butter Toast"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
