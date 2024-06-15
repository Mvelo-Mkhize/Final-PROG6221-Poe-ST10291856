using Final_PROG6221_Poe_ST10291856;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PROG6221_ST10291856_Poe
{
    /// <summary>
    /// Interaction logic for EnterRecipeWindow.xaml
    /// This window allows the user to enter details for a new recipe.
    /// </summary>
    public partial class EnterRecipeWindow : Window
    {
        // RecipeManager to handle recipe operations
        private RecipeManager recipeHandler;

        // Constructor to initialize the window with the RecipeManager
        public EnterRecipeWindow(RecipeManager handler)
        {
            InitializeComponent(); // Initialize the UI components
            recipeHandler = handler; // Assign the handler to the class-level variable
        }

        // Event handler for the Add Ingredients button click
        private void AddIngredientsButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the recipe name from the text box
            string recipeName = RecipeNameTextBox.Text;
            int numIngredients;

            // Check if the recipe name is valid and the number of ingredients is a valid integer
            if (string.IsNullOrEmpty(recipeName) || !int.TryParse(NumIngredientsTextBox.Text, out numIngredients))
            {
                // Show an error message if the input values are not valid
                MessageBox.Show("Please enter valid details.", "Error");
                return; // Exit the method
            }

            // Create a new Recipes object with the given name
            Recipes recipe = new Recipes { Name = recipeName };

            // Loop to enter details for the specified number of ingredients
            for (int i = 0; i < numIngredients; i++)
            {
                // Create and show the EnterIngredientWindow to input ingredient details
                EnterIngredientWindow enterIngredientWindow = new EnterIngredientWindow(recipe, i + 1);
                enterIngredientWindow.ShowDialog();
            }

            // Add the new recipe to the RecipeManager
            recipeHandler.AddRecipe(recipe);
            // Show a success message
            MessageBox.Show("Recipe details entered successfully.", "Success");
            // Close the current window
            Close();
        }

        // Event handler for the Home button click
        private void Homebtn(object sender, RoutedEventArgs e)
        {
            this.Hide(); // Hide the current window
            MainWindow window = new MainWindow(); // Create a new instance of the main window
            window.Show(); // Show the main window
        }
    }
}
