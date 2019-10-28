using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for Fryceritops - inherits from Side
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// Constructor - sets default size as Small
        /// </summary>
        public Fryceritops()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// Get function that returns ingredients of side
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }

        private Size size;
        /// <summary>
        /// Get and set for size of Side, sets Price and Calories accordingly
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (size)
                {
                    case (Size.Small):
                        {
                            Price = 0.99;
                            Calories = 222;
                            break;
                        }
                    case (Size.Medium):
                        {
                            Price = 1.45;
                            Calories = 365;
                            break;
                        }
                    case (Size.Large):
                        {
                            Price = 1.95;
                            Calories = 480;
                            break;
                        }
                }
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");

            }
        }
        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns>Name of the item</returns>
        public override string ToString()
        {
            string name = "";
            name += GetSizeString();
            return name + "Fryceritops";
        }
    }
}
