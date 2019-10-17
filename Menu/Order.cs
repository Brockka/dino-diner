using System;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Items that have been added to the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }

        public double SubtotalCost { get; }

        public double SalesTaxRate { get; protected set; }

        public double SalesTaxCost { get; }

        public double TotalCost { get; }
    }
}
