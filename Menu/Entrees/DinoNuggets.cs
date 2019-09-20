/*  DinoNuggets.cs
*   Author: Brock Kaufmann
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Number of nuggets being ordered (default 6)
        /// </summary>
        private int nuggetCount = 6;

        /// <summary>
        /// Overrides the base class list of ingredients with the ones specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                for (int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }


        /// <summary>
        /// Constructs DinoNuggets menu item with calories and price
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }

        /// <summary>
        /// Adds a nugget to the order and updates calories, price and nuggetCount
        /// </summary>
        public void AddNugget()
        {
            nuggetCount++;
            Price += .25;
            Calories += 59;
        }

    }
}
