using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for Steakosaurus Burger - inherits from Entree
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        private bool wholeWheatBun = true;
        private bool steakburgerPattie = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        /// <summary>
        /// Get function that returns ingredients of entree based on state of object
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (steakburgerPattie) ingredients.Add("Steakburger Pattie");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor, sets base Price and Calories values
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        public void HoldBun()
        {
            this.wholeWheatBun = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }

        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
