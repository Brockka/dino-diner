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
                Cream.Visibility = Visibility.Collapsed;
                Sweet.Visibility = Visibility.Collapsed;
                Lemon.Visibility = Visibility.Collapsed;
                Decaf.Visibility = Visibility.Collapsed;
                Flavor.Visibility = Visibility.Visible;
            }
            if (sender.Equals(TeaButton))
            {
                Cream.Visibility = Visibility.Collapsed;
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
                Cream.Visibility = Visibility.Visible;
            }
            if (sender.Equals(WaterButton))
            {
                Cream.Visibility = Visibility.Collapsed;
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

        /// <summary>
        /// Sets size to small
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void MakeSizeSmall(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Sets size to medium
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void MakeSizeMedium(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Sets size to large
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void MakeSizeLarge(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Makes tyrannotea sweet
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void MakeSweet(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Adds Lemon to drink
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void AddLemon(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Holds ice from drink
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void RemoveIce(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Adds ice from drink
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void AddIce(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Makes drink decaf
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void MakeDecaf(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Leaves room for cream in Jurassic Java
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void LeaveRoomForCream(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
