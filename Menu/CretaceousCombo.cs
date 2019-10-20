using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for food combos - entree + side + drink
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The PropertyChanged event handler notifies of changes to the Price, Description and Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Get and set for Entree in the combo
        /// </summary>
        public Entree Entree { get; set; }
        /// <summary>
        /// Get and set for Drink in the combo
        /// </summary>
        public Drink Drink { get; set; }
        /// <summary>
        /// Get and set for Side in the combo
        /// </summary>
        public Side Side { get; set; }

        /// <summary>
        /// Constructor with default side and drink
        /// </summary>
        /// <param name="entree"> Entree of the combo </param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Drink = new Sodasaurus();
            Side = new Fryceritops();
        }
        /// <summary>
        /// Constructor with all options provided
        /// </summary>
        /// <param name="entree"> Entree of the combo </param>
        /// <param name="drink"> Drink of the combo </param>
        /// <param name="side"> Side of the combo </param>
        public CretaceousCombo(Entree entree, Drink drink, Side side)
        {
            Entree = entree;
            Drink = drink;
            Side = side;
        }
        
        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Total calculated price of combo with the discount
        /// </summary>
        public double Price
        {
            get
            {
                return Drink.Price + Side.Price + Entree.Price - 0.25;
            }
        }
        /// <summary>
        /// Total calculated Calories of combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Drink.Calories + Side.Calories + Entree.Calories;
            }
        }

        /// <summary>
        /// Get for list of ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> comboIngredients = new List<string>();
                comboIngredients.Concat(Side.Ingredients);
                comboIngredients.Concat(Entree.Ingredients);
                comboIngredients.Concat(Drink.Ingredients);
                return comboIngredients;

            }
        }
        /// <summary>
        /// Text representation of combo
        /// </summary>
        public override string ToString()
        {
            return Entree.ToString() + " Combo";
        }
        /// <summary>
        /// Gets the description of this order item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// Gets any special instructions for this order item
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Special);
                ingredients.Add(Side.ToString());
                ingredients.AddRange(Side.Special);
                ingredients.Add(Drink.ToString());
                ingredients.AddRange(Drink.Special);
                return ingredients.ToArray();
            }
        }
    }
}
