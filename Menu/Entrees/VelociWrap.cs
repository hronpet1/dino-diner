using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for VelociWrap - inherits from Entree
    /// </summary>
    public class VelociWrap : Entree
    {
        private bool tortilla = true;
        private bool chickenBreast = true;
        private bool romaineLettuce = true;
        private bool caesarDressing = true;
        private bool parmesanCheese = true;
        /// <summary>
        /// Get function that returns ingredients of entree based on state of object
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                if (tortilla) ingredients.Add("Flour Tortilla");
                if (chickenBreast) ingredients.Add("Chicken Breast");
                if (romaineLettuce) ingredients.Add("Romaine Lettuce");
                if (caesarDressing) ingredients.Add("Ceasar Dressing");
                if (parmesanCheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor, sets base Price and Calories values
        /// </summary>
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
        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns>Name of the item</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
