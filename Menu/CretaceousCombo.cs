/*  CretaceousCombo.cs
*   Author: Brock Kaufmann
*/

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem
    {
        public Entree Entree { get; set; }
        public Drink Drink { get; set; }
        public Side Side { get; set; }

        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set{
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
            }
        }

        /// <summary>
        /// Gets price of combo
        /// </summary>
        public double Price
        {
            get
            {
                return Drink.Price + Side.Price + Entree.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets calories of combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Drink.Calories + Side.Calories + Entree.Calories;
            }
        }

        /// <summary>
        /// Gets ingredients for combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        /// <summary>
        /// Overriden ToString() for CretaceousCombo class
        /// </summary>
        /// <returns>returns name of menu item as a string</returns>
        public override string ToString()
        {
            return (Entree.ToString() + " Combo");
        }

    }
}
