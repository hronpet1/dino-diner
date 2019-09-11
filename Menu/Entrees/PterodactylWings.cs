using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings : Entree
    {
        private bool chicken = true;
        private bool wingSauce = true;

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {  };
                if (chicken) ingredients.Add("Chicken");
                if (wingSauce) ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
