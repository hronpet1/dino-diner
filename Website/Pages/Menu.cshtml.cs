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
    }
}