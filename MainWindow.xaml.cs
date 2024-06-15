using PROG6221_ST10291856_Poe;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Final_PROG6221_Poe_ST10291856
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Viewbtn(object sender, RoutedEventArgs e)
        {
            MainWindow2 window = new MainWindow2();
            window.Show();
        }
    }
}