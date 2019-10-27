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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        //Field for sodasaurus object
        Sodasaurus soda;

        /// <summary>
        /// Initializes form
        /// </summary>
        public FlavorSelection(Sodasaurus sodasaurus)
        {
            soda = sodasaurus;
            InitializeComponent();
        }

        /// <summary>
        /// Changes flavor of drink to cherry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void MakeCherry(object sender, RoutedEventArgs args)
        {
            soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Cherry;
            NavigationService.Navigate(new DrinkSelection(soda));
        }

        /// <summary>
        /// Changes flavor of drink to chocolate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void MakeChocolate(object sender, RoutedEventArgs args)
        {
            soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Chocolate;
            NavigationService.Navigate(new DrinkSelection(soda));
        }

        /// <summary>
        /// Changes flavor of drink to Lime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void MakeLime(object sender, RoutedEventArgs args)
        {
            soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Lime;
            NavigationService.Navigate(new DrinkSelection(soda));
        }

        /// <summary>
        /// Changes flavor of drink to vanilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void MakeVanilla(object sender, RoutedEventArgs args)
        {
            soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Vanilla;
            NavigationService.Navigate(new DrinkSelection(soda));
        }

        /// <summary>
        /// Changes flavor of drink to orange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void MakeOrange(object sender, RoutedEventArgs args)
        {
            soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Orange;
            NavigationService.Navigate(new DrinkSelection(soda));
        }

        /// <summary>
        /// Changes flavor of drink to Cola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void MakeCola(object sender, RoutedEventArgs args)
        {
            soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Cola;
            NavigationService.Navigate(new DrinkSelection(soda));
        }

        /// <summary>
        /// Changes flavor of drink to chocolate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void MakeRootbeer(object sender, RoutedEventArgs args)
        {
            soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.RootBeer;
            NavigationService.Navigate(new DrinkSelection(soda));
        }
    }
}
