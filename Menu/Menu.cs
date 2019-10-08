using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class representing menu of DinoDiner
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// List of all available menu items
        /// </summary>
        /// <returns> List of menu items</returns>
        public List<IMenuItem> AvailableMenuItems()
        {
            List<IMenuItem> menuItems = new List<IMenuItem>();
            foreach (IMenuItem item in AvailableEntrees())
                menuItems.Add(item);
            foreach (IMenuItem item in AvailableDrinks())
                menuItems.Add(item);
            foreach (IMenuItem item in AvailableSides())
                menuItems.Add(item);
            foreach (IMenuItem item in AvailableCombos())
                menuItems.Add(item);
            return menuItems;

        }
        /// <summary>
        /// List of all available entrees
        /// </summary>
        /// <returns> List of entrees </returns>
        public List<IMenuItem> AvailableEntrees()
        {
            List<IMenuItem> entrees = new List<IMenuItem>();
            entrees.Add(new Brontowurst());
            entrees.Add(new DinoNuggets());
            entrees.Add(new PrehistoricPBJ());
            entrees.Add(new PterodactylWings());
            entrees.Add(new SteakosaurusBurger());
            entrees.Add(new TRexKingBurger());
            entrees.Add(new VelociWrap());
            return entrees;
        }
        /// <summary>
        /// List of all available sides
        /// </summary>
        /// <returns> List of sides</returns>
        public List<IMenuItem> AvailableSides()
        {
            List<IMenuItem> sides = new List<IMenuItem>();
            sides.Add(new Fryceritops());
            sides.Add(new MeteorMacAndCheese());
            sides.Add(new MezzorellaSticks());
            sides.Add(new Triceritots());
            return sides;
        }
        /// <summary>
        /// List of all available drinks
        /// </summary>
        /// <returns> List of drinks</returns>
        public List<IMenuItem> AvailableDrinks()
        {
            List<IMenuItem> drinks = new List<IMenuItem>();
            drinks.Add(new Sodasaurus());
            drinks.Add(new JurassicJava());
            drinks.Add(new Water());
            drinks.Add(new Tyrannotea());
            return drinks;
        }
        /// <summary>
        /// List of all available combos
        /// </summary>
        /// <returns> List of combos</returns>
        public List<IMenuItem> AvailableCombos()
        {
            List<IMenuItem> combos = new List<IMenuItem>();
            combos.Add(new CretaceousCombo(new Brontowurst()));
            combos.Add(new CretaceousCombo(new DinoNuggets()));
            combos.Add(new CretaceousCombo(new PrehistoricPBJ()));
            combos.Add(new CretaceousCombo(new PterodactylWings()));
            combos.Add(new CretaceousCombo(new SteakosaurusBurger()));
            combos.Add(new CretaceousCombo(new TRexKingBurger()));
            combos.Add(new CretaceousCombo(new VelociWrap()));
            return combos;
        }

        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns>All names of items in menu separated by newline </returns>
        public override string ToString()
        {
            string name = "";
            foreach (IMenuItem item in AvailableMenuItems())
                name += item.ToString() + "\n";
            return name;
        }
    }
}