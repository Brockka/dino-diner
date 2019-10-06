/*  Menu.cs
*   Author: Brock Kaufmann
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the menu
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// List of available menu items
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                JurassicJava java = new JurassicJava();
                Sodasaurus soda = new Sodasaurus();
                Tyrannotea tea = new Tyrannotea();
                Water water = new Water();
                Brontowurst wurst = new Brontowurst();
                DinoNuggets nugs = new DinoNuggets();
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                PterodactylWings wings = new PterodactylWings();
                SteakosaurusBurger burg = new SteakosaurusBurger();
                TRexKingBurger kingburg = new TRexKingBurger();
                VelociWrap wrap = new VelociWrap();
                Fryceritops fries = new Fryceritops();
                MeteorMacAndCheese mac = new MeteorMacAndCheese();
                MezzorellaSticks sticks = new MezzorellaSticks();
                Triceritots tots = new Triceritots();
                CretaceousCombo combo1 = new CretaceousCombo(wurst);
                CretaceousCombo combo2 = new CretaceousCombo(nugs);
                CretaceousCombo combo3 = new CretaceousCombo(pbj);
                CretaceousCombo combo4 = new CretaceousCombo(wings);
                CretaceousCombo combo5 = new CretaceousCombo(burg);
                CretaceousCombo combo6 = new CretaceousCombo(kingburg);
                CretaceousCombo combo7 = new CretaceousCombo(wrap);
                items.Add(java);
                items.Add(soda);
                items.Add(tea);
                items.Add(water);
                items.Add(wurst);
                items.Add(nugs);
                items.Add(pbj);
                items.Add(wings);
                items.Add(burg);
                items.Add(kingburg);
                items.Add(wrap);
                items.Add(fries);
                items.Add(mac);
                items.Add(sticks);
                items.Add(tots);
                items.Add(combo1);
                items.Add(combo2);
                items.Add(combo3);
                items.Add(combo4);
                items.Add(combo5);
                items.Add(combo6);
                items.Add(combo7);
                return items;
            }
        }

        /// <summary>
        /// List of available entrees
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> items = new List<Entree>();
                Brontowurst wurst = new Brontowurst();
                DinoNuggets nugs = new DinoNuggets();
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                PterodactylWings wings = new PterodactylWings();
                SteakosaurusBurger burg = new SteakosaurusBurger();
                TRexKingBurger kingburg = new TRexKingBurger();
                VelociWrap wrap = new VelociWrap();
                items.Add(wurst);
                items.Add(nugs);
                items.Add(pbj);
                items.Add(wings);
                items.Add(burg);
                items.Add(kingburg);
                items.Add(wrap);
                return items;
            }
        }

        /// <summary>
        /// List of available sides
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> items = new List<Side>();
                Fryceritops fries = new Fryceritops();
                MeteorMacAndCheese mac = new MeteorMacAndCheese();
                MezzorellaSticks sticks = new MezzorellaSticks();
                Triceritots tots = new Triceritots();
                items.Add(fries);
                items.Add(mac);
                items.Add(sticks);
                items.Add(tots);
                return items;
            }
        }

        /// <summary>
        /// List of available drinks
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> items = new List<Drink>();
                JurassicJava java = new JurassicJava();
                Sodasaurus soda = new Sodasaurus();
                Tyrannotea tea = new Tyrannotea();
                Water water = new Water();
                items.Add(java);
                items.Add(soda);
                items.Add(tea);
                items.Add(water);
                return items;
            }
        }

        /// <summary>
        /// List of available combos
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> items = new List<CretaceousCombo>();
                foreach(Entree entree in AvailableEntrees)
                {
                    CretaceousCombo combo = new CretaceousCombo(entree);
                    items.Add(combo);
                }
                return items;
            }
        }


        /// <summary>
        /// Overriden ToString() for Menu class
        /// </summary>
        /// <returns>returns name of menu item</returns>
        public override string ToString()
        {
            string s = "";
            foreach (IMenuItem item in AvailableMenuItems)
            {
                s += item.ToString() + "\n";
            }
            return s;
        }
    }
}
