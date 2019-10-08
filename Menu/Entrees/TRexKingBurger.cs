using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for TRexKingBurger - inherits from Entree
    /// </summary>
    public class TRexKingBurger : Entree
    {
        private bool wholeWheatBun = true;
        private int steakburgerPatties = 3;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;
        /// <summary>
        /// Get function that returns ingredients of entree based on state of object
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                for ( int i= 0; i < steakburgerPatties; i++)
                    ingredients.Add("Steakburger Pattie");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor, sets base Price and Calories values
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        public void HoldBun()
        {
            this.wholeWheatBun = false;
        }
       
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldTomato()
        {
            this.tomato = false;
        }

        public void HoldMayo()
        {
            this.mayo = false;
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
            return "T-Rex King Burger";
        }

    }
}
