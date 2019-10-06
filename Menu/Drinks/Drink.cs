/*  Drink.cs
*   Author: Brock Kaufmann
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets whether there is ice or not
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Sets Ice to false
        /// </summary>
        public virtual void HoldIce()
        {
            Ice = false;
        }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }


    }
}
