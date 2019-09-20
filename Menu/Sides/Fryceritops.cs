using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        public Fryceritops()
        {
            this.Size = Size.Small;
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegtable Oil");
                return ingredients;
            }
        }

        private Size size;
        public override Size Size
        {

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
            }
        }
    }
}
