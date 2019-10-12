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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Initializes form
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dynamically displays different button options
        /// </summary>
        /// <param name="sender">button that was pushed</param>
        /// <param name="args"></param>
        private void DrinkSelected(object sender, RoutedEventArgs args)
        {
            if (sender.Equals(SodaButton))
            {
                Sweet.Visibility = Visibility.Collapsed;
                Lemon.Visibility = Visibility.Collapsed;
                Decaf.Visibility = Visibility.Collapsed;
                Flavor.Visibility = Visibility.Visible;
            }
            if (sender.Equals(TeaButton))
            {
                Flavor.Visibility = Visibility.Collapsed;
                Decaf.Visibility = Visibility.Collapsed;
                Sweet.Visibility = Visibility.Visible;
                Lemon.Visibility = Visibility.Visible;
            }
            if (sender.Equals(JavaButton))
            {
                Sweet.Visibility = Visibility.Collapsed;
                Lemon.Visibility = Visibility.Collapsed;
                Flavor.Visibility = Visibility.Collapsed;
                Decaf.Visibility = Visibility.Visible;
            }
            if (sender.Equals(WaterButton))
            {
                Sweet.Visibility = Visibility.Collapsed;
                Flavor.Visibility = Visibility.Collapsed;
                Decaf.Visibility = Visibility.Collapsed;
                Lemon.Visibility = Visibility.Visible;
            }

        }

        /// <summary>
        /// Selects flavor
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void ChooseFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
