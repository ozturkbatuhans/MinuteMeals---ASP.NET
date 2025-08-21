using Microsoft.EntityFrameworkCore;
using MinuteMeals.Models;


namespace MinuteMeals.Data
{
    public class RecipeDbContext : DbContext
    {

        public RecipeDbContext(DbContextOptions<RecipeDbContext> options) : base(options) { }

        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe { Id = 1, Name = "Spaghetti Carbonara", Ingredients = "Pasta, Eggs, Bacon, Parmesan", Steps = "Boil pasta, cook bacon, mix eggs with cheese, combine everything.", CookingTimeInMinutes = 20 },
                new Recipe { Id = 2, Name = "Greek Salad", Ingredients = "Cucumber, Tomato, Onion, Feta Cheese, Olives", Steps = "Chop vegetables, mix with feta and olives, add olive oil.", CookingTimeInMinutes = 10 },
                new Recipe { Id = 3, Name = "Chicken Curry", Ingredients = "Chicken, Onion, Garlic, Curry Powder, Coconut Milk", Steps = "Sauté onions and garlic, add chicken, add curry powder and coconut milk, simmer.", CookingTimeInMinutes = 30 },
                new Recipe { Id = 4, Name = "French Toast", Ingredients = "Bread, Eggs, Milk, Sugar, Cinnamon", Steps = "Dip bread in egg mixture, cook on pan until golden brown.", CookingTimeInMinutes = 15 },
                new Recipe { Id = 5, Name = "Tomato Soup", Ingredients = "Tomatoes, Onion, Garlic, Basil, Cream", Steps = "Sauté onions and garlic, add tomatoes, blend and simmer with basil.", CookingTimeInMinutes = 25 },
                new Recipe { Id = 6, Name = "Grilled Cheese Sandwich", Ingredients = "Bread, Cheese, Butter", Steps = "Butter bread, add cheese, grill until golden brown.", CookingTimeInMinutes = 10 },
                new Recipe { Id = 7, Name = "Pancakes", Ingredients = "Flour, Milk, Eggs, Sugar, Baking Powder", Steps = "Mix ingredients, pour on pan, flip when bubbly.", CookingTimeInMinutes = 15 },
                new Recipe { Id = 8, Name = "Omelette", Ingredients = "Eggs, Cheese, Ham, Vegetables", Steps = "Whisk eggs, cook in pan, add toppings, fold.", CookingTimeInMinutes = 10 },
                new Recipe { Id = 9, Name = "Lasagna", Ingredients = "Pasta, Ground Beef, Tomato Sauce, Cheese", Steps = "Layer pasta, beef, sauce, and cheese, bake.", CookingTimeInMinutes = 45 },
                new Recipe { Id = 10, Name = "Chocolate Cake", Ingredients = "Flour, Cocoa, Sugar, Eggs, Butter", Steps = "Mix ingredients, bake in oven, cool and serve.", CookingTimeInMinutes = 40 }
            );
        } 
        
        
    }
}
