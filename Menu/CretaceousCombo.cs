using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem
    {
        public Entree Entree { get; set; }
        public Drink Drink { get; set; }
        public Side Side { get; set; }

        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Drink = new Sodasaurus();
            Side = new Fryceritops();
        }

        public CretaceousCombo(Entree entree, Drink drink, Side side)
        {
            Entree = entree;
            Drink = drink;
            Side = side;
        }

        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        public double Price
        {
            get
            {
                return Drink.Price + Side.Price + Entree.Price - 0.25;
            }
        }
        public uint Calories
        {
            get
            {
                return Drink.Calories + Side.Calories + Entree.Calories;
            }
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> comboIngredients = new List<string>();
                comboIngredients.Concat(Side.Ingredients);
                comboIngredients.Concat(Entree.Ingredients);
                comboIngredients.Concat(Drink.Ingredients);
                return comboIngredients;

            }
        }
        /// <summary>
        /// TO DO
        /// </summary>
        public override string ToString()
        {
            return Entree.ToString() + " Combo";
        }
    }
}
