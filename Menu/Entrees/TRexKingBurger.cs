/*  TRexKingBurger.cs
*   Author: Brock Kaufmann
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// bool representing the bun
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// bool representing the lettuce
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// bool representing the tomato
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// bool representing the onion
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// bool representing the pickles
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// bool representing ketchup
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// bool representing mustard
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// bool representing mayo
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Overrides the base class list of ingredients with the ones specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                for (int i = 0; i < 3; i++)
                {
                    ingredients.Add("Steakburger Pattie");
                }
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs TRexKingBurger with specified price and calories 
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Holds the bun from ingredients
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Holds the onion from ingredients
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// Holds the tomato from ingredients
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        /// <summary>
        /// Holds the lettuce from ingredients
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Holds the pickles from ingredients
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Holds ketchup from ingredients
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Holds mayo from ingredients
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }

        /// <summary>
        /// Holds mustard from ingredients
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

    }
}
