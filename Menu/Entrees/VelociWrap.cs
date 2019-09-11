using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {
        private bool tortilla = true;
        private bool chickenBreast = true;
        private bool romaineLettuce = true;
        private bool caesarDressing = true;
        private bool parmesanCheese = true;

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                if (tortilla) ingredients.Add("Flour Tortilla");
                if (chickenBreast) ingredients.Add("Chicken Breast");
                if (romaineLettuce) ingredients.Add("Romaine Lettuce");
                if (caesarDressing) ingredients.Add("Caesar Dressing");
                if (parmesanCheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldDressing()
        {
            this.caesarDressing = false;
        }

        public void HoldLettuce()
        {
            this.romaineLettuce = false;
        }

        public void HoldCheese()
        {
            this.parmesanCheese = false;
        }
    }
}
