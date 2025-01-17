using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for DinoNuggets - inherits from Entree
    /// </summary>
    public class DinoNuggets : Entree
    {
        private uint nuggets = 6;
        /// <summary>
        /// Get function that returns ingredients of entree based on state of object
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {};
                for (int i = 0; i < nuggets; i++)
                    ingredients.Add("Chicken Nugget");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor, sets base Price and Calories values
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59*nuggets;
        }

        /// <summary>
        /// Adds one nugget and changes Price and Calories accordingly
        /// </summary>
        public void AddNugget()
        {
            nuggets++;
            this.Price += 0.25;
            this.Calories += 59;
            NotifyOfPropertyChange("Price");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns>Name of the item</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }

        /// <summary>
        /// Gets any special instructions for this order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (nuggets > 6) special.Add( nuggets-6 + " Extra Nuggets");
                return special.ToArray();
            }
        }

    }
}
