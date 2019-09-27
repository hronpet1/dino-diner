using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class for JurassicJava - inherits from Drink
    /// </summary>
    public class JurassicJava : Drink
    {
        public bool RoomForCream { get; set; } = false;
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// Get function that returns ingredients of drink
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                ingredients.Add("Water");
                ingredients.Add("Coffee");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor - sets default size as Small
        /// </summary>
        public JurassicJava()
        {
            Size = Size.Small;
            Ice = false;
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
                            Price = 0.59;
                            Calories = 2;
                            break;
                        }
                    case (Size.Medium):
                        {
                            Price = 0.99;
                            Calories = 4;
                            break;
                        }
                    case (Size.Large):
                        {
                            Price = 1.49;
                            Calories = 8;
                            break;
                        }
                }
            }
        }

        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
        public void AddIce()
        {
            Ice = true;
        }
    }
}
