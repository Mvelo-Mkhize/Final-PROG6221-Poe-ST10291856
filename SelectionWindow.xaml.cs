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
    /// Interaction logic for MainWindow2.xaml
    /// This window provides the main interface for managing recipes.
    /// </summary>
    public partial class MainWindow2 : Window
    {
        // RecipeManager to handle recipe operations
        private RecipeManager recipeHandler;

        // Constructor to initialize the window and the RecipeManager
        public MainWindow2()
        {
            InitializeComponent(); // Initialize the UI components
            recipeHandler = new RecipeManager(); // Instantiate the RecipeManager
        }

        // Event handler for the Enter Recipe Details button click
        private void EnterRecipeDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            // Create and show the EnterRecipeWindow
            EnterRecipeWindow enterRecipeWindow = new EnterRecipeWindow(recipeHandler);
            enterRecipeWindow.Show();
            this.Hide(); // Hide the current window
        }

        // Event handler for the View Recipes button click
        private void ViewRecipesButton_Click(object sender, RoutedEventArgs e)
        {
            // Create and show the ViewRecipeWindow
            ViewRecipeWindow viewRecipesWindow = new ViewRecipeWindow(recipeHandler);
            viewRecipesWindow.Show();
            this.Hide(); // Hide the current window
        }

        // Event handler for the Choose Recipe button click
        private void ChooseRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Create and show the ChooseRecipeWindow
            ChooseRecipeWindow chooseRecipeWindow = new ChooseRecipeWindow(recipeHandler);
            chooseRecipeWindow.Show();
            this.Hide(); // Hide the current window
        }

        // Event handler for the Clear All Data button click
        private void ClearAllDataButton_Click(object sender, RoutedEventArgs e)
        {
            recipeHandler.ClearData(); // Clear all recipes from the RecipeManager
            MessageBox.Show("All data has been cleared.", "Clear All Data"); // Show a confirmation message
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
