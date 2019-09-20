/*  Brontowurst.cs
*   Author: Brock Kaufmann
*/

using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Brontowurst menu item
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Bool representing the bun
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Bool representing the onion
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// Bool representing peanut the braut
        /// </summary>
        private bool braut = true;
        /// <summary>
        /// Bool representing the peppers
        /// </summary>
        private bool peppers = true;

        /// <summary>
        /// Overrides the base class list of ingredients with the ones specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (braut) ingredients.Add("Brautwurst");
                if (onion) ingredients.Add("Onion");
                if (peppers) ingredients.Add("Peppers");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for Brontowurst with price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Removes bun from ingredients
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Removes peppers from ingredients
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Removes onion from ingredients
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

    }
}