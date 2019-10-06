/*  Sodasaurus.cs
*   Author: Brock Kaufmann
*/
using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink, IMenuItem
    {
        /// <summary>
        /// Class for sodasaurus
        /// </summary>
        public SodasaurusFlavor Flavor;

        /// <summary>
        /// Overrides the base class list of ingredients with the ones specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }

        /// <summary>
        /// Creates a private size field
        /// </summary>
        private Size size;
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                }
            }
            get { return size; }
            
        }

        /// <summary>
        /// Public constructor that initializes the default calories and price (size small)
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
        }

        /// <summary>
        /// Overriden ToString() for Sodasaurus class
        /// </summary>
        /// <returns>returns name of menu item as a string</returns>
        public override string ToString()
        {
            string s;
            if (Size == Size.Small)
            {
                s = "Small ";
            }
            else if (Size == Size.Medium)
            {
                s = "Medium ";
            }
            else
            {
                s = "Large ";
            }
            switch (Flavor)
            {
                case SodasaurusFlavor.Cherry:
                    s += "Cherry ";
                    break;
                case SodasaurusFlavor.Chocolate:
                    s += "Chocolate ";
                    break;
                case SodasaurusFlavor.Cola:
                    s += "Cola ";
                    break;
                case SodasaurusFlavor.Orange:
                    s += "Orange ";
                    break;
                case SodasaurusFlavor.Lime:
                    s += "Lime ";
                    break;
                case SodasaurusFlavor.RootBeer:
                    s += "RootBeer ";
                    break;
                case SodasaurusFlavor.Vanilla:
                    s += "Vanilla ";
                    break;
            }
            s += "Sodasaurus";
            return s;
        }
    }
}
