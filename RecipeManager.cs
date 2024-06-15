using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_ST10291856_Poe
{
    // RecipeManager class handles operations related to managing recipes
    public class RecipeManager
    {
        // Private list to store recipe objects
        private List<Recipes> recipes = new List<Recipes>();

        // Method to add a recipe to the list
        public void AddRecipe(Recipes recipe)
        {
            recipes.Add(recipe); // Add the given recipe to the list
        }

        // Method to retrieve all recipes from the list
        public IEnumerable<Recipes> GetRecipes()
        {
            return recipes; // Return the list of recipes
        }

        // Method to clear all data from the list
        public void ClearData()
        {
            recipes.Clear(); // Remove all recipes from the list
        }
    }
}
