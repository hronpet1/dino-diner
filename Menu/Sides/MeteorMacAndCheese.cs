using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
    {
        public MeteorMacAndCheese()
        {
            this.Size = Size.Small;
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                ingredients.Add("Macaroni Noodles");
                ingredients.Add("Cheese Product");
                ingredients.Add("Pork Sausuage");
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
