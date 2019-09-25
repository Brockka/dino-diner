using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus
    {
        public double Price = 1.50;

        public SodasaurusFlavor Flavor;

        public Size size;
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
            }
        }
    }
}
