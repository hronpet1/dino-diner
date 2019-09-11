using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {
        private uint nuggets = 6;

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {};
                for (int i = 0; i < nuggets; i++)
                    ingredients.Add("Chicken Nugget");
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59*nuggets;
        }

        public void AddNugget()
        {
            nuggets++;
            this.Price += 0.25;
        }
	}
}
