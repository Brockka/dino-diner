/*  MezzorellaSticks.cs
*   Author: Brock Kaufmann
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// MezzorellaSticks menu item
    /// </summary>
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Overrides the base class list of ingredients with the ones specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Breading", "Cheese Product", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// Creates a private size field
        /// </summary>
        private Size size;

        /// <summary>
        /// Overrides the base class size to provide the price and calories associated with this menu item
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                }

            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Public constructor that initializes the default calories and price (size small)
        /// </summary>
        public MezzorellaSticks()
        {
            this.Price = .99;
            this.Calories = 540;
        }
    }
}
