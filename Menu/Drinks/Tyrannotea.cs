using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Property that holds if there is lemon in the tea
        /// </summary>
        public bool Lemon = false;

        /// <summary>
        /// Property that holds if the tea is sweetened or unsweetened
        /// </summary>
        public bool Sweet = false;

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

        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
