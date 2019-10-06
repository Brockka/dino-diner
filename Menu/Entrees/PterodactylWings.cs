/*  PterodactylWings.cs
*   Author: Brock Kaufmann
*/
using System.Collections.Generic;


namespace DinoDiner.Menu
{

    /// <summary>
    /// Class for Pterodactly wings menu item
    /// </summary>
    public class PterodactylWings : Entree, IMenuItem
    {

        /// <summary>
        /// Overrides the base class list of ingredients with the ones specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Chicken", "Wing Sauce"};
            }

        }

        /// <summary>
        /// Constructor for PterodactylWings that sets price and calories
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// Overriden ToString() for PterodactylWings class
        /// </summary>
        /// <returns>returns name of menu item</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
