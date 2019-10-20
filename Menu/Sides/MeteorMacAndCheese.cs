﻿/*  Fryceritops.cs
*   Author: Brock Kaufmann
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// MeteorMacAndCheese menu item
    /// </summary>
    public class MeteorMacAndCheese : Side, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the 
        /// Price, Description and Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Helper function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets the description
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets the special modifications to the order if any
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }

        /// <summary>
        /// Overrides the base class list of ingredients with the ones specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
            }
        }

        /// <summary>
        /// Creates a private size field
        /// </summary>
        private Size size;

        /// <summary>
        /// Overrides the base class size to provide the price and calories associated with this menu item
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                }

            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Public constructor that initializes the default calories and price (size small)
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Price = .99;
            this.Calories = 420;
        }

        /// <summary>
        /// Overriden ToString() for MeteorMacAndCheese class
        /// </summary>
        /// <returns>returns name of menu item</returns>
        public override string ToString()
        {
            return $"{Size} Meteor Mac and Cheese";
        }

    }
}
