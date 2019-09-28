﻿/*  JurrasicJava.cs
*   Author: Brock Kaufmann
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// Gets and sets the room for cream
        /// </summary>
        public bool RoomForCream { get; set; }

        /// <summary>
        /// Gets and sets whether the drink is decaf
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// Overrides the base class list of ingredients with the ones specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
               return new List<string>() { "Water", "Coffee" };
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
                        Price = 1.49;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                }
            }
            get { return size; }

        }

        /// <summary>
        /// Public constructor that initializes the default calories and price (size small)
        /// </summary>
        public JurrasicJava()
        {
            this.Price = 0.59;
            this.Calories = 2;
            HoldIce();
        }

        /// <summary>
        /// Leaves room for cream in the drink
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// Adds ice to the drink
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }
    }
}
