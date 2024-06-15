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
    /// Interaction logic for IngredientWindow.xaml
    /// This window allows the user to input and save details for a new ingredient.
    /// </summary>
    public partial class IngredientWindow : Window
    {
        // Property to get the created Ingredient
        public Ingredient Ingredient { get; private set; }

        // Constructor to initialize the window
        public IngredientWindow()
        {
            InitializeComponent(); // Initialize the UI components
        }

        // Event handler for the Save Ingredient button click
        private void SaveIngredientButton_Click(object sender, RoutedEventArgs e)
        {
            // Attempt to parse the quantity and calories input by the user
            if (double.TryParse(QuantityTextBox.Text, out double quantity) &&
                double.TryParse(CaloriesTextBox.Text, out double calories))
            {
                // Create a new Ingredient object with the input values
                Ingredient = new Ingredient(IngredientNameTextBox.Text, quantity, UnitTextBox.Text, calories, FoodGroupTextBox.Text);
                DialogResult = true; // Set the dialog result to true to indicate success
            }
            else
            {
                // Show an error message if the input values are not valid
                MessageBox.Show("Please enter valid values for quantity and calories.");
            }
        }

        // Event handler for the Home button click
        private void Homebtn(object sender, RoutedEventArgs e)
        {
            this.Hide(); // Hide the current window
            MainWindow window = new MainWindow(); // Create a new instance of the main window
            window.Show(); // Show the main window
        }

        // Event handler for the Close button click
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close(); // Close the current window
        }
    }
}
