/*  Tyrannotea.cs
*   Author: Brock Kaufmann
*/
using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink, IMenuItem
    {
        /// <summary>
        /// Gets and sets the whether there is lemon in the tea
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// Creates a private sweet field
        /// </summary>
        private bool sweet;
        /// <summary>
        /// Gets and sets if the tea is sweetened or unsweetened
        /// </summary>
        public bool Sweet { 
                get { return sweet; }
                set{
                    sweet = value;
                    switch (Size)
                    {
                        case Size.Large:
                            if (sweet)
                            {
                            Calories = 64;
                            }
                            else
                            {
                            Calories = 32;
                            }
                            break;
                        case Size.Medium:
                            if (sweet)
                            {
                                Calories = 32;
                            }
                            else
                            {
                                Calories = 16;
                            }
                            break;
                        case Size.Small:
                            if (sweet)
                            {
                            Calories = 16;
                            }
                            else
                            {
                                Calories = 8;
                            }
                            break;
                }
                
                }

            }

        /// <summary>
        /// Overrides the base class list of ingredients with the ones specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> list = new List<string>() { "Water", "Tea" };
                if (Lemon)
                {
                    list.Add("Lemon");
                }
                if (Sweet)
                {
                    list.Add("Cane Sugar");
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
                switch (size)
                {
                    case Size.Large:
                        Price = 1.99;
                        if (Sweet)
                        {
                            Calories = 64;
                        }
                        else
                        {
                            Calories = 32;
                        }
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        if (Sweet)
                        {
                            Calories = 32;
                        }
                        else
                        {
                            Calories = 16;
                        }
                        break;
                }
            }
            get { return size; }

        }

        /// <summary>
        /// Public constructor that initializes the default calories and price (size small)
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            if (Sweet)
            {
                this.Calories = 16;
            }
            else
            {
                this.Calories = 8;
            }
        }

        /// <summary>
        /// Method to add lemon to drink
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        /// <summary>
        /// Overriden ToString() for Tyrannotea class
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
            if (Sweet)
            {
                s += "Sweet ";
            }
            s += "Tyrannotea";
            return s;
        }
    }
}
