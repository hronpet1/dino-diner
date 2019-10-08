using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu 
{
    /// <summary>
    /// Class for MezzorellaSticks - inherits from Side
    /// </summary>
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Constructor - sets default size as Small
        /// </summary>
        public MezzorellaSticks()
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
                ingredients.Add("Breading");
                ingredients.Add("Cheese Product");
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
                            this.Price = 0.99;
                            this.Calories = 540;
                            break;
                        }
                    case (Size.Medium):
                        {
                            this.Price = 1.45;
                            this.Calories = 610;
                            break;
                        }
                    case (Size.Large):
                        {
                            this.Price = 1.95;
                            this.Calories = 720;
                            break;
                        }
                }
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
            return name + "Mezzorella Sticks";
        }

    }
}
