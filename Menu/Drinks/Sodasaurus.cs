using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
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
    }
}
