/*  Water.cs
*   Author: Brock Kaufmann
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink, IMenuItem
    {
        /// <summary>
        /// Gets and sets whether there is lemon or not
        /// </summary>
        public bool Lemon{ get; set; }

        /// <summary>
        /// Overrides the base class list of ingredients with the ones specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> list = new List<string>() { "Water" };
                if (Lemon)
                {
                    list.Add("Lemon");
                }
                return list;
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
            }
            get { return size; }

        }

        /// <summary>
        /// Public constructor that initializes the default calories and price (size small)
        /// </summary>
        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;
        }

        /// <summary>
        /// Method to add lemon to drink
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        /// <summary>
        /// Overriden ToString() for Water class
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
            s += "Water";
            return s;
        }
    }
}
