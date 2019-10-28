using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for Water - inherits from Drink
    /// </summary>
    public class Water : Drink
    {
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// Get function that returns ingredients of drink
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                ingredients.Add("Water");
                if(Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor - sets default size as Small
        /// </summary>
        public Water()
        {
            Size = Size.Small;
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
                            Price = 0.10;
                            Calories = 0;
                            break;
                        }
                    case (Size.Medium):
                        {
                            Price = 0.10;
                            Calories = 0;
                            break;
                        }
                    case (Size.Large):
                        {
                            Price = 0.10;
                            Calories = 0;
                            break;
                        }
                }
                NotifyOfPropertyChange("Description");

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
            return name + "Water";
        }
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
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
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }

    }
}
