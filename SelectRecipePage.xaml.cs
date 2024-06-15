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
    /// Interaction logic for ChooseRecipeWindow.xaml
    /// This window allows the user to choose a recipe from a list and view its details.
    /// </summary>
    public partial class ChooseRecipeWindow : Window
    {
        // List to store recipes
        private List<Recipes> recipes;

        // RecipeManager to handle recipe operations
        private RecipeManager recipeHandler;

        // Constructor to initialize the window with the list of recipes from RecipeManager
        public ChooseRecipeWindow(RecipeManager handler)
        {
            InitializeComponent(); // Initialize the UI components
            recipeHandler = handler; // Assign the handler to the class-level variable
            recipes = new List<Recipes>(recipeHandler.GetRecipes()); // Get recipes from handler and store in the list
            ChooseRecipeListBox.ItemsSource = recipes; // Set the ListBox's item source to the list of recipes
        }

        // Event handler for when the Select Recipe button is clicked
        private void SelectRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Check if the selected item is a recipe
            if (ChooseRecipeListBox.SelectedItem is Recipes selectedRecipe)
            {
                selectedRecipe.DisplayRecipe(); // Display the selected recipe details
            }
            else
            {
                // Show an error message if no recipe is selected
                MessageBox.Show("Please select a recipe.", "Error");
            }
        }

        // Event handler for when the Home button is clicked
        private void Homebtn(object sender, RoutedEventArgs e)
        {
            this.Hide(); // Hide the current window
            MainWindow window = new MainWindow(); // Create a new instance of the main window
            window.Show(); // Show the main window
        }
    }
}
