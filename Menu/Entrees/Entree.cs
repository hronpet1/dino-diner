using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Base class for all Entrees
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// Price of entree - provides get and set
        /// </summary>
        public virtual double Price { get; set; }
        /// <summary>
        /// Calories in entree - provides get and set
        /// </summary>
        public virtual uint Calories { get; set; }
        /// <summary>
        /// List of ingredients in entree - provides get
        /// </summary>
        public abstract List<string> Ingredients { get; }
    }
}
