/*  Order.cs
*   Author: Brock Kaufmann
*/
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

        /// <summary>
        /// Total price of all items in order
        /// </summary>
        public double SubtotalCost {
            get {
                if (SubtotalCost > 0) { return SubtotalCost; }
                else { return 0; }
            }
        }

        /// <summary>
        /// The sales tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// The additional costs associated with sales tax
        /// </summary>
        public double SalesTaxCost { get; }

        /// <summary>
        /// The total cost of the order including the price of the items and sales tax
        /// </summary>
        public double TotalCost { get; }
    }
}
