/*  SteakosaurusBurger.cs
*   Author: Brock Kaufmann
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Steakosaurus burger menu item
    /// </summary>
    public class SteakosaurusBurger : Entree, IMenuItem
    {
        /// <summary>
        /// Bool representing the bun
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Bool representing pickles
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Bool representing ketchup
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Bool representing mustard
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Overrides the base class list of ingredients with the ones specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                ingredients.Add("Steakburger Pattie");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for SteakosaurusBurger that sets price and calories
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Holds bun from list of ingredients 
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Holds pickle from list of ingredients
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Holds ketchup from list of ingredients
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Holds mustard from list of ingredients
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// Overriden ToString() for SteakosaurusBurger class
        /// </summary>
        /// <returns>returns name of menu item</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
