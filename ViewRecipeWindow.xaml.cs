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
    /// Interaction logic for ViewRecipeWindow.xaml
    /// This window is used to display and view the details of recipes.
    /// </summary>
    public partial class ViewRecipeWindow : Window
    {
        // List to store recipes
        private List<Recipes> recipes;

        // Constructor to initialize the window with the list of recipes from RecipeManager
        public ViewRecipeWindow(RecipeManager handler)
        {
            InitializeComponent(); // Initialize the UI components
            recipes = new List<Recipes>(handler.GetRecipes()); // Get recipes from handler and store in the list
            RecipesListBox.ItemsSource = recipes; // Set the ListBox's item source to the list of recipes
        }

        // Event handler for when the selection in the ListBox changes
        private void RecipesListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Check if the selected item is a recipe
            if (RecipesListBox.SelectedItem is Recipes selectedRecipe)
            {
                // Display a message box showing the recipe details
                MessageBox.Show(selectedRecipe.ToString() + "\n" + string.Join("\n", selectedRecipe.GetIngredients()), "Recipe Details");
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
