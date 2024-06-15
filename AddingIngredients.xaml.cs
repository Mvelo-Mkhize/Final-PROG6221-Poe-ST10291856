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
    /// Interaction logic for EnterIngredientWindow.xaml
    /// This window allows the user to enter details for a new ingredient.
    /// </summary>
    public partial class EnterIngredientWindow : Window
    {
        // Recipe object to which the ingredient will be added
        private Recipes recipe;
        // Ingredient number for display purposes
        private int ingredientNumber;

        // Constructor to initialize the window with the recipe and ingredient number
        public EnterIngredientWindow(Recipes recipe, int number)
        {
            InitializeComponent(); // Initialize the UI components
            this.recipe = recipe; // Assign the recipe to the class-level variable
            ingredientNumber = number; // Assign the ingredient number
            Title = $"Enter Ingredient {number} Details"; // Set the window title
        }

        // Event handler for the Add Ingredient button click
        private void AddIngredientButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the ingredient details from the text boxes
            string name = IngredientNameTextBox.Text;
            double quantity, calories;
            string unit = UnitTextBox.Text;
            string foodGroup = FoodGroupTextBox.Text;

            // Check if the input values are valid
            if (string.IsNullOrEmpty(name) || !double.TryParse(QuantityTextBox.Text, out quantity) || !double.TryParse(CaloriesTextBox.Text, out calories))
            {
                // Show an error message if the input values are not valid
                MessageBox.Show("Please enter valid details.", "Error");
                return; // Exit the method
            }

            // Add the new ingredient to the recipe
            recipe.AddIngredient(name, quantity, unit, calories, foodGroup);
            Close(); // Close the current window
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
