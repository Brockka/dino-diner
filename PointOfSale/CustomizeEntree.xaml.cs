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
    /// Interaction logic for CustomizeEntree.xaml
    /// </summary>
    public partial class CustomizeEntree : Page
    {
        private Entree entree;

        public CustomizeEntree(Entree entree)
        {
            this.entree = entree;
            InitializeComponent();
        }

        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {

        }

        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {

        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
