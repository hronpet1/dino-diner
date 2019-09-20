using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        public Triceritots()
        {
            this.Size = Size.Small;
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                ingredients.Add("Potato");
                ingredients.Add("Breading");
                ingredients.Add("Vegtable Oil");
                return ingredients;
            }
        }

        public override Size Size
        {
            get { return Size; }
            set
            {
                Size = value;
                switch (Size)
                {
                    case (Size.Small):
                        {
                            this.Price = 0.99;
                            this.Calories = 352;
                            break;
                        }
                    case (Size.Medium):
                        {
                            this.Price = 1.45;
                            this.Calories = 410;
                            break;
                        }
                    case (Size.Large):
                        {
                            this.Price = 1.95;
                            this.Calories = 590;
                            break;
                        }
                }
            }
        }
    }
}
