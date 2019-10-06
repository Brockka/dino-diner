/*  Brontowurst.cs
*   Modified by: Brock Kaufmann
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for Prehistoric PB & J menu item
    /// </summary>
    public class PrehistoricPBJ: Entree, IMenuItem
    {
        /// <summary>
        /// Bool representing peanut butter on the sandwich
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// Bool representing jelly on the sandwich
        /// </summary>
        private bool jelly = true;

        /// <summary>
        /// Overrides the base class list of ingredients with the ones specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for PrehistoricPBJ that sets the price and calories
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Removes peanutbutter from ingredients
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Removes jelly from ingredients
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }

        /// <summary>
        /// Overriden ToString() for PrehistotricPBJ class
        /// </summary>
        /// <returns>returns name of menu item</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

    }
}
