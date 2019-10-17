/*  CretaceousCombo.cs
*   Author: Brock Kaufmann
*/

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Combo menu item
    /// </summary>
    public class CretaceousCombo : IMenuItem
    {
        /// <summary>
        /// Entree component of combo
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Drink component of combo
        /// </summary>
        public Drink Drink { get; set; }

        /// <summary>
        /// Side component of combo
        /// </summary>
        public Side Side { get; set; }

        //Backing variable for size
        private Size size = Size.Small;
        //Size property
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

        /// <summary>
        /// CretatceousCombo constructor
        /// </summary>
        /// <param name="entree">The entree being chosen</param>
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
            return $"{Entree} Combo";
        }

        /// <summary>
        /// Gets description of combo
        /// </summary>
        public string Description
        {
            get{ return this.ToString(); }
        }

        /// <summary>
        /// Gets any special modifications to the order
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Special);
                ingredients.Add(Side.ToString());
                ingredients.AddRange(Side.Special);
                ingredients.Add(Drink.ToString());
                ingredients.AddRange(Drink.Special);
                return ingredients.ToArray();
            }
        }
    }
}
