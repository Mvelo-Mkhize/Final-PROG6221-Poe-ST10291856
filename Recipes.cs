using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_ST10291856_Poe
{
    // Recipes class represents a recipe containing a name and a list of ingredients
    public class Recipes
    {
        // Public property to get or set the name of the recipe
        public string Name { get; set; }

        // Private list to store ingredients for the recipe
        private List<Ingredient> ingredients = new List<Ingredient>();

        // Method to add an ingredient to the recipe
        public void AddIngredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            // Create a new Ingredient object and add it to the list
            ingredients.Add(new Ingredient(name, quantity, unit, calories, foodGroup));
        }

        // Method to display the recipe details to the console
        public void DisplayRecipe()
        {
            Console.WriteLine($"Recipe: {Name}");
            // Loop through each ingredient and display its details
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }
        }

        // Override the ToString method to return the recipe name
        public override string ToString()
        {
            return Name;
        }

        // Method to get a list of ingredient details as strings
        public List<string> GetIngredients()
        {
            // Create a list to store ingredient details
            List<string> ingredientDetails = new List<string>();
            // Loop through each ingredient and add its details to the list
            foreach (var ingredient in ingredients)
            {
                ingredientDetails.Add(ingredient.ToString());
            }
            return ingredientDetails; // Return the list of ingredient details
        }
    }

    // Ingredient class represents an ingredient with properties like name, quantity, unit, calories, and food group
    public class Ingredient
    {
        // Public properties to get or set the ingredient's details
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public double Calories { get; set; }
        public string FoodGroup { get; set; }

        // Private field to store the original quantity of the ingredient
        private double originalQuantity;

        // Constructor to initialize the Ingredient object with given values
        public Ingredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Calories = calories;
            FoodGroup = foodGroup;
            originalQuantity = quantity; // Set the original quantity
        }

        // Override the ToString method to return a formatted string representing the ingredient
        public override string ToString()
        {
            return $"{Name}: {Quantity} {Unit}, {Calories} calories, {FoodGroup}";
        }
    }
}
