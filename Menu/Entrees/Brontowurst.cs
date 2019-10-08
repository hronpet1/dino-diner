using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for Brontowurst - inherits from Entree
    /// </summary>
    public class Brontowurst : Entree
    {
        private bool wholeWheatBun = true;
        private bool brautwurst = true;
        private bool peppers = true;
        private bool onion = true;

        /// <summary>
        /// Get function that returns ingredients of entree based on state of object
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {};
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (brautwurst) ingredients.Add("Brautwurst");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor, sets base Price and Calories values
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldBun()
        {
            this.wholeWheatBun = false;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldOnion()
        {
            this.onion = false;
        }
        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns>Name of the item</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
