using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        private Menu menu;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public float? minPrice { get; set; }

        [BindProperty]
        public float? maxPrice { get; set; }

        [BindProperty]
        public List<string> excludedIngredients { get; set; } = new List<string>();
        public Menu Menu { 
            get
            {
                return menu;
            } 
        }
        public void OnGet()
        {
            this.menu = new Menu();
        }

        public void OnPost()
        {
             menu = new Menu();

             if (search != null)
             {
                 menu.CurCombos = menu.CurCombos.Where(combo => combo.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                 menu.CurDrinks = menu.CurDrinks.Where(drink => drink.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                 menu.CurEntrees = menu.CurEntrees.Where(entree => entree.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                 menu.CurSides = menu.CurSides.Where(side => side.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                 // Movies = MovieDatabase.Search(Movies, search);
             }

             if (menuCategory.Count != 0)
             {
                if (!menuCategory.Contains("entree"))
                {
                   menu.CurEntrees = Enumerable.Empty<Entree>();
                }
                if (!menuCategory.Contains("drink"))
                {
                    menu.CurDrinks = Enumerable.Empty<Drink>();
                }
                if (!menuCategory.Contains("side"))
                {
                    menu.CurSides = Enumerable.Empty<Side>();
                }
                if (!menuCategory.Contains("combo"))
                {
                    menu.CurCombos = Enumerable.Empty<CretaceousCombo>();
                }
            }

                if (minPrice != null)
                {
                menu.CurCombos = menu.CurCombos.Where(combo => combo.Price >= minPrice);
                menu.CurDrinks = menu.CurDrinks.Where(drink => drink.Price >= minPrice);
                menu.CurEntrees = menu.CurEntrees.Where(entree => entree.Price >= minPrice);
                menu.CurSides = menu.CurSides.Where(side => side.Price >= minPrice);
            }
                if (maxPrice != null)
                {
                menu.CurCombos = menu.CurCombos.Where(combo => combo.Price <= maxPrice);
                menu.CurDrinks = menu.CurDrinks.Where(drink => drink.Price <= maxPrice);
                menu.CurEntrees = menu.CurEntrees.Where(entree => entree.Price <= maxPrice);
                menu.CurSides = menu.CurSides.Where(side => side.Price <= maxPrice);
            }
                
                if (excludedIngredients != null)
                {
                    foreach(string ing in excludedIngredients)
                {
                    IEnumerable<CretaceousCombo> combosToRemove = menu.CurCombos.Where(combo => combo.Ingredients.Contains(ing));
                    IEnumerable<Entree> entreesToRemove = menu.CurEntrees.Where(entree => entree.Ingredients.Contains(ing));
                    IEnumerable<Drink> drinksToRemove = menu.CurDrinks.Where(drink => drink.Ingredients.Contains(ing));
                    IEnumerable<Side> sidesToRemove = menu.CurSides.Where(side => side.Ingredients.Contains(ing));

                    var notTheseCombos = combosToRemove.Select(s => s.ToString());
                    var notTheseEntrees = entreesToRemove.Select(s => s.ToString());
                    var notTheseDrinks = drinksToRemove.Select(s => s.ToString());
                    var notTheseSides = sidesToRemove.Select(s => s.ToString());


                    menu.CurCombos = menu.CurCombos.Where(f => !notTheseCombos.Contains(f.ToString())).ToList();
                    menu.CurEntrees = menu.CurEntrees.Where(f => !notTheseEntrees.Contains(f.ToString())).ToList();
                    menu.CurDrinks = menu.CurDrinks.Where(f => !notTheseDrinks.Contains(f.ToString())).ToList();
                    menu.CurSides = menu.CurSides.Where(f => !notTheseSides.Contains(f.ToString())).ToList();
                }
            }
            }
    }
}