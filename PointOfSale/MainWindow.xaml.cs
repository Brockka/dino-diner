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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes form
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Order order = (Order)DataContext;
            order.Items.Add(new Fryceritops());
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.HoldIce();
            tea.Size = DinoDiner.Menu.Size.Medium;
            order.Items.Add(tea);
        }

        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            SetFrameDataContext();
        }

        public void OnDataContextChanged(object sender, NavigationEventArgs args)
        {
            SetFrameDataContext();
        }

        private void SetFrameDataContext()
        {
            FrameworkElement content = OrderInterface.Content as FrameworkElement;
            if (content == null) return;
            content.DataContext = OrderInterface.DataContext;
        }
    }
}
