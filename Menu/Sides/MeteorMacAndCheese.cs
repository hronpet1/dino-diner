using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Class for MeteorMacAndCheese - inherits from Side
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// Constructor - sets default size as Small
        /// </summary>
        public MeteorMacAndCheese()
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
                ingredients.Add("Macaroni Noodles");
                ingredients.Add("Cheese Product");
                ingredients.Add("Pork Sausage");
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
                            this.Calories = 420;
                            break;
                        }
                    case (Size.Medium):
                        {
                            this.Price = 1.45;
                            this.Calories = 490;
                            break;
                        }
                    case (Size.Large):
                        {
                            this.Price = 1.95;
                            this.Calories = 520;
                            break;
                        }
                }
            }
        }
    }
}
