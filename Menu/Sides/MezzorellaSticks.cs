using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu.Sides 
{
    public class MezzorellaSticks : Side
    {
        public MezzorellaSticks()
        {
            this.Size = Size.Small;
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                ingredients.Add("Breding");
                ingredients.Add("Cheese Product");
                ingredients.Add("Vegtable Oil");
                return ingredients;
            }
        }

        private Size size;
        public override Size Size
        {
            set
            {
                Size = value;
                switch (Size)
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
    }
}
