/*  VelociWrap.cs
*   Author: Brock Kaufmann
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// VelociWrap menu item
    /// </summary>
    public class VelociWrap : Entree, IMenuItem
    {
        /// <summary>
        /// bool representing dressing
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// bool representing lettuce
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// bool representing the cheese
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// Overrides the base class list of ingredients with the ones specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                ingredients.Add("Flour Tortilla");
                ingredients.Add("Chicken Breast");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs VelociWrap with specified price and calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Holds lettuce from the list of ingredients
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Holds dressing from list of ingredients
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Holds cheese from list of ingredients
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }

        /// <summary>
        /// Overriden ToString() for VelociWrap class
        /// </summary>
        /// <returns>returns name of menu item</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
