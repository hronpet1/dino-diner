using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for Sodasaurus - inherits from Drink
    /// </summary>
    public class Sodasaurus : Drink
    {
        private SodasaurusFlavor flavor;
        /// <summary>
        /// Get and set function for Soda flavor
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Get function that returns ingredients of drink
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }
        
        /// <summary>
        /// Gets any special instructions for this order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Constructor - sets default size as Small
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
            Flavor = SodasaurusFlavor.Cola;
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
                            Price = 1.50;
                            Calories = 112;
                            break;
                        }
                    case (Size.Medium):
                        {
                            Price = 2.00;
                            Calories = 156;
                            break;
                        }
                    case (Size.Large):
                        {
                            Price = 2.50;
                            Calories = 208;
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
            name += Flavor + " ";
            return name + "Sodasaurus";
        }
    }
}
