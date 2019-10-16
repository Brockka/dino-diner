using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Order item interface
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Property to get price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Property to get description
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Property to get the modifications to the order (eg "Hold Mayo")
        /// </summary>
        string[] Special { get; }

    }
}
