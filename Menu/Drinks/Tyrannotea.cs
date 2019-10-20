using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for Tyrannotea - inherits from Drink
    /// </summary>
    public class Tyrannotea : Drink
    {
        private bool sweet = false;
        /// <summary>
        /// Get and set of sweet variable - when changing sweetness, changes calories accordingly
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                if (value)
                    switch (size)
                    {
                        case (Size.Small):
                            {
                                Calories = 16;
                                break;
                            }
                        case (Size.Medium):
                            {
                                Calories = 32;
                                break;
                            }
                        case (Size.Large):
                            {
                                Calories = 64;
                                break;
                            }
                    }
                else
                    switch (size)
                    {
                        case (Size.Small):
                            {
                                Calories = 8;
                                break;
                            }
                        case (Size.Medium):
                            {
                                Calories = 16;
                                break;
                            }
                        case (Size.Large):
                            {
                                Calories = 32;
                                break;
                            }
                    }
            }
        }
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
                ingredients.Add("Tea");
                if (Lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor - sets default size as Small
        /// </summary>
        public Tyrannotea()
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
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
                
                size = value;
                switch (size)
                {
                    case (Size.Small):
                        {
                            Price = 0.99;
                            if (Sweet)
                                Calories = 16;
                            else
                                Calories = 8;
                            break;
                        }
                    case (Size.Medium):
                        {
                            Price = 1.49;
                            if (Sweet)
                                Calories = 32;
                            else
                                Calories = 16;
                            break;
                        }
                    case (Size.Large):
                        {
                            Price = 1.99;
                            if (Sweet)
                                Calories = 64;
                            else
                                Calories = 32;
                            break;
                        }
                }
            }
        }

        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns>Name of the item</returns>
        public override string ToString()
        {
            string name = "";
            name += GetSizeString();
            if(sweet) name += "Sweet ";
            return name + "Tyrannotea";
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
