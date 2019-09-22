using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for Pterodactyl Wings - inherits from Entree
    /// </summary>
    public class PterodactylWings : Entree
    {
        private bool chicken = true;
        private bool wingSauce = true;
        /// <summary>
        /// Get function that returns ingredients of entree based on state of object
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {  };
                if (chicken) ingredients.Add("Chicken");
                if (wingSauce) ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor, sets base Price and Calories values
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
